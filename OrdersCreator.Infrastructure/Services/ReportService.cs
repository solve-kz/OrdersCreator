using ClosedXML.Excel;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrdersCreator.Infrastructure.Services;

public class ReportService : IReportService
{
    private readonly ISettingsService _settingsService;

    public ReportService(ISettingsService settingsService)
    {
        _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));
    }

    public Order CompleteOrder(Order order)
    {
        if (order is null)
            throw new ArgumentNullException(nameof(order));

        if (order.Customer == null && order.CustomerId == 0)
            throw new InvalidOperationException("Контрагент не выбран.");

        if (!order.Lines.Any())
            throw new InvalidOperationException("Нет строк для отчёта.");

        var aggregatedLines = order.Lines
            .GroupBy(l => l.ProductId)
            .Select((g, idx) => new OrderLine
            {
                OrderId = order.Id,
                Order = order,
                ProductId = g.Key,
                Product = g.First().Product,
                WeightKg = g.Sum(x => x.WeightKg),
                RowNumber = idx + 1
            })
            .ToList();

        order.Lines.Clear();
        order.Lines.AddRange(aggregatedLines);
        order.Status = OrderStatus.Complited;

        if (string.IsNullOrWhiteSpace(order.Number))
        {
            order.Number = order.Date.ToString("yyyyMMddHHmmss");
        }

        return order;
    }

    public string CreateReport(Order order)
    {
        if (order is null)
            throw new ArgumentNullException(nameof(order));

        var settings = _settingsService.GetSettings();

        if (string.IsNullOrWhiteSpace(settings.ReportsRootFolder))
            throw new InvalidOperationException("Не задана корневая папка для отчётов.");

        if (string.IsNullOrWhiteSpace(settings.ReportTemplatePath) || !File.Exists(settings.ReportTemplatePath))
            throw new InvalidOperationException("Шаблон отчёта не найден.");

        var finalized = CompleteOrder(order);
        var outputFolder = BuildOutputFolder(settings, finalized.Date);
        Directory.CreateDirectory(outputFolder);

        var reportPath = Path.Combine(outputFolder, BuildReportFileName(settings, finalized));

        using (var workbook = new XLWorkbook(settings.ReportTemplatePath))
        {
            var worksheet = workbook.Worksheets.First();

            ReplaceSimplePlaceholders(worksheet, finalized);
            FillLines(worksheet, finalized);

            workbook.SaveAs(reportPath);
        }

        if (settings.OpenReportAfterSave)
        {
            TryOpen(reportPath);
        }

        return reportPath;
    }

    private static string BuildOutputFolder(AppSettings settings, DateTime date)
    {
        if (!settings.UseDailySubfolder)
            return settings.ReportsRootFolder;

        return Path.Combine(settings.ReportsRootFolder, date.ToString("yyyy-MM-dd"));
    }

    private static string BuildReportFileName(AppSettings settings, Order order)
    {
        var mask = settings.ReportFileNameMask;
        mask = ReplaceDateMask(mask, order.Date);
        mask = mask.Replace("{CustomerName}", order.Customer?.Name ?? string.Empty);
        mask = mask.Replace("{OrderNumber}", order.Number);

        var invalidChars = Path.GetInvalidFileNameChars();
        var sanitized = string.Join('_', mask.Split(invalidChars, StringSplitOptions.RemoveEmptyEntries));
        return sanitized;
    }

    private static string ReplaceDateMask(string template, DateTime date)
    {
        return Regex.Replace(template, "\\{Date(?::(?<format>[^}]+))?\\}", m =>
        {
            var format = m.Groups["format"].Success ? m.Groups["format"].Value : "yyyy-MM-dd";
            return date.ToString(format);
        }, RegexOptions.IgnoreCase);
    }

    private static void ReplaceSimplePlaceholders(IXLWorksheet worksheet, Order order)
    {
        var replacements = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["{contragent}"] = order.Customer?.Name ?? string.Empty,
            ["{customer}"] = order.Customer?.Name ?? string.Empty,
            ["{date}"] = order.Date.ToString("dd.MM.yyyy"),
            ["{order_number}"] = order.Number,
            ["{total_weight}"] = order.Lines.Sum(l => l.WeightKg).ToString("F3"),
            ["{line_count}"] = order.Lines.Count.ToString()
        };

        foreach (var cell in worksheet.CellsUsed())
        {
            var value = cell.GetString();
            var replaced = ReplaceTokens(value, replacements);
            if (!string.Equals(value, replaced, StringComparison.Ordinal))
            {
                cell.Value = replaced;
            }
        }
    }

    private static void FillLines(IXLWorksheet worksheet, Order order)
    {
        var placeholderCell = worksheet
            .CellsUsed(c => c.GetString().Contains("{lines}", StringComparison.OrdinalIgnoreCase))
            .FirstOrDefault();

        if (placeholderCell == null)
            return;

        var templateRowNumber = placeholderCell.Address.RowNumber;
        var templateRow = worksheet.Row(templateRowNumber);
        var lastColumn = templateRow.LastCellUsed()?.Address.ColumnNumber ?? 0;

        var templateTexts = new List<string>();
        for (int col = 1; col <= lastColumn; col++)
        {
            templateTexts.Add(templateRow.Cell(col).GetString());
        }

        if (order.Lines.Count > 1)
        {
            templateRow.InsertRowsBelow(order.Lines.Count - 1);
        }

        for (int i = 0; i < order.Lines.Count; i++)
        {
            var row = worksheet.Row(templateRowNumber + i);
            var line = order.Lines[i];

            for (int col = 1; col <= lastColumn; col++)
            {
                var text = templateTexts[col - 1];
                var replaced = ReplaceLinePlaceholders(text, order, line, i + 1);
                row.Cell(col).Value = replaced;
            }
        }
    }

    private static string ReplaceLinePlaceholders(string text, Order order, OrderLine line, int index)
    {
        var replacements = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["{n}"] = index.ToString(),
            ["{product}"] = line.Product?.Name ?? string.Empty,
            ["{code}"] = line.Product?.Code ?? string.Empty,
            ["{weight}"] = line.WeightKg.ToString("F3"),
            ["{category}"] = line.Product?.Category?.Name ?? string.Empty,
            ["{lines}"] = string.Empty
        };

        return ReplaceTokens(ReplaceOrderTokens(text, order), replacements);
    }

    private static string ReplaceOrderTokens(string text, Order order)
    {
        var replacements = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["{contragent}"] = order.Customer?.Name ?? string.Empty,
            ["{customer}"] = order.Customer?.Name ?? string.Empty,
            ["{date}"] = order.Date.ToString("dd.MM.yyyy"),
            ["{order_number}"] = order.Number,
            ["{total_weight}"] = order.Lines.Sum(l => l.WeightKg).ToString("F3"),
            ["{line_count}"] = order.Lines.Count.ToString(),
        };

        return ReplaceTokens(text, replacements);
    }

    private static string ReplaceTokens(string text, IDictionary<string, string> replacements)
    {
        var result = text;
        foreach (var kvp in replacements)
        {
            result = Regex.Replace(result, Regex.Escape(kvp.Key), kvp.Value ?? string.Empty, RegexOptions.IgnoreCase);
        }

        return result;
    }

    private static void TryOpen(string path)
    {
        try
        {
            var psi = new ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
        catch
        {
            // ignore
        }
    }
}

using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

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

        order.Lines.RemoveAll(l => l is null);

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
                ItemsCount = g.Count(),
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
        mask = ReplaceCustomPlaceholders(mask, order);

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

    private static string ReplaceCustomPlaceholders(string template, Order order)
    {
        var customerName = order.Customer?.Name?.Trim() ?? string.Empty;
        var customerShort = GetShortName(customerName, 10);

        var replacements = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["{customer}"] = customerName,
            ["{customer_short}"] = customerShort,
            ["{ДД}"] = order.Date.ToString("dd"),
            ["{ММ}"] = order.Date.ToString("MM"),
            ["{ГГГГ}"] = order.Date.ToString("yyyy"),
            ["{ГГ}"] = order.Date.ToString("yy"),
            ["{ЧЧ}"] = order.Date.ToString("HH"),
            ["{мм}"] = order.Date.ToString("mm"),
            ["{сс}"] = order.Date.ToString("ss"),
            ["{CustomerName}"] = customerName,
            ["{OrderNumber}"] = order.Number
        };

        var orderedKeys = replacements.Keys.OrderByDescending(k => k.Length).ToList();

        var result = new StringBuilder(template);
        foreach (var key in orderedKeys)
        {
            result.Replace(key, replacements[key]);
        }

        return result.ToString();
    }

    private static string GetShortName(string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value))
            return string.Empty;

        return value.Length <= maxLength ? value : value.Substring(0, maxLength);
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
        // Ищем ячейку с плейсхолдером {lines}
        var placeholderCell = worksheet
            .CellsUsed(c => c.GetString().Contains("{lines}", StringComparison.OrdinalIgnoreCase))
            .FirstOrDefault();

        if (placeholderCell == null)
            return;

        var templateRowNumber = placeholderCell.Address.RowNumber;
        var templateRow = worksheet.Row(templateRowNumber);
        var placeholderColumn = placeholderCell.Address.ColumnNumber;
        var lastColumn = Math.Max(templateRow.LastCellUsed()?.Address.ColumnNumber ?? 0, placeholderColumn + 3);

        // Сохраняем исходный текст каждой ячейки шаблонной строки
        var templateTexts = new List<string>();
        for (int col = 1; col <= lastColumn; col++)
        {
            templateTexts.Add(templateRow.Cell(col).GetString());
        }

        // Добавляем нужное количество строк под шаблоном
        if (order.Lines.Count > 1)
        {
            templateRow.InsertRowsBelow(order.Lines.Count - 1);

            var templateRange = worksheet.Range(templateRowNumber, 1, templateRowNumber, lastColumn);

            for (int offset = 1; offset < order.Lines.Count; offset++)
            {
                var targetRowNumber = templateRowNumber + offset;
                var targetRange = worksheet.Range(targetRowNumber, 1, targetRowNumber, lastColumn);
                templateRange.CopyTo(targetRange);
            }
        }

        // Заполняем строки заказов
        for (int i = 0; i < order.Lines.Count; i++)
        {
            var line = order.Lines[i];
            var rowNumber = templateRowNumber + i;
            var row = worksheet.Row(rowNumber);

            for (int col = 1; col <= lastColumn; col++)
            {
                var text = templateTexts[col - 1];

                if (col == placeholderColumn)
                {
                    // Номер строки
                    row.Cell(col).Value = i + 1;
                }
                else if (col == placeholderColumn + 1)
                {
                    // Название продукта
                    row.Cell(col).Value = line.Product?.Name ?? string.Empty;
                }
                else if (col == placeholderColumn + 2)
                {
                    // Количество
                    row.Cell(col).Value = line.ItemsCount;
                }
                else if (col == placeholderColumn + 3)
                {
                    // Вес (как строка с 3 знаками)
                    row.Cell(col).Value = line.WeightKg.ToString("F3");
                }
                else
                {
                    // Остальные плейсхолдеры
                    row.Cell(col).Value = ReplaceLinePlaceholders(text, order, line, i + 1);
                }
            }
        }

        // Обводка таблицы
        var lastRow = templateRowNumber + order.Lines.Count - 1;
        var dataRange = worksheet.Range(templateRowNumber, placeholderColumn, lastRow, placeholderColumn + 3);
        var border = dataRange.Style.Border;
        border.OutsideBorder = XLBorderStyleValues.Thin;
        border.InsideBorder = XLBorderStyleValues.Thin;
    }


    private static string ReplaceLinePlaceholders(string text, Order order, OrderLine line, int index)
    {
        var replacements = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["{n}"] = index.ToString(),
            ["{product}"] = line.Product?.Name ?? string.Empty,
            ["{code}"] = line.Product?.Code ?? string.Empty,
            ["{count}"] = line.ItemsCount.ToString(),
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
        if (string.IsNullOrEmpty(text))
            return string.Empty;

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

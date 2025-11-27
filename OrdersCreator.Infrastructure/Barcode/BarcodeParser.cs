using OrdersCreator.Domain.Barcode;
using System.Globalization;

namespace OrdersCreator.Infrastructure.Barcode;

/// <summary>
/// Разбирает штрих-код весового товара формата 12/13 знаков.
/// </summary>
public class BarcodeParser : IBarcodeParser
{
    public ParsedBarcode Parse(string rawBarcode)
    {
        if (string.IsNullOrWhiteSpace(rawBarcode))
            throw new ArgumentException("Штрих-код пустой.", nameof(rawBarcode));

        var trimmed = rawBarcode.Trim();
        if (trimmed.Length is not 12 and not 13)
            throw new ArgumentException("Штрих-код должен содержать 12 или 13 цифр.", nameof(rawBarcode));

        if (!trimmed.All(char.IsDigit))
            throw new ArgumentException("Штрих-код должен содержать только цифры.", nameof(rawBarcode));

        // 13-й символ игнорируем (контрольная цифра)
        var payload = trimmed.Length == 13 ? trimmed[..12] : trimmed;

        var productCode = payload[..7] + "00000";
        var weightPart = payload.Substring(7, 5);
        var weightKg = decimal.Parse(weightPart, NumberStyles.None, CultureInfo.InvariantCulture) / 1000m;

        return new ParsedBarcode(trimmed, productCode, weightKg);
    }
}

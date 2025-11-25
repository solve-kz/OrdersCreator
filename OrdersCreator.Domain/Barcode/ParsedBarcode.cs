using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ParsedBarcode.cs
namespace OrdersCreator.Domain.Barcode;

public sealed class ParsedBarcode
{
    public string Raw { get; }

    public string ProductCode { get; }

    /// <summary>Вес в килограммах.</summary>
    public decimal WeightKg { get; }

    public ParsedBarcode(string raw, string productCode, decimal weightKg)
    {
        Raw = raw;
        ProductCode = productCode;
        WeightKg = weightKg;
    }
}


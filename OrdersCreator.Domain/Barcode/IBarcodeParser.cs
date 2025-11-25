using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IBarcodeParser.cs
namespace OrdersCreator.Domain.Barcode;

/// <summary>
/// Логика разбора сырой строки от сканера в код товара и вес.
/// </summary>
public interface IBarcodeParser
{
    ParsedBarcode Parse(string rawBarcode);
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OrderLine.cs
namespace OrdersCreator.Domain.Models;

/// <summary>
/// Строка заказа: один товар, одно взвешивание (или агрегированная масса по товару).
/// </summary>
public sealed class OrderLine
{
    public int Id { get; set; }

    public int OrderId { get; set; }
    public Order? Order { get; set; }

    public int ProductId { get; set; }
    public Product? Product { get; set; }

    /// <summary>Вес в килограммах.</summary>
    public decimal WeightKg { get; set; }

    /// <summary>Номер строки в печатном отчёте.</summary>
    public int RowNumber { get; set; }
}


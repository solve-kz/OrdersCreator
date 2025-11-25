using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Order.cs
namespace OrdersCreator.Domain.Models;

/// <summary>
/// Заказ – то, что сейчас формируется сканированием.
/// </summary>
public sealed class Order
{
    public int Id { get; set; }

    public string Number { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;

    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public OrderStatus Status { get; set; } = OrderStatus.Draft;

    public List<OrderLine> Lines { get; } = new();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Customer.cs
namespace OrdersCreator.Domain.Models;

/// <summary>
/// Контрагент (получатель заказа).
/// </summary>
public sealed class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    // при необходимости можно расширить:
    /*public string? Address { get; set; }
    public string? Inn { get; set; }
    public string? Phone { get; set; }*/
}

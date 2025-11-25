// Product.cs
namespace OrdersCreator.Domain.Models;

/// <summary>
/// Товар, на который приходят штрих-коды.
/// </summary>
public sealed class Product
{
    public int Id { get; set; }

    /// <summary>Код товара из штрих-кода (обычно 7 цифр).</summary>
    public string Code { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}

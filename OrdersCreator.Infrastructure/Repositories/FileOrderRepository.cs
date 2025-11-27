using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace OrdersCreator.Infrastructure.Repositories;

public class FileOrderRepository : IOrderRepository
{
    private static readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true
    };

    public Order? GetById(int id) => null;

    public Order Add(Order order) => throw new NotSupportedException();

    public void Update(Order order)
    {
        throw new NotSupportedException();
    }

    public void SaveToFile(Order order, string filePath)
    {
        if (order is null)
            throw new ArgumentNullException(nameof(order));

        if (order.Customer == null && order.CustomerId == 0)
            throw new InvalidOperationException("Контрагент не выбран.");

        var dto = SerializableOrder.FromOrder(order);
        var folder = Path.GetDirectoryName(filePath);
        if (!string.IsNullOrWhiteSpace(folder))
        {
            Directory.CreateDirectory(folder);
        }

        var json = JsonSerializer.Serialize(dto, _options);
        File.WriteAllText(filePath, json);
    }

    public Order LoadFromFile(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            throw new ArgumentNullException(nameof(filePath));

        if (!File.Exists(filePath))
            throw new FileNotFoundException("Файл заказа не найден.", filePath);

        var json = File.ReadAllText(filePath);
        var dto = JsonSerializer.Deserialize<SerializableOrder>(json, _options)
            ?? throw new InvalidOperationException("Не удалось прочитать заказ из файла.");

        return dto.ToOrder();
    }

    private sealed record SerializableOrder
    {
        public string Number { get; init; } = string.Empty;
        public DateTime Date { get; init; }
        public OrderStatus Status { get; init; }
        public SerializableCustomer Customer { get; init; } = new();
        public List<SerializableLine> Lines { get; init; } = new();

        public static SerializableOrder FromOrder(Order order)
        {
            return new SerializableOrder
            {
                Number = order.Number,
                Date = order.Date,
                Status = order.Status,
                Customer = SerializableCustomer.FromCustomer(order.Customer ?? new Customer { Id = order.CustomerId }),
                Lines = order.Lines.Select(SerializableLine.FromLine).ToList()
            };
        }

        public Order ToOrder()
        {
            var order = new Order
            {
                Number = Number,
                Date = Date,
                Status = Status,
                Customer = Customer.ToCustomer(),
                CustomerId = Customer.Id
            };

            foreach (var line in Lines)
            {
                var product = line.Product.ToProduct();
                var orderLine = new OrderLine
                {
                    Order = order,
                    OrderId = order.Id,
                    Product = product,
                    ProductId = product.Id,
                    WeightKg = line.WeightKg,
                    RowNumber = line.RowNumber
                };

                order.Lines.Add(orderLine);
            }

            return order;
        }
    }

    private sealed record SerializableLine
    {
        public int RowNumber { get; init; }
        public decimal WeightKg { get; init; }
        public SerializableProduct Product { get; init; } = new();

        public static SerializableLine FromLine(OrderLine line)
        {
            return new SerializableLine
            {
                RowNumber = line.RowNumber,
                WeightKg = line.WeightKg,
                Product = SerializableProduct.FromProduct(line.Product ?? new Product { Id = line.ProductId })
            };
        }
    }

    private sealed record SerializableProduct
    {
        public int Id { get; init; }
        public string Code { get; init; } = string.Empty;
        public string Name { get; init; } = string.Empty;
        public SerializableCategory? Category { get; init; }

        public static SerializableProduct FromProduct(Product product)
        {
            return new SerializableProduct
            {
                Id = product.Id,
                Code = product.Code,
                Name = product.Name,
                Category = product.Category != null ? SerializableCategory.FromCategory(product.Category) : null
            };
        }

        public Product ToProduct()
        {
            var category = Category?.ToCategory();
            return new Product
            {
                Id = Id,
                Code = Code,
                Name = Name,
                Category = category,
                CategoryId = category?.Id ?? 0
            };
        }
    }

    private sealed record SerializableCategory
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;

        public static SerializableCategory FromCategory(Category category)
        {
            return new SerializableCategory
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        public Category ToCategory() => new() { Id = Id, Name = Name };
    }

    private sealed record SerializableCustomer
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;

        public static SerializableCustomer FromCustomer(Customer customer)
        {
            return new SerializableCustomer
            {
                Id = customer.Id,
                Name = customer.Name
            };
        }

        public Customer ToCustomer() => new() { Id = Id, Name = Name };
    }
}

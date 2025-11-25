using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IProductService.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Services;

public interface IProductService
{
    IReadOnlyList<Product> GetAll();

    IReadOnlyList<Product> GetByCategory(int categoryId);

    Product? FindByCode(string code);

    Product AddProduct(string code, string name, Category category);

    void UpdateProduct(Product product);

    void DeleteProduct(int id);
}


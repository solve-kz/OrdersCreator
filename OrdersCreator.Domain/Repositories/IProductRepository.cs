using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IProductRepository.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Repositories;

public interface IProductRepository
{
    Product? GetById(int id);
    Product? GetByCode(string code);

    IReadOnlyList<Product> GetAll();
    IReadOnlyList<Product> GetByCategoryId(int categoryId);

    Product AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int id);
}


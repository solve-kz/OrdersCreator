using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;

namespace OrdersCreator.Infrastructure.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;

        public Product AddProduct(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            var index = _products.FindIndex(p => p.Id == id);
            if (index >= 0)
            {
                _products.RemoveAt(index);
            }
        }

        public IReadOnlyList<Product> GetAll()
        {
            // возвращаем копию, чтобы снаружи не ломали список
            return _products.ToList();
        }

        public Product? GetByCode(string code)
        {
            return _products.FirstOrDefault(p => p.Code == code);
        }

        public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IReadOnlyList<Product> GetByCategoryId(int categoryId)
        {
            return _products
                .Where(p => p.CategoryId == categoryId)
                .ToList();
        }

        public void UpdateProduct(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index >= 0)
            {
                _products[index] = product;
            }
        }
    }
}

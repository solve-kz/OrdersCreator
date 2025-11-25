using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;

namespace OrdersCreator.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public IReadOnlyList<Product> GetAll()
        {
            return _repo.GetAll();
        }

        public IReadOnlyList<Product> GetByCategory(int categoryId)
        {
            return _repo.GetByCategoryId(categoryId);
        }

        public Product? FindByCode(string code)
        {
            return _repo.GetByCode(code);
        }

        public Product AddProduct(string code, string name, Category category)
        {
            var product = new Product
            {
                Code = code.Trim(),
                Name = name.Trim(),
                CategoryId = category.Id,
                Category = category
            };

            return _repo.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _repo.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _repo.DeleteProduct(id);
        }
    }
}

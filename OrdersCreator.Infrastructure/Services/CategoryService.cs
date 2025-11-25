using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCreator.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public IReadOnlyList<Category> GetAll()
        {
            return _repo.GetAll(); // сейчас возвращает пустой список
        }

        public Category AddCategory(string name)
        {
            var c = new Category { Name = name.Trim() };
            return _repo.AddCategory(c); // сейчас просто возвращает объект без сохранения
        }

        public void UpdateCategory(Category c)
        {
            _repo.UpdateCategory(c); // no-op, но метод есть => UI работает
        }

        public void DeleteCategory(int id)
        {
            _repo.DeleteCategory(id); // no-op
        }
    }
}

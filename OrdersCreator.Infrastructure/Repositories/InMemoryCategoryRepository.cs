using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCreator.Infrastructure.Repositories
{
    public class InMemoryCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories = new();
        private int _nextId = 1;

        public Category AddCategory(Category category)
        {
            category.Id = _nextId++;
            _categories.Add(category);
            return category;
        }

        public void UpdateCategory(Category category)
        {
            var index = _categories.FindIndex(c => c.Id == category.Id);
            if (index >= 0)
                _categories[index] = category;
        }

        public void DeleteCategory(int id)
        {
            var index = _categories.FindIndex(c => c.Id == id);
            if (index >= 0)
                _categories.RemoveAt(index);
        }

        public Category? GetById(int id)
            => _categories.FirstOrDefault(c => c.Id == id);

        public IReadOnlyList<Category> GetAll()
            => _categories.ToList();
    }
}

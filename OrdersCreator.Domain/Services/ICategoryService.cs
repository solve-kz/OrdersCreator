using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ICategoryService.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Services
{
    public interface ICategoryService
    {
        IReadOnlyList<Category> GetAll();

        Category AddCategory(string name);

        void UpdateCategory(Category category);

        void DeleteCategory(int id);
    }
}

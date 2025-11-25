using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ICategoryRepository.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Repositories;

public interface ICategoryRepository
{
    Category? GetById(int id);
    IReadOnlyList<Category> GetAll();

    Category AddCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(int id);
}


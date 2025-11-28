using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;

namespace OrdersCreator.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IProductRepository repo, ICategoryRepository categoryRepository)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public IReadOnlyList<Product> GetAll()
        {
            var products = _repo
                .GetAll()
                .ToList();

            AttachCategories(products);

            return products;
        }

        public IReadOnlyList<Product> GetByCategory(int categoryId)
        {
            var products = _repo
                .GetByCategoryId(categoryId)
                .ToList();

            AttachCategories(products);

            return products;
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

        public IReadOnlyList<Product> ImportFromXlsx(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Не указан путь к файлу.", nameof(filePath));

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден.", filePath);

            var imported = new List<(string Code, string Name, string Category)>();

            using (var workbook = new XLWorkbook(filePath))
            {
                foreach (var worksheet in workbook.Worksheets)
                {
                    var categoryName = worksheet.Name.Trim();

                    if (string.IsNullOrWhiteSpace(categoryName))
                        continue;

                    if (string.Equals(categoryName, "PLU", StringComparison.OrdinalIgnoreCase))
                        continue;

                    var rows = worksheet.RowsUsed().Skip(1);

                    foreach (var row in rows)
                    {
                        var code = row.Cell(1).GetString().Trim();
                        var name = row.Cell(2).GetString().Trim();

                        if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
                            continue;

                        imported.Add((code, name, categoryName));
                    }
                }
            }

            var existingProducts = _repo.GetAll();
            var existingCodes = new HashSet<string>(existingProducts.Select(p => p.Code.Trim()), StringComparer.OrdinalIgnoreCase);

            var categories = _categoryRepository.GetAll();
            var categoryLookup = new Dictionary<string, Category>(StringComparer.OrdinalIgnoreCase);

            foreach (var category in categories)
            {
                categoryLookup[category.Name.Trim()] = category;
            }

            var addedProducts = new List<Product>();

            foreach (var item in imported)
            {
                if (existingCodes.Contains(item.Code))
                    continue;

                if (!categoryLookup.TryGetValue(item.Category, out var category))
                {
                    category = _categoryRepository.AddCategory(new Category { Name = item.Category });
                    categoryLookup[item.Category] = category;
                }

                var product = new Product
                {
                    Code = item.Code,
                    Name = item.Name,
                    CategoryId = category.Id,
                    Category = category
                };

                addedProducts.Add(_repo.AddProduct(product));
                existingCodes.Add(item.Code);
            }

            return addedProducts;
        }

        private void AttachCategories(IReadOnlyCollection<Product> products)
        {
            if (products.Count == 0)
                return;

            var categoryLookup = _categoryRepository
                .GetAll()
                .ToDictionary(c => c.Id);

            foreach (var product in products)
            {
                if (categoryLookup.TryGetValue(product.CategoryId, out var category))
                    product.Category = category;
            }
        }

        public void ExportToXlsx(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Не указан путь к файлу.", nameof(filePath));

            var categories = _categoryRepository
                .GetAll()
                .OrderBy(c => c.Name)
                .ToList();

            var products = _repo
                .GetAll()
                .GroupBy(p => p.CategoryId)
                .ToDictionary(g => g.Key, g => g.OrderBy(p => p.Name).ToList());

            using var workbook = new XLWorkbook();

            foreach (var category in categories)
            {
                var worksheet = workbook.AddWorksheet(category.Name);
                worksheet.Cell(1, 1).Value = "Код";
                worksheet.Cell(1, 2).Value = "Наименование";

                if (products.TryGetValue(category.Id, out var categoryProducts))
                {
                    for (int i = 0; i < categoryProducts.Count; i++)
                    {
                        var product = categoryProducts[i];
                        worksheet.Cell(i + 2, 1).Value = product.Code;
                        worksheet.Cell(i + 2, 2).Value = product.Name;
                    }
                }

                worksheet.Columns().AdjustToContents();
            }

            workbook.SaveAs(filePath);
        }
    }
}

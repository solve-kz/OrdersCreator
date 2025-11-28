using ClosedXML.Excel;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OrdersCreator.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public IReadOnlyList<Customer> GetAll()
        {
            return _repo.GetAll(); // сейчас возвращает пустой список
        }

        public Customer AddCustomer(string name)
        {
            var c = new Customer { Name = name.Trim() };
            return _repo.AddCustomer(c); // сейчас просто возвращает объект без сохранения
        }

        public void UpdateCustomer(Customer c)
        {
            _repo.UpdateCustomer(c); // no-op, но метод есть => UI работает
        }

        public void DeleteCustomer(int id)
        {
            _repo.DeleteCustomer(id); // no-op
        }

        public IReadOnlyList<Customer> ImportFromXlsx(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Не указан путь к файлу.", nameof(filePath));

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден.", filePath);

            var imported = new List<Customer>();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheets.First();
                var rows = worksheet.RowsUsed().Skip(1); // пропускаем заголовок

                foreach (var row in rows)
                {
                    var name = row.Cell(1).GetString().Trim();

                    if (string.IsNullOrWhiteSpace(name))
                        continue;

                    imported.Add(new Customer { Name = name });
                }
            }

            foreach (var existing in _repo.GetAll())
            {
                _repo.DeleteCustomer(existing.Id);
            }

            var result = new List<Customer>();

            foreach (var customer in imported)
            {
                result.Add(_repo.AddCustomer(customer));
            }

            return result;
        }

        public void ExportToXlsx(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Не указан путь к файлу.", nameof(filePath));

            var customers = _repo
                .GetAll()
                .OrderBy(c => c.Name)
                .ToList();

            using var workbook = new XLWorkbook();
            var worksheet = workbook.AddWorksheet("Контрагенты");

            worksheet.Cell(1, 1).Value = "Название";

            for (int i = 0; i < customers.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = customers[i].Name;
            }

            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(filePath);
        }
    }

}

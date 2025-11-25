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
            var c = new Customer { Name = name.Trim()};
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
    }

}

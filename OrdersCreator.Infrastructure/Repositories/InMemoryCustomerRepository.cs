using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCreator.Infrastructure.Repositories
{
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new();
        private int _nextId = 1;

        public Customer AddCustomer(Customer customer)
        {
            customer.Id = _nextId++;
            _customers.Add(customer);
            return customer;
        }

        public void UpdateCustomer(Customer customer)
        {
            var index = _customers.FindIndex(c => c.Id == customer.Id);
            if (index >= 0)
                _customers[index] = customer;
        }

        public void DeleteCustomer(int id)
        {
            var index = _customers.FindIndex(c => c.Id == id);
            if (index >= 0)
                _customers.RemoveAt(index);
        }

        public Customer? GetById(int id)
            => _customers.FirstOrDefault(c => c.Id == id);

        public IReadOnlyList<Customer> GetAll()
            => _customers.ToList();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ICustomerRepository.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Repositories;

public interface ICustomerRepository
{
    Customer? GetById(int id);
    IReadOnlyList<Customer> GetAll();

    Customer AddCustomer(Customer customer);
    void UpdateCustomer(Customer customer);
    void DeleteCustomer(int id);
}


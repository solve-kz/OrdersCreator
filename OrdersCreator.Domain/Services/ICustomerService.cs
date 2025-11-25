using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ICustomerService.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Services;

public interface ICustomerService
{
    IReadOnlyList<Customer> GetAll();

    Customer AddCustomer(string name);

    void UpdateCustomer(Customer customer);

    void DeleteCustomer(int id);
}


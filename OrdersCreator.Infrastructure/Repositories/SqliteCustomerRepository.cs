using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Infrastructure.Sqlite;

namespace OrdersCreator.Infrastructure.Repositories
{
    public sealed class SqliteCustomerRepository : ICustomerRepository
    {
        private readonly SqliteConnectionFactory _factory;

        public SqliteCustomerRepository(SqliteConnectionFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public Customer AddCustomer(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Customers (Name)
                VALUES ($name);

                SELECT last_insert_rowid();
            ";

            cmd.Parameters.AddWithValue("$name", customer.Name.Trim());

            var newId = Convert.ToInt64(cmd.ExecuteScalar());
            customer.Id = (int)newId;

            return customer;
        }

        public void UpdateCustomer(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE Customers
                SET Name = $name
                WHERE Id = $id;
            ";

            cmd.Parameters.AddWithValue("$name", customer.Name.Trim());
            cmd.Parameters.AddWithValue("$id", customer.Id);

            cmd.ExecuteNonQuery();
        }

        public void DeleteCustomer(int id)
        {
            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                DELETE FROM Customers
                WHERE Id = $id;
            ";

            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();
        }

        public Customer? GetById(int id)
        {
            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, Name
                FROM Customers
                WHERE Id = $id;
            ";

            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            return new Customer
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            };
        }

        public IReadOnlyList<Customer> GetAll()
        {
            var result = new List<Customer>();

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, Name
                FROM Customers
                ORDER BY Name;
            ";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Customer
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }

            return result;
        }
    }
}

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
    public sealed class SqliteProductRepository : IProductRepository
    {
        private readonly SqliteConnectionFactory _factory;

        public SqliteProductRepository(SqliteConnectionFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public Product AddProduct(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Products (Code, Name, CategoryId)
                VALUES ($code, $name, $categoryId);

                SELECT last_insert_rowid();
            ";

            cmd.Parameters.AddWithValue("$code", product.Code.Trim());
            cmd.Parameters.AddWithValue("$name", product.Name.Trim());
            cmd.Parameters.AddWithValue("$categoryId", product.CategoryId);

            var newId = Convert.ToInt64(cmd.ExecuteScalar());
            product.Id = (int)newId;

            return product;
        }

        public void UpdateProduct(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE Products
                SET Code = $code,
                    Name = $name,
                    CategoryId = $categoryId
                WHERE Id = $id;
            ";

            cmd.Parameters.AddWithValue("$code", product.Code.Trim());
            cmd.Parameters.AddWithValue("$name", product.Name.Trim());
            cmd.Parameters.AddWithValue("$categoryId", product.CategoryId);
            cmd.Parameters.AddWithValue("$id", product.Id);

            cmd.ExecuteNonQuery();
        }

        public void DeleteProduct(int id)
        {
            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                DELETE FROM Products
                WHERE Id = $id;
            ";

            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();
        }

        public Product? GetById(int id)
        {
            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, Code, Name, CategoryId
                FROM Products
                WHERE Id = $id;
            ";

            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            return new Product
            {
                Id = reader.GetInt32(0),
                Code = reader.GetString(1),
                Name = reader.GetString(2),
                CategoryId = reader.GetInt32(3)
            };
        }

        public IReadOnlyList<Product> GetAll()
        {
            var result = new List<Product>();

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, Code, Name, CategoryId
                FROM Products
                ORDER BY Name;
            ";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Product
                {
                    Id = reader.GetInt32(0),
                    Code = reader.GetString(1),
                    Name = reader.GetString(2),
                    CategoryId = reader.GetInt32(3)
                });
            }

            return result;
        }

        public Product? GetByCode(string code)
        {
            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, Code, Name, CategoryId
                FROM Products
                WHERE Code = $code;
            ";

            cmd.Parameters.AddWithValue("$code", code.Trim());

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            return new Product
            {
                Id = reader.GetInt32(0),
                Code = reader.GetString(1),
                Name = reader.GetString(2),
                CategoryId = reader.GetInt32(3)
            };
        }

        public IReadOnlyList<Product> GetByCategoryId(int categoryId)
        {
            var result = new List<Product>();

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, Code, Name, CategoryId
                FROM Products
                WHERE CategoryId = $categoryId
                ORDER BY Name;
            ";

            cmd.Parameters.AddWithValue("$categoryId", categoryId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Product
                {
                    Id = reader.GetInt32(0),
                    Code = reader.GetString(1),
                    Name = reader.GetString(2),
                    CategoryId = reader.GetInt32(3)
                });
            }

            return result;
        }
    }
}

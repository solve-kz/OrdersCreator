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
    public sealed class SqliteCategoryRepository : ICategoryRepository
    {
        private readonly SqliteConnectionFactory _factory;

        public SqliteCategoryRepository(SqliteConnectionFactory factory)
        {
            _factory = factory;
        }

        public Category AddCategory(Category category)
        {
            ArgumentNullException.ThrowIfNull(category);

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
        INSERT INTO Categories (Name)
        VALUES ($name);

        SELECT last_insert_rowid();
    ";

            cmd.Parameters.AddWithValue("$name", category.Name.Trim());

            var newId = Convert.ToInt64(cmd.ExecuteScalar());
            category.Id = (int)newId;

            return category;
        }

        public void UpdateCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException(nameof(category));

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                            UPDATE Categories
                            SET Name = $name
                            WHERE Id = $id;
                            ";
            cmd.Parameters.AddWithValue("$name", category.Name.Trim());
            cmd.Parameters.AddWithValue("$id", category.Id);

            cmd.ExecuteNonQuery();
        }

        public void DeleteCategory(int id)
        {
            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                            DELETE FROM Categories
                            WHERE Id = $id;
                            ";
            cmd.Parameters.AddWithValue("$id", id);

            cmd.ExecuteNonQuery();
        }

        public Category? GetById(int id)
        {
            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                            SELECT Id, Name
                            FROM Categories
                            WHERE Id = $id;
                            ";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            return new Category
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            };
        }

        public IReadOnlyList<Category> GetAll()
        {
            var result = new List<Category>();

            using var conn = _factory.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                            SELECT Id, Name
                            FROM Categories
                            ORDER BY Name;
                            ";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Category
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }

            return result;
        }
    }
}

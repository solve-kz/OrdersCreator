using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace OrdersCreator.Infrastructure.Sqlite
{
    public sealed class SqliteDbInitializer
    {
        private readonly SqliteConnectionFactory _factory;

        public SqliteDbInitializer(SqliteConnectionFactory factory)
        {
            _factory = factory;
        }

        public void EnsureCreated()
        {
            using var connection = _factory.CreateConnection();
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                            CREATE TABLE IF NOT EXISTS Categories (
                            Id      INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name    TEXT NOT NULL UNIQUE
                            );

                            CREATE TABLE IF NOT EXISTS Customers (
                            Id      INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name    TEXT NOT NULL UNIQUE
                            );

                            CREATE TABLE IF NOT EXISTS Products (
                            Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                            Code        TEXT NOT NULL UNIQUE,
                            Name        TEXT NOT NULL,
                            CategoryId  INTEGER NOT NULL,
                            FOREIGN KEY (CategoryId) REFERENCES Categories(Id) ON DELETE RESTRICT
                            );
";
            cmd.ExecuteNonQuery();
        }
    }
}

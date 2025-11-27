using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace OrdersCreator.Infrastructure.Sqlite
{
    public sealed class SqliteConnectionFactory
    {
        private readonly string _connectionString;

        public SqliteConnectionFactory(string dbFilePath)
        {
            if (string.IsNullOrWhiteSpace(dbFilePath))
                throw new ArgumentException("Путь к файлу БД не задан.", nameof(dbFilePath));

            // База хранится в папке программы
            _connectionString = $"Data Source={dbFilePath};Cache=Shared";
        }

        public SqliteConnection CreateConnection()
        {
            return new SqliteConnection(_connectionString);
        }
    }
}

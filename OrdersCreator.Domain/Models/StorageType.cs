using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCreator.Domain.Models
{
    public enum StorageType
    {
        /// <summary>
        /// In-memory — тестовый режим, без сохранения между запусками.
        /// </summary>
        InMemory = 0,

        /// <summary>
        /// Локальный файл SQLite рядом с программой.
        /// </summary>
        Sqlite = 1,

        /// <summary>
        /// Внешний SQL Server по строке подключения.
        /// </summary>
        SqlServer = 2
    }
}

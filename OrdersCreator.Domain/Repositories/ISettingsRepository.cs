using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ISettingsRepository.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Repositories
{
    /// <summary>
    /// Низкоуровневый доступ к хранению настроек (SQLite / SQL Server / файл).
    /// </summary>
    public interface ISettingsRepository
    {
        /// <summary>Загрузить настройки (или вернуть значения по умолчанию).</summary>
        AppSettings Load();

        /// <summary>Сохранить настройки.</summary>
        void Save(AppSettings settings);
    }
}


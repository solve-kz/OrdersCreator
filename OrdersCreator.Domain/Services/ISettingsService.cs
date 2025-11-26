using OrdersCreator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCreator.Domain.Services
{
    /// <summary>
    /// Высокоуровневый сервис настроек для UI и остальной логики.
    /// </summary>
    public interface ISettingsService
    {
        /// <summary>
        /// Получить текущие настройки.
        /// Может использовать внутренний кэш.
        /// </summary>
        AppSettings GetSettings();

        /// <summary>
        /// Обновить и сохранить настройки.
        /// </summary>
        void UpdateSettings(AppSettings settings);
    }
}

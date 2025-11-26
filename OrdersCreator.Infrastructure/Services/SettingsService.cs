using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;

namespace OrdersCreator.Infrastructure.Services
{
    /// <summary>
    /// Реализация сервиса настроек с простым кэшированием.
    /// </summary>
    public sealed class SettingsService : ISettingsService
    {
        private readonly ISettingsRepository _repository;
        private AppSettings? _cache;

        public SettingsService(ISettingsRepository repository)
        {
            _repository = repository;
        }

        public AppSettings GetSettings()
        {
            // Лениво загружаем один раз и кэшируем.
            return _cache ??= _repository.Load();
        }

        public void UpdateSettings(AppSettings settings)
        {
            _repository.Save(settings);
            _cache = settings;
        }
    }
}

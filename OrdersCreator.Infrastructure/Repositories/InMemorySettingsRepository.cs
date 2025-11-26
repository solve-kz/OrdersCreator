using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;

namespace OrdersCreator.Infrastructure.Repositories
{
    /// <summary>
    /// Простейший репозиторий настроек "в памяти" – для отладки без БД.
    /// Живёт только пока запущено приложение.
    /// </summary>
    public sealed class InMemorySettingsRepository : ISettingsRepository
    {
        private AppSettings _settings;

        public InMemorySettingsRepository()
        {
            // здесь можно задать дефолты, если надо свои
            _settings = new AppSettings();
        }

        public AppSettings Load()
        {
            // возвращаем копию, чтобы снаружи модель не ломали случайно
            return new AppSettings
            {
                ReportsRootFolder = _settings.ReportsRootFolder,
                UseDailySubfolder = _settings.UseDailySubfolder,
                ReportTemplatePath = _settings.ReportTemplatePath,
                ReportFileNameMask = _settings.ReportFileNameMask,
                OpenReportAfterSave = _settings.OpenReportAfterSave,
                ScannerCharTimeoutMs = _settings.ScannerCharTimeoutMs,
                AllowManualBarcodeInput = _settings.AllowManualBarcodeInput,
                SoundsEnabled = _settings.SoundsEnabled,
                UnknownProductMode = _settings.UnknownProductMode,
                StorageType = _settings.StorageType,
                SqlServerConnectionString = _settings.SqlServerConnectionString
            };
        }

        public void Save(AppSettings settings)
        {
            // просто сохраняем копию в поле
            _settings = settings;
        }
    }
}

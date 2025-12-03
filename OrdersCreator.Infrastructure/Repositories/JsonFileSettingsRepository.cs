using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;

namespace OrdersCreator.Infrastructure.Repositories
{
    /// <summary>
    /// Репозиторий настроек, сохраняющий их в JSON-файл.
    /// </summary>
    public sealed class JsonFileSettingsRepository : ISettingsRepository
    {
        private readonly string _filePath;
        private readonly JsonSerializerOptions _options;

        public JsonFileSettingsRepository(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Путь к файлу настроек не задан.", nameof(filePath));

            _filePath = filePath;

            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
                // Хотим видеть в JSON строки enum'ов, а не числа
                Converters = { new JsonStringEnumConverter() }
            };
        }

        public AppSettings Load()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    // Первый запуск: файла нет — создаём настройки по умолчанию
                    WriteDefaultConfig();
                    return new AppSettings();
                }

                var json = File.ReadAllText(_filePath);

                if (string.IsNullOrWhiteSpace(json))
                {
                    WriteDefaultConfig();
                    return new AppSettings();
                }

                var settings = JsonSerializer.Deserialize<AppSettings>(json, _options);

                return settings ?? new AppSettings();
            }
            catch
            {
                // Если файл битый или что-то сломалось — не заваливаем приложение,
                // а возвращаем настройки по умолчанию.
                WriteDefaultConfig();
                return new AppSettings();
            }
        }

        public void Save(AppSettings settings)
        {
            if (settings == null) throw new ArgumentNullException(nameof(settings));

            // Создаём каталог при необходимости
            var dir = Path.GetDirectoryName(_filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var json = JsonSerializer.Serialize(settings, _options);
            File.WriteAllText(_filePath, json);
        }

        private void WriteDefaultConfig()
        {
            Save(new AppSettings());
        }
    }
}

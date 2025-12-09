using OrdersCreator.Domain.Barcode;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;
using OrdersCreator.Infrastructure.Barcode;
using OrdersCreator.Infrastructure.Repositories;
using OrdersCreator.Infrastructure.Services; // реальные реализации
using OrdersCreator.Infrastructure.Sqlite;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    internal static class Program
    {
        private static readonly JsonSerializerOptions DefaultConfigSerializerOptions = new()
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "OrderCreator");

            EnsureAppDataDirectory(appDataPath);

            var settingsFilePath = Path.Combine(appDataPath, "appsettings.json");
            var defaultSettings = new AppSettings();
            EnsureConfigUpToDate(settingsFilePath, defaultSettings);

            HelpDirectoryManager.EnsureHelpDirectoryReady(appDataPath);

            var builder = new ConfigurationBuilder()
                .AddJsonFile(settingsFilePath, optional: true, reloadOnChange: true)
                .Build();

            ISettingsRepository settingsRepo = new JsonFileSettingsRepository(settingsFilePath);
            ISettingsService settingsService = new SettingsService(settingsRepo);

            var appSettings = settingsService.GetSettings();

            // ----- 2. Выбор хранилища справочников -----
            ICategoryRepository categoryRepo;
            ICustomerRepository customerRepo;
            IProductRepository productRepo;

            if (appSettings.StorageType == StorageType.Sqlite)
            {
                var dbPath = Path.Combine(appDataPath, "OrderCreator.db");

                var sqliteFactory = EnsureDatabaseReady(dbPath);
                var dbInitializer = new SqliteDbInitializer(sqliteFactory);

                try
                {
                    dbInitializer.EnsureCreated();

                    categoryRepo = new SqliteCategoryRepository(sqliteFactory);
                    customerRepo = new SqliteCustomerRepository(sqliteFactory);
                    productRepo = new SqliteProductRepository(sqliteFactory);
                }
                catch (Exception ex)
                {
                    // На всякий случай fallback, чтобы программа не умерла
                    MessageBox.Show(
                        "Не удалось инициализировать базу SQLite.\n" +
                        "Будет использовано временное хранилище в памяти.\n\n" +
                        ex.Message,
                        "Ошибка инициализации БД",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    categoryRepo = new InMemoryCategoryRepository();
                    customerRepo = new InMemoryCustomerRepository();
                    productRepo = new InMemoryProductRepository();
                }
            }
            else
            {
                // Режим "В памяти" – тестовый или отладочный
                categoryRepo = new InMemoryCategoryRepository();
                customerRepo = new InMemoryCustomerRepository();
                productRepo = new InMemoryProductRepository();
            }

            // ----- 3. Сервисы справочников -----
            ICategoryService categoryService = new CategoryService(categoryRepo);
            ICustomerService customerService = new CustomerService(customerRepo);
            IProductService productService = new ProductService(productRepo, categoryRepo);
            IReportService reportService = new ReportService(settingsService);
            IOrderRepository orderRepository = new FileOrderRepository();

            IBarcodeParser barcodeParser = new BarcodeParser();
            IOrderService orderService = new OrderService(productService);


            /*ICustomerRepository customerRepository = new InMemoryCustomerRepository();
            ICustomerService customerService = new CustomerService(customerRepository);
            ICategoryRepository categoryRepository = new InMemoryCategoryRepository();
            ICategoryService categoryService = new CategoryService(categoryRepository);
            IProductRepository productRepo = new InMemoryProductRepository();
            IProductService productService = new ProductService(productRepo);*/


            var mainForm = new MainForm(
                customerService,
                categoryService,
                productService,
                settingsService,
                barcodeParser,
                orderService,
                reportService,
                orderRepository);
            Application.Run(mainForm);
        }

        private static void EnsureAppDataDirectory(string appDataPath)
        {
            Directory.CreateDirectory(appDataPath);
        }

        private static void EnsureConfigUpToDate(string configPath, AppSettings defaultSettings)
        {
            var dir = Path.GetDirectoryName(configPath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            AppSettings settings;
            var needRewrite = false;
            var existingProperties = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            try
            {
                if (!File.Exists(configPath))
                {
                    settings = new AppSettings();
                    needRewrite = true;
                }
                else
                {
                    var json = File.ReadAllText(configPath);

                    if (string.IsNullOrWhiteSpace(json))
                    {
                        settings = new AppSettings();
                        needRewrite = true;
                    }
                    else
                    {
                        using var doc = JsonDocument.Parse(json);
                        existingProperties.UnionWith(doc.RootElement
                            .EnumerateObject()
                            .Select(p => p.Name));

                        settings = JsonSerializer.Deserialize<AppSettings>(json, DefaultConfigSerializerOptions)
                                   ?? new AppSettings();
                    }
                }
            }
            catch
            {
                settings = new AppSettings();
                needRewrite = true;
            }

            foreach (var property in typeof(AppSettings).GetProperties())
            {
                if (property.GetMethod is null || property.SetMethod is null)
                {
                    continue;
                }

                if (existingProperties.Contains(property.Name))
                {
                    continue;
                }

                var defaultValue = property.GetValue(defaultSettings);
                property.SetValue(settings, defaultValue);
                needRewrite = true;
            }

            if (needRewrite)
            {
                var json = JsonSerializer.Serialize(settings, DefaultConfigSerializerOptions);
                File.WriteAllText(configPath, json);
            }
        }

        private static SqliteConnectionFactory EnsureDatabaseReady(string dbPath)
        {
            if (!File.Exists(dbPath))
            {
                var sourceDbPath = Path.Combine(AppContext.BaseDirectory, "Data", "OrderCreator.db");

                if (File.Exists(sourceDbPath))
                {
                    File.Copy(sourceDbPath, dbPath, overwrite: true);
                }
            }

            return new SqliteConnectionFactory(dbPath);
        }
    }
}

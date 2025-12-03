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
using System.IO;
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

            // ----- 1. Настройки из JSON -----
            var appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "OrderCreator");
            Directory.CreateDirectory(appDataPath);

            var settingsFilePath = Path.Combine(appDataPath, "appsettings.json");
            EnsureDefaultConfig(settingsFilePath);

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
                var dbDir = Path.Combine(appDataPath, "Data");

                Directory.CreateDirectory(dbDir);

                var dbPath = Path.Combine(dbDir, "OrderCreator.db");

                if (!File.Exists(dbPath))
                {
                    var legacyAppDataDb = Path.Combine(appDataPath, "orders.db");
                    var legacyLocalDb = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "OrderCreator",
                        "Data",
                        "OrderCreator.db");
                    var legacyProgramDb = Path.Combine(AppContext.BaseDirectory, "OrderCreator.db");

                    if (File.Exists(legacyAppDataDb))
                    {
                        File.Copy(legacyAppDataDb, dbPath);
                    }
                    else if (File.Exists(legacyLocalDb))
                    {
                        File.Copy(legacyLocalDb, dbPath);
                    }
                    else if (File.Exists(legacyProgramDb))
                    {
                        File.Copy(legacyProgramDb, dbPath);
                    }
                }

                var sqliteFactory = new SqliteConnectionFactory(dbPath);
                var dbInitializer = new SqliteDbInitializer(sqliteFactory);

                try
                {
                    // ЭТОГО достаточно: если файла нет – он создастся,
                    // если таблиц нет – они создадутся.
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

        private static void EnsureDefaultConfig(string configPath)
        {
            if (File.Exists(configPath))
                return;

            var dir = Path.GetDirectoryName(configPath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var defaultSettings = new AppSettings();
            var json = JsonSerializer.Serialize(defaultSettings, DefaultConfigSerializerOptions);
            File.WriteAllText(configPath, json);
        }
    }
}

using OrdersCreator.Domain.Barcode;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;
using OrdersCreator.Infrastructure.Repositories;
using OrdersCreator.Infrastructure.Services; // реальные реализации
using OrdersCreator.Infrastructure.Sqlite;
using System;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // ----- 1. Настройки из JSON -----
            var settingsFilePath = Path.Combine(AppContext.BaseDirectory, "settings.json");
            ISettingsRepository settingsRepo = new JsonFileSettingsRepository(settingsFilePath);
            ISettingsService settingsService = new SettingsService(settingsRepo);

            var appSettings = settingsService.GetSettings();

            // ----- 2. Выбор хранилища справочников -----
            ICategoryRepository categoryRepo;
            ICustomerRepository customerRepo;
            IProductRepository productRepo;

            if (appSettings.StorageType == StorageType.Sqlite)
            {
                var dbPath = Path.Combine(AppContext.BaseDirectory, "orders.db");
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
            IProductService productService = new ProductService(productRepo);


            /*ICustomerRepository customerRepository = new InMemoryCustomerRepository();
            ICustomerService customerService = new CustomerService(customerRepository);
            ICategoryRepository categoryRepository = new InMemoryCategoryRepository();
            ICategoryService categoryService = new CategoryService(categoryRepository);
            IProductRepository productRepo = new InMemoryProductRepository();
            IProductService productService = new ProductService(productRepo);*/


            var mainForm = new MainForm(customerService, categoryService, productService, settingsService);
            Application.Run(mainForm);
        }
    }
}
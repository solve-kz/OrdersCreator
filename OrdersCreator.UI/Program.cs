using OrdersCreator.Domain.Barcode;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;
using System;
using System.Windows.Forms;
using OrdersCreator.Infrastructure.Services; // реальные реализации
using OrdersCreator.Infrastructure.Repositories;

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
            
            ICustomerRepository customerRepository = new InMemoryCustomerRepository();
            ICustomerService customerService = new CustomerService(customerRepository);
            ICategoryRepository categoryRepository = new InMemoryCategoryRepository();
            ICategoryService categoryService = new CategoryService(categoryRepository);
            IProductRepository productRepo = new InMemoryProductRepository();
            IProductService productService = new ProductService(productRepo);
            ISettingsRepository settingsRepository = new InMemorySettingsRepository();
            ISettingsService settingsService = new SettingsService(settingsRepository);

            var mainForm = new MainForm(customerService, categoryService, productService, settingsService);
            Application.Run(mainForm);
        }
    }
}
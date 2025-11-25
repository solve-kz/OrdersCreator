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

            // Здесь пока можно создать "заглушки" / InMemory-реализации:
            /*IBarcodeParser barcodeParser = new SimpleBarcodeParser(); // TODO: твоя реализация
            IOrderService orderService = new InMemoryOrderService();   // TODO
            ICustomerService customerService = new InMemoryCustomerService(); // TODO
            IProductService productService = new InMemoryProductService();    // TODO
            IReportService reportService = new DummyReportService();         // TODO*/

            ICustomerRepository customerRepository = new InMemoryCustomerRepository();
            ICustomerService customerService = new CustomerService(customerRepository);
            ICategoryRepository categoryRepository = new InMemoryCategoryRepository();
            ICategoryService categoryService = new CategoryService(categoryRepository);
            IProductRepository productRepo = new InMemoryProductRepository();
            IProductService productService = new ProductService(productRepo);

            var mainForm = new MainForm(customerService, categoryService, productService);
            Application.Run(mainForm);
        }
    }
}
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    public partial class MainForm : Form
    {

        private readonly ICustomerService _customerService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public MainForm(ICustomerService customerService, ICategoryService categoryService, IProductService productService)
        {
            InitializeComponent();
            _customerService = customerService;
            LoadCustomersForMain();
            _categoryService = categoryService;
            _productService = productService;
        }

        private void LoadCustomersForMain()
        {
            var customers = _customerService
                .GetAll()
                .OrderBy(c => c.Name)
                .ToList();

            cmbCustomers.DataSource = customers;
            cmbCustomers.DisplayMember = nameof(Customer.Name);
            cmbCustomers.ValueMember = nameof(Customer.Id);

            cmbCustomers.SelectedIndex = -1;
        }

        

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRefEdit refEditForm = new FormRefEdit(_customerService, _categoryService, _productService);
            refEditForm.ShowDialog();
            LoadCustomersForMain();
        }
    }
}

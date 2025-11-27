using OrdersCreator.Domain.Barcode;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        private readonly ISettingsService _settingsService;



        public MainForm(ICustomerService customerService, 
                        ICategoryService categoryService, 
                        IProductService productService,
                        ISettingsService settingsService)
        {
            InitializeComponent();
            _customerService = customerService;            
            _categoryService = categoryService;
            _productService = productService;
            _settingsService = settingsService;
            
            LoadCustomersForMain();

            

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

        private void настройкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings(_settingsService);
            settingsForm.ShowDialog();
        }

        private void cmbCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedIndex != -1)
            {
                lblReady.Text = "Готов к сканированию";
            }
            else
            {
                lblReady.Text = "Выберите контрагента!";
            }
        }
    }
}

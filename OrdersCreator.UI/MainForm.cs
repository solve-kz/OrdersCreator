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
        private readonly IBarcodeParser _barcodeParser;
        private readonly IOrderService _orderService;

        private AppSettings _appSettings = new();
        private readonly StringBuilder _scannerBuffer = new();
        private readonly System.Windows.Forms.Timer _scannerTimer = new();
        private DateTime _lastScannerCharTime;



        public MainForm(ICustomerService customerService,
                        ICategoryService categoryService,
                        IProductService productService,
                        ISettingsService settingsService,
                        IBarcodeParser barcodeParser,
                        IOrderService orderService)
        {
            InitializeComponent();
            _customerService = customerService;
            _categoryService = categoryService;
            _productService = productService;
            _settingsService = settingsService;
            _barcodeParser = barcodeParser;
            _orderService = orderService;

            _appSettings = _settingsService.GetSettings();
            _scannerTimer.Interval = _appSettings.ScannerCharTimeoutMs;
            _scannerTimer.Tick += ScannerTimer_Tick;

            KeyPreview = true;
            KeyPress += MainForm_KeyPress;
            KeyDown += MainForm_KeyDown;


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

            _appSettings = _settingsService.GetSettings();
            _scannerTimer.Interval = _appSettings.ScannerCharTimeoutMs;
        }

        private void cmbCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedIndex != -1 && cmbCustomers.SelectedItem is Customer selectedCustomer)
            {
                _orderService.SetCustomer(selectedCustomer);
                lblReady.Text = "Готов к сканированию";
            }
            else
            {
                lblReady.Text = "Выберите контрагента!";
            }
        }

        private void MainForm_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                AppendScannerChar(e.KeyChar);
                e.Handled = true;
            }
            else if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                FinalizeScannerBuffer();
                e.Handled = true;
            }
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _scannerBuffer.Length > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                FinalizeScannerBuffer();
            }
            else if (e.KeyCode == Keys.F9)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (!_appSettings.AllowManualBarcodeInput)
                    return;

                var clipboardText = Clipboard.GetText()?.Trim();
                if (!string.IsNullOrWhiteSpace(clipboardText))
                {
                    ProcessRawBarcode(clipboardText);
                }
            }
        }

        private void AppendScannerChar(char keyChar)
        {
            var now = DateTime.UtcNow;
            if (_scannerBuffer.Length > 0 &&
                (now - _lastScannerCharTime).TotalMilliseconds > _appSettings.ScannerCharTimeoutMs)
            {
                _scannerBuffer.Clear();
            }

            _scannerBuffer.Append(keyChar);
            _lastScannerCharTime = now;

            RestartScannerTimer();
        }

        private void ScannerTimer_Tick(object? sender, EventArgs e)
        {
            FinalizeScannerBuffer();
        }

        private void RestartScannerTimer()
        {
            _scannerTimer.Stop();
            _scannerTimer.Interval = _appSettings.ScannerCharTimeoutMs;
            _scannerTimer.Start();
        }

        private void FinalizeScannerBuffer()
        {
            _scannerTimer.Stop();

            if (_scannerBuffer.Length == 0)
                return;

            var raw = _scannerBuffer.ToString();
            _scannerBuffer.Clear();

            if (raw.Length is not 12 and not 13)
                return;

            ProcessRawBarcode(raw);
        }

        private void ProcessRawBarcode(string rawBarcode)
        {
            if (string.IsNullOrWhiteSpace(rawBarcode))
                return;

            try
            {
                var parsed = _barcodeParser.Parse(rawBarcode);
                var orderLine = _orderService.AddLineFromBarcode(parsed);
                DisplayParsedBarcode(parsed, orderLine);
                lblReady.Text = "Готов к сканированию";
            }
            catch (Exception ex)
            {
                lblReady.Text = ex.Message;
            }
        }

        private void DisplayParsedBarcode(ParsedBarcode parsedBarcode, OrderLine orderLine)
        {
            lblCodeAmount.Text = parsedBarcode.ProductCode;
            lblCodeWeight.Text = parsedBarcode.WeightKg.ToString("F3");

            if (orderLine.Product != null)
            {
                lblCurrentTitle.Text = orderLine.Product.Name;
                lblCurrentCategory.Text = orderLine.Product.Category?.Name ?? string.Empty;
                lblCurrentWeight.Text = _orderService
                    .GetCurrentProductSubtotal(orderLine.Product.Code)
                    .ToString("F3");
            }
        }

    }
}

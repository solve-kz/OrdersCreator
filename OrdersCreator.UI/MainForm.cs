using OrdersCreator.Domain.Barcode;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Repositories;
using OrdersCreator.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
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
        private readonly IReportService _reportService;
        private readonly IOrderRepository _orderRepository;

        private ParsedBarcode? _pendingBarcode;
        private SoundPlayer? _successPlayer;
        private SoundPlayer? _failurePlayer;

        private AppSettings _appSettings = new();
        private IReadOnlyList<Category> _categories = new List<Category>();
        private readonly StringBuilder _scannerBuffer = new();
        private readonly System.Windows.Forms.Timer _scannerTimer = new();
        private DateTime _lastScannerCharTime;



        public MainForm(ICustomerService customerService,
                        ICategoryService categoryService,
                        IProductService productService,
                        ISettingsService settingsService,
                        IBarcodeParser barcodeParser,
                        IOrderService orderService,
                        IReportService reportService,
                        IOrderRepository orderRepository)
        {
            InitializeComponent();
            _customerService = customerService;
            _categoryService = categoryService;
            _productService = productService;
            _settingsService = settingsService;
            _barcodeParser = barcodeParser;
            _orderService = orderService;
            _reportService = reportService;
            _orderRepository = orderRepository;

            _appSettings = _settingsService.GetSettings();
            _scannerTimer.Interval = _appSettings.ScannerCharTimeoutMs;
            _scannerTimer.Tick += ScannerTimer_Tick;

            KeyPreview = true;
            KeyPress += MainForm_KeyPress;
            KeyDown += MainForm_KeyDown;

            Load += MainForm_Load;

            btnCancel.Click += BtnCancel_Click;
            btnNewProductAdd.Click += BtnNewProductAdd_Click;
            dataGridViewOrderLines.SelectionChanged += DataGridViewOrderLines_SelectionChanged;
            btnCreateReport.Click += BtnCreateReport_Click;
            открытьToolStripMenuItem.Click += ОткрытьToolStripMenuItem_Click;
            сохранитьToolStripMenuItem.Click += СохранитьToolStripMenuItem_Click;


            LoadCustomersForMain();
            LoadCategoriesForNewProduct();

            InitializeSounds();            

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
            LoadCategoriesForNewProduct();
        }

        private void настройкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings(_settingsService);
            settingsForm.ShowDialog();

            _appSettings = _settingsService.GetSettings();
            _scannerTimer.Interval = _appSettings.ScannerCharTimeoutMs;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            SwitchToGreenMode();
            UpdateResults();

            /*if (cmbCustomers.Items.Count > 0 && cmbCustomers.SelectedIndex == -1)
            {
                cmbCustomers.SelectedIndex = 0;
            }*/
        }

        private void cmbCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedIndex != -1 && cmbCustomers.SelectedItem is Customer selectedCustomer)
            {
                _orderService.StartNewOrder(selectedCustomer);
                dataGridViewOrderLines.Rows.Clear();
                lblReady.Text = "Готов к сканированию!";
                lblReady.BackColor = Color.Green;
                UpdateResults();
            }
            else
            {
                lblReady.Text = "Выберите контрагента!";
                lblReady.BackColor = Color.Red; 
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
            if (panelRedMode.Visible && e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                BtnNewProductAdd_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.Enter && _scannerBuffer.Length > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                FinalizeScannerBuffer();
            }
            else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                CancelLastAction();
            }
            else if (e.KeyCode == Keys.F12)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                BtnCreateReport_Click(sender, e);
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

            if (panelRedMode.Visible)
                return;

            if (cmbCustomers.SelectedItem is not Customer selectedCustomer)
            {
                lblReady.Text = "Выберите контрагента!";
                lblReady.BackColor = Color.Red;
                PlayFailureSound();
                return;
            }

            try
            {
                var parsed = _barcodeParser.Parse(rawBarcode);
                var product = _productService.FindByCode(parsed.ProductCode);

                if (product == null)
                {
                    HandleUnknownProduct(parsed);
                    return;
                }

                var orderLine = _orderService.AddLine(product, parsed.WeightKg);
                AddOrderLineToGrid(orderLine);
                DisplayParsedBarcode(parsed, orderLine);
                lblReady.Text = "Готов к сканированию!";
                lblReady.BackColor = Color.Green;
                UpdateResults();
                PlaySuccessSound();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка парсинга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // lblReady.Text = ex.Message;
                PlayFailureSound();
            }
        }

        private void DisplayParsedBarcode(ParsedBarcode parsedBarcode, OrderLine orderLine)
        {
            if (orderLine.Product != null)
            {
                lblCurrentTitle.Text = orderLine.Product.Name;
                lblCurrentCategory.Text = (orderLine.Product.Category ?? FindCategoryById(orderLine.Product.CategoryId))?.Name ?? string.Empty;
                lblCurrentWeight.Text = parsedBarcode.WeightKg.ToString("F3");

                lblCodeAmount.Text = GetProductCount(orderLine.Product.Code).ToString();
                lblCodeWeight.Text = _orderService
                    .GetCurrentProductSubtotal(orderLine.Product.Code)
                    .ToString("F3");
            }

            dataGridViewOrderLines.ClearSelection();
            if (dataGridViewOrderLines.Rows.Count > 0)
            {
                dataGridViewOrderLines.Rows[0].Selected = true;
            }
        }

        private void AddOrderLineToGrid(OrderLine orderLine)
        {
            var productCode = orderLine.Product?.Code ?? string.Empty;
            var productTitle = orderLine.Product?.Name ?? string.Empty;

            dataGridViewOrderLines.Rows.Insert(0,
                orderLine.RowNumber,
                productCode,
                productTitle,
                orderLine.WeightKg.ToString("F3"),
                "✕");
        }

        private void UpdateResults()
        {
            var lines = _orderService.CurrentOrder?.Lines ?? new List<OrderLine>();
            var productCode = GetSelectedProductCode();
            var relevantLines = lines
                .Where(l => !string.IsNullOrWhiteSpace(productCode) && l.Product?.Code == productCode)
                .ToList();

            var totalWeight = relevantLines.Sum(l => l.WeightKg);

            lblResults.Text = $"ИТОГО: {relevantLines.Count} мест | {totalWeight:F3} кг.";
        }

        private void LoadCategoriesForNewProduct()
        {
            var categories = _categoryService
                .GetAll()
                .OrderBy(c => c.Name)
                .ToList();

            _categories = categories;

            cbNewProductCategory.DataSource = categories;
            cbNewProductCategory.DisplayMember = nameof(Category.Name);
            cbNewProductCategory.ValueMember = nameof(Category.Id);
        }

        private void InitializeSounds()
        {
            var baseDir = AppContext.BaseDirectory;
            var successPath = Path.Combine(baseDir, "Sounds", "success.wav");
            var failurePath = Path.Combine(baseDir, "Sounds", "failure.wav");

            if (File.Exists(successPath))
            {
                _successPlayer = new SoundPlayer(successPath);
            }

            if (File.Exists(failurePath))
            {
                _failurePlayer = new SoundPlayer(failurePath);
            }
        }

        private void PlaySuccessSound()
        {
            if (_appSettings.SoundsEnabled)
            {
                _successPlayer?.Play();
            }
        }

        private void PlayFailureSound()
        {
            if (_appSettings.SoundsEnabled)
            {
                _failurePlayer?.Play();
            }
        }

        private void HandleUnknownProduct(ParsedBarcode parsed)
        {
            _pendingBarcode = parsed;

            tbNewProductCode.Text = parsed.ProductCode;
            tbNewProductWeight.Text = parsed.WeightKg.ToString("F3");
            tbNewProductTitle.Text = string.Empty;

            SwitchToRedMode();
            // lblReady.Text = $"Товар {parsed.ProductCode} не найден";
            MessageBox.Show($"Товар {parsed.ProductCode} не найден", "Ошибка поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PlayFailureSound();

            if (cbNewProductCategory.Items.Count > 0)
            {
                cbNewProductCategory.SelectedIndex = 0;
            }

            tbNewProductTitle.Focus();
        }

        private void SwitchToGreenMode()
        {
            panelRedMode.Visible = false;
            panelGreenMode.Visible = true;
            panelGreenMode.BringToFront();
        }

        private void SwitchToRedMode()
        {
            panelGreenMode.Visible = false;
            panelRedMode.Visible = true;
            panelRedMode.BringToFront();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            CancelLastAction();
        }

        private void CancelLastAction()
        {
            if (panelRedMode.Visible)
            {
                _pendingBarcode = null;
                SwitchToGreenMode();
                lblReady.Text = "Готов к сканированию!";
                lblReady.BackColor = Color.Green;
                return;
            }

            if (_orderService.CurrentOrder?.Lines.Count > 0)
            {
                _orderService.CancelLastLine();

                if (dataGridViewOrderLines.Rows.Count > 0)
                {
                    dataGridViewOrderLines.Rows.RemoveAt(0);
                }

                UpdateResults();
                // lblReady.Text = "Последняя строка отменена.";
                MessageBox.Show("Последняя строка отменена", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnNewProductAdd_Click(object? sender, EventArgs e)
        {
            if (_pendingBarcode == null)
                return;

            if (cbNewProductCategory.SelectedItem is not Category category)
                return;

            var title = tbNewProductTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
                return;

            var product = _productService.AddProduct(_pendingBarcode.ProductCode, title, category);
            var orderLine = _orderService.AddLine(product, _pendingBarcode.WeightKg);

            AddOrderLineToGrid(orderLine);
            DisplayParsedBarcode(_pendingBarcode, orderLine);
            UpdateResults();
            PlaySuccessSound();

            _pendingBarcode = null;
            SwitchToGreenMode();
            lblReady.Text = "Готов к сканированию!";
            lblReady.BackColor = Color.Green;
        }

        private void DataGridViewOrderLines_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridViewOrderLines.SelectedRows.Count == 0)
                return;

            var row = dataGridViewOrderLines.SelectedRows[0];
            var productCode = row.Cells[nameof(ProductCode)]?.Value?.ToString() ?? string.Empty;

            lblCodeAmount.Text = GetProductCount(productCode).ToString();
            lblCodeWeight.Text = _orderService
                .GetCurrentProductSubtotal(productCode)
                .ToString("F3");

            UpdateResults();
        }

        private int GetProductCount(string productCode)
        {
            var lines = _orderService.CurrentOrder?.Lines ?? new List<OrderLine>();

            if (string.IsNullOrWhiteSpace(productCode))
                return 0;

            var normalized = productCode.Trim();

            return lines.Count(l => l.Product?.Code == normalized);
        }

        private string GetSelectedProductCode()
        {
            if (dataGridViewOrderLines.SelectedRows.Count == 0)
                return string.Empty;

            return dataGridViewOrderLines.SelectedRows[0].Cells[nameof(ProductCode)]?.Value?.ToString() ?? string.Empty;
        }

        private Category? FindCategoryById(int categoryId)
        {
            return _categories.FirstOrDefault(c => c.Id == categoryId) ??
                   _categoryService.GetAll().FirstOrDefault(c => c.Id == categoryId);
        }

        private void BtnCreateReport_Click(object? sender, EventArgs e)
        {
            try
            {
                var current = _orderService.CurrentOrder ?? throw new InvalidOperationException("Нет активного заказа.");

                var reportPath = _reportService.CreateReport(current);

                if (current.Customer != null)
                {
                    ResetAfterReport(current.Customer);
                }

                // lblReady.Text = $"Отчёт сохранён: {reportPath}";
                MessageBox.Show($"Отчёт сохранён: {reportPath}", "Ошибка формирования отчёта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PlaySuccessSound();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка формирования отчёта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // lblReady.Text = ex.Message;
                PlayFailureSound();
            }
        }

        private void ResetAfterReport(Customer customer)
        {
            dataGridViewOrderLines.Rows.Clear();
            _orderService.StartNewOrder(customer, DateTime.Now);
            SwitchToGreenMode();
            _scannerBuffer.Clear();
            UpdateResults();

            lblCurrentTitle.Text = string.Empty;
            lblCurrentCategory.Text = string.Empty;
            lblCurrentWeight.Text = string.Empty;
            lblCodeAmount.Text = string.Empty;
            lblCodeWeight.Text = string.Empty;
        }

        private void СохранитьToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            try
            {
                var order = _orderService.CurrentOrder ?? throw new InvalidOperationException("Нет активного заказа для сохранения.");

                using var dialog = new SaveFileDialog
                {
                    Filter = "Файлы заказа (*.order.json)|*.order.json|JSON (*.json)|*.json|Все файлы (*.*)|*.*",
                    DefaultExt = "order.json"
                };

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                _orderRepository.SaveToFile(order, dialog.FileName);
                MessageBox.Show($"Заказ сохранён: {dialog.FileName}", "Ошибка формирования отчёта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // lblReady.Text = $"Заказ сохранён: {dialog.FileName}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения заказа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // lblReady.Text = ex.Message;
            }
        }

        private void ОткрытьToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            try
            {
                using var dialog = new OpenFileDialog
                {
                    Filter = "Файлы заказа (*.order.json)|*.order.json|JSON (*.json)|*.json|Все файлы (*.*)|*.*",
                    DefaultExt = "order.json"
                };

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                var order = _orderRepository.LoadFromFile(dialog.FileName);
                ApplyLoadedOrder(order);
                // lblReady.Text = $"Загружен заказ: {order.Number}";
                MessageBox.Show($"Загружен заказ: {order.Number}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки заказа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // lblReady.Text = ex.Message;
            }
        }

        private void ApplyLoadedOrder(Order order)
        {
            if (order.Customer != null)
            {
                var customers = (cmbCustomers.DataSource as IEnumerable<Customer>)?.ToList() ?? new List<Customer>();
                if (!customers.Any(c => c.Id == order.Customer.Id))
                {
                    customers.Add(order.Customer);
                    cmbCustomers.DataSource = customers.OrderBy(c => c.Name).ToList();
                    cmbCustomers.DisplayMember = nameof(Customer.Name);
                    cmbCustomers.ValueMember = nameof(Customer.Id);
                }

                for (int i = 0; i < cmbCustomers.Items.Count; i++)
                {
                    if (cmbCustomers.Items[i] is Customer customer && customer.Id == order.Customer.Id)
                    {
                        cmbCustomers.SelectedIndex = i;
                        break;
                    }
                }
            }

            _orderService.LoadOrder(order);
            FillGridFromOrder(order);
            SwitchToGreenMode();
            UpdateResults();
        }

        private void FillGridFromOrder(Order order)
        {
            dataGridViewOrderLines.Rows.Clear();

            foreach (var line in order.Lines.OrderByDescending(l => l.RowNumber))
            {
                AddOrderLineToGrid(line);
            }

            if (dataGridViewOrderLines.Rows.Count > 0)
            {
                dataGridViewOrderLines.Rows[0].Selected = true;
            }
        }

    }
}

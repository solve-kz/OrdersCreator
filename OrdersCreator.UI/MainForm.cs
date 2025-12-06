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
            ButtonCursorHelper.ApplyHandCursor(this);

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
            FormClosing += MainForm_FormClosing;

            Load += MainForm_Load;

            btnCancel.Click += BtnCancel_Click;
            btnNewProductAdd.Click += BtnNewProductAdd_Click;
            dataGridViewOrderLines.SelectionChanged += DataGridViewOrderLines_SelectionChanged;
            btnCreateReport.Click += BtnCreateReport_Click;
            открытьToolStripMenuItem.Click += ОткрытьToolStripMenuItem_Click;
            сохранитьToolStripMenuItem.Click += СохранитьToolStripMenuItem_Click;
            создатьToolStripMenuItem.Click += СоздатьToolStripMenuItem_Click;
            выходToolStripMenuItem.Click += ВыходToolStripMenuItem_Click;
            категорииToolStripMenuItem.Click += КатегорииToolStripMenuItem_Click;
            товарыToolStripMenuItem.Click += ТоварыToolStripMenuItem_Click;
            контрагентыToolStripMenuItem.Click += КонтрагентыToolStripMenuItem_Click;


            LoadCustomersForMain();
            LoadCategoriesForNewProduct();

            InitializeSounds();

            StartBlankOrder();
        }


        private void LoadCustomersForMain(int? selectedCustomerId = null)
        {
            var customers = _customerService
                .GetAll()
                .OrderBy(c => c.Name)
                .ToList();

            cmbCustomers.DataSource = customers;
            cmbCustomers.DisplayMember = nameof(Customer.Name);
            cmbCustomers.ValueMember = nameof(Customer.Id);
            if (selectedCustomerId.HasValue)
            {
                var selectedIndex = customers.FindIndex(c => c.Id == selectedCustomerId.Value);
                cmbCustomers.SelectedIndex = selectedIndex;
            }
            else
            {
                cmbCustomers.SelectedIndex = -1;
            }
        }

        private void настройкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings(_settingsService);
            settingsForm.ShowDialog();

            _appSettings = _settingsService.GetSettings();
            _scannerTimer.Interval = _appSettings.ScannerCharTimeoutMs;
        }

        private void КатегорииToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            OpenReferencesEditor(FormRefEditTab.Categories);
        }

        private void ТоварыToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            OpenReferencesEditor(FormRefEditTab.Products);
        }

        private void КонтрагентыToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            OpenReferencesEditor(FormRefEditTab.Customers);
        }

        private void OpenReferencesEditor(FormRefEditTab tab)
        {
            var currentCustomerId = _orderService.CurrentOrder?.CustomerId;
            FormRefEdit refEditForm = new FormRefEdit(_customerService, _categoryService, _productService, tab);
            refEditForm.ShowDialog();
            LoadCustomersForMain(currentCustomerId);
            LoadCategoriesForNewProduct();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            SwitchToGreenMode();

            /*if (cmbCustomers.Items.Count > 0 && cmbCustomers.SelectedIndex == -1)
            {
                cmbCustomers.SelectedIndex = 0;
            }*/
        }

        private void cmbCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedIndex != -1 && cmbCustomers.SelectedItem is Customer selectedCustomer)
            {
                _orderService.SetCustomer(selectedCustomer);
                lblReady.Text = "Готов к сканированию!";
                lblReady.BackColor = Color.Green;
                panelReady.BackColor = Color.Green;
                imgReady.Image = Properties.Resources.readyScan;
            }
            else
            {
                lblReady.Text = "Выберите контрагента!";
                lblReady.BackColor = Color.Red;
                panelReady.BackColor = Color.Red;
                imgReady.Image = Properties.Resources.attention;
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
            if (e.Control)
            {
                if (e.KeyCode == Keys.N)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    СоздатьToolStripMenuItem_Click(sender, e);
                    return;
                }

                if (e.KeyCode == Keys.O)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    ОткрытьToolStripMenuItem_Click(sender, e);
                    return;
                }

                if (e.KeyCode == Keys.S)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    СохранитьToolStripMenuItem_Click(sender, e);
                    return;
                }

                if (e.KeyCode == Keys.Q)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    ВыходToolStripMenuItem_Click(sender, e);
                    return;
                }
            }

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
            else if (e.KeyCode == Keys.Escape && panelRedMode.Visible)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                CancelRedMode();
            }
            else if (e.KeyCode == Keys.Delete && !panelRedMode.Visible)
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
                panelReady.BackColor = Color.Red;
                imgReady.Image = Properties.Resources.attention;
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
                panelReady.BackColor = Color.Green;
                imgReady.Image = Properties.Resources.readyScan;
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
                panel5.Visible = true;
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
            var uniqueCodes = lines
                .Select(l => l.Product?.Code)
                .Where(code => !string.IsNullOrWhiteSpace(code))
                .Distinct()
                .Count();

            var totalWeight = lines.Sum(l => l.WeightKg);
            var totalPlaces = lines.Count;

            lblResults.Text = $"ИТОГО: {uniqueCodes} позиций | {totalPlaces} мест | {totalWeight:F3} кг.";
            UpdateActionButtonsVisibility();
        }

        private void UpdateActionButtonsVisibility()
        {
            var hasLines = _orderService.CurrentOrder?.Lines?.Any() ?? false;
            btnCancel.Visible = hasLines;
            btnCreateReport.Visible = hasLines;
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
            if (_appSettings.SoundsEnabled) PlayFailureSound();
            if (_appSettings.UnknownProductMode == UnknownProductMode.PromptForData)
            {
                SwitchToRedMode();
            }
            else
            {
                MessageBox.Show($"Товар {parsed.ProductCode} не найден", "Ошибка поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


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
            btnCancel.Text = "ОТМЕНА (DEL)";
        }

        private void SwitchToRedMode()
        {
            panelGreenMode.Visible = false;
            panelRedMode.Visible = true;
            panelRedMode.BringToFront();
            btnCancel.Text = "ОТМЕНА (ESC)";
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            CancelLastAction();
        }

        private void CancelLastAction()
        {
            if (panelRedMode.Visible)
            {
                CancelRedMode();
                return;
            }

            if ((_orderService.CurrentOrder?.Lines.Count ?? 0) == 0)
                return;

            var confirmation = MessageBox.Show(
                "Удалить последний товар?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            _orderService.CancelLastLine();

            if (dataGridViewOrderLines.Rows.Count > 0)
            {
                dataGridViewOrderLines.Rows.RemoveAt(0);
            }

            UpdateResults();
            ClearSelectionAndDetails();
        }

        private void CancelRedMode()
        {
            _pendingBarcode = null;
            SwitchToGreenMode();
            lblReady.Text = "Готов к сканированию!";
            lblReady.BackColor = Color.Green;
            panelReady.BackColor = Color.Green;
            imgReady.Image = Properties.Resources.readyScan;
            ClearSelectionAndDetails();
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
            panelReady.BackColor = Color.Green;
            imgReady.Image = Properties.Resources.readyScan;
        }

        private void DataGridViewOrderLines_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridViewOrderLines.SelectedRows.Count == 0)
            {
                ClearOrderLineDetails();
                return;
            }


            var row = dataGridViewOrderLines.SelectedRows[0];
            var productCode = row.Cells[nameof(ProductCode)]?.Value?.ToString() ?? string.Empty;
            var productTitle = row.Cells[nameof(ProductTitle)]?.Value?.ToString() ?? string.Empty;
            var productWeight = row.Cells[nameof(ProductWeight)]?.Value?.ToString() ?? string.Empty;
            var product = _productService.FindByCode(productCode);
            var categoryName = product?.Category?.Name ?? FindCategoryById(product?.CategoryId ?? 0)?.Name ?? string.Empty;


            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            panel5.Visible = true;
            lblCurrentTitle.Text = productTitle;
            lblCurrentCategory.Text = categoryName;
            lblCurrentWeight.Text = productWeight;
            lblCodeAmount.Text = GetProductCount(productCode).ToString();
            lblCodeWeight.Text = _orderService
                .GetCurrentProductSubtotal(productCode)
                .ToString("F3");
        }

        private void ClearSelectionAndDetails()
        {
            dataGridViewOrderLines.ClearSelection();
            ClearOrderLineDetails();
        }

        private void ClearOrderLineDetails()
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            panel5.Visible = false;
            lblCurrentTitle.Text = string.Empty;
            lblCurrentCategory.Text = string.Empty;
            lblCurrentWeight.Text = string.Empty;
            lblCodeAmount.Text = string.Empty;
            lblCodeWeight.Text = string.Empty;
        }

        private int GetProductCount(string productCode)
        {
            var lines = _orderService.CurrentOrder?.Lines ?? new List<OrderLine>();

            if (string.IsNullOrWhiteSpace(productCode))
                return 0;

            var normalized = productCode.Trim();

            return lines.Count(l => l.Product?.Code == normalized);
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

                StartBlankOrder(DateTime.Now);

                // lblReady.Text = $"Отчёт сохранён: {reportPath}";
                MessageBox.Show($"Отчёт сохранён: {reportPath}", "Сохранение отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // PlaySuccessSound();
            }
            catch (Exception ex)
            {
                PlayFailureSound();
                MessageBox.Show(ex.Message, "Ошибка формирования отчёта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // lblReady.Text = ex.Message;
                
            }
        }

        private void StartBlankOrder(DateTime? date = null)
        {
            dataGridViewOrderLines.Rows.Clear();
            _orderService.StartNewOrder(null, date);
            cmbCustomers.SelectedIndex = -1;
            SwitchToGreenMode();
            _scannerBuffer.Clear();
            UpdateResults();

            lblReady.Text = "Выберите контрагента!";
            lblReady.BackColor = Color.Red;
            panelReady.BackColor = Color.Red;
            imgReady.Image = Properties.Resources.attention;
            ClearSelectionAndDetails();
        }

        private void СохранитьToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            SaveCurrentOrder();
        }

        private bool SaveCurrentOrder()
        {
            try
            {
                var order = _orderService.CurrentOrder ?? throw new InvalidOperationException("Нет активного заказа для сохранения.");

                using var dialog = new SaveFileDialog
                {
                    Filter = "Файлы заказа (*.order.json)|*.order.json|JSON (*.json)|*.json|Все файлы (*.*)|*.*",
                    DefaultExt = "order.json",
                    FileName = GetSuggestedFileName(order)
                };

                if (dialog.ShowDialog() != DialogResult.OK)
                    return false;

                _orderRepository.SaveToFile(order, dialog.FileName);
                MessageBox.Show($"Заказ сохранён: {dialog.FileName}", "Сохранение заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения заказа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
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
                MessageBox.Show($"Загружен заказ: {order.Number}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки заказа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void СоздатьToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (!PromptSaveIfOrderNotEmpty())
                return;

            StartBlankOrder(DateTime.Now);
        }

        private void ВыходToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!PromptSaveIfOrderNotEmpty())
            {
                e.Cancel = true;
            }
        }

        private bool PromptSaveIfOrderNotEmpty()
        {
            if (!OrderHasLines())
                return true;

            var dialogResult = MessageBox.Show(
                "Сохранить текущий заказ?",
                "Сохранение заказа",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            return dialogResult switch
            {
                DialogResult.Yes => SaveCurrentOrder(),
                DialogResult.No => true,
                DialogResult.Cancel => false,
                _ => false
            };
        }

        private bool OrderHasLines()
        {
            return (_orderService.CurrentOrder?.Lines?.Any() ?? false);
        }

        private string GetSuggestedFileName(Order order)
        {
            var customerName = order.Customer?.Name?.Trim() ?? string.Empty;
            var baseName = new string(customerName.Take(10).ToArray());

            if (string.IsNullOrWhiteSpace(baseName))
                baseName = "order";

            var invalidChars = Path.GetInvalidFileNameChars();
            baseName = string.Concat(baseName.Select(ch => invalidChars.Contains(ch) ? '_' : ch));

            return $"{baseName}-{order.Date:dd-MM}.order.json";
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

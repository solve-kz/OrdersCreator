using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    public enum FormSettingsTab
    {
        Behavior,
        Reports,
        Storage
    }

    public partial class FormSettings : Form
    {

        private readonly ISettingsService _settingsService;
        private AppSettings _settings = new AppSettings();
        private readonly Font _tabBoldFont;
        private readonly ContextMenuStrip _fileNameVariablesMenu;
        private bool _isUpdatingConfirmationToggles;

        public FormSettings(ISettingsService settingsService, FormSettingsTab initialTab = FormSettingsTab.Behavior)
        {
            InitializeComponent();
            ButtonCursorHelper.ApplyHandCursor(this);

            using var iconStream = new MemoryStream(Properties.Resources.icon_settings_ico);
            Icon = new Icon(iconStream);

            _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));

            _fileNameVariablesMenu = new ContextMenuStrip();
            components ??= new System.ComponentModel.Container();
            components.Add(_fileNameVariablesMenu);
            InitializeVariablesMenu();

            LoadSettingsToControls();

            InitializeConfirmationToggles();

            // Кэшируем жирный шрифт для выделенной вкладки
            _tabBoldFont = new Font(tabSettings.Font, FontStyle.Bold);

            tabSettings.Alignment = TabAlignment.Left;
            tabSettings.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabSettings.SizeMode = TabSizeMode.Fixed;
            tabSettings.ItemSize = new Size(40, 240);   // у тебя уже задано
            tabSettings.Multiline = true;

            tabSettings.DrawItem += tabSettings_DrawItem;
            tabSettings.SelectedIndexChanged += tabSettings_SelectedIndexChanged;
            btnVar.Click += BtnVar_Click;
            tbReportFileNameMask.KeyDown += TbReportFileNameMask_KeyDown;

            SelectTab(initialTab);
            UpdateTitleWithActiveTab();
        }

        private void LoadSettingsToControls()
        {
            _settings = _settingsService.GetSettings();

            // ---- блок "Отчёты по заказам" ----
            tbReportsRootFolder.Text = ConvertPathSeparatorsForUi(_settings.ReportsRootFolder);
            chbUseDailySubfolder.Checked = _settings.UseDailySubfolder;
            tbReportTemplatePath.Text = ConvertPathSeparatorsForUi(_settings.ReportTemplatePath);
            tbReportFileNameMask.Text = NormalizeReportFileNameMask(_settings.ReportFileNameMask);
            chbOpenReportAfterSave.Checked = _settings.OpenReportAfterSave;
            tbOrdersSaveFolder.Text = ConvertPathSeparatorsForUi(_settings.OrdersSaveFolder);
            chbAutoSaveOrders.Checked = _settings.AutoSaveOrders;
            chbCheckUpdatesOnStartup.Checked = _settings.CheckUpdatesOnStartup;

            // ---- блок поведения ----
            var timeout = _settings.ScannerCharTimeoutMs;
            if (timeout < (int)numScannerCharTimeoutMs.Minimum)
                timeout = (int)numScannerCharTimeoutMs.Minimum;
            if (timeout > (int)numScannerCharTimeoutMs.Maximum)
                timeout = (int)numScannerCharTimeoutMs.Maximum;

            numScannerCharTimeoutMs.Value = timeout;
            chbAllowManualBarcodeInput.Checked = _settings.AllowManualBarcodeInput;
            chbSoundsEnabled.Checked = _settings.SoundsEnabled;

            // cmbUnknownProductMode: 0 – Запросить данные; 1 – Показать ошибку
            var modeIndex = (int)_settings.UnknownProductMode;
            if (modeIndex < 0 || modeIndex >= cmbUnknownProductMode.Items.Count)
                modeIndex = 0;
            cmbUnknownProductMode.SelectedIndex = modeIndex;

            chbConfirmDeleteLastProduct.Checked = _settings.ConfirmDeleteLastProduct;
            chbConfirmDeleteAnyProduct.Checked = _settings.ConfirmDeleteAnyProduct;
            chbConfirmDeleteCategory.Checked = _settings.ConfirmDeleteCategoryFromCatalog;
            chbConfirmDeleteProduct.Checked = _settings.ConfirmDeleteProductFromCatalog;
            chbConfirmDeleteCustomer.Checked = _settings.ConfirmDeleteCustomerFromCatalog;
            chbConfirmCancelNewProduct.Checked = _settings.ConfirmCancelNewProduct;
            chbConfirmCloseIncompleteOrder.Checked = _settings.ConfirmCloseIncompleteOrder;

            // ---- блок хранения данных ----
            // cmbStorageType: 0 – В памяти, 1 – SQLite, 2 – SQLServer
            var storageIndex = (int)_settings.StorageType;
            if (storageIndex < 0 || storageIndex >= cmbStorageType.Items.Count)
                storageIndex = 1; // по умолчанию SQLite
            cmbStorageType.SelectedIndex = storageIndex;

            tbSqlServerConnectionString.Text = _settings.SqlServerConnectionString;

            // обновить видимость поля строки подключения
            cmbStorageType_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void cmbStorageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStorageType.SelectedIndex == 2)
            {
                lblSqlServerConnectionString.Visible = true;
                tbSqlServerConnectionString.Visible = true;
            }
            else
            {
                lblSqlServerConnectionString.Visible = false;
                tbSqlServerConnectionString.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // если по каким-то причинам _settings ещё не загружен
            if (_settings == null)
                _settings = new AppSettings();

            // ---- отчёты ----
            _settings.ReportsRootFolder = ConvertPathSeparatorsFromUi(tbReportsRootFolder.Text);
            _settings.UseDailySubfolder = chbUseDailySubfolder.Checked;
            _settings.ReportTemplatePath = ConvertPathSeparatorsFromUi(tbReportTemplatePath.Text);
            _settings.ReportFileNameMask = NormalizeReportFileNameMask(tbReportFileNameMask.Text);
            _settings.OpenReportAfterSave = chbOpenReportAfterSave.Checked;
            _settings.OrdersSaveFolder = ConvertPathSeparatorsFromUi(tbOrdersSaveFolder.Text);
            _settings.AutoSaveOrders = chbAutoSaveOrders.Checked;
            _settings.CheckUpdatesOnStartup = chbCheckUpdatesOnStartup.Checked;

            // ---- поведение ----
            _settings.ScannerCharTimeoutMs = (int)numScannerCharTimeoutMs.Value;
            _settings.AllowManualBarcodeInput = chbAllowManualBarcodeInput.Checked;
            _settings.SoundsEnabled = chbSoundsEnabled.Checked;

            var modeIndex = cmbUnknownProductMode.SelectedIndex;
            if (modeIndex < 0) modeIndex = 0;
            _settings.UnknownProductMode = (UnknownProductMode)modeIndex;

            _settings.ConfirmDeleteLastProduct = chbConfirmDeleteLastProduct.Checked;
            _settings.ConfirmDeleteAnyProduct = chbConfirmDeleteAnyProduct.Checked;
            _settings.ConfirmDeleteCategoryFromCatalog = chbConfirmDeleteCategory.Checked;
            _settings.ConfirmDeleteProductFromCatalog = chbConfirmDeleteProduct.Checked;
            _settings.ConfirmDeleteCustomerFromCatalog = chbConfirmDeleteCustomer.Checked;
            _settings.ConfirmCancelNewProduct = chbConfirmCancelNewProduct.Checked;
            _settings.ConfirmCloseIncompleteOrder = chbConfirmCloseIncompleteOrder.Checked;

            // ---- хранение ----
            var storageIndex = cmbStorageType.SelectedIndex;
            if (storageIndex < 0) storageIndex = 1; // SQLite по умолчанию
            _settings.StorageType = (StorageType)storageIndex;
            _settings.SqlServerConnectionString = tbSqlServerConnectionString.Text.Trim();

            // сохраняем через сервис
            _settingsService.UpdateSettings(_settings);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnReportsRootFolder_Click(object sender, EventArgs e)
        {
            var selectedPath = ChooseFolder(ConvertPathSeparatorsFromUi(tbReportsRootFolder.Text),
                "Выберите корневую папку для отчётов");

            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                tbReportsRootFolder.Text = ConvertPathSeparatorsForUi(selectedPath);
            }
        }

        private void btnOrdersSaveFolder_Click(object sender, EventArgs e)
        {
            var selectedPath = ChooseFolder(ConvertPathSeparatorsFromUi(tbOrdersSaveFolder.Text),
                "Выберите папку для сохранения заказов");

            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                tbOrdersSaveFolder.Text = ConvertPathSeparatorsForUi(selectedPath);
            }
        }

        private void btnReportTemplatePath_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Filter = "Шаблоны Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";

            var templatePath = ConvertPathSeparatorsFromUi(tbReportTemplatePath.Text);
            if (!string.IsNullOrWhiteSpace(templatePath))
            {
                var directory = Path.GetDirectoryName(templatePath);
                if (!string.IsNullOrWhiteSpace(directory))
                {
                    dialog.InitialDirectory = directory;
                }

                dialog.FileName = Path.GetFileName(templatePath);
            }

            if (string.IsNullOrWhiteSpace(dialog.InitialDirectory))
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                tbReportTemplatePath.Text = ConvertPathSeparatorsForUi(dialog.FileName);
            }
        }

        private static string ConvertPathSeparatorsForUi(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return string.Empty;

            return path.Replace(Path.DirectorySeparatorChar, '>');
        }

        private static string ConvertPathSeparatorsFromUi(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return string.Empty;

            return path.Replace('>', Path.DirectorySeparatorChar).Trim();
        }

        private static string ChooseFolder(string? currentPath, string description)
        {
            using var dialog = new FolderBrowserDialog();
            dialog.Description = description;

            var selectedPath = currentPath;

            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                try
                {
                    if (!Directory.Exists(selectedPath))
                    {
                        Directory.CreateDirectory(selectedPath);
                    }
                }
                catch
                {
                    selectedPath = string.Empty;
                }
            }

            dialog.SelectedPath = !string.IsNullOrWhiteSpace(selectedPath)
                ? selectedPath
                : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }

            return string.Empty;
        }

        private void SelectTab(FormSettingsTab tab)
        {
            switch (tab)
            {
                case FormSettingsTab.Reports:
                    tabSettings.SelectedTab = tabReports;
                    break;
                case FormSettingsTab.Storage:
                    tabSettings.SelectedTab = tabStorage;
                    break;
                default:
                    tabSettings.SelectedTab = tabBehavior;
                    break;
            }
        }

        private void UpdateTitleWithActiveTab()
        {
            var tabTitle = tabSettings.SelectedTab?.Text ?? string.Empty;
            Text = string.IsNullOrWhiteSpace(tabTitle)
                ? "Настройки"
                : $"Настройки: {tabTitle}";
        }

        private void tabSettings_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateTitleWithActiveTab();
        }

        private void tabSettings_DrawItem(object? sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            var tab = tabSettings.TabPages[e.Index];
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Немного уменьшим прямоугольник, чтобы не прилипал к краям
            var bounds = e.Bounds;
            bounds.Inflate(-1, -1);

            // Цвета
            Color backColor = isSelected ? Color.White : Color.FromArgb(245, 245, 245);
            Color textColor = isSelected ? Color.Black : Color.FromArgb(100, 100, 100);
            Color separator = Color.FromArgb(220, 220, 220);
            Color accentColor = Color.FromArgb(0, 120, 215); // «синяя полоска» активной вкладки

            // Фон вкладки
            using (var backBrush = new SolidBrush(backColor))
                g.FillRectangle(backBrush, bounds);

            // Полоса слева для выделенной вкладки
            if (isSelected)
            {
                var accentRect = new Rectangle(bounds.Left, bounds.Top, 4, bounds.Height);
                using (var accentBrush = new SolidBrush(accentColor))
                    g.FillRectangle(accentBrush, accentRect);

                bounds.X += 4;      // чтобы текст не наезжал на полоску
                bounds.Width -= 4;
            }

            // Область текста (немного отступов)
            var textRect = new Rectangle(
                bounds.Left + 10,
                bounds.Top,
                bounds.Width - 16,
                bounds.Height
            );

            using (var textBrush = new SolidBrush(textColor))
            using (var sf = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            })
            {
                var font = isSelected ? _tabBoldFont : tabSettings.Font;
                g.DrawString(tab.Text, font, textBrush, textRect, sf);
            }

            // Вертикальный разделитель между панелью вкладок и содержимым
            using (var pen = new Pen(separator))
            {
                g.DrawLine(pen, bounds.Right, bounds.Top, bounds.Right, bounds.Bottom);

                // Тонкая линия снизу между вкладками
                g.DrawLine(pen, bounds.Left, bounds.Bottom, bounds.Right, bounds.Bottom);
            }

            // ВАЖНО: НЕ рисуем прямоугольную рамку вокруг всей вкладки,
            // поэтому e.Graphics.DrawRectangle(...) убран.
        }

        private void InitializeVariablesMenu()
        {
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{customer}", "Полное наименование контрагента"));
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{customer_short}", "Контрагент (первые 10 символов)"));
            _fileNameVariablesMenu.Items.Add(new ToolStripSeparator());
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{ДД}", "День заказа"));
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{ММ}", "Месяц заказа"));
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{ГГ}", "Год (последние две цифры)"));
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{ГГГГ}", "Год полностью"));
            _fileNameVariablesMenu.Items.Add(new ToolStripSeparator());
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{ЧЧ}", "Часы"));
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{мм}", "Минуты"));
            _fileNameVariablesMenu.Items.Add(CreateVariableMenuItem("{сс}", "Секунды"));
        }

        private ToolStripMenuItem CreateVariableMenuItem(string placeholder, string description)
        {
            var item = new ToolStripMenuItem($"{placeholder} — {description}");
            item.Tag = placeholder;
            item.Click += VariableMenuItem_Click;
            return item;
        }

        private void VariableMenuItem_Click(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is string placeholder)
            {
                InsertPlaceholderIntoMask(placeholder);
            }
        }

        private void BtnVar_Click(object? sender, EventArgs e)
        {
            var buttonLocation = btnVar.PointToScreen(new Point(0, btnVar.Height));
            _fileNameVariablesMenu.Show(buttonLocation);
        }

        private void InsertPlaceholderIntoMask(string placeholder)
        {
            var normalizedPlaceholder = NormalizePlaceholder(placeholder);

            if (string.IsNullOrEmpty(normalizedPlaceholder))
                return;

            var selectionStart = tbReportFileNameMask.SelectionStart;
            var selectionLength = tbReportFileNameMask.SelectionLength;

            var text = tbReportFileNameMask.Text ?? string.Empty;

            if (selectionLength > 0)
            {
                text = text.Remove(selectionStart, selectionLength);
            }

            text = text.Insert(selectionStart, normalizedPlaceholder);
            tbReportFileNameMask.Text = text;
            tbReportFileNameMask.SelectionStart = selectionStart + normalizedPlaceholder.Length;
            tbReportFileNameMask.Focus();
        }

        private void TbReportFileNameMask_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back || tbReportFileNameMask.SelectionLength > 0)
                return;

            var caretPosition = tbReportFileNameMask.SelectionStart;
            var text = tbReportFileNameMask.Text ?? string.Empty;

            if (caretPosition == 0 || caretPosition > text.Length || text[caretPosition - 1] != '}')
                return;

            var openBraceIndex = text.LastIndexOf('{', caretPosition - 1);
            if (openBraceIndex < 0)
                return;

            tbReportFileNameMask.Text = text.Remove(openBraceIndex, caretPosition - openBraceIndex);
            tbReportFileNameMask.SelectionStart = openBraceIndex;
            e.SuppressKeyPress = true;
        }

        private static string NormalizePlaceholder(string placeholder)
        {
            if (string.IsNullOrWhiteSpace(placeholder))
                return string.Empty;

            var normalized = placeholder.Trim();

            if (!normalized.StartsWith('{'))
                normalized = "{" + normalized;

            if (!normalized.EndsWith('}'))
                normalized += "}";

            return normalized;
        }

        private static string NormalizeReportFileNameMask(string? fileNameMask)
        {
            if (string.IsNullOrWhiteSpace(fileNameMask))
                return string.Empty;

            var mask = fileNameMask.Trim();

            if (mask.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                mask = mask.Substring(0, mask.Length - ".xlsx".Length);
            }

            return mask;
        }

        private IEnumerable<CheckBox> GetConfirmationCheckboxes()
        {
            yield return chbConfirmDeleteLastProduct;
            yield return chbConfirmDeleteAnyProduct;
            yield return chbConfirmDeleteCategory;
            yield return chbConfirmDeleteProduct;
            yield return chbConfirmDeleteCustomer;
            yield return chbConfirmCancelNewProduct;
            yield return chbConfirmCloseIncompleteOrder;
        }

        private void InitializeConfirmationToggles()
        {
            chbConfirmToggleAll.CheckedChanged += ChbConfirmToggleAll_CheckedChanged;

            foreach (var checkbox in GetConfirmationCheckboxes())
            {
                checkbox.CheckedChanged += ConfirmationCheckBox_CheckedChanged;
            }

            UpdateConfirmationsToggleState();
        }

        private void ChbConfirmToggleAll_CheckedChanged(object? sender, EventArgs e)
        {
            if (_isUpdatingConfirmationToggles)
                return;

            try
            {
                _isUpdatingConfirmationToggles = true;
                foreach (var checkbox in GetConfirmationCheckboxes())
                {
                    checkbox.Checked = chbConfirmToggleAll.Checked;
                }
            }
            finally
            {
                _isUpdatingConfirmationToggles = false;
            }
        }

        private void ConfirmationCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            if (_isUpdatingConfirmationToggles)
                return;

            try
            {
                _isUpdatingConfirmationToggles = true;
                chbConfirmToggleAll.Checked = GetConfirmationCheckboxes().All(cb => cb.Checked);
            }
            finally
            {
                _isUpdatingConfirmationToggles = false;
            }
        }

        private void UpdateConfirmationsToggleState()
        {
            _isUpdatingConfirmationToggles = true;
            chbConfirmToggleAll.Checked = GetConfirmationCheckboxes().All(cb => cb.Checked);
            _isUpdatingConfirmationToggles = false;
        }
    }
}

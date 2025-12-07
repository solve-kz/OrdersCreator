using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Services;

namespace OrdersCreator.UI
{
    public partial class FormSettings : Form
    {

        private readonly ISettingsService _settingsService;
        private AppSettings _settings = new AppSettings();

        public FormSettings(ISettingsService settingsService)
        {
            InitializeComponent();
            ButtonCursorHelper.ApplyHandCursor(this);

            _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));

            LoadSettingsToControls();
        }

        private void LoadSettingsToControls()
        {
            _settings = _settingsService.GetSettings();

            // ---- блок "Отчёты по заказам" ----
            tbReportsRootFolder.Text = _settings.ReportsRootFolder;
            chbUseDailySubfolder.Checked = _settings.UseDailySubfolder;
            tbReportTemplatePath.Text = _settings.ReportTemplatePath;
            tbReportFileNameMask.Text = _settings.ReportFileNameMask;
            chbOpenReportAfterSave.Checked = _settings.OpenReportAfterSave;

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
            _settings.ReportsRootFolder = tbReportsRootFolder.Text.Trim();
            _settings.UseDailySubfolder = chbUseDailySubfolder.Checked;
            _settings.ReportTemplatePath = tbReportTemplatePath.Text.Trim();
            _settings.ReportFileNameMask = tbReportFileNameMask.Text.Trim();
            _settings.OpenReportAfterSave = chbOpenReportAfterSave.Checked;

            // ---- поведение ----
            _settings.ScannerCharTimeoutMs = (int)numScannerCharTimeoutMs.Value;
            _settings.AllowManualBarcodeInput = chbAllowManualBarcodeInput.Checked;
            _settings.SoundsEnabled = chbSoundsEnabled.Checked;

            var modeIndex = cmbUnknownProductMode.SelectedIndex;
            if (modeIndex < 0) modeIndex = 0;
            _settings.UnknownProductMode = (UnknownProductMode)modeIndex;

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
            using var dialog = new FolderBrowserDialog();
            dialog.Description = "Выберите корневую папку для отчётов";

            var reportsPath = tbReportsRootFolder.Text.Trim();
            if (!string.IsNullOrWhiteSpace(reportsPath))
            {
                try
                {
                    if (!Directory.Exists(reportsPath))
                    {
                        Directory.CreateDirectory(reportsPath);
                    }
                }
                catch
                {
                    // если папку не удалось создать, используем путь по умолчанию
                    reportsPath = string.Empty;
                }
            }

            if (!string.IsNullOrWhiteSpace(reportsPath))
            {
                dialog.SelectedPath = reportsPath;
            }
            else
            {
                dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                tbReportsRootFolder.Text = dialog.SelectedPath;
            }
        }

        private void btnReportTemplatePath_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Filter = "Шаблоны Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";

            var templatePath = tbReportTemplatePath.Text.Trim();
            if (!string.IsNullOrWhiteSpace(templatePath))
            {
                dialog.FileName = templatePath;

                var directory = Path.GetDirectoryName(templatePath);
                if (!string.IsNullOrWhiteSpace(directory))
                {
                    dialog.InitialDirectory = directory;
                }
            }

            if (string.IsNullOrWhiteSpace(dialog.InitialDirectory))
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                tbReportTemplatePath.Text = dialog.FileName;
            }
        }
    }
}

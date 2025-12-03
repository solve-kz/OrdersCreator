using System.Drawing;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chbUseDailySubfolder = new CheckBox();
            tbReportTemplatePath = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            tbReportsRootFolder = new TextBox();
            btnReportsRootFolder = new Button();
            tbReportFileNameMask = new TextBox();
            btnReportTemplatePath = new Button();
            chbOpenReportAfterSave = new CheckBox();
            numScannerCharTimeoutMs = new NumericUpDown();
            chbAllowManualBarcodeInput = new CheckBox();
            chbSoundsEnabled = new CheckBox();
            cmbUnknownProductMode = new ComboBox();
            cmbStorageType = new ComboBox();
            tbSqlServerConnectionString = new TextBox();
            tabSettings = new TabControl();
            tabReports = new TabPage();
            tlpReports = new TableLayoutPanel();
            labelReportsRoot = new Label();
            labelTemplatePath = new Label();
            labelFileNameMask = new Label();
            tabBehavior = new TabPage();
            tlpBehavior = new TableLayoutPanel();
            labelScannerTimeout = new Label();
            labelUnknownProduct = new Label();
            tabStorage = new TabPage();
            tlpStorage = new TableLayoutPanel();
            labelStorageType = new Label();
            lblSqlServerConnectionString = new Label();
            panelBottomButtons = new Panel();
            flpButtons = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numScannerCharTimeoutMs).BeginInit();
            tabSettings.SuspendLayout();
            tabReports.SuspendLayout();
            tlpReports.SuspendLayout();
            tabBehavior.SuspendLayout();
            tlpBehavior.SuspendLayout();
            tabStorage.SuspendLayout();
            tlpStorage.SuspendLayout();
            panelBottomButtons.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // chbUseDailySubfolder
            // 
            chbUseDailySubfolder.AutoSize = true;
            chbUseDailySubfolder.Location = new Point(223, 41);
            chbUseDailySubfolder.Margin = new Padding(0, 4, 4, 4);
            chbUseDailySubfolder.Name = "chbUseDailySubfolder";
            chbUseDailySubfolder.Size = new Size(233, 25);
            chbUseDailySubfolder.TabIndex = 4;
            chbUseDailySubfolder.Text = "Создавать подпапку с датой";
            chbUseDailySubfolder.UseVisualStyleBackColor = true;
            // 
            // tbReportTemplatePath
            // 
            tbReportTemplatePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbReportTemplatePath.BorderStyle = BorderStyle.FixedSingle;
            tbReportTemplatePath.Location = new Point(227, 74);
            tbReportTemplatePath.Margin = new Padding(4);
            tbReportTemplatePath.Name = "tbReportTemplatePath";
            tbReportTemplatePath.Size = new Size(531, 29);
            tbReportTemplatePath.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.ForestGreen;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(164, 0);
            btnOK.Margin = new Padding(10, 0, 0, 0);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(144, 34);
            btnOK.TabIndex = 8;
            btnOK.Text = "СОХРАНИТЬ";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(0, 0);
            btnCancel.Margin = new Padding(0, 0, 10, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "ОТМЕНА";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbReportsRootFolder
            // 
            tbReportsRootFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbReportsRootFolder.BorderStyle = BorderStyle.FixedSingle;
            tbReportsRootFolder.Location = new Point(227, 4);
            tbReportsRootFolder.Margin = new Padding(4);
            tbReportsRootFolder.Name = "tbReportsRootFolder";
            tbReportsRootFolder.Size = new Size(531, 29);
            tbReportsRootFolder.TabIndex = 2;
            // 
            // btnReportsRootFolder
            // 
            btnReportsRootFolder.BackColor = Color.RoyalBlue;
            btnReportsRootFolder.FlatAppearance.BorderSize = 0;
            btnReportsRootFolder.FlatStyle = FlatStyle.Flat;
            btnReportsRootFolder.ForeColor = Color.White;
            btnReportsRootFolder.Location = new Point(766, 4);
            btnReportsRootFolder.Margin = new Padding(4);
            btnReportsRootFolder.Name = "btnReportsRootFolder";
            btnReportsRootFolder.Size = new Size(102, 29);
            btnReportsRootFolder.TabIndex = 11;
            btnReportsRootFolder.Text = "ВЫБРАТЬ";
            btnReportsRootFolder.UseVisualStyleBackColor = false;
            btnReportsRootFolder.Click += btnReportsRootFolder_Click;
            // 
            // tbReportFileNameMask
            // 
            tbReportFileNameMask.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbReportFileNameMask.BorderStyle = BorderStyle.FixedSingle;
            tbReportFileNameMask.Location = new Point(227, 111);
            tbReportFileNameMask.Margin = new Padding(4);
            tbReportFileNameMask.Name = "tbReportFileNameMask";
            tbReportFileNameMask.Size = new Size(531, 29);
            tbReportFileNameMask.TabIndex = 14;
            // 
            // btnReportTemplatePath
            // 
            btnReportTemplatePath.BackColor = Color.RoyalBlue;
            btnReportTemplatePath.FlatAppearance.BorderSize = 0;
            btnReportTemplatePath.FlatStyle = FlatStyle.Flat;
            btnReportTemplatePath.ForeColor = Color.White;
            btnReportTemplatePath.Location = new Point(766, 74);
            btnReportTemplatePath.Margin = new Padding(4);
            btnReportTemplatePath.Name = "btnReportTemplatePath";
            btnReportTemplatePath.Size = new Size(102, 29);
            btnReportTemplatePath.TabIndex = 15;
            btnReportTemplatePath.Text = "ВЫБРАТЬ";
            btnReportTemplatePath.UseVisualStyleBackColor = false;
            btnReportTemplatePath.Click += btnReportTemplatePath_Click;
            // 
            // chbOpenReportAfterSave
            // 
            chbOpenReportAfterSave.AutoSize = true;
            chbOpenReportAfterSave.Location = new Point(227, 148);
            chbOpenReportAfterSave.Margin = new Padding(4);
            chbOpenReportAfterSave.Name = "chbOpenReportAfterSave";
            chbOpenReportAfterSave.Size = new Size(283, 25);
            chbOpenReportAfterSave.TabIndex = 16;
            chbOpenReportAfterSave.Text = "Открывать отчет после сохранения";
            chbOpenReportAfterSave.UseVisualStyleBackColor = true;
            // 
            // numScannerCharTimeoutMs
            // 
            numScannerCharTimeoutMs.Location = new Point(310, 3);
            numScannerCharTimeoutMs.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numScannerCharTimeoutMs.Name = "numScannerCharTimeoutMs";
            numScannerCharTimeoutMs.Size = new Size(120, 29);
            numScannerCharTimeoutMs.TabIndex = 19;
            // 
            // chbAllowManualBarcodeInput
            // 
            chbAllowManualBarcodeInput.AutoSize = true;
            chbAllowManualBarcodeInput.Location = new Point(311, 39);
            chbAllowManualBarcodeInput.Margin = new Padding(4);
            chbAllowManualBarcodeInput.Name = "chbAllowManualBarcodeInput";
            chbAllowManualBarcodeInput.Size = new Size(202, 25);
            chbAllowManualBarcodeInput.TabIndex = 20;
            chbAllowManualBarcodeInput.Text = "Разрешить ручной ввод";
            chbAllowManualBarcodeInput.UseVisualStyleBackColor = true;
            // 
            // chbSoundsEnabled
            // 
            chbSoundsEnabled.AutoSize = true;
            chbSoundsEnabled.Location = new Point(311, 72);
            chbSoundsEnabled.Margin = new Padding(4);
            chbSoundsEnabled.Name = "chbSoundsEnabled";
            chbSoundsEnabled.Size = new Size(144, 25);
            chbSoundsEnabled.TabIndex = 21;
            chbSoundsEnabled.Text = "Включить звуки";
            chbSoundsEnabled.UseVisualStyleBackColor = true;
            // 
            // cmbUnknownProductMode
            // 
            cmbUnknownProductMode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbUnknownProductMode.FormattingEnabled = true;
            cmbUnknownProductMode.Items.AddRange(new object[] { "Запросить данные", "Показать ошибку" });
            cmbUnknownProductMode.Location = new Point(310, 190);
            cmbUnknownProductMode.Name = "cmbUnknownProductMode";
            cmbUnknownProductMode.Size = new Size(559, 29);
            cmbUnknownProductMode.TabIndex = 23;
            // 
            // cmbStorageType
            // 
            cmbStorageType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbStorageType.FormattingEnabled = true;
            cmbStorageType.Items.AddRange(new object[] { "В памяти", "SQLite", "SQLServer" });
            cmbStorageType.Location = new Point(177, 4);
            cmbStorageType.Margin = new Padding(4);
            cmbStorageType.Name = "cmbStorageType";
            cmbStorageType.Size = new Size(691, 29);
            cmbStorageType.TabIndex = 27;
            cmbStorageType.SelectedIndexChanged += cmbStorageType_SelectedIndexChanged;
            // 
            // tbSqlServerConnectionString
            // 
            tbSqlServerConnectionString.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSqlServerConnectionString.BorderStyle = BorderStyle.FixedSingle;
            tbSqlServerConnectionString.Location = new Point(177, 41);
            tbSqlServerConnectionString.Margin = new Padding(4);
            tbSqlServerConnectionString.Name = "tbSqlServerConnectionString";
            tbSqlServerConnectionString.Size = new Size(691, 29);
            tbSqlServerConnectionString.TabIndex = 28;
            tbSqlServerConnectionString.Visible = false;
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(tabReports);
            tabSettings.Controls.Add(tabBehavior);
            tabSettings.Controls.Add(tabStorage);
            tabSettings.Dock = DockStyle.Fill;
            tabSettings.Location = new Point(0, 0);
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new Size(900, 351);
            tabSettings.TabIndex = 29;
            // 
            // tabReports
            // 
            tabReports.Controls.Add(tlpReports);
            tabReports.Location = new Point(4, 30);
            tabReports.Name = "tabReports";
            tabReports.Padding = new Padding(10);
            tabReports.Size = new Size(892, 317);
            tabReports.TabIndex = 0;
            tabReports.Text = "Отчёты";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // tlpReports
            // 
            tlpReports.AutoSize = true;
            tlpReports.ColumnCount = 3;
            tlpReports.ColumnStyles.Add(new ColumnStyle());
            tlpReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpReports.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpReports.Controls.Add(labelReportsRoot, 0, 0);
            tlpReports.Controls.Add(tbReportsRootFolder, 1, 0);
            tlpReports.Controls.Add(btnReportsRootFolder, 2, 0);
            tlpReports.Controls.Add(chbUseDailySubfolder, 1, 1);
            tlpReports.Controls.Add(labelTemplatePath, 0, 2);
            tlpReports.Controls.Add(tbReportTemplatePath, 1, 2);
            tlpReports.Controls.Add(btnReportTemplatePath, 2, 2);
            tlpReports.Controls.Add(labelFileNameMask, 0, 3);
            tlpReports.Controls.Add(tbReportFileNameMask, 1, 3);
            tlpReports.Controls.Add(chbOpenReportAfterSave, 1, 4);
            tlpReports.Dock = DockStyle.Fill;
            tlpReports.Location = new Point(10, 10);
            tlpReports.Name = "tlpReports";
            tlpReports.RowCount = 5;
            tlpReports.RowStyles.Add(new RowStyle());
            tlpReports.RowStyles.Add(new RowStyle());
            tlpReports.RowStyles.Add(new RowStyle());
            tlpReports.RowStyles.Add(new RowStyle());
            tlpReports.RowStyles.Add(new RowStyle());
            tlpReports.Size = new Size(872, 297);
            tlpReports.TabIndex = 0;
            // 
            // labelReportsRoot
            // 
            labelReportsRoot.Anchor = AnchorStyles.Left;
            labelReportsRoot.AutoSize = true;
            labelReportsRoot.Location = new Point(3, 8);
            labelReportsRoot.Margin = new Padding(3);
            labelReportsRoot.Name = "labelReportsRoot";
            labelReportsRoot.Size = new Size(217, 21);
            labelReportsRoot.TabIndex = 30;
            labelReportsRoot.Text = "Корневая папка для отчётов:";
            // 
            // labelTemplatePath
            // 
            labelTemplatePath.Anchor = AnchorStyles.Left;
            labelTemplatePath.AutoSize = true;
            labelTemplatePath.Location = new Point(3, 78);
            labelTemplatePath.Margin = new Padding(3);
            labelTemplatePath.Name = "labelTemplatePath";
            labelTemplatePath.Size = new Size(161, 21);
            labelTemplatePath.TabIndex = 13;
            labelTemplatePath.Text = "Путь к .xlsx-шаблону:";
            // 
            // labelFileNameMask
            // 
            labelFileNameMask.Anchor = AnchorStyles.Left;
            labelFileNameMask.AutoSize = true;
            labelFileNameMask.Location = new Point(3, 115);
            labelFileNameMask.Margin = new Padding(3);
            labelFileNameMask.Name = "labelFileNameMask";
            labelFileNameMask.Size = new Size(156, 21);
            labelFileNameMask.TabIndex = 12;
            labelFileNameMask.Text = "Маска имени файла:";
            // 
            // tabBehavior
            // 
            tabBehavior.Controls.Add(tlpBehavior);
            tabBehavior.Location = new Point(4, 24);
            tabBehavior.Name = "tabBehavior";
            tabBehavior.Padding = new Padding(10);
            tabBehavior.Size = new Size(892, 323);
            tabBehavior.TabIndex = 1;
            tabBehavior.Text = "Поведение";
            tabBehavior.UseVisualStyleBackColor = true;
            // 
            // tlpBehavior
            // 
            tlpBehavior.AutoSize = true;
            tlpBehavior.ColumnCount = 2;
            tlpBehavior.ColumnStyles.Add(new ColumnStyle());
            tlpBehavior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBehavior.Controls.Add(labelScannerTimeout, 0, 0);
            tlpBehavior.Controls.Add(numScannerCharTimeoutMs, 1, 0);
            tlpBehavior.Controls.Add(chbAllowManualBarcodeInput, 1, 1);
            tlpBehavior.Controls.Add(chbSoundsEnabled, 1, 2);
            tlpBehavior.Controls.Add(labelUnknownProduct, 0, 3);
            tlpBehavior.Controls.Add(cmbUnknownProductMode, 1, 3);
            tlpBehavior.Dock = DockStyle.Fill;
            tlpBehavior.Location = new Point(10, 10);
            tlpBehavior.Name = "tlpBehavior";
            tlpBehavior.RowCount = 4;
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.Size = new Size(872, 303);
            tlpBehavior.TabIndex = 0;
            // 
            // labelScannerTimeout
            // 
            labelScannerTimeout.Anchor = AnchorStyles.Left;
            labelScannerTimeout.AutoSize = true;
            labelScannerTimeout.Location = new Point(3, 7);
            labelScannerTimeout.Margin = new Padding(3);
            labelScannerTimeout.Name = "labelScannerTimeout";
            labelScannerTimeout.Size = new Size(301, 21);
            labelScannerTimeout.TabIndex = 18;
            labelScannerTimeout.Text = "Таймаут между символами сканера (мс):";
            labelScannerTimeout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUnknownProduct
            // 
            labelUnknownProduct.Anchor = AnchorStyles.Left;
            labelUnknownProduct.AutoSize = true;
            labelUnknownProduct.Location = new Point(3, 191);
            labelUnknownProduct.Margin = new Padding(3);
            labelUnknownProduct.Name = "labelUnknownProduct";
            labelUnknownProduct.Size = new Size(260, 21);
            labelUnknownProduct.TabIndex = 22;
            labelUnknownProduct.Text = "Действие при неизвестном товаре:";
            labelUnknownProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabStorage
            // 
            tabStorage.Controls.Add(tlpStorage);
            tabStorage.Location = new Point(4, 24);
            tabStorage.Name = "tabStorage";
            tabStorage.Padding = new Padding(10);
            tabStorage.Size = new Size(892, 323);
            tabStorage.TabIndex = 2;
            tabStorage.Text = "Хранение данных";
            tabStorage.UseVisualStyleBackColor = true;
            // 
            // tlpStorage
            // 
            tlpStorage.AutoSize = true;
            tlpStorage.ColumnCount = 2;
            tlpStorage.ColumnStyles.Add(new ColumnStyle());
            tlpStorage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpStorage.Controls.Add(labelStorageType, 0, 0);
            tlpStorage.Controls.Add(cmbStorageType, 1, 0);
            tlpStorage.Controls.Add(lblSqlServerConnectionString, 0, 1);
            tlpStorage.Controls.Add(tbSqlServerConnectionString, 1, 1);
            tlpStorage.Dock = DockStyle.Top;
            tlpStorage.Location = new Point(10, 10);
            tlpStorage.Name = "tlpStorage";
            tlpStorage.RowCount = 2;
            tlpStorage.RowStyles.Add(new RowStyle());
            tlpStorage.RowStyles.Add(new RowStyle());
            tlpStorage.Size = new Size(872, 74);
            tlpStorage.TabIndex = 0;
            // 
            // labelStorageType
            // 
            labelStorageType.Anchor = AnchorStyles.Left;
            labelStorageType.AutoSize = true;
            labelStorageType.Location = new Point(3, 8);
            labelStorageType.Margin = new Padding(3);
            labelStorageType.Name = "labelStorageType";
            labelStorageType.Size = new Size(123, 21);
            labelStorageType.TabIndex = 25;
            labelStorageType.Text = "Тип хранилища:";
            labelStorageType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSqlServerConnectionString
            // 
            lblSqlServerConnectionString.Anchor = AnchorStyles.Left;
            lblSqlServerConnectionString.AutoSize = true;
            lblSqlServerConnectionString.Location = new Point(3, 45);
            lblSqlServerConnectionString.Margin = new Padding(3);
            lblSqlServerConnectionString.Name = "lblSqlServerConnectionString";
            lblSqlServerConnectionString.Size = new Size(167, 21);
            lblSqlServerConnectionString.TabIndex = 26;
            lblSqlServerConnectionString.Text = "Строка подключения:";
            lblSqlServerConnectionString.TextAlign = ContentAlignment.MiddleCenter;
            lblSqlServerConnectionString.Visible = false;
            // 
            // panelBottomButtons
            // 
            panelBottomButtons.Controls.Add(flpButtons);
            panelBottomButtons.Dock = DockStyle.Bottom;
            panelBottomButtons.Location = new Point(0, 351);
            panelBottomButtons.Name = "panelBottomButtons";
            panelBottomButtons.Padding = new Padding(10);
            panelBottomButtons.Size = new Size(900, 60);
            panelBottomButtons.TabIndex = 30;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Controls.Add(btnOK);
            flpButtons.Dock = DockStyle.Right;
            flpButtons.Location = new Point(592, 10);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(298, 40);
            flpButtons.TabIndex = 0;
            flpButtons.WrapContents = false;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 411);
            Controls.Add(tabSettings);
            Controls.Add(panelBottomButtons);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)numScannerCharTimeoutMs).EndInit();
            tabSettings.ResumeLayout(false);
            tabReports.ResumeLayout(false);
            tabReports.PerformLayout();
            tlpReports.ResumeLayout(false);
            tlpReports.PerformLayout();
            tabBehavior.ResumeLayout(false);
            tabBehavior.PerformLayout();
            tlpBehavior.ResumeLayout(false);
            tlpBehavior.PerformLayout();
            tabStorage.ResumeLayout(false);
            tabStorage.PerformLayout();
            tlpStorage.ResumeLayout(false);
            tlpStorage.PerformLayout();
            panelBottomButtons.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CheckBox chbUseDailySubfolder;
        private TextBox tbReportTemplatePath;
        private Button btnOK;
        private Button btnCancel;
        private TextBox tbReportsRootFolder;
        private Button btnReportsRootFolder;
        private TextBox tbReportFileNameMask;
        private Button btnReportTemplatePath;
        private CheckBox chbOpenReportAfterSave;
        private NumericUpDown numScannerCharTimeoutMs;
        private CheckBox chbAllowManualBarcodeInput;
        private CheckBox chbSoundsEnabled;
        private ComboBox cmbUnknownProductMode;
        private ComboBox cmbStorageType;
        private TextBox tbSqlServerConnectionString;
        private TabControl tabSettings;
        private TabPage tabReports;
        private TabPage tabBehavior;
        private TabPage tabStorage;
        private TableLayoutPanel tlpReports;
        private Label labelReportsRoot;
        private Label labelTemplatePath;
        private Label labelFileNameMask;
        private TableLayoutPanel tlpBehavior;
        private Label labelScannerTimeout;
        private Label labelUnknownProduct;
        private TableLayoutPanel tlpStorage;
        private Label labelStorageType;
        private Label lblSqlServerConnectionString;
        private Panel panelBottomButtons;
        private FlowLayoutPanel flpButtons;
    }
}

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
            labelOrdersSaveFolder = new Label();
            tbOrdersSaveFolder = new TextBox();
            tbReportTemplatePath = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            tbReportsRootFolder = new TextBox();
            btnReportsRootFolder = new Button();
            tbReportFileNameMask = new TextBox();
            btnReportTemplatePath = new Button();
            chbOpenReportAfterSave = new CheckBox();
            btnOrdersSaveFolder = new Button();
            chbAutoSaveOrders = new CheckBox();
            numScannerCharTimeoutMs = new NumericUpDown();
            chbAllowManualBarcodeInput = new CheckBox();
            chbSoundsEnabled = new CheckBox();
            chbCheckUpdatesOnStartup = new CheckBox();
            cmbUnknownProductMode = new ComboBox();
            cmbStorageType = new ComboBox();
            tbSqlServerConnectionString = new TextBox();
            tabSettings = new TabControl();
            tabBehavior = new TabPage();
            tlpBehavior = new TableLayoutPanel();
            labelScannerTimeout = new Label();
            labelUnknownProduct = new Label();
            groupConfirmations = new GroupBox();
            tlpConfirmations = new TableLayoutPanel();
            chbConfirmToggleAll = new CheckBox();
            chbConfirmDeleteLastProduct = new CheckBox();
            chbConfirmDeleteAnyProduct = new CheckBox();
            chbConfirmDeleteCategory = new CheckBox();
            chbConfirmDeleteProduct = new CheckBox();
            chbConfirmDeleteCustomer = new CheckBox();
            chbConfirmCancelNewProduct = new CheckBox();
            chbConfirmCloseIncompleteOrder = new CheckBox();
            tabReports = new TabPage();
            tlpReports = new TableLayoutPanel();
            labelReportsRoot = new Label();
            labelTemplatePath = new Label();
            labelFileNameMask = new Label();
            btnVar = new Button();
            tabStorage = new TabPage();
            tlpStorage = new TableLayoutPanel();
            labelStorageType = new Label();
            lblSqlServerConnectionString = new Label();
            panelBottomButtons = new Panel();
            flpButtons = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numScannerCharTimeoutMs).BeginInit();
            tabSettings.SuspendLayout();
            tabBehavior.SuspendLayout();
            tlpBehavior.SuspendLayout();
            groupConfirmations.SuspendLayout();
            tlpConfirmations.SuspendLayout();
            tabReports.SuspendLayout();
            tlpReports.SuspendLayout();
            tabStorage.SuspendLayout();
            tlpStorage.SuspendLayout();
            panelBottomButtons.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // chbUseDailySubfolder
            // 
            chbUseDailySubfolder.AutoSize = true;
            chbUseDailySubfolder.Location = new Point(186, 139);
            chbUseDailySubfolder.Margin = new Padding(0, 4, 4, 4);
            chbUseDailySubfolder.Name = "chbUseDailySubfolder";
            chbUseDailySubfolder.Size = new Size(233, 25);
            chbUseDailySubfolder.TabIndex = 4;
            chbUseDailySubfolder.Text = "Создавать подпапку с датой";
            chbUseDailySubfolder.UseVisualStyleBackColor = true;
            // 
            // labelOrdersSaveFolder
            // 
            labelOrdersSaveFolder.Anchor = AnchorStyles.Left;
            labelOrdersSaveFolder.AutoSize = true;
            labelOrdersSaveFolder.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204, true);
            labelOrdersSaveFolder.Location = new Point(3, 13);
            labelOrdersSaveFolder.Margin = new Padding(3);
            labelOrdersSaveFolder.Name = "labelOrdersSaveFolder";
            labelOrdersSaveFolder.Size = new Size(180, 19);
            labelOrdersSaveFolder.TabIndex = 32;
            labelOrdersSaveFolder.Text = "Папка сохранения заказов:";
            // 
            // tbOrdersSaveFolder
            // 
            tbOrdersSaveFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbOrdersSaveFolder.BorderStyle = BorderStyle.FixedSingle;
            tbOrdersSaveFolder.Location = new Point(189, 8);
            tbOrdersSaveFolder.Margin = new Padding(3, 3, 4, 3);
            tbOrdersSaveFolder.Name = "tbOrdersSaveFolder";
            tbOrdersSaveFolder.Size = new Size(593, 29);
            tbOrdersSaveFolder.TabIndex = 33;
            // 
            // tbReportTemplatePath
            // 
            tbReportTemplatePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbReportTemplatePath.BorderStyle = BorderStyle.FixedSingle;
            tbReportTemplatePath.Location = new Point(190, 188);
            tbReportTemplatePath.Margin = new Padding(4);
            tbReportTemplatePath.Name = "tbReportTemplatePath";
            tbReportTemplatePath.Size = new Size(592, 29);
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
            tbReportsRootFolder.Location = new Point(190, 98);
            tbReportsRootFolder.Margin = new Padding(4);
            tbReportsRootFolder.Name = "tbReportsRootFolder";
            tbReportsRootFolder.Size = new Size(592, 29);
            tbReportsRootFolder.TabIndex = 2;
            // 
            // btnReportsRootFolder
            // 
            btnReportsRootFolder.BackColor = Color.RoyalBlue;
            btnReportsRootFolder.FlatAppearance.BorderSize = 0;
            btnReportsRootFolder.FlatStyle = FlatStyle.Flat;
            btnReportsRootFolder.ForeColor = Color.White;
            btnReportsRootFolder.Image = Properties.Resources.icon_open;
            btnReportsRootFolder.Location = new Point(790, 94);
            btnReportsRootFolder.Margin = new Padding(4);
            btnReportsRootFolder.Name = "btnReportsRootFolder";
            btnReportsRootFolder.Size = new Size(30, 30);
            btnReportsRootFolder.TabIndex = 11;
            btnReportsRootFolder.UseVisualStyleBackColor = false;
            btnReportsRootFolder.Click += btnReportsRootFolder_Click;
            // 
            // tbReportFileNameMask
            // 
            tbReportFileNameMask.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbReportFileNameMask.BorderStyle = BorderStyle.FixedSingle;
            tbReportFileNameMask.Location = new Point(190, 233);
            tbReportFileNameMask.Margin = new Padding(4);
            tbReportFileNameMask.Name = "tbReportFileNameMask";
            tbReportFileNameMask.Size = new Size(592, 29);
            tbReportFileNameMask.TabIndex = 14;
            // 
            // btnReportTemplatePath
            // 
            btnReportTemplatePath.BackColor = Color.RoyalBlue;
            btnReportTemplatePath.FlatAppearance.BorderSize = 0;
            btnReportTemplatePath.FlatStyle = FlatStyle.Flat;
            btnReportTemplatePath.ForeColor = Color.White;
            btnReportTemplatePath.Image = Properties.Resources.icon_open;
            btnReportTemplatePath.Location = new Point(790, 184);
            btnReportTemplatePath.Margin = new Padding(4);
            btnReportTemplatePath.Name = "btnReportTemplatePath";
            btnReportTemplatePath.Size = new Size(30, 30);
            btnReportTemplatePath.TabIndex = 15;
            btnReportTemplatePath.UseVisualStyleBackColor = false;
            btnReportTemplatePath.Click += btnReportTemplatePath_Click;
            // 
            // chbOpenReportAfterSave
            // 
            chbOpenReportAfterSave.AutoSize = true;
            chbOpenReportAfterSave.Location = new Point(190, 274);
            chbOpenReportAfterSave.Margin = new Padding(4);
            chbOpenReportAfterSave.Name = "chbOpenReportAfterSave";
            chbOpenReportAfterSave.Size = new Size(283, 25);
            chbOpenReportAfterSave.TabIndex = 16;
            chbOpenReportAfterSave.Text = "Открывать отчет после сохранения";
            chbOpenReportAfterSave.UseVisualStyleBackColor = true;
            // 
            // btnOrdersSaveFolder
            // 
            btnOrdersSaveFolder.BackColor = Color.RoyalBlue;
            btnOrdersSaveFolder.FlatAppearance.BorderSize = 0;
            btnOrdersSaveFolder.FlatStyle = FlatStyle.Flat;
            btnOrdersSaveFolder.ForeColor = Color.White;
            btnOrdersSaveFolder.Image = Properties.Resources.icon_open;
            btnOrdersSaveFolder.Location = new Point(789, 3);
            btnOrdersSaveFolder.Margin = new Padding(3, 3, 4, 3);
            btnOrdersSaveFolder.Name = "btnOrdersSaveFolder";
            btnOrdersSaveFolder.Size = new Size(30, 30);
            btnOrdersSaveFolder.TabIndex = 34;
            btnOrdersSaveFolder.UseVisualStyleBackColor = false;
            btnOrdersSaveFolder.Click += btnOrdersSaveFolder_Click;
            // 
            // chbAutoSaveOrders
            // 
            chbAutoSaveOrders.AutoSize = true;
            chbAutoSaveOrders.Location = new Point(189, 49);
            chbAutoSaveOrders.Margin = new Padding(3, 4, 4, 4);
            chbAutoSaveOrders.Name = "chbAutoSaveOrders";
            chbAutoSaveOrders.Size = new Size(219, 25);
            chbAutoSaveOrders.TabIndex = 35;
            chbAutoSaveOrders.Text = "Включить автосохранение";
            chbAutoSaveOrders.UseVisualStyleBackColor = true;
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
            // chbCheckUpdatesOnStartup
            // 
            chbCheckUpdatesOnStartup.AutoSize = true;
            chbCheckUpdatesOnStartup.Location = new Point(311, 105);
            chbCheckUpdatesOnStartup.Margin = new Padding(4);
            chbCheckUpdatesOnStartup.Name = "chbCheckUpdatesOnStartup";
            chbCheckUpdatesOnStartup.Size = new Size(277, 25);
            chbCheckUpdatesOnStartup.TabIndex = 25;
            chbCheckUpdatesOnStartup.Text = "Проверять обновления при старте";
            chbCheckUpdatesOnStartup.UseVisualStyleBackColor = true;
            // 
            // cmbUnknownProductMode
            // 
            cmbUnknownProductMode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbUnknownProductMode.FormattingEnabled = true;
            cmbUnknownProductMode.Items.AddRange(new object[] { "Запросить данные", "Показать ошибку" });
            cmbUnknownProductMode.Location = new Point(310, 137);
            cmbUnknownProductMode.Name = "cmbUnknownProductMode";
            cmbUnknownProductMode.Size = new Size(553, 29);
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
            cmbStorageType.Size = new Size(685, 29);
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
            tbSqlServerConnectionString.Size = new Size(685, 29);
            tbSqlServerConnectionString.TabIndex = 28;
            tbSqlServerConnectionString.Visible = false;
            // 
            // tabSettings
            // 
            tabSettings.Alignment = TabAlignment.Left;
            tabSettings.Controls.Add(tabBehavior);
            tabSettings.Controls.Add(tabReports);
            tabSettings.Controls.Add(tabStorage);
            tabSettings.Dock = DockStyle.Fill;
            tabSettings.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204, true);
            tabSettings.ItemSize = new Size(40, 180);
            tabSettings.Location = new Point(5, 5);
            tabSettings.Multiline = true;
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new Size(1074, 400);
            tabSettings.SizeMode = TabSizeMode.Fixed;
            tabSettings.TabIndex = 29;
            tabSettings.DrawItem += tabSettings_DrawItem;
            // 
            // tabBehavior
            // 
            tabBehavior.Controls.Add(tlpBehavior);
            tabBehavior.Location = new Point(184, 4);
            tabBehavior.Name = "tabBehavior";
            tabBehavior.Padding = new Padding(10);
            tabBehavior.Size = new Size(886, 392);
            tabBehavior.TabIndex = 1;
            tabBehavior.Text = "Общие";
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
            tlpBehavior.Controls.Add(chbCheckUpdatesOnStartup, 1, 3);
            tlpBehavior.Controls.Add(labelUnknownProduct, 0, 4);
            tlpBehavior.Controls.Add(cmbUnknownProductMode, 1, 4);
            tlpBehavior.Controls.Add(groupConfirmations, 0, 5);
            tlpBehavior.Dock = DockStyle.Fill;
            tlpBehavior.Location = new Point(10, 10);
            tlpBehavior.Name = "tlpBehavior";
            tlpBehavior.RowCount = 6;
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.RowStyles.Add(new RowStyle());
            tlpBehavior.Size = new Size(866, 372);
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
            labelUnknownProduct.Location = new Point(3, 138);
            labelUnknownProduct.Margin = new Padding(3);
            labelUnknownProduct.Name = "labelUnknownProduct";
            labelUnknownProduct.Size = new Size(260, 21);
            labelUnknownProduct.TabIndex = 22;
            labelUnknownProduct.Text = "Действие при неизвестном товаре:";
            labelUnknownProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupConfirmations
            // 
            groupConfirmations.AutoSize = true;
            tlpBehavior.SetColumnSpan(groupConfirmations, 2);
            groupConfirmations.Controls.Add(tlpConfirmations);
            groupConfirmations.Dock = DockStyle.Top;
            groupConfirmations.Location = new Point(3, 175);
            groupConfirmations.Margin = new Padding(3, 12, 3, 3);
            groupConfirmations.Name = "groupConfirmations";
            groupConfirmations.Padding = new Padding(10, 8, 10, 8);
            groupConfirmations.Size = new Size(860, 193);
            groupConfirmations.TabIndex = 24;
            groupConfirmations.TabStop = false;
            groupConfirmations.Text = "Запрашивать подтверждение:";
            // 
            // tlpConfirmations
            // 
            tlpConfirmations.AutoSize = true;
            tlpConfirmations.ColumnCount = 2;
            tlpConfirmations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpConfirmations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpConfirmations.Controls.Add(chbConfirmToggleAll, 0, 0);
            tlpConfirmations.Controls.Add(chbConfirmDeleteLastProduct, 0, 1);
            tlpConfirmations.Controls.Add(chbConfirmDeleteAnyProduct, 1, 1);
            tlpConfirmations.Controls.Add(chbConfirmDeleteCategory, 0, 2);
            tlpConfirmations.Controls.Add(chbConfirmDeleteProduct, 1, 2);
            tlpConfirmations.Controls.Add(chbConfirmDeleteCustomer, 0, 3);
            tlpConfirmations.Controls.Add(chbConfirmCancelNewProduct, 1, 3);
            tlpConfirmations.Controls.Add(chbConfirmCloseIncompleteOrder, 0, 4);
            tlpConfirmations.Dock = DockStyle.Fill;
            tlpConfirmations.Location = new Point(10, 30);
            tlpConfirmations.Name = "tlpConfirmations";
            tlpConfirmations.RowCount = 5;
            tlpConfirmations.RowStyles.Add(new RowStyle());
            tlpConfirmations.RowStyles.Add(new RowStyle());
            tlpConfirmations.RowStyles.Add(new RowStyle());
            tlpConfirmations.RowStyles.Add(new RowStyle());
            tlpConfirmations.RowStyles.Add(new RowStyle());
            tlpConfirmations.Size = new Size(840, 155);
            tlpConfirmations.TabIndex = 0;
            // 
            // chbConfirmToggleAll
            // 
            chbConfirmToggleAll.AutoSize = true;
            tlpConfirmations.SetColumnSpan(chbConfirmToggleAll, 2);
            chbConfirmToggleAll.Location = new Point(3, 3);
            chbConfirmToggleAll.Name = "chbConfirmToggleAll";
            chbConfirmToggleAll.Size = new Size(213, 25);
            chbConfirmToggleAll.TabIndex = 7;
            chbConfirmToggleAll.Text = "включить/выключить все";
            chbConfirmToggleAll.UseVisualStyleBackColor = true;
            // 
            // chbConfirmDeleteLastProduct
            // 
            chbConfirmDeleteLastProduct.AutoSize = true;
            chbConfirmDeleteLastProduct.Location = new Point(3, 34);
            chbConfirmDeleteLastProduct.Name = "chbConfirmDeleteLastProduct";
            chbConfirmDeleteLastProduct.Size = new Size(267, 25);
            chbConfirmDeleteLastProduct.TabIndex = 0;
            chbConfirmDeleteLastProduct.Text = "при удалении последнего товара";
            chbConfirmDeleteLastProduct.UseVisualStyleBackColor = true;
            // 
            // chbConfirmDeleteAnyProduct
            // 
            chbConfirmDeleteAnyProduct.AutoSize = true;
            chbConfirmDeleteAnyProduct.Location = new Point(423, 34);
            chbConfirmDeleteAnyProduct.Name = "chbConfirmDeleteAnyProduct";
            chbConfirmDeleteAnyProduct.Size = new Size(294, 25);
            chbConfirmDeleteAnyProduct.TabIndex = 1;
            chbConfirmDeleteAnyProduct.Text = "при удалении произвольного товара";
            chbConfirmDeleteAnyProduct.UseVisualStyleBackColor = true;
            // 
            // chbConfirmDeleteCategory
            // 
            chbConfirmDeleteCategory.AutoSize = true;
            chbConfirmDeleteCategory.Location = new Point(3, 65);
            chbConfirmDeleteCategory.Name = "chbConfirmDeleteCategory";
            chbConfirmDeleteCategory.Size = new Size(322, 25);
            chbConfirmDeleteCategory.TabIndex = 2;
            chbConfirmDeleteCategory.Text = "при удалении категории из справочника";
            chbConfirmDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // chbConfirmDeleteProduct
            // 
            chbConfirmDeleteProduct.AutoSize = true;
            chbConfirmDeleteProduct.Location = new Point(423, 65);
            chbConfirmDeleteProduct.Name = "chbConfirmDeleteProduct";
            chbConfirmDeleteProduct.Size = new Size(298, 25);
            chbConfirmDeleteProduct.TabIndex = 3;
            chbConfirmDeleteProduct.Text = "при удалении товара из справочника";
            chbConfirmDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // chbConfirmDeleteCustomer
            // 
            chbConfirmDeleteCustomer.AutoSize = true;
            chbConfirmDeleteCustomer.Location = new Point(3, 96);
            chbConfirmDeleteCustomer.Name = "chbConfirmDeleteCustomer";
            chbConfirmDeleteCustomer.Size = new Size(337, 25);
            chbConfirmDeleteCustomer.TabIndex = 4;
            chbConfirmDeleteCustomer.Text = "при удалении контрагента из справочника";
            chbConfirmDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // chbConfirmCancelNewProduct
            // 
            chbConfirmCancelNewProduct.AutoSize = true;
            chbConfirmCancelNewProduct.Location = new Point(423, 96);
            chbConfirmCancelNewProduct.Name = "chbConfirmCancelNewProduct";
            chbConfirmCancelNewProduct.Size = new Size(308, 25);
            chbConfirmCancelNewProduct.TabIndex = 5;
            chbConfirmCancelNewProduct.Text = "при отмене добавления нового товара";
            chbConfirmCancelNewProduct.UseVisualStyleBackColor = true;
            // 
            // chbConfirmCloseIncompleteOrder
            // 
            chbConfirmCloseIncompleteOrder.AutoSize = true;
            tlpConfirmations.SetColumnSpan(chbConfirmCloseIncompleteOrder, 2);
            chbConfirmCloseIncompleteOrder.Location = new Point(3, 127);
            chbConfirmCloseIncompleteOrder.Name = "chbConfirmCloseIncompleteOrder";
            chbConfirmCloseIncompleteOrder.Size = new Size(302, 25);
            chbConfirmCloseIncompleteOrder.TabIndex = 6;
            chbConfirmCloseIncompleteOrder.Text = "при закрытии незавершенного заказа";
            chbConfirmCloseIncompleteOrder.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            tabReports.Controls.Add(tlpReports);
            tabReports.Location = new Point(184, 4);
            tabReports.Name = "tabReports";
            tabReports.Padding = new Padding(10);
            tabReports.Size = new Size(886, 392);
            tabReports.TabIndex = 0;
            tabReports.Text = "Пути и шаблоны";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // tlpReports
            // 
            tlpReports.AutoSize = true;
            tlpReports.ColumnCount = 3;
            tlpReports.ColumnStyles.Add(new ColumnStyle());
            tlpReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpReports.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpReports.Controls.Add(labelOrdersSaveFolder, 0, 0);
            tlpReports.Controls.Add(tbOrdersSaveFolder, 1, 0);
            tlpReports.Controls.Add(btnOrdersSaveFolder, 2, 0);
            tlpReports.Controls.Add(chbAutoSaveOrders, 1, 1);
            tlpReports.Controls.Add(labelReportsRoot, 0, 2);
            tlpReports.Controls.Add(tbReportsRootFolder, 1, 2);
            tlpReports.Controls.Add(btnReportsRootFolder, 2, 2);
            tlpReports.Controls.Add(chbUseDailySubfolder, 1, 3);
            tlpReports.Controls.Add(labelTemplatePath, 0, 4);
            tlpReports.Controls.Add(tbReportTemplatePath, 1, 4);
            tlpReports.Controls.Add(btnReportTemplatePath, 2, 4);
            tlpReports.Controls.Add(labelFileNameMask, 0, 5);
            tlpReports.Controls.Add(tbReportFileNameMask, 1, 5);
            tlpReports.Controls.Add(chbOpenReportAfterSave, 1, 6);
            tlpReports.Controls.Add(btnVar, 2, 5);
            tlpReports.Dock = DockStyle.Fill;
            tlpReports.Location = new Point(10, 10);
            tlpReports.Name = "tlpReports";
            tlpReports.RowCount = 7;
            tlpReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpReports.Size = new Size(866, 372);
            tlpReports.TabIndex = 0;
            // 
            // labelReportsRoot
            // 
            labelReportsRoot.Anchor = AnchorStyles.Left;
            labelReportsRoot.AutoSize = true;
            labelReportsRoot.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204, true);
            labelReportsRoot.Location = new Point(3, 103);
            labelReportsRoot.Margin = new Padding(3);
            labelReportsRoot.Name = "labelReportsRoot";
            labelReportsRoot.Size = new Size(131, 19);
            labelReportsRoot.TabIndex = 30;
            labelReportsRoot.Text = "Папка для отчётов:";
            // 
            // labelTemplatePath
            // 
            labelTemplatePath.Anchor = AnchorStyles.Left;
            labelTemplatePath.AutoSize = true;
            labelTemplatePath.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204, true);
            labelTemplatePath.Location = new Point(3, 193);
            labelTemplatePath.Margin = new Padding(3);
            labelTemplatePath.Name = "labelTemplatePath";
            labelTemplatePath.Size = new Size(143, 19);
            labelTemplatePath.TabIndex = 13;
            labelTemplatePath.Text = "Путь к .xlsx-шаблону:";
            // 
            // labelFileNameMask
            // 
            labelFileNameMask.Anchor = AnchorStyles.Left;
            labelFileNameMask.AutoSize = true;
            labelFileNameMask.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204, true);
            labelFileNameMask.Location = new Point(3, 238);
            labelFileNameMask.Margin = new Padding(3);
            labelFileNameMask.Name = "labelFileNameMask";
            labelFileNameMask.Size = new Size(140, 19);
            labelFileNameMask.TabIndex = 12;
            labelFileNameMask.Text = "Маска имени файла:";
            // 
            // btnVar
            // 
            btnVar.BackColor = Color.RoyalBlue;
            btnVar.FlatAppearance.BorderSize = 0;
            btnVar.FlatStyle = FlatStyle.Flat;
            btnVar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204, true);
            btnVar.ForeColor = Color.White;
            btnVar.Location = new Point(790, 229);
            btnVar.Margin = new Padding(4);
            btnVar.Name = "btnVar";
            btnVar.Size = new Size(70, 29);
            btnVar.TabIndex = 31;
            btnVar.Text = "+VAR";
            btnVar.UseVisualStyleBackColor = false;
            // 
            // tabStorage
            // 
            tabStorage.Controls.Add(tlpStorage);
            tabStorage.Location = new Point(184, 4);
            tabStorage.Name = "tabStorage";
            tabStorage.Padding = new Padding(10);
            tabStorage.Size = new Size(886, 392);
            tabStorage.TabIndex = 2;
            tabStorage.Text = "База данных";
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
            tlpStorage.Size = new Size(866, 74);
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
            panelBottomButtons.Location = new Point(5, 405);
            panelBottomButtons.Name = "panelBottomButtons";
            panelBottomButtons.Padding = new Padding(10);
            panelBottomButtons.Size = new Size(1074, 60);
            panelBottomButtons.TabIndex = 30;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Controls.Add(btnOK);
            flpButtons.Dock = DockStyle.Right;
            flpButtons.Location = new Point(766, 10);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(298, 40);
            flpButtons.TabIndex = 0;
            flpButtons.WrapContents = false;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 470);
            Controls.Add(tabSettings);
            Controls.Add(panelBottomButtons);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettings";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)numScannerCharTimeoutMs).EndInit();
            tabSettings.ResumeLayout(false);
            tabBehavior.ResumeLayout(false);
            tabBehavior.PerformLayout();
            tlpBehavior.ResumeLayout(false);
            tlpBehavior.PerformLayout();
            groupConfirmations.ResumeLayout(false);
            groupConfirmations.PerformLayout();
            tlpConfirmations.ResumeLayout(false);
            tlpConfirmations.PerformLayout();
            tabReports.ResumeLayout(false);
            tabReports.PerformLayout();
            tlpReports.ResumeLayout(false);
            tlpReports.PerformLayout();
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
        private Label labelOrdersSaveFolder;
        private TableLayoutPanel tlpBehavior;
        private Label labelScannerTimeout;
        private Label labelUnknownProduct;
        private GroupBox groupConfirmations;
        private TableLayoutPanel tlpConfirmations;
        private CheckBox chbConfirmToggleAll;
        private CheckBox chbConfirmDeleteLastProduct;
        private CheckBox chbConfirmDeleteAnyProduct;
        private CheckBox chbConfirmDeleteCategory;
        private CheckBox chbConfirmDeleteProduct;
        private CheckBox chbConfirmDeleteCustomer;
        private CheckBox chbConfirmCancelNewProduct;
        private CheckBox chbConfirmCloseIncompleteOrder;
        private TableLayoutPanel tlpStorage;
        private Label labelStorageType;
        private Label lblSqlServerConnectionString;
        private Panel panelBottomButtons;
        private FlowLayoutPanel flpButtons;
        private Button btnVar;
        private TextBox tbOrdersSaveFolder;
        private Button btnOrdersSaveFolder;
        private CheckBox chbAutoSaveOrders;
        private CheckBox chbCheckUpdatesOnStartup;
    }
}

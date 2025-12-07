namespace OrdersCreator.UI
{
    partial class FormRefEdit
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabCategory = new TabPage();
            tlpCategories = new TableLayoutPanel();
            panelTopCategories = new Panel();
            panelGridCategories = new Panel();
            dataGridViewCategories = new DataGridView();
            RowNumber = new DataGridViewTextBoxColumn();
            CategoryTitle = new DataGridViewTextBoxColumn();
            panelEditCategories = new Panel();
            tlpCategoriesEdit = new TableLayoutPanel();
            labelCategoryName = new Label();
            textBoxCategoryName = new TextBox();
            panelButtonsCategories = new Panel();
            flowLayoutPanelCategoriesButtons = new FlowLayoutPanel();
            btnCategoryAdd = new Button();
            btnCategorySave = new Button();
            btnCategoryDel = new Button();
            btnCategoryCancel = new Button();
            tabProducts = new TabPage();
            tlpBarcodes = new TableLayoutPanel();
            panelTopBarcodes = new Panel();
            tlpBarcodesTop = new TableLayoutPanel();
            lblFilterCategory = new Label();
            comboBoxCategoryFilter = new ComboBox();
            flowLayoutPanelFilterActions = new FlowLayoutPanel();
            btnApplyFilter = new Button();
            btnResetFilter = new Button();
            lblSearch = new Label();
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            panelGridBarcodes = new Panel();
            dataGridViewProducts = new DataGridView();
            ProductNumber = new DataGridViewTextBoxColumn();
            ProductCategory = new DataGridViewTextBoxColumn();
            ProductTitle = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            panelEditBarcodes = new Panel();
            tlpBarcodesEditContainer = new TableLayoutPanel();
            tlpBarcodeName = new TableLayoutPanel();
            label4 = new Label();
            textBoxBarcodeName = new TextBox();
            tlpBarcodesEdit = new TableLayoutPanel();
            label3 = new Label();
            textBoxBarcodeCode = new TextBox();
            label5 = new Label();
            comboBoxBarcodeCategory = new ComboBox();
            panelButtonsBarcodes = new Panel();
            tlpBarcodesButtons = new TableLayoutPanel();
            flowLayoutPanelImport = new FlowLayoutPanel();
            btnProductsImport = new Button();
            btnProductsExport = new Button();
            flowLayoutPanelCrud = new FlowLayoutPanel();
            btnProductAdd = new Button();
            btnProductSave = new Button();
            btnProductDel = new Button();
            btnProductCancel = new Button();
            tabCustomers = new TabPage();
            tlpCustomers = new TableLayoutPanel();
            panelTopCustomers = new Panel();
            tlpCustomersTop = new TableLayoutPanel();
            lblCustomerSearch = new Label();
            textBoxSearchCustomer = new TextBox();
            btnSearchCustomer = new Button();
            panelGridCustomers = new Panel();
            dataGridViewCustomers = new DataGridView();
            CustomerNumber = new DataGridViewTextBoxColumn();
            CustomerTitle = new DataGridViewTextBoxColumn();
            panelEditCustomers = new Panel();
            tlpCustomersEdit = new TableLayoutPanel();
            label6 = new Label();
            textBoxCustomerName = new TextBox();
            panelButtonsCustomers = new Panel();
            tlpCustomersButtons = new TableLayoutPanel();
            flowLayoutPanelCustomersImport = new FlowLayoutPanel();
            btnCustomersImport = new Button();
            btnCustomersExport = new Button();
            flowLayoutPanelCustomersButtons = new FlowLayoutPanel();
            btnCustomerAdd = new Button();
            btnCustomerSave = new Button();
            btnCustomerDel = new Button();
            btnCustomerCancel = new Button();
            tabControl1.SuspendLayout();
            tabCategory.SuspendLayout();
            tlpCategories.SuspendLayout();
            panelGridCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            panelEditCategories.SuspendLayout();
            tlpCategoriesEdit.SuspendLayout();
            panelButtonsCategories.SuspendLayout();
            flowLayoutPanelCategoriesButtons.SuspendLayout();
            tabProducts.SuspendLayout();
            tlpBarcodes.SuspendLayout();
            panelTopBarcodes.SuspendLayout();
            tlpBarcodesTop.SuspendLayout();
            flowLayoutPanelFilterActions.SuspendLayout();
            panelGridBarcodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panelEditBarcodes.SuspendLayout();
            tlpBarcodesEditContainer.SuspendLayout();
            tlpBarcodeName.SuspendLayout();
            tlpBarcodesEdit.SuspendLayout();
            panelButtonsBarcodes.SuspendLayout();
            tlpBarcodesButtons.SuspendLayout();
            flowLayoutPanelImport.SuspendLayout();
            flowLayoutPanelCrud.SuspendLayout();
            tabCustomers.SuspendLayout();
            tlpCustomers.SuspendLayout();
            panelTopCustomers.SuspendLayout();
            tlpCustomersTop.SuspendLayout();
            panelGridCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            panelEditCustomers.SuspendLayout();
            tlpCustomersEdit.SuspendLayout();
            panelButtonsCustomers.SuspendLayout();
            tlpCustomersButtons.SuspendLayout();
            flowLayoutPanelCustomersImport.SuspendLayout();
            flowLayoutPanelCustomersButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategory);
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabCustomers);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.ItemSize = new Size(300, 40);
            tabControl1.Location = new Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(974, 751);
            tabControl1.TabIndex = 1;
            // 
            // tabCategory
            // 
            tabCategory.Controls.Add(tlpCategories);
            tabCategory.Location = new Point(4, 44);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3);
            tabCategory.Size = new Size(966, 703);
            tabCategory.TabIndex = 0;
            tabCategory.Text = "Категории товаров";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // tlpCategories
            // 
            tlpCategories.ColumnCount = 1;
            tlpCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCategories.Controls.Add(panelTopCategories, 0, 0);
            tlpCategories.Controls.Add(panelGridCategories, 0, 1);
            tlpCategories.Controls.Add(panelEditCategories, 0, 2);
            tlpCategories.Controls.Add(panelButtonsCategories, 0, 3);
            tlpCategories.Dock = DockStyle.Fill;
            tlpCategories.Location = new Point(3, 3);
            tlpCategories.Name = "tlpCategories";
            tlpCategories.RowCount = 4;
            tlpCategories.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCategories.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpCategories.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpCategories.Size = new Size(960, 697);
            tlpCategories.TabIndex = 0;
            // 
            // panelTopCategories
            // 
            panelTopCategories.Dock = DockStyle.Fill;
            panelTopCategories.Location = new Point(3, 3);
            panelTopCategories.Name = "panelTopCategories";
            panelTopCategories.Size = new Size(954, 14);
            panelTopCategories.TabIndex = 0;
            panelTopCategories.Visible = false;
            // 
            // panelGridCategories
            // 
            panelGridCategories.Controls.Add(dataGridViewCategories);
            panelGridCategories.Dock = DockStyle.Fill;
            panelGridCategories.Location = new Point(3, 23);
            panelGridCategories.Name = "panelGridCategories";
            panelGridCategories.Size = new Size(954, 531);
            panelGridCategories.TabIndex = 1;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToResizeRows = false;
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { RowNumber, CategoryTitle });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCategories.Dock = DockStyle.Fill;
            dataGridViewCategories.Location = new Point(0, 0);
            dataGridViewCategories.MultiSelect = false;
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.RowHeadersVisible = false;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(954, 531);
            dataGridViewCategories.TabIndex = 1;
            // 
            // RowNumber
            // 
            RowNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowNumber.HeaderText = "№";
            RowNumber.Name = "RowNumber";
            RowNumber.ReadOnly = true;
            RowNumber.Width = 53;
            // 
            // CategoryTitle
            // 
            CategoryTitle.HeaderText = "Наименование категории";
            CategoryTitle.Name = "CategoryTitle";
            CategoryTitle.ReadOnly = true;
            // 
            // panelEditCategories
            // 
            panelEditCategories.BackColor = Color.Gainsboro;
            panelEditCategories.Controls.Add(tlpCategoriesEdit);
            panelEditCategories.Dock = DockStyle.Fill;
            panelEditCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelEditCategories.Location = new Point(3, 560);
            panelEditCategories.Name = "panelEditCategories";
            panelEditCategories.Padding = new Padding(10);
            panelEditCategories.Size = new Size(954, 64);
            panelEditCategories.TabIndex = 2;
            // 
            // tlpCategoriesEdit
            // 
            tlpCategoriesEdit.ColumnCount = 2;
            tlpCategoriesEdit.ColumnStyles.Add(new ColumnStyle());
            tlpCategoriesEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCategoriesEdit.Controls.Add(labelCategoryName, 0, 0);
            tlpCategoriesEdit.Controls.Add(textBoxCategoryName, 1, 0);
            tlpCategoriesEdit.Dock = DockStyle.Fill;
            tlpCategoriesEdit.Location = new Point(10, 10);
            tlpCategoriesEdit.Name = "tlpCategoriesEdit";
            tlpCategoriesEdit.RowCount = 1;
            tlpCategoriesEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCategoriesEdit.Size = new Size(934, 44);
            tlpCategoriesEdit.TabIndex = 0;
            // 
            // labelCategoryName
            // 
            labelCategoryName.Anchor = AnchorStyles.Left;
            labelCategoryName.AutoSize = true;
            labelCategoryName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCategoryName.Location = new Point(3, 12);
            labelCategoryName.Name = "labelCategoryName";
            labelCategoryName.Size = new Size(107, 19);
            labelCategoryName.TabIndex = 0;
            labelCategoryName.Text = "Наименование:";
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCategoryName.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategoryName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCategoryName.Location = new Point(116, 9);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.Size = new Size(815, 25);
            textBoxCategoryName.TabIndex = 1;
            // 
            // panelButtonsCategories
            // 
            panelButtonsCategories.BackColor = Color.LightGray;
            panelButtonsCategories.Controls.Add(flowLayoutPanelCategoriesButtons);
            panelButtonsCategories.Dock = DockStyle.Fill;
            panelButtonsCategories.Location = new Point(3, 630);
            panelButtonsCategories.Name = "panelButtonsCategories";
            panelButtonsCategories.Padding = new Padding(10);
            panelButtonsCategories.Size = new Size(954, 64);
            panelButtonsCategories.TabIndex = 3;
            // 
            // flowLayoutPanelCategoriesButtons
            // 
            flowLayoutPanelCategoriesButtons.Controls.Add(btnCategoryAdd);
            flowLayoutPanelCategoriesButtons.Controls.Add(btnCategorySave);
            flowLayoutPanelCategoriesButtons.Controls.Add(btnCategoryDel);
            flowLayoutPanelCategoriesButtons.Controls.Add(btnCategoryCancel);
            flowLayoutPanelCategoriesButtons.Dock = DockStyle.Bottom;
            flowLayoutPanelCategoriesButtons.Location = new Point(10, 14);
            flowLayoutPanelCategoriesButtons.Name = "flowLayoutPanelCategoriesButtons";
            flowLayoutPanelCategoriesButtons.Size = new Size(934, 40);
            flowLayoutPanelCategoriesButtons.TabIndex = 0;
            flowLayoutPanelCategoriesButtons.WrapContents = false;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.BackColor = Color.ForestGreen;
            btnCategoryAdd.FlatAppearance.BorderSize = 0;
            btnCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnCategoryAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCategoryAdd.ForeColor = Color.White;
            btnCategoryAdd.Location = new Point(3, 3);
            btnCategoryAdd.Margin = new Padding(3, 3, 10, 3);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(120, 40);
            btnCategoryAdd.TabIndex = 0;
            btnCategoryAdd.Text = "ДОБАВИТЬ";
            btnCategoryAdd.UseVisualStyleBackColor = false;
            // 
            // btnCategorySave
            // 
            btnCategorySave.BackColor = Color.DodgerBlue;
            btnCategorySave.FlatAppearance.BorderSize = 0;
            btnCategorySave.FlatStyle = FlatStyle.Flat;
            btnCategorySave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCategorySave.ForeColor = Color.White;
            btnCategorySave.Location = new Point(136, 3);
            btnCategorySave.Margin = new Padding(3, 3, 10, 3);
            btnCategorySave.Name = "btnCategorySave";
            btnCategorySave.Size = new Size(120, 40);
            btnCategorySave.TabIndex = 1;
            btnCategorySave.Text = "СОХРАНИТЬ";
            btnCategorySave.UseVisualStyleBackColor = false;
            // 
            // btnCategoryDel
            // 
            btnCategoryDel.BackColor = Color.Red;
            btnCategoryDel.FlatAppearance.BorderSize = 0;
            btnCategoryDel.FlatStyle = FlatStyle.Flat;
            btnCategoryDel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCategoryDel.ForeColor = Color.White;
            btnCategoryDel.Location = new Point(269, 3);
            btnCategoryDel.Margin = new Padding(3, 3, 10, 3);
            btnCategoryDel.Name = "btnCategoryDel";
            btnCategoryDel.Size = new Size(120, 40);
            btnCategoryDel.TabIndex = 2;
            btnCategoryDel.Text = "УДАЛИТЬ";
            btnCategoryDel.UseVisualStyleBackColor = false;
            // 
            // btnCategoryCancel
            // 
            btnCategoryCancel.BackColor = Color.Gray;
            btnCategoryCancel.FlatAppearance.BorderSize = 0;
            btnCategoryCancel.FlatStyle = FlatStyle.Flat;
            btnCategoryCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCategoryCancel.ForeColor = Color.White;
            btnCategoryCancel.Location = new Point(402, 3);
            btnCategoryCancel.Margin = new Padding(3, 3, 10, 3);
            btnCategoryCancel.Name = "btnCategoryCancel";
            btnCategoryCancel.Size = new Size(120, 40);
            btnCategoryCancel.TabIndex = 3;
            btnCategoryCancel.Text = "ОТМЕНА";
            btnCategoryCancel.UseVisualStyleBackColor = false;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(tlpBarcodes);
            tabProducts.Location = new Point(4, 44);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(970, 705);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Штрих-коды товаров";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // tlpBarcodes
            // 
            tlpBarcodes.ColumnCount = 1;
            tlpBarcodes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBarcodes.Controls.Add(panelTopBarcodes, 0, 0);
            tlpBarcodes.Controls.Add(panelGridBarcodes, 0, 1);
            tlpBarcodes.Controls.Add(panelEditBarcodes, 0, 2);
            tlpBarcodes.Controls.Add(panelButtonsBarcodes, 0, 3);
            tlpBarcodes.Dock = DockStyle.Fill;
            tlpBarcodes.Location = new Point(3, 3);
            tlpBarcodes.Name = "tlpBarcodes";
            tlpBarcodes.RowCount = 4;
            tlpBarcodes.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpBarcodes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBarcodes.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpBarcodes.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpBarcodes.Size = new Size(964, 699);
            tlpBarcodes.TabIndex = 0;
            // 
            // panelTopBarcodes
            // 
            panelTopBarcodes.Controls.Add(tlpBarcodesTop);
            panelTopBarcodes.Dock = DockStyle.Fill;
            panelTopBarcodes.Location = new Point(3, 3);
            panelTopBarcodes.Name = "panelTopBarcodes";
            panelTopBarcodes.Padding = new Padding(10, 10, 10, 0);
            panelTopBarcodes.Size = new Size(958, 54);
            panelTopBarcodes.TabIndex = 0;
            // 
            // tlpBarcodesTop
            // 
            tlpBarcodesTop.ColumnCount = 6;
            tlpBarcodesTop.ColumnStyles.Add(new ColumnStyle());
            tlpBarcodesTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tlpBarcodesTop.ColumnStyles.Add(new ColumnStyle());
            tlpBarcodesTop.ColumnStyles.Add(new ColumnStyle());
            tlpBarcodesTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBarcodesTop.ColumnStyles.Add(new ColumnStyle());
            tlpBarcodesTop.Controls.Add(lblFilterCategory, 0, 0);
            tlpBarcodesTop.Controls.Add(comboBoxCategoryFilter, 1, 0);
            tlpBarcodesTop.Controls.Add(flowLayoutPanelFilterActions, 2, 0);
            tlpBarcodesTop.Controls.Add(lblSearch, 3, 0);
            tlpBarcodesTop.Controls.Add(textBoxSearch, 4, 0);
            tlpBarcodesTop.Controls.Add(btnSearch, 5, 0);
            tlpBarcodesTop.Dock = DockStyle.Fill;
            tlpBarcodesTop.Location = new Point(10, 10);
            tlpBarcodesTop.Name = "tlpBarcodesTop";
            tlpBarcodesTop.RowCount = 1;
            tlpBarcodesTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBarcodesTop.Size = new Size(938, 44);
            tlpBarcodesTop.TabIndex = 0;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.Anchor = AnchorStyles.Left;
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFilterCategory.Location = new Point(3, 12);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(146, 19);
            lblFilterCategory.TabIndex = 0;
            lblFilterCategory.Text = "Фильтр по категории:";
            // 
            // comboBoxCategoryFilter
            // 
            comboBoxCategoryFilter.Anchor = AnchorStyles.Left;
            comboBoxCategoryFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxCategoryFilter.FormattingEnabled = true;
            comboBoxCategoryFilter.Location = new Point(155, 8);
            comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            comboBoxCategoryFilter.Size = new Size(174, 25);
            comboBoxCategoryFilter.TabIndex = 1;
            // 
            // flowLayoutPanelFilterActions
            // 
            flowLayoutPanelFilterActions.Anchor = AnchorStyles.Left;
            flowLayoutPanelFilterActions.AutoSize = true;
            flowLayoutPanelFilterActions.Controls.Add(btnApplyFilter);
            flowLayoutPanelFilterActions.Controls.Add(btnResetFilter);
            flowLayoutPanelFilterActions.Location = new Point(335, 3);
            flowLayoutPanelFilterActions.Name = "flowLayoutPanelFilterActions";
            flowLayoutPanelFilterActions.Size = new Size(239, 38);
            flowLayoutPanelFilterActions.TabIndex = 5;
            flowLayoutPanelFilterActions.WrapContents = false;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = Color.DodgerBlue;
            btnApplyFilter.FlatAppearance.BorderSize = 0;
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnApplyFilter.ForeColor = Color.White;
            btnApplyFilter.Location = new Point(3, 3);
            btnApplyFilter.Margin = new Padding(3, 3, 10, 3);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(150, 32);
            btnApplyFilter.TabIndex = 0;
            btnApplyFilter.Text = "ПРИМЕНИТЬ";
            btnApplyFilter.UseVisualStyleBackColor = false;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.Gray;
            btnResetFilter.FlatAppearance.BorderSize = 0;
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnResetFilter.ForeColor = Color.White;
            btnResetFilter.Location = new Point(166, 3);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(70, 32);
            btnResetFilter.TabIndex = 1;
            btnResetFilter.Text = "СБРОС";
            btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSearch.Location = new Point(580, 12);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(51, 19);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Поиск:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch.Location = new Point(637, 9);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(212, 25);
            textBoxSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Enabled = false;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(855, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "НАЙТИ";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panelGridBarcodes
            // 
            panelGridBarcodes.Controls.Add(dataGridViewProducts);
            panelGridBarcodes.Dock = DockStyle.Fill;
            panelGridBarcodes.Location = new Point(3, 63);
            panelGridBarcodes.Name = "panelGridBarcodes";
            panelGridBarcodes.Size = new Size(958, 463);
            panelGridBarcodes.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { ProductNumber, ProductCategory, ProductTitle, ProductCode });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(0, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(958, 463);
            dataGridViewProducts.TabIndex = 2;
            // 
            // ProductNumber
            // 
            ProductNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductNumber.HeaderText = "№";
            ProductNumber.Name = "ProductNumber";
            ProductNumber.ReadOnly = true;
            ProductNumber.Width = 53;
            // 
            // ProductCategory
            // 
            ProductCategory.FillWeight = 80F;
            ProductCategory.HeaderText = "Категория";
            ProductCategory.Name = "ProductCategory";
            ProductCategory.ReadOnly = true;
            // 
            // ProductTitle
            // 
            ProductTitle.FillWeight = 300F;
            ProductTitle.HeaderText = "Наименование товара";
            ProductTitle.Name = "ProductTitle";
            ProductTitle.ReadOnly = true;
            // 
            // ProductCode
            // 
            ProductCode.FillWeight = 80F;
            ProductCode.HeaderText = "Код товара";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            // 
            // panelEditBarcodes
            // 
            panelEditBarcodes.BackColor = Color.Gainsboro;
            panelEditBarcodes.Controls.Add(tlpBarcodesEditContainer);
            panelEditBarcodes.Dock = DockStyle.Fill;
            panelEditBarcodes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelEditBarcodes.Location = new Point(3, 532);
            panelEditBarcodes.Name = "panelEditBarcodes";
            panelEditBarcodes.Padding = new Padding(10);
            panelEditBarcodes.Size = new Size(958, 94);
            panelEditBarcodes.TabIndex = 2;
            // 
            // tlpBarcodesEditContainer
            // 
            tlpBarcodesEditContainer.ColumnCount = 1;
            tlpBarcodesEditContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBarcodesEditContainer.Controls.Add(tlpBarcodeName, 0, 0);
            tlpBarcodesEditContainer.Controls.Add(tlpBarcodesEdit, 0, 1);
            tlpBarcodesEditContainer.Dock = DockStyle.Fill;
            tlpBarcodesEditContainer.Location = new Point(10, 10);
            tlpBarcodesEditContainer.Name = "tlpBarcodesEditContainer";
            tlpBarcodesEditContainer.RowCount = 2;
            tlpBarcodesEditContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpBarcodesEditContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpBarcodesEditContainer.Size = new Size(938, 74);
            tlpBarcodesEditContainer.TabIndex = 0;
            // 
            // tlpBarcodeName
            // 
            tlpBarcodeName.ColumnCount = 2;
            tlpBarcodeName.ColumnStyles.Add(new ColumnStyle());
            tlpBarcodeName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBarcodeName.Controls.Add(label4, 0, 0);
            tlpBarcodeName.Controls.Add(textBoxBarcodeName, 1, 0);
            tlpBarcodeName.Dock = DockStyle.Fill;
            tlpBarcodeName.Location = new Point(3, 3);
            tlpBarcodeName.Name = "tlpBarcodeName";
            tlpBarcodeName.RowCount = 1;
            tlpBarcodeName.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpBarcodeName.Size = new Size(932, 30);
            tlpBarcodeName.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(107, 19);
            label4.TabIndex = 0;
            label4.Text = "Наименование:";
            // 
            // textBoxBarcodeName
            // 
            textBoxBarcodeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxBarcodeName.BorderStyle = BorderStyle.FixedSingle;
            textBoxBarcodeName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBarcodeName.Location = new Point(116, 5);
            textBoxBarcodeName.Margin = new Padding(3, 3, 10, 3);
            textBoxBarcodeName.Name = "textBoxBarcodeName";
            textBoxBarcodeName.Size = new Size(806, 25);
            textBoxBarcodeName.TabIndex = 1;
            // 
            // tlpBarcodesEdit
            // 
            tlpBarcodesEdit.ColumnCount = 4;
            tlpBarcodesEdit.ColumnStyles.Add(new ColumnStyle());
            tlpBarcodesEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpBarcodesEdit.ColumnStyles.Add(new ColumnStyle());
            tlpBarcodesEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpBarcodesEdit.Controls.Add(label3, 0, 0);
            tlpBarcodesEdit.Controls.Add(textBoxBarcodeCode, 1, 0);
            tlpBarcodesEdit.Controls.Add(label5, 2, 0);
            tlpBarcodesEdit.Controls.Add(comboBoxBarcodeCategory, 3, 0);
            tlpBarcodesEdit.Dock = DockStyle.Fill;
            tlpBarcodesEdit.Location = new Point(3, 39);
            tlpBarcodesEdit.Name = "tlpBarcodesEdit";
            tlpBarcodesEdit.RowCount = 1;
            tlpBarcodesEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpBarcodesEdit.Size = new Size(932, 32);
            tlpBarcodesEdit.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 0;
            label3.Text = "Код товара:";
            // 
            // textBoxBarcodeCode
            // 
            textBoxBarcodeCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxBarcodeCode.BorderStyle = BorderStyle.FixedSingle;
            textBoxBarcodeCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBarcodeCode.Location = new Point(92, 5);
            textBoxBarcodeCode.Margin = new Padding(3, 3, 10, 3);
            textBoxBarcodeCode.Name = "textBoxBarcodeCode";
            textBoxBarcodeCode.Size = new Size(367, 25);
            textBoxBarcodeCode.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(472, 8);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 2;
            label5.Text = "Категория:";
            // 
            // comboBoxBarcodeCategory
            // 
            comboBoxBarcodeCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxBarcodeCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxBarcodeCategory.FormattingEnabled = true;
            comboBoxBarcodeCategory.Location = new Point(554, 4);
            comboBoxBarcodeCategory.Name = "comboBoxBarcodeCategory";
            comboBoxBarcodeCategory.Size = new Size(375, 25);
            comboBoxBarcodeCategory.TabIndex = 3;
            // 
            // panelButtonsBarcodes
            // 
            panelButtonsBarcodes.BackColor = Color.LightGray;
            panelButtonsBarcodes.Controls.Add(tlpBarcodesButtons);
            panelButtonsBarcodes.Dock = DockStyle.Fill;
            panelButtonsBarcodes.Location = new Point(3, 632);
            panelButtonsBarcodes.Name = "panelButtonsBarcodes";
            panelButtonsBarcodes.Padding = new Padding(10);
            panelButtonsBarcodes.Size = new Size(958, 64);
            panelButtonsBarcodes.TabIndex = 3;
            // 
            // tlpBarcodesButtons
            // 
            tlpBarcodesButtons.ColumnCount = 2;
            tlpBarcodesButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpBarcodesButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpBarcodesButtons.Controls.Add(flowLayoutPanelImport, 0, 0);
            tlpBarcodesButtons.Controls.Add(flowLayoutPanelCrud, 1, 0);
            tlpBarcodesButtons.Dock = DockStyle.Fill;
            tlpBarcodesButtons.Location = new Point(10, 10);
            tlpBarcodesButtons.Name = "tlpBarcodesButtons";
            tlpBarcodesButtons.RowCount = 1;
            tlpBarcodesButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBarcodesButtons.Size = new Size(938, 44);
            tlpBarcodesButtons.TabIndex = 0;
            // 
            // flowLayoutPanelImport
            // 
            flowLayoutPanelImport.Controls.Add(btnProductsImport);
            flowLayoutPanelImport.Controls.Add(btnProductsExport);
            flowLayoutPanelImport.Dock = DockStyle.Fill;
            flowLayoutPanelImport.Location = new Point(3, 3);
            flowLayoutPanelImport.Name = "flowLayoutPanelImport";
            flowLayoutPanelImport.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanelImport.Size = new Size(369, 38);
            flowLayoutPanelImport.TabIndex = 0;
            flowLayoutPanelImport.WrapContents = false;
            // 
            // btnProductsImport
            // 
            btnProductsImport.BackColor = Color.BlueViolet;
            btnProductsImport.FlatAppearance.BorderSize = 0;
            btnProductsImport.FlatStyle = FlatStyle.Flat;
            btnProductsImport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductsImport.ForeColor = Color.White;
            btnProductsImport.Location = new Point(3, 8);
            btnProductsImport.Margin = new Padding(3, 3, 10, 3);
            btnProductsImport.Name = "btnProductsImport";
            btnProductsImport.Size = new Size(140, 33);
            btnProductsImport.TabIndex = 0;
            btnProductsImport.Text = "ИМПОРТ";
            btnProductsImport.UseVisualStyleBackColor = false;
            // 
            // btnProductsExport
            // 
            btnProductsExport.BackColor = Color.BlueViolet;
            btnProductsExport.FlatAppearance.BorderSize = 0;
            btnProductsExport.FlatStyle = FlatStyle.Flat;
            btnProductsExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductsExport.ForeColor = Color.White;
            btnProductsExport.Location = new Point(156, 8);
            btnProductsExport.Margin = new Padding(3, 3, 10, 3);
            btnProductsExport.Name = "btnProductsExport";
            btnProductsExport.Size = new Size(140, 33);
            btnProductsExport.TabIndex = 1;
            btnProductsExport.Text = "ЭКСПОРТ";
            btnProductsExport.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelCrud
            // 
            flowLayoutPanelCrud.Anchor = AnchorStyles.Right;
            flowLayoutPanelCrud.AutoSize = true;
            flowLayoutPanelCrud.Controls.Add(btnProductAdd);
            flowLayoutPanelCrud.Controls.Add(btnProductSave);
            flowLayoutPanelCrud.Controls.Add(btnProductDel);
            flowLayoutPanelCrud.Controls.Add(btnProductCancel);
            flowLayoutPanelCrud.Location = new Point(403, 3);
            flowLayoutPanelCrud.Name = "flowLayoutPanelCrud";
            flowLayoutPanelCrud.Size = new Size(532, 38);
            flowLayoutPanelCrud.TabIndex = 1;
            flowLayoutPanelCrud.WrapContents = false;
            // 
            // btnProductAdd
            // 
            btnProductAdd.BackColor = Color.ForestGreen;
            btnProductAdd.FlatAppearance.BorderSize = 0;
            btnProductAdd.FlatStyle = FlatStyle.Flat;
            btnProductAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductAdd.ForeColor = Color.White;
            btnProductAdd.Location = new Point(3, 3);
            btnProductAdd.Margin = new Padding(3, 3, 10, 3);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(120, 40);
            btnProductAdd.TabIndex = 0;
            btnProductAdd.Text = "ДОБАВИТЬ";
            btnProductAdd.UseVisualStyleBackColor = false;
            // 
            // btnProductSave
            // 
            btnProductSave.BackColor = Color.DodgerBlue;
            btnProductSave.FlatAppearance.BorderSize = 0;
            btnProductSave.FlatStyle = FlatStyle.Flat;
            btnProductSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductSave.ForeColor = Color.White;
            btnProductSave.Location = new Point(136, 3);
            btnProductSave.Margin = new Padding(3, 3, 10, 3);
            btnProductSave.Name = "btnProductSave";
            btnProductSave.Size = new Size(120, 40);
            btnProductSave.TabIndex = 1;
            btnProductSave.Text = "СОХРАНИТЬ";
            btnProductSave.UseVisualStyleBackColor = false;
            // 
            // btnProductDel
            // 
            btnProductDel.BackColor = Color.Red;
            btnProductDel.FlatAppearance.BorderSize = 0;
            btnProductDel.FlatStyle = FlatStyle.Flat;
            btnProductDel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductDel.ForeColor = Color.White;
            btnProductDel.Location = new Point(269, 3);
            btnProductDel.Margin = new Padding(3, 3, 10, 3);
            btnProductDel.Name = "btnProductDel";
            btnProductDel.Size = new Size(120, 40);
            btnProductDel.TabIndex = 2;
            btnProductDel.Text = "УДАЛИТЬ";
            btnProductDel.UseVisualStyleBackColor = false;
            // 
            // btnProductCancel
            // 
            btnProductCancel.BackColor = Color.Gray;
            btnProductCancel.FlatAppearance.BorderSize = 0;
            btnProductCancel.FlatStyle = FlatStyle.Flat;
            btnProductCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductCancel.ForeColor = Color.White;
            btnProductCancel.Location = new Point(402, 3);
            btnProductCancel.Margin = new Padding(3, 3, 10, 3);
            btnProductCancel.Name = "btnProductCancel";
            btnProductCancel.Size = new Size(120, 40);
            btnProductCancel.TabIndex = 3;
            btnProductCancel.Text = "ОТМЕНА";
            btnProductCancel.UseVisualStyleBackColor = false;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(tlpCustomers);
            tabCustomers.Location = new Point(4, 44);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Size = new Size(970, 705);
            tabCustomers.TabIndex = 2;
            tabCustomers.Text = "Контрагенты";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tlpCustomers
            // 
            tlpCustomers.ColumnCount = 1;
            tlpCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomers.Controls.Add(panelTopCustomers, 0, 0);
            tlpCustomers.Controls.Add(panelGridCustomers, 0, 1);
            tlpCustomers.Controls.Add(panelEditCustomers, 0, 2);
            tlpCustomers.Controls.Add(panelButtonsCustomers, 0, 3);
            tlpCustomers.Dock = DockStyle.Fill;
            tlpCustomers.Location = new Point(0, 0);
            tlpCustomers.Name = "tlpCustomers";
            tlpCustomers.RowCount = 4;
            tlpCustomers.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCustomers.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpCustomers.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpCustomers.Size = new Size(970, 705);
            tlpCustomers.TabIndex = 0;
            // 
            // panelTopCustomers
            // 
            panelTopCustomers.Controls.Add(tlpCustomersTop);
            panelTopCustomers.Dock = DockStyle.Fill;
            panelTopCustomers.Location = new Point(3, 3);
            panelTopCustomers.Name = "panelTopCustomers";
            panelTopCustomers.Padding = new Padding(10, 10, 10, 0);
            panelTopCustomers.Size = new Size(964, 54);
            panelTopCustomers.TabIndex = 0;
            // 
            // tlpCustomersTop
            // 
            tlpCustomersTop.ColumnCount = 3;
            tlpCustomersTop.ColumnStyles.Add(new ColumnStyle());
            tlpCustomersTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpCustomersTop.ColumnStyles.Add(new ColumnStyle());
            tlpCustomersTop.Controls.Add(lblCustomerSearch, 0, 0);
            tlpCustomersTop.Controls.Add(textBoxSearchCustomer, 1, 0);
            tlpCustomersTop.Controls.Add(btnSearchCustomer, 2, 0);
            tlpCustomersTop.Dock = DockStyle.Fill;
            tlpCustomersTop.Location = new Point(10, 10);
            tlpCustomersTop.Name = "tlpCustomersTop";
            tlpCustomersTop.RowCount = 1;
            tlpCustomersTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCustomersTop.Size = new Size(944, 44);
            tlpCustomersTop.TabIndex = 0;
            // 
            // lblCustomerSearch
            // 
            lblCustomerSearch.Anchor = AnchorStyles.Left;
            lblCustomerSearch.AutoSize = true;
            lblCustomerSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCustomerSearch.Location = new Point(3, 12);
            lblCustomerSearch.Name = "lblCustomerSearch";
            lblCustomerSearch.Size = new Size(51, 19);
            lblCustomerSearch.TabIndex = 0;
            lblCustomerSearch.Text = "Поиск:";
            // 
            // textBoxSearchCustomer
            // 
            textBoxSearchCustomer.Anchor = AnchorStyles.Left;
            textBoxSearchCustomer.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearchCustomer.Location = new Point(60, 9);
            textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            textBoxSearchCustomer.Size = new Size(244, 25);
            textBoxSearchCustomer.TabIndex = 1;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Anchor = AnchorStyles.Left;
            btnSearchCustomer.BackColor = Color.DodgerBlue;
            btnSearchCustomer.FlatAppearance.BorderSize = 0;
            btnSearchCustomer.FlatStyle = FlatStyle.Flat;
            btnSearchCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearchCustomer.ForeColor = Color.White;
            btnSearchCustomer.Location = new Point(310, 7);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(80, 30);
            btnSearchCustomer.TabIndex = 2;
            btnSearchCustomer.Text = "Найти";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // panelGridCustomers
            // 
            panelGridCustomers.Controls.Add(dataGridViewCustomers);
            panelGridCustomers.Dock = DockStyle.Fill;
            panelGridCustomers.Location = new Point(3, 63);
            panelGridCustomers.Name = "panelGridCustomers";
            panelGridCustomers.Size = new Size(964, 499);
            panelGridCustomers.TabIndex = 1;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.AllowUserToResizeRows = false;
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerNumber, CustomerTitle });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCustomers.Dock = DockStyle.Fill;
            dataGridViewCustomers.Location = new Point(0, 0);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.ReadOnly = true;
            dataGridViewCustomers.RowHeadersVisible = false;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.Size = new Size(964, 499);
            dataGridViewCustomers.TabIndex = 1;
            // 
            // CustomerNumber
            // 
            CustomerNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerNumber.HeaderText = "№";
            CustomerNumber.Name = "CustomerNumber";
            CustomerNumber.ReadOnly = true;
            CustomerNumber.Width = 53;
            // 
            // CustomerTitle
            // 
            CustomerTitle.FillWeight = 300F;
            CustomerTitle.HeaderText = "Наименование контрагента";
            CustomerTitle.Name = "CustomerTitle";
            CustomerTitle.ReadOnly = true;
            // 
            // panelEditCustomers
            // 
            panelEditCustomers.BackColor = Color.Gainsboro;
            panelEditCustomers.Controls.Add(tlpCustomersEdit);
            panelEditCustomers.Dock = DockStyle.Fill;
            panelEditCustomers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelEditCustomers.Location = new Point(3, 568);
            panelEditCustomers.Name = "panelEditCustomers";
            panelEditCustomers.Padding = new Padding(10);
            panelEditCustomers.Size = new Size(964, 64);
            panelEditCustomers.TabIndex = 2;
            // 
            // tlpCustomersEdit
            // 
            tlpCustomersEdit.ColumnCount = 2;
            tlpCustomersEdit.ColumnStyles.Add(new ColumnStyle());
            tlpCustomersEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomersEdit.Controls.Add(label6, 0, 0);
            tlpCustomersEdit.Controls.Add(textBoxCustomerName, 1, 0);
            tlpCustomersEdit.Dock = DockStyle.Fill;
            tlpCustomersEdit.Location = new Point(10, 10);
            tlpCustomersEdit.Name = "tlpCustomersEdit";
            tlpCustomersEdit.RowCount = 1;
            tlpCustomersEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCustomersEdit.Size = new Size(944, 44);
            tlpCustomersEdit.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 12);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 0;
            label6.Text = "Наименование:";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCustomerName.BorderStyle = BorderStyle.FixedSingle;
            textBoxCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCustomerName.Location = new Point(116, 9);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(825, 25);
            textBoxCustomerName.TabIndex = 1;
            // 
            // panelButtonsCustomers
            // 
            panelButtonsCustomers.BackColor = Color.LightGray;
            panelButtonsCustomers.Controls.Add(tlpCustomersButtons);
            panelButtonsCustomers.Dock = DockStyle.Fill;
            panelButtonsCustomers.Location = new Point(3, 638);
            panelButtonsCustomers.Name = "panelButtonsCustomers";
            panelButtonsCustomers.Padding = new Padding(10);
            panelButtonsCustomers.Size = new Size(964, 64);
            panelButtonsCustomers.TabIndex = 3;
            // 
            // tlpCustomersButtons
            // 
            tlpCustomersButtons.ColumnCount = 2;
            tlpCustomersButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpCustomersButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpCustomersButtons.Controls.Add(flowLayoutPanelCustomersImport, 0, 0);
            tlpCustomersButtons.Controls.Add(flowLayoutPanelCustomersButtons, 1, 0);
            tlpCustomersButtons.Dock = DockStyle.Fill;
            tlpCustomersButtons.Location = new Point(10, 10);
            tlpCustomersButtons.Name = "tlpCustomersButtons";
            tlpCustomersButtons.RowCount = 1;
            tlpCustomersButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCustomersButtons.Size = new Size(944, 44);
            tlpCustomersButtons.TabIndex = 0;
            // 
            // flowLayoutPanelCustomersImport
            // 
            flowLayoutPanelCustomersImport.Controls.Add(btnCustomersImport);
            flowLayoutPanelCustomersImport.Controls.Add(btnCustomersExport);
            flowLayoutPanelCustomersImport.Dock = DockStyle.Fill;
            flowLayoutPanelCustomersImport.Location = new Point(3, 3);
            flowLayoutPanelCustomersImport.Name = "flowLayoutPanelCustomersImport";
            flowLayoutPanelCustomersImport.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanelCustomersImport.Size = new Size(371, 38);
            flowLayoutPanelCustomersImport.TabIndex = 0;
            flowLayoutPanelCustomersImport.WrapContents = false;
            // 
            // btnCustomersImport
            // 
            btnCustomersImport.BackColor = Color.BlueViolet;
            btnCustomersImport.FlatAppearance.BorderSize = 0;
            btnCustomersImport.FlatStyle = FlatStyle.Flat;
            btnCustomersImport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomersImport.ForeColor = Color.White;
            btnCustomersImport.Location = new Point(3, 8);
            btnCustomersImport.Margin = new Padding(3, 3, 10, 3);
            btnCustomersImport.Name = "btnCustomersImport";
            btnCustomersImport.Size = new Size(140, 33);
            btnCustomersImport.TabIndex = 0;
            btnCustomersImport.Text = "ИМПОРТ";
            btnCustomersImport.UseVisualStyleBackColor = false;
            // 
            // btnCustomersExport
            // 
            btnCustomersExport.BackColor = Color.BlueViolet;
            btnCustomersExport.FlatAppearance.BorderSize = 0;
            btnCustomersExport.FlatStyle = FlatStyle.Flat;
            btnCustomersExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomersExport.ForeColor = Color.White;
            btnCustomersExport.Location = new Point(156, 8);
            btnCustomersExport.Margin = new Padding(3, 3, 10, 3);
            btnCustomersExport.Name = "btnCustomersExport";
            btnCustomersExport.Size = new Size(140, 33);
            btnCustomersExport.TabIndex = 1;
            btnCustomersExport.Text = "ЭКСПОРТ";
            btnCustomersExport.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelCustomersButtons
            // 
            flowLayoutPanelCustomersButtons.Anchor = AnchorStyles.Right;
            flowLayoutPanelCustomersButtons.AutoSize = true;
            flowLayoutPanelCustomersButtons.Controls.Add(btnCustomerAdd);
            flowLayoutPanelCustomersButtons.Controls.Add(btnCustomerSave);
            flowLayoutPanelCustomersButtons.Controls.Add(btnCustomerDel);
            flowLayoutPanelCustomersButtons.Controls.Add(btnCustomerCancel);
            flowLayoutPanelCustomersButtons.Location = new Point(409, 3);
            flowLayoutPanelCustomersButtons.Name = "flowLayoutPanelCustomersButtons";
            flowLayoutPanelCustomersButtons.Size = new Size(532, 38);
            flowLayoutPanelCustomersButtons.TabIndex = 1;
            flowLayoutPanelCustomersButtons.WrapContents = false;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.BackColor = Color.ForestGreen;
            btnCustomerAdd.FlatAppearance.BorderSize = 0;
            btnCustomerAdd.FlatStyle = FlatStyle.Flat;
            btnCustomerAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomerAdd.ForeColor = Color.White;
            btnCustomerAdd.Location = new Point(3, 3);
            btnCustomerAdd.Margin = new Padding(3, 3, 10, 3);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(120, 40);
            btnCustomerAdd.TabIndex = 0;
            btnCustomerAdd.Text = "ДОБАВИТЬ";
            btnCustomerAdd.UseVisualStyleBackColor = false;
            // 
            // btnCustomerSave
            // 
            btnCustomerSave.BackColor = Color.DodgerBlue;
            btnCustomerSave.FlatAppearance.BorderSize = 0;
            btnCustomerSave.FlatStyle = FlatStyle.Flat;
            btnCustomerSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomerSave.ForeColor = Color.White;
            btnCustomerSave.Location = new Point(136, 3);
            btnCustomerSave.Margin = new Padding(3, 3, 10, 3);
            btnCustomerSave.Name = "btnCustomerSave";
            btnCustomerSave.Size = new Size(120, 40);
            btnCustomerSave.TabIndex = 1;
            btnCustomerSave.Text = "СОХРАНИТЬ";
            btnCustomerSave.UseVisualStyleBackColor = false;
            // 
            // btnCustomerDel
            // 
            btnCustomerDel.BackColor = Color.Red;
            btnCustomerDel.FlatAppearance.BorderSize = 0;
            btnCustomerDel.FlatStyle = FlatStyle.Flat;
            btnCustomerDel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomerDel.ForeColor = Color.White;
            btnCustomerDel.Location = new Point(269, 3);
            btnCustomerDel.Margin = new Padding(3, 3, 10, 3);
            btnCustomerDel.Name = "btnCustomerDel";
            btnCustomerDel.Size = new Size(120, 40);
            btnCustomerDel.TabIndex = 2;
            btnCustomerDel.Text = "УДАЛИТЬ";
            btnCustomerDel.UseVisualStyleBackColor = false;
            // 
            // btnCustomerCancel
            // 
            btnCustomerCancel.BackColor = Color.Gray;
            btnCustomerCancel.FlatAppearance.BorderSize = 0;
            btnCustomerCancel.FlatStyle = FlatStyle.Flat;
            btnCustomerCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomerCancel.ForeColor = Color.White;
            btnCustomerCancel.Location = new Point(402, 3);
            btnCustomerCancel.Margin = new Padding(3, 3, 10, 3);
            btnCustomerCancel.Name = "btnCustomerCancel";
            btnCustomerCancel.Size = new Size(120, 40);
            btnCustomerCancel.TabIndex = 3;
            btnCustomerCancel.Text = "ОТМЕНА";
            btnCustomerCancel.UseVisualStyleBackColor = false;
            // 
            // FormRefEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(tabControl1);
            Name = "FormRefEdit";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование справочников";
            tabControl1.ResumeLayout(false);
            tabCategory.ResumeLayout(false);
            tlpCategories.ResumeLayout(false);
            panelGridCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            panelEditCategories.ResumeLayout(false);
            tlpCategoriesEdit.ResumeLayout(false);
            tlpCategoriesEdit.PerformLayout();
            panelButtonsCategories.ResumeLayout(false);
            flowLayoutPanelCategoriesButtons.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            tlpBarcodes.ResumeLayout(false);
            panelTopBarcodes.ResumeLayout(false);
            tlpBarcodesTop.ResumeLayout(false);
            tlpBarcodesTop.PerformLayout();
            flowLayoutPanelFilterActions.ResumeLayout(false);
            panelGridBarcodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panelEditBarcodes.ResumeLayout(false);
            tlpBarcodesEditContainer.ResumeLayout(false);
            tlpBarcodeName.ResumeLayout(false);
            tlpBarcodeName.PerformLayout();
            tlpBarcodesEdit.ResumeLayout(false);
            tlpBarcodesEdit.PerformLayout();
            panelButtonsBarcodes.ResumeLayout(false);
            tlpBarcodesButtons.ResumeLayout(false);
            tlpBarcodesButtons.PerformLayout();
            flowLayoutPanelImport.ResumeLayout(false);
            flowLayoutPanelCrud.ResumeLayout(false);
            tabCustomers.ResumeLayout(false);
            tlpCustomers.ResumeLayout(false);
            panelTopCustomers.ResumeLayout(false);
            tlpCustomersTop.ResumeLayout(false);
            tlpCustomersTop.PerformLayout();
            panelGridCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            panelEditCustomers.ResumeLayout(false);
            tlpCustomersEdit.ResumeLayout(false);
            tlpCustomersEdit.PerformLayout();
            panelButtonsCustomers.ResumeLayout(false);
            tlpCustomersButtons.ResumeLayout(false);
            tlpCustomersButtons.PerformLayout();
            flowLayoutPanelCustomersImport.ResumeLayout(false);
            flowLayoutPanelCustomersButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCategory;
        private TabPage tabProducts;
        private TabPage tabCustomers;
        private TableLayoutPanel tlpCategories;
        private Panel panelTopCategories;
        private Panel panelGridCategories;
        private DataGridView dataGridViewCategories;
        private DataGridViewTextBoxColumn RowNumber;
        private DataGridViewTextBoxColumn CategoryTitle;
        private Panel panelEditCategories;
        private TableLayoutPanel tlpCategoriesEdit;
        private Label labelCategoryName;
        private TextBox textBoxCategoryName;
        private Panel panelButtonsCategories;
        private FlowLayoutPanel flowLayoutPanelCategoriesButtons;
        private Button btnCategoryAdd;
        private Button btnCategorySave;
        private Button btnCategoryDel;
        private Button btnCategoryCancel;
        private TableLayoutPanel tlpBarcodes;
        private Panel panelTopBarcodes;
        private Panel panelGridBarcodes;
        private DataGridView dataGridViewProducts;
        private Panel panelEditBarcodes;
        private Panel panelButtonsBarcodes;
        private TableLayoutPanel tlpBarcodesTop;
        private Label lblFilterCategory;
        private ComboBox comboBoxCategoryFilter;
        private Label lblSearch;
        private TextBox textBoxSearch;
        private Button btnSearch;
        private FlowLayoutPanel flowLayoutPanelFilterActions;
        private Button btnApplyFilter;
        private Button btnResetFilter;
        private TableLayoutPanel tlpBarcodesEditContainer;
        private TableLayoutPanel tlpBarcodeName;
        private TableLayoutPanel tlpBarcodesEdit;
        private Label label3;
        private TextBox textBoxBarcodeCode;
        private Label label4;
        private TextBox textBoxBarcodeName;
        private Label label5;
        private ComboBox comboBoxBarcodeCategory;
        private TableLayoutPanel tlpBarcodesButtons;
        private FlowLayoutPanel flowLayoutPanelImport;
        private Button btnProductsImport;
        private Button btnProductsExport;
        private FlowLayoutPanel flowLayoutPanelCrud;
        private Button btnProductAdd;
        private Button btnProductSave;
        private Button btnProductDel;
        private Button btnProductCancel;
        private TableLayoutPanel tlpCustomers;
        private Panel panelTopCustomers;
        private TableLayoutPanel tlpCustomersTop;
        private Label lblCustomerSearch;
        private TextBox textBoxSearchCustomer;
        private Button btnSearchCustomer;
        private Panel panelGridCustomers;
        private DataGridView dataGridViewCustomers;
        private DataGridViewTextBoxColumn CustomerNumber;
        private DataGridViewTextBoxColumn CustomerTitle;
        private Panel panelEditCustomers;
        private TableLayoutPanel tlpCustomersEdit;
        private Label label6;
        private TextBox textBoxCustomerName;
        private Panel panelButtonsCustomers;
        private TableLayoutPanel tlpCustomersButtons;
        private FlowLayoutPanel flowLayoutPanelCustomersButtons;
        private Button btnCustomerAdd;
        private Button btnCustomerSave;
        private Button btnCustomerDel;
        private Button btnCustomerCancel;
        private FlowLayoutPanel flowLayoutPanelCustomersImport;
        private Button btnCustomersImport;
        private Button btnCustomersExport;
        private DataGridViewTextBoxColumn ProductNumber;
        private DataGridViewTextBoxColumn ProductCategory;
        private DataGridViewTextBoxColumn ProductTitle;
        private DataGridViewTextBoxColumn ProductCode;
    }
}

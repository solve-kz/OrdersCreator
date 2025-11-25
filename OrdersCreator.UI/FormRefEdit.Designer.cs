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
            tabControl1 = new TabControl();
            tabCategory = new TabPage();
            dataGridViewCategories = new DataGridView();
            RowNumber = new DataGridViewTextBoxColumn();
            CategoryTitle = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnCategoriesExport = new Button();
            btnCategoriesImport = new Button();
            tbCategoryTitle = new TextBox();
            label1 = new Label();
            btnCategoryCancel = new Button();
            btnCategoryDel = new Button();
            btnCategorySave = new Button();
            btnCategoryAdd = new Button();
            tabProducts = new TabPage();
            dataGridViewProducts = new DataGridView();
            ProductNumber = new DataGridViewTextBoxColumn();
            ProductCategory = new DataGridViewTextBoxColumn();
            ProductTitle = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnProductsExport = new Button();
            btnProductsImport = new Button();
            cmbProductCategory = new ComboBox();
            tbProductTitle = new TextBox();
            tbProductCode = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnProductCancel = new Button();
            btnProductDel = new Button();
            btnProductSave = new Button();
            btnProductAdd = new Button();
            panel2 = new Panel();
            btnFilterCancel = new Button();
            btnFilterApply = new Button();
            cmbProductCategoryFilter = new ComboBox();
            label2 = new Label();
            tabCustomers = new TabPage();
            dataGridViewCustomers = new DataGridView();
            CustomerNumber = new DataGridViewTextBoxColumn();
            CustomerTitle = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnCustomersExport = new Button();
            btnCustomersImport = new Button();
            btnCustomerCancel = new Button();
            btnCustomerDel = new Button();
            btnCustomerSave = new Button();
            btnCustomerAdd = new Button();
            tbCustomerTitle = new TextBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            panel1.SuspendLayout();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategory);
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabCustomers);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.ItemSize = new Size(200, 40);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(984, 761);
            tabControl1.TabIndex = 1;
            // 
            // tabCategory
            // 
            tabCategory.Controls.Add(dataGridViewCategories);
            tabCategory.Controls.Add(panel1);
            tabCategory.Location = new Point(4, 44);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3);
            tabCategory.Size = new Size(976, 713);
            tabCategory.TabIndex = 0;
            tabCategory.Text = "Категории товаров";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.BackgroundColor = Color.White;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { RowNumber, CategoryTitle });
            dataGridViewCategories.Dock = DockStyle.Fill;
            dataGridViewCategories.Location = new Point(3, 3);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.RowHeadersVisible = false;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(970, 507);
            dataGridViewCategories.TabIndex = 1;
            // 
            // RowNumber
            // 
            RowNumber.HeaderText = "№";
            RowNumber.Name = "RowNumber";
            RowNumber.ReadOnly = true;
            // 
            // CategoryTitle
            // 
            CategoryTitle.HeaderText = "Наименование категории";
            CategoryTitle.Name = "CategoryTitle";
            CategoryTitle.ReadOnly = true;
            CategoryTitle.Width = 400;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnCategoriesExport);
            panel1.Controls.Add(btnCategoriesImport);
            panel1.Controls.Add(tbCategoryTitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCategoryCancel);
            panel1.Controls.Add(btnCategoryDel);
            panel1.Controls.Add(btnCategorySave);
            panel1.Controls.Add(btnCategoryAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(3, 510);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 200);
            panel1.TabIndex = 0;
            // 
            // btnCategoriesExport
            // 
            btnCategoriesExport.BackColor = Color.BlueViolet;
            btnCategoriesExport.FlatAppearance.BorderSize = 0;
            btnCategoriesExport.FlatStyle = FlatStyle.Flat;
            btnCategoriesExport.ForeColor = Color.White;
            btnCategoriesExport.Location = new Point(46, 143);
            btnCategoriesExport.Name = "btnCategoriesExport";
            btnCategoriesExport.Size = new Size(140, 33);
            btnCategoriesExport.TabIndex = 15;
            btnCategoriesExport.Text = "Экспорт .xlsx";
            btnCategoriesExport.UseVisualStyleBackColor = false;
            // 
            // btnCategoriesImport
            // 
            btnCategoriesImport.BackColor = Color.BlueViolet;
            btnCategoriesImport.FlatAppearance.BorderSize = 0;
            btnCategoriesImport.FlatStyle = FlatStyle.Flat;
            btnCategoriesImport.ForeColor = Color.White;
            btnCategoriesImport.Location = new Point(46, 104);
            btnCategoriesImport.Name = "btnCategoriesImport";
            btnCategoriesImport.Size = new Size(140, 33);
            btnCategoriesImport.TabIndex = 14;
            btnCategoriesImport.Text = "Импорт .xlsx";
            btnCategoriesImport.UseVisualStyleBackColor = false;
            // 
            // tbCategoryTitle
            // 
            tbCategoryTitle.Location = new Point(209, 42);
            tbCategoryTitle.Name = "tbCategoryTitle";
            tbCategoryTitle.Size = new Size(737, 29);
            tbCategoryTitle.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 45);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 4;
            label1.Text = "Наименование:";
            // 
            // btnCategoryCancel
            // 
            btnCategoryCancel.BackColor = Color.Gray;
            btnCategoryCancel.FlatAppearance.BorderSize = 0;
            btnCategoryCancel.FlatStyle = FlatStyle.Flat;
            btnCategoryCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCategoryCancel.ForeColor = Color.White;
            btnCategoryCancel.Location = new Point(781, 129);
            btnCategoryCancel.Name = "btnCategoryCancel";
            btnCategoryCancel.Size = new Size(165, 47);
            btnCategoryCancel.TabIndex = 3;
            btnCategoryCancel.Text = "ОТМЕНА";
            btnCategoryCancel.UseVisualStyleBackColor = false;
            // 
            // btnCategoryDel
            // 
            btnCategoryDel.BackColor = Color.Red;
            btnCategoryDel.FlatAppearance.BorderSize = 0;
            btnCategoryDel.FlatStyle = FlatStyle.Flat;
            btnCategoryDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCategoryDel.ForeColor = Color.White;
            btnCategoryDel.Location = new Point(610, 129);
            btnCategoryDel.Name = "btnCategoryDel";
            btnCategoryDel.Size = new Size(165, 47);
            btnCategoryDel.TabIndex = 2;
            btnCategoryDel.Text = "УДАЛИТЬ";
            btnCategoryDel.UseVisualStyleBackColor = false;
            // 
            // btnCategorySave
            // 
            btnCategorySave.BackColor = Color.DodgerBlue;
            btnCategorySave.FlatAppearance.BorderSize = 0;
            btnCategorySave.FlatStyle = FlatStyle.Flat;
            btnCategorySave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCategorySave.ForeColor = Color.White;
            btnCategorySave.Location = new Point(439, 129);
            btnCategorySave.Name = "btnCategorySave";
            btnCategorySave.Size = new Size(165, 47);
            btnCategorySave.TabIndex = 1;
            btnCategorySave.Text = "СОХРАНИТЬ";
            btnCategorySave.UseVisualStyleBackColor = false;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.BackColor = Color.ForestGreen;
            btnCategoryAdd.FlatAppearance.BorderSize = 0;
            btnCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnCategoryAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCategoryAdd.ForeColor = Color.White;
            btnCategoryAdd.Location = new Point(268, 129);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(165, 47);
            btnCategoryAdd.TabIndex = 0;
            btnCategoryAdd.Text = "ДОБАВИТЬ";
            btnCategoryAdd.UseVisualStyleBackColor = false;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(dataGridViewProducts);
            tabProducts.Controls.Add(panel3);
            tabProducts.Controls.Add(panel2);
            tabProducts.Location = new Point(4, 44);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(976, 713);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Штрих-коды товаров";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { ProductNumber, ProductCategory, ProductTitle, ProductCode });
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(3, 83);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(970, 427);
            dataGridViewProducts.TabIndex = 2;
            // 
            // ProductNumber
            // 
            ProductNumber.HeaderText = "№";
            ProductNumber.Name = "ProductNumber";
            ProductNumber.ReadOnly = true;
            // 
            // ProductCategory
            // 
            ProductCategory.HeaderText = "Категория";
            ProductCategory.Name = "ProductCategory";
            ProductCategory.ReadOnly = true;
            ProductCategory.Width = 150;
            // 
            // ProductTitle
            // 
            ProductTitle.HeaderText = "Наименование товара";
            ProductTitle.Name = "ProductTitle";
            ProductTitle.ReadOnly = true;
            ProductTitle.Width = 400;
            // 
            // ProductCode
            // 
            ProductCode.HeaderText = "Код товара";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            ProductCode.Width = 200;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(btnProductsExport);
            panel3.Controls.Add(btnProductsImport);
            panel3.Controls.Add(cmbProductCategory);
            panel3.Controls.Add(tbProductTitle);
            panel3.Controls.Add(tbProductCode);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnProductCancel);
            panel3.Controls.Add(btnProductDel);
            panel3.Controls.Add(btnProductSave);
            panel3.Controls.Add(btnProductAdd);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 510);
            panel3.Name = "panel3";
            panel3.Size = new Size(970, 200);
            panel3.TabIndex = 1;
            // 
            // btnProductsExport
            // 
            btnProductsExport.BackColor = Color.BlueViolet;
            btnProductsExport.FlatAppearance.BorderSize = 0;
            btnProductsExport.FlatStyle = FlatStyle.Flat;
            btnProductsExport.ForeColor = Color.White;
            btnProductsExport.Location = new Point(34, 160);
            btnProductsExport.Name = "btnProductsExport";
            btnProductsExport.Size = new Size(140, 33);
            btnProductsExport.TabIndex = 15;
            btnProductsExport.Text = "Экспорт .xlsx";
            btnProductsExport.UseVisualStyleBackColor = false;
            // 
            // btnProductsImport
            // 
            btnProductsImport.BackColor = Color.BlueViolet;
            btnProductsImport.FlatAppearance.BorderSize = 0;
            btnProductsImport.FlatStyle = FlatStyle.Flat;
            btnProductsImport.ForeColor = Color.White;
            btnProductsImport.Location = new Point(34, 121);
            btnProductsImport.Name = "btnProductsImport";
            btnProductsImport.Size = new Size(140, 33);
            btnProductsImport.TabIndex = 14;
            btnProductsImport.Text = "Импорт .xlsx";
            btnProductsImport.UseVisualStyleBackColor = false;
            // 
            // cmbProductCategory
            // 
            cmbProductCategory.FormattingEnabled = true;
            cmbProductCategory.Location = new Point(196, 94);
            cmbProductCategory.Name = "cmbProductCategory";
            cmbProductCategory.Size = new Size(754, 29);
            cmbProductCategory.TabIndex = 13;
            // 
            // tbProductTitle
            // 
            tbProductTitle.Location = new Point(196, 56);
            tbProductTitle.Name = "tbProductTitle";
            tbProductTitle.Size = new Size(754, 29);
            tbProductTitle.TabIndex = 12;
            // 
            // tbProductCode
            // 
            tbProductCode.Location = new Point(196, 15);
            tbProductCode.Name = "tbProductCode";
            tbProductCode.Size = new Size(754, 29);
            tbProductCode.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 97);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 10;
            label5.Text = "Категория:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 59);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 9;
            label4.Text = "Наименование:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 18);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 8;
            label3.Text = "Код товара:";
            // 
            // btnProductCancel
            // 
            btnProductCancel.BackColor = Color.Gray;
            btnProductCancel.FlatAppearance.BorderSize = 0;
            btnProductCancel.FlatStyle = FlatStyle.Flat;
            btnProductCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductCancel.ForeColor = Color.White;
            btnProductCancel.Location = new Point(785, 136);
            btnProductCancel.Name = "btnProductCancel";
            btnProductCancel.Size = new Size(165, 47);
            btnProductCancel.TabIndex = 7;
            btnProductCancel.Text = "ОТМЕНА";
            btnProductCancel.UseVisualStyleBackColor = false;
            // 
            // btnProductDel
            // 
            btnProductDel.BackColor = Color.Red;
            btnProductDel.FlatAppearance.BorderSize = 0;
            btnProductDel.FlatStyle = FlatStyle.Flat;
            btnProductDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductDel.ForeColor = Color.White;
            btnProductDel.Location = new Point(614, 136);
            btnProductDel.Name = "btnProductDel";
            btnProductDel.Size = new Size(165, 47);
            btnProductDel.TabIndex = 6;
            btnProductDel.Text = "УДАЛИТЬ";
            btnProductDel.UseVisualStyleBackColor = false;
            // 
            // btnProductSave
            // 
            btnProductSave.BackColor = Color.DodgerBlue;
            btnProductSave.FlatAppearance.BorderSize = 0;
            btnProductSave.FlatStyle = FlatStyle.Flat;
            btnProductSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductSave.ForeColor = Color.White;
            btnProductSave.Location = new Point(443, 136);
            btnProductSave.Name = "btnProductSave";
            btnProductSave.Size = new Size(165, 47);
            btnProductSave.TabIndex = 5;
            btnProductSave.Text = "СОХРАНИТЬ";
            btnProductSave.UseVisualStyleBackColor = false;
            // 
            // btnProductAdd
            // 
            btnProductAdd.BackColor = Color.ForestGreen;
            btnProductAdd.FlatAppearance.BorderSize = 0;
            btnProductAdd.FlatStyle = FlatStyle.Flat;
            btnProductAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnProductAdd.ForeColor = Color.White;
            btnProductAdd.Location = new Point(272, 136);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(165, 47);
            btnProductAdd.TabIndex = 4;
            btnProductAdd.Text = "ДОБАВИТЬ";
            btnProductAdd.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnFilterCancel);
            panel2.Controls.Add(btnFilterApply);
            panel2.Controls.Add(cmbProductCategoryFilter);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 80);
            panel2.TabIndex = 0;
            // 
            // btnFilterCancel
            // 
            btnFilterCancel.BackColor = Color.Gray;
            btnFilterCancel.FlatAppearance.BorderSize = 0;
            btnFilterCancel.FlatStyle = FlatStyle.Flat;
            btnFilterCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnFilterCancel.ForeColor = Color.White;
            btnFilterCancel.Location = new Point(785, 25);
            btnFilterCancel.Name = "btnFilterCancel";
            btnFilterCancel.Size = new Size(165, 29);
            btnFilterCancel.TabIndex = 8;
            btnFilterCancel.Text = "СБРОСИТЬ";
            btnFilterCancel.UseVisualStyleBackColor = false;
            // 
            // btnFilterApply
            // 
            btnFilterApply.BackColor = Color.DodgerBlue;
            btnFilterApply.FlatAppearance.BorderSize = 0;
            btnFilterApply.FlatStyle = FlatStyle.Flat;
            btnFilterApply.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnFilterApply.ForeColor = Color.White;
            btnFilterApply.Location = new Point(576, 26);
            btnFilterApply.Name = "btnFilterApply";
            btnFilterApply.Size = new Size(188, 29);
            btnFilterApply.TabIndex = 6;
            btnFilterApply.Text = "ПРИМЕНИТЬ ФИЛЬТР";
            btnFilterApply.UseVisualStyleBackColor = false;
            // 
            // cmbProductCategoryFilter
            // 
            cmbProductCategoryFilter.FormattingEnabled = true;
            cmbProductCategoryFilter.Location = new Point(256, 26);
            cmbProductCategoryFilter.Name = "cmbProductCategoryFilter";
            cmbProductCategoryFilter.Size = new Size(299, 29);
            cmbProductCategoryFilter.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 29);
            label2.Name = "label2";
            label2.Size = new Size(181, 21);
            label2.TabIndex = 0;
            label2.Text = "Фильтр по категории:";
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(dataGridViewCustomers);
            tabCustomers.Controls.Add(panel4);
            tabCustomers.Location = new Point(4, 44);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Size = new Size(976, 713);
            tabCustomers.TabIndex = 2;
            tabCustomers.Text = "Контрагенты";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.BackgroundColor = Color.White;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerNumber, CustomerTitle });
            dataGridViewCustomers.Dock = DockStyle.Fill;
            dataGridViewCustomers.Location = new Point(0, 0);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.ReadOnly = true;
            dataGridViewCustomers.RowHeadersVisible = false;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.Size = new Size(976, 513);
            dataGridViewCustomers.TabIndex = 1;
            // 
            // CustomerNumber
            // 
            CustomerNumber.HeaderText = "№";
            CustomerNumber.Name = "CustomerNumber";
            CustomerNumber.ReadOnly = true;
            // 
            // CustomerTitle
            // 
            CustomerTitle.HeaderText = "Наименование контрагента";
            CustomerTitle.Name = "CustomerTitle";
            CustomerTitle.ReadOnly = true;
            CustomerTitle.Width = 300;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(btnCustomersExport);
            panel4.Controls.Add(btnCustomersImport);
            panel4.Controls.Add(btnCustomerCancel);
            panel4.Controls.Add(btnCustomerDel);
            panel4.Controls.Add(btnCustomerSave);
            panel4.Controls.Add(btnCustomerAdd);
            panel4.Controls.Add(tbCustomerTitle);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 513);
            panel4.Name = "panel4";
            panel4.Size = new Size(976, 200);
            panel4.TabIndex = 0;
            // 
            // btnCustomersExport
            // 
            btnCustomersExport.BackColor = Color.BlueViolet;
            btnCustomersExport.FlatAppearance.BorderSize = 0;
            btnCustomersExport.FlatStyle = FlatStyle.Flat;
            btnCustomersExport.ForeColor = Color.White;
            btnCustomersExport.Location = new Point(57, 159);
            btnCustomersExport.Name = "btnCustomersExport";
            btnCustomersExport.Size = new Size(140, 33);
            btnCustomersExport.TabIndex = 13;
            btnCustomersExport.Text = "Экспорт .xlsx";
            btnCustomersExport.UseVisualStyleBackColor = false;
            // 
            // btnCustomersImport
            // 
            btnCustomersImport.BackColor = Color.BlueViolet;
            btnCustomersImport.FlatAppearance.BorderSize = 0;
            btnCustomersImport.FlatStyle = FlatStyle.Flat;
            btnCustomersImport.ForeColor = Color.White;
            btnCustomersImport.Location = new Point(57, 120);
            btnCustomersImport.Name = "btnCustomersImport";
            btnCustomersImport.Size = new Size(140, 33);
            btnCustomersImport.TabIndex = 12;
            btnCustomersImport.Text = "Импорт .xlsx";
            btnCustomersImport.UseVisualStyleBackColor = false;
            // 
            // btnCustomerCancel
            // 
            btnCustomerCancel.BackColor = Color.Gray;
            btnCustomerCancel.FlatAppearance.BorderSize = 0;
            btnCustomerCancel.FlatStyle = FlatStyle.Flat;
            btnCustomerCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomerCancel.ForeColor = Color.White;
            btnCustomerCancel.Location = new Point(782, 145);
            btnCustomerCancel.Name = "btnCustomerCancel";
            btnCustomerCancel.Size = new Size(165, 47);
            btnCustomerCancel.TabIndex = 11;
            btnCustomerCancel.Text = "ОТМЕНА";
            btnCustomerCancel.UseVisualStyleBackColor = false;
            // 
            // btnCustomerDel
            // 
            btnCustomerDel.BackColor = Color.Red;
            btnCustomerDel.FlatAppearance.BorderSize = 0;
            btnCustomerDel.FlatStyle = FlatStyle.Flat;
            btnCustomerDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomerDel.ForeColor = Color.White;
            btnCustomerDel.Location = new Point(611, 145);
            btnCustomerDel.Name = "btnCustomerDel";
            btnCustomerDel.Size = new Size(165, 47);
            btnCustomerDel.TabIndex = 10;
            btnCustomerDel.Text = "УДАЛИТЬ";
            btnCustomerDel.UseVisualStyleBackColor = false;
            // 
            // btnCustomerSave
            // 
            btnCustomerSave.BackColor = Color.DodgerBlue;
            btnCustomerSave.FlatAppearance.BorderSize = 0;
            btnCustomerSave.FlatStyle = FlatStyle.Flat;
            btnCustomerSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomerSave.ForeColor = Color.White;
            btnCustomerSave.Location = new Point(440, 145);
            btnCustomerSave.Name = "btnCustomerSave";
            btnCustomerSave.Size = new Size(165, 47);
            btnCustomerSave.TabIndex = 9;
            btnCustomerSave.Text = "СОХРАНИТЬ";
            btnCustomerSave.UseVisualStyleBackColor = false;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.BackColor = Color.ForestGreen;
            btnCustomerAdd.FlatAppearance.BorderSize = 0;
            btnCustomerAdd.FlatStyle = FlatStyle.Flat;
            btnCustomerAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCustomerAdd.ForeColor = Color.White;
            btnCustomerAdd.Location = new Point(269, 145);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(165, 47);
            btnCustomerAdd.TabIndex = 8;
            btnCustomerAdd.Text = "ДОБАВИТЬ";
            btnCustomerAdd.UseVisualStyleBackColor = false;
            // 
            // tbCustomerTitle
            // 
            tbCustomerTitle.Location = new Point(186, 36);
            tbCustomerTitle.Name = "tbCustomerTitle";
            tbCustomerTitle.Size = new Size(761, 29);
            tbCustomerTitle.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 39);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 6;
            label6.Text = "Наименование:";
            // 
            // FormRefEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(tabControl1);
            Name = "FormRefEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование справочников";
            tabControl1.ResumeLayout(false);
            tabCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabCategory;
        private TabPage tabProducts;
        private TabPage tabCustomers;
        private DataGridView dataGridViewCategories;
        private Panel panel1;
        private Button btnCategoryAdd;
        private Button btnCategoryDel;
        private Button btnCategorySave;
        private TextBox tbCategoryTitle;
        private Label label1;
        private Button btnCategoryCancel;
        private Panel panel3;
        private Panel panel2;
        private Button btnProductCancel;
        private Button btnProductDel;
        private Button btnProductSave;
        private Button btnProductAdd;
        private Button btnFilterApply;
        private ComboBox cmbProductCategoryFilter;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button btnFilterCancel;
        private DataGridView dataGridViewProducts;
        private ComboBox cmbProductCategory;
        private TextBox tbProductTitle;
        private TextBox tbProductCode;
        private Label label5;
        private Panel panel4;
        private Button btnCustomerCancel;
        private Button btnCustomerDel;
        private Button btnCustomerSave;
        private Button btnCustomerAdd;
        private TextBox tbCustomerTitle;
        private Label label6;
        private DataGridView dataGridViewCustomers;
        private Button btnCustomersExport;
        private Button btnCustomersImport;
        private Button btnProductsExport;
        private Button btnProductsImport;
        private Button btnCategoriesExport;
        private Button btnCategoriesImport;
        private DataGridViewTextBoxColumn CustomerNumber;
        private DataGridViewTextBoxColumn CustomerTitle;
        private DataGridViewTextBoxColumn RowNumber;
        private DataGridViewTextBoxColumn CategoryTitle;
        private DataGridViewTextBoxColumn ProductNumber;
        private DataGridViewTextBoxColumn ProductCategory;
        private DataGridViewTextBoxColumn ProductTitle;
        private DataGridViewTextBoxColumn ProductCode;
    }
}
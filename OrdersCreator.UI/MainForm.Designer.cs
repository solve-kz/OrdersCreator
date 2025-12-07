namespace OrdersCreator.UI
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            категорииToolStripMenuItem = new ToolStripMenuItem();
            товарыToolStripMenuItem = new ToolStripMenuItem();
            контрагентыToolStripMenuItem = new ToolStripMenuItem();
            настройкаToolStripMenuItem = new ToolStripMenuItem();
            общиеНастройкиToolStripMenuItem = new ToolStripMenuItem();
            отчетыНастройкиToolStripMenuItem = new ToolStripMenuItem();
            хранилищеНастройкиToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            справкаF1ToolStripMenuItem = new ToolStripMenuItem();
            горячиеКлавишиToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            cmbCustomers = new ComboBox();
            lblCustomer = new Label();
            panel2 = new Panel();
            lblResults = new Label();
            btnCreateReport = new Button();
            btnCancel = new Button();
            panelMainBody = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewOrderLines = new DataGridView();
            panelLeftContainer = new Panel();
            panelGreenMode = new Panel();
            tlpGreenMode = new TableLayoutPanel();
            panelReady = new Panel();
            imgReady = new PictureBox();
            lblReady = new Label();
            panel4 = new Panel();
            lblCurrentWeight = new Label();
            lblCurrentTitle = new Label();
            panel5 = new Panel();
            lblCurrentCategory = new Label();
            panel3 = new Panel();
            lblCodeWeight = new Label();
            lblCodeAmount = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panelRedMode = new Panel();
            tlpRedMode = new TableLayoutPanel();
            panelRedHeader = new Panel();
            imgRedWarning = new PictureBox();
            label6 = new Label();
            panel6 = new Panel();
            tbNewProductWeight = new TextBox();
            label8 = new Label();
            tbNewProductCode = new TextBox();
            label7 = new Label();
            panel7 = new Panel();
            btnNewProductAdd = new Button();
            cbNewProductCategory = new ComboBox();
            label10 = new Label();
            tbNewProductTitle = new TextBox();
            label9 = new Label();
            RowNumber = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductTitle = new DataGridViewTextBoxColumn();
            ProductWeight = new DataGridViewTextBoxColumn();
            RowDelete = new DataGridViewButtonColumn();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelMainBody.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderLines).BeginInit();
            panelLeftContainer.SuspendLayout();
            panelGreenMode.SuspendLayout();
            tlpGreenMode.SuspendLayout();
            panelReady.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgReady).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panelRedMode.SuspendLayout();
            tlpRedMode.SuspendLayout();
            panelRedHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgRedWarning).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справочникиToolStripMenuItem, настройкаToolStripMenuItem, помощьToolStripMenuItem });
            menuStrip1.Location = new Point(5, 5);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1174, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Image = Properties.Resources.new_file;
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            создатьToolStripMenuItem.Size = new Size(172, 22);
            создатьToolStripMenuItem.Text = "Новый";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = Properties.Resources.open_document;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(172, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = Properties.Resources.save;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(172, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Image = Properties.Resources.window_close;
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            выходToolStripMenuItem.Size = new Size(172, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { категорииToolStripMenuItem, товарыToolStripMenuItem, контрагентыToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // категорииToolStripMenuItem
            // 
            категорииToolStripMenuItem.Image = Properties.Resources.categories;
            категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            категорииToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            категорииToolStripMenuItem.Size = new Size(218, 22);
            категорииToolStripMenuItem.Text = "Категории";
            // 
            // товарыToolStripMenuItem
            // 
            товарыToolStripMenuItem.Image = Properties.Resources.products;
            товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            товарыToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
            товарыToolStripMenuItem.Size = new Size(218, 22);
            товарыToolStripMenuItem.Text = "Товары";
            // 
            // контрагентыToolStripMenuItem
            // 
            контрагентыToolStripMenuItem.Image = Properties.Resources.customers;
            контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            контрагентыToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.K;
            контрагентыToolStripMenuItem.Size = new Size(218, 22);
            контрагентыToolStripMenuItem.Text = "Контрагенты";
            // 
            // настройкаToolStripMenuItem
            // 
            настройкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { общиеНастройкиToolStripMenuItem, отчетыНастройкиToolStripMenuItem, хранилищеНастройкиToolStripMenuItem });
            настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            настройкаToolStripMenuItem.Size = new Size(79, 20);
            настройкаToolStripMenuItem.Text = "Настройки";
            // 
            // общиеНастройкиToolStripMenuItem
            // 
            общиеНастройкиToolStripMenuItem.Name = "общиеНастройкиToolStripMenuItem";
            общиеНастройкиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.G;
            общиеНастройкиToolStripMenuItem.Size = new Size(214, 22);
            общиеНастройкиToolStripMenuItem.Text = "Общие";
            общиеНастройкиToolStripMenuItem.Click += ОбщиеНастройкиToolStripMenuItem_Click;
            // 
            // отчетыНастройкиToolStripMenuItem
            // 
            отчетыНастройкиToolStripMenuItem.Name = "отчетыНастройкиToolStripMenuItem";
            отчетыНастройкиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
            отчетыНастройкиToolStripMenuItem.Size = new Size(214, 22);
            отчетыНастройкиToolStripMenuItem.Text = "Пути и шаблоны";
            отчетыНастройкиToolStripMenuItem.Click += ОтчетыНастройкиToolStripMenuItem_Click;
            // 
            // хранилищеНастройкиToolStripMenuItem
            // 
            хранилищеНастройкиToolStripMenuItem.Name = "хранилищеНастройкиToolStripMenuItem";
            хранилищеНастройкиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
            хранилищеНастройкиToolStripMenuItem.Size = new Size(214, 22);
            хранилищеНастройкиToolStripMenuItem.Text = "Хранилище";
            хранилищеНастройкиToolStripMenuItem.Click += ХранилищеНастройкиToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { справкаF1ToolStripMenuItem, горячиеКлавишиToolStripMenuItem, оПрограммеToolStripMenuItem });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(68, 20);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справкаF1ToolStripMenuItem
            // 
            справкаF1ToolStripMenuItem.Name = "справкаF1ToolStripMenuItem";
            справкаF1ToolStripMenuItem.ShortcutKeys = Keys.F1;
            справкаF1ToolStripMenuItem.Size = new Size(173, 22);
            справкаF1ToolStripMenuItem.Text = "Справка";
            справкаF1ToolStripMenuItem.Click += справкаF1ToolStripMenuItem_Click;
            // 
            // горячиеКлавишиToolStripMenuItem
            //
            горячиеКлавишиToolStripMenuItem.Name = "горячиеКлавишиToolStripMenuItem";
            горячиеКлавишиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            горячиеКлавишиToolStripMenuItem.Size = new Size(173, 22);
            горячиеКлавишиToolStripMenuItem.Text = "Горячие клавиши";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(173, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // общиеНастройкиToolStripMenuItem
            // 
            общиеНастройкиToolStripMenuItem.Name = "общиеНастройкиToolStripMenuItem";
            общиеНастройкиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.G;
            общиеНастройкиToolStripMenuItem.Size = new Size(241, 22);
            общиеНастройкиToolStripMenuItem.Text = "Общие";
            общиеНастройкиToolStripMenuItem.Click += ОбщиеНастройкиToolStripMenuItem_Click;
            // 
            // отчетыНастройкиToolStripMenuItem
            // 
            отчетыНастройкиToolStripMenuItem.Name = "отчетыНастройкиToolStripMenuItem";
            отчетыНастройкиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
            отчетыНастройкиToolStripMenuItem.Size = new Size(241, 22);
            отчетыНастройкиToolStripMenuItem.Text = "Пути и шаблоны";
            отчетыНастройкиToolStripMenuItem.Click += ОтчетыНастройкиToolStripMenuItem_Click;
            // 
            // хранилищеНастройкиToolStripMenuItem
            // 
            хранилищеНастройкиToolStripMenuItem.Name = "хранилищеНастройкиToolStripMenuItem";
            хранилищеНастройкиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
            хранилищеНастройкиToolStripMenuItem.Size = new Size(241, 22);
            хранилищеНастройкиToolStripMenuItem.Text = "Хранилище";
            хранилищеНастройкиToolStripMenuItem.Click += ХранилищеНастройкиToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { справкаF1ToolStripMenuItem, горячиеКлавишиToolStripMenuItem, оПрограммеToolStripMenuItem });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(68, 20);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справкаF1ToolStripMenuItem
            // 
            справкаF1ToolStripMenuItem.Name = "справкаF1ToolStripMenuItem";
            справкаF1ToolStripMenuItem.ShortcutKeys = Keys.F1;
            справкаF1ToolStripMenuItem.Size = new Size(180, 22);
            справкаF1ToolStripMenuItem.Text = "Справка";
            справкаF1ToolStripMenuItem.Click += справкаF1ToolStripMenuItem_Click;
            // 
            // горячиеКлавишиToolStripMenuItem
            // 
            горячиеКлавишиToolStripMenuItem.Name = "горячиеКлавишиToolStripMenuItem";
            горячиеКлавишиToolStripMenuItem.Size = new Size(180, 22);
            горячиеКлавишиToolStripMenuItem.Text = "Горячие клавиши";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(180, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbCustomers);
            panel1.Controls.Add(lblCustomer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 60);
            panel1.TabIndex = 1;
            // 
            // cmbCustomers
            // 
            cmbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(134, 17);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(1028, 25);
            cmbCustomers.TabIndex = 1;
            cmbCustomers.SelectedValueChanged += cmbCustomers_SelectedValueChanged;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCustomer.Location = new Point(12, 17);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(107, 21);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Контрагент:";
            lblCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(lblResults);
            panel2.Controls.Add(btnCreateReport);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(5, 616);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 80);
            panel2.TabIndex = 2;
            // 
            // lblResults
            // 
            lblResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblResults.Location = new Point(731, 26);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(290, 30);
            lblResults.TabIndex = 2;
            lblResults.Text = "ИТОГО: 0 мест | 00,000 кг.";
            lblResults.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCreateReport
            // 
            btnCreateReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateReport.BackColor = Color.Green;
            btnCreateReport.FlatAppearance.BorderSize = 0;
            btnCreateReport.FlatStyle = FlatStyle.Flat;
            btnCreateReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateReport.ForeColor = Color.White;
            btnCreateReport.Location = new Point(176, 21);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(209, 35);
            btnCreateReport.TabIndex = 1;
            btnCreateReport.Text = "СОЗДАТЬ ОТЧЕТ (F12)";
            btnCreateReport.UseVisualStyleBackColor = false;
            btnCreateReport.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(14, 21);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 35);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "ОТМЕНА (DEL)";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            // 
            // panelMainBody
            // 
            panelMainBody.Controls.Add(tableLayoutPanel1);
            panelMainBody.Dock = DockStyle.Fill;
            panelMainBody.Location = new Point(5, 89);
            panelMainBody.Name = "panelMainBody";
            panelMainBody.Size = new Size(1174, 527);
            panelMainBody.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 480F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dataGridViewOrderLines, 1, 0);
            tableLayoutPanel1.Controls.Add(panelLeftContainer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1174, 527);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewOrderLines
            // 
            dataGridViewOrderLines.AllowUserToAddRows = false;
            dataGridViewOrderLines.AllowUserToResizeRows = false;
            dataGridViewOrderLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrderLines.BackgroundColor = Color.White;
            dataGridViewOrderLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderLines.Columns.AddRange(new DataGridViewColumn[] { RowNumber, ProductCode, ProductTitle, ProductWeight, RowDelete });
            dataGridViewOrderLines.Dock = DockStyle.Fill;
            dataGridViewOrderLines.Location = new Point(483, 3);
            dataGridViewOrderLines.MultiSelect = false;
            dataGridViewOrderLines.Name = "dataGridViewOrderLines";
            dataGridViewOrderLines.ReadOnly = true;
            dataGridViewOrderLines.RowHeadersVisible = false;
            dataGridViewOrderLines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderLines.Size = new Size(688, 521);
            dataGridViewOrderLines.TabIndex = 0;
            // 
            // RowNumber
            // 
            RowNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowNumber.HeaderText = "№";
            RowNumber.Name = "RowNumber";
            RowNumber.ReadOnly = true;
            RowNumber.Width = 48;
            // 
            // ProductCode
            // 
            ProductCode.FillWeight = 80F;
            ProductCode.HeaderText = "Код";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            // 
            // ProductTitle
            // 
            ProductTitle.FillWeight = 300F;
            ProductTitle.HeaderText = "Наименование";
            ProductTitle.MinimumWidth = 370;
            ProductTitle.Name = "ProductTitle";
            ProductTitle.ReadOnly = true;
            // 
            // ProductWeight
            // 
            ProductWeight.FillWeight = 80F;
            ProductWeight.HeaderText = "Вес";
            ProductWeight.Name = "ProductWeight";
            ProductWeight.ReadOnly = true;
            // 
            // RowDelete
            // 
            RowDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowDelete.HeaderText = "Удл.";
            RowDelete.Name = "RowDelete";
            RowDelete.ReadOnly = true;
            RowDelete.Width = 38;
            // 
            // panelLeftContainer
            // 
            panelLeftContainer.Controls.Add(panelGreenMode);
            panelLeftContainer.Controls.Add(panelRedMode);
            panelLeftContainer.Dock = DockStyle.Fill;
            panelLeftContainer.Location = new Point(3, 3);
            panelLeftContainer.Name = "panelLeftContainer";
            panelLeftContainer.Size = new Size(474, 521);
            panelLeftContainer.TabIndex = 1;
            // 
            // panelGreenMode
            // 
            panelGreenMode.BackColor = Color.ForestGreen;
            panelGreenMode.Controls.Add(tlpGreenMode);
            panelGreenMode.Dock = DockStyle.Fill;
            panelGreenMode.Location = new Point(0, 0);
            panelGreenMode.Name = "panelGreenMode";
            panelGreenMode.Padding = new Padding(10);
            panelGreenMode.Size = new Size(474, 521);
            panelGreenMode.TabIndex = 0;
            // 
            // tlpGreenMode
            // 
            tlpGreenMode.ColumnCount = 1;
            tlpGreenMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpGreenMode.Controls.Add(panelReady, 0, 0);
            tlpGreenMode.Controls.Add(panel4, 0, 1);
            tlpGreenMode.Controls.Add(panel3, 0, 2);
            tlpGreenMode.Dock = DockStyle.Fill;
            tlpGreenMode.Location = new Point(10, 10);
            tlpGreenMode.Name = "tlpGreenMode";
            tlpGreenMode.RowCount = 3;
            tlpGreenMode.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tlpGreenMode.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpGreenMode.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpGreenMode.Size = new Size(454, 501);
            tlpGreenMode.TabIndex = 5;
            // 
            // panelReady
            // 
            panelReady.BackColor = Color.Green;
            panelReady.Controls.Add(imgReady);
            panelReady.Controls.Add(lblReady);
            panelReady.Dock = DockStyle.Fill;
            panelReady.Location = new Point(3, 3);
            panelReady.Name = "panelReady";
            panelReady.Size = new Size(448, 68);
            panelReady.TabIndex = 4;
            // 
            // imgReady
            // 
            imgReady.Image = Properties.Resources.readyScan;
            imgReady.Location = new Point(43, 5);
            imgReady.Name = "imgReady";
            imgReady.Size = new Size(64, 64);
            imgReady.SizeMode = PictureBoxSizeMode.AutoSize;
            imgReady.TabIndex = 1;
            imgReady.TabStop = false;
            // 
            // lblReady
            // 
            lblReady.AutoSize = true;
            lblReady.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblReady.ForeColor = Color.White;
            lblReady.Location = new Point(141, 24);
            lblReady.Name = "lblReady";
            lblReady.Size = new Size(230, 25);
            lblReady.TabIndex = 0;
            lblReady.Text = "Выберите контрагента!";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGreen;
            panel4.Controls.Add(lblCurrentWeight);
            panel4.Controls.Add(lblCurrentTitle);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 164);
            panel4.TabIndex = 1;
            // 
            // lblCurrentWeight
            // 
            lblCurrentWeight.AutoSize = true;
            lblCurrentWeight.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCurrentWeight.ForeColor = Color.White;
            lblCurrentWeight.Location = new Point(269, 105);
            lblCurrentWeight.Name = "lblCurrentWeight";
            lblCurrentWeight.Size = new Size(123, 32);
            lblCurrentWeight.TabIndex = 1;
            lblCurrentWeight.Text = "00,000 кг";
            // 
            // lblCurrentTitle
            // 
            lblCurrentTitle.AutoSize = true;
            lblCurrentTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCurrentTitle.ForeColor = Color.White;
            lblCurrentTitle.Location = new Point(18, 22);
            lblCurrentTitle.MaximumSize = new Size(420, 0);
            lblCurrentTitle.Name = "lblCurrentTitle";
            lblCurrentTitle.Size = new Size(293, 25);
            lblCurrentTitle.TabIndex = 2;
            lblCurrentTitle.Text = "Наименование текущего товара";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblCurrentCategory);
            panel5.Location = new Point(18, 105);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 33);
            panel5.TabIndex = 3;
            panel5.Visible = false;
            // 
            // lblCurrentCategory
            // 
            lblCurrentCategory.AutoSize = true;
            lblCurrentCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCurrentCategory.ForeColor = Color.Green;
            lblCurrentCategory.Location = new Point(23, 4);
            lblCurrentCategory.Name = "lblCurrentCategory";
            lblCurrentCategory.Size = new Size(108, 25);
            lblCurrentCategory.TabIndex = 0;
            lblCurrentCategory.Text = "Категория";
            lblCurrentCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGreen;
            panel3.Controls.Add(lblCodeWeight);
            panel3.Controls.Add(lblCodeAmount);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 247);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 251);
            panel3.TabIndex = 0;
            // 
            // lblCodeWeight
            // 
            lblCodeWeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCodeWeight.AutoSize = true;
            lblCodeWeight.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCodeWeight.ForeColor = Color.White;
            lblCodeWeight.Location = new Point(140, 110);
            lblCodeWeight.Name = "lblCodeWeight";
            lblCodeWeight.Size = new Size(74, 86);
            lblCodeWeight.TabIndex = 4;
            lblCodeWeight.Text = "0";
            // 
            // lblCodeAmount
            // 
            lblCodeAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCodeAmount.AutoSize = true;
            lblCodeAmount.Font = new Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCodeAmount.ForeColor = Color.LightGray;
            lblCodeAmount.Location = new Point(149, 44);
            lblCodeAmount.Name = "lblCodeAmount";
            lblCodeAmount.Size = new Size(64, 74);
            lblCodeAmount.TabIndex = 3;
            lblCodeAmount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 162);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 2;
            label5.Text = "ВЕС:";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 79);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 1;
            label4.Text = "КОЛИЧЕСТВО:";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 21);
            label3.Name = "label3";
            label3.Size = new Size(264, 21);
            label3.TabIndex = 0;
            label3.Text = "ИТОГО ПО ВЫБРАННОМУ ТОВАРУ:";
            label3.Visible = false;
            // 
            // panelRedMode
            // 
            panelRedMode.BackColor = Color.LightCoral;
            panelRedMode.Controls.Add(tlpRedMode);
            panelRedMode.Dock = DockStyle.Fill;
            panelRedMode.Location = new Point(0, 0);
            panelRedMode.Name = "panelRedMode";
            panelRedMode.Padding = new Padding(10);
            panelRedMode.Size = new Size(474, 521);
            panelRedMode.TabIndex = 5;
            panelRedMode.Visible = false;
            // 
            // tlpRedMode
            // 
            tlpRedMode.ColumnCount = 1;
            tlpRedMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRedMode.Controls.Add(panelRedHeader, 0, 0);
            tlpRedMode.Controls.Add(panel6, 0, 1);
            tlpRedMode.Controls.Add(panel7, 0, 2);
            tlpRedMode.Dock = DockStyle.Fill;
            tlpRedMode.Location = new Point(10, 10);
            tlpRedMode.Name = "tlpRedMode";
            tlpRedMode.RowCount = 3;
            tlpRedMode.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tlpRedMode.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpRedMode.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpRedMode.Size = new Size(454, 501);
            tlpRedMode.TabIndex = 4;
            // 
            // panelRedHeader
            // 
            panelRedHeader.BackColor = Color.Red;
            panelRedHeader.Controls.Add(imgRedWarning);
            panelRedHeader.Controls.Add(label6);
            panelRedHeader.Dock = DockStyle.Fill;
            panelRedHeader.Location = new Point(3, 3);
            panelRedHeader.Name = "panelRedHeader";
            panelRedHeader.Size = new Size(448, 68);
            panelRedHeader.TabIndex = 0;
            // 
            // imgRedWarning
            // 
            imgRedWarning.Image = Properties.Resources.attention;
            imgRedWarning.Location = new Point(43, 5);
            imgRedWarning.Name = "imgRedWarning";
            imgRedWarning.Size = new Size(64, 64);
            imgRedWarning.SizeMode = PictureBoxSizeMode.AutoSize;
            imgRedWarning.TabIndex = 1;
            imgRedWarning.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(141, 24);
            label6.Name = "label6";
            label6.Size = new Size(265, 25);
            label6.TabIndex = 0;
            label6.Text = "ТОВАР НЕ НАЙДЕН В БАЗЕ!";
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Controls.Add(tbNewProductWeight);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(tbNewProductCode);
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Fill;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(3, 77);
            panel6.Name = "panel6";
            panel6.Size = new Size(448, 164);
            panel6.TabIndex = 1;
            // 
            // tbNewProductWeight
            // 
            tbNewProductWeight.BackColor = Color.LightCoral;
            tbNewProductWeight.BorderStyle = BorderStyle.FixedSingle;
            tbNewProductWeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbNewProductWeight.ForeColor = Color.White;
            tbNewProductWeight.Location = new Point(24, 122);
            tbNewProductWeight.Name = "tbNewProductWeight";
            tbNewProductWeight.ReadOnly = true;
            tbNewProductWeight.Size = new Size(356, 29);
            tbNewProductWeight.TabIndex = 3;
            tbNewProductWeight.Text = "00,000 кг.";
            tbNewProductWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(24, 95);
            label8.Name = "label8";
            label8.Size = new Size(136, 19);
            label8.TabIndex = 2;
            label8.Text = "Извлеченный вес:";
            // 
            // tbNewProductCode
            // 
            tbNewProductCode.BackColor = Color.LightCoral;
            tbNewProductCode.BorderStyle = BorderStyle.FixedSingle;
            tbNewProductCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbNewProductCode.ForeColor = Color.White;
            tbNewProductCode.Location = new Point(24, 48);
            tbNewProductCode.Name = "tbNewProductCode";
            tbNewProductCode.ReadOnly = true;
            tbNewProductCode.Size = new Size(356, 29);
            tbNewProductCode.TabIndex = 1;
            tbNewProductCode.Text = "000000000000";
            tbNewProductCode.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(24, 20);
            label7.Name = "label7";
            label7.Size = new Size(173, 19);
            label7.TabIndex = 0;
            label7.Text = "Считанный код товара:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Controls.Add(btnNewProductAdd);
            panel7.Controls.Add(cbNewProductCategory);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(tbNewProductTitle);
            panel7.Controls.Add(label9);
            panel7.Dock = DockStyle.Fill;
            panel7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(3, 247);
            panel7.Name = "panel7";
            panel7.Size = new Size(448, 251);
            panel7.TabIndex = 2;
            // 
            // btnNewProductAdd
            // 
            btnNewProductAdd.BackColor = Color.White;
            btnNewProductAdd.Cursor = Cursors.Hand;
            btnNewProductAdd.FlatAppearance.BorderSize = 0;
            btnNewProductAdd.FlatStyle = FlatStyle.Flat;
            btnNewProductAdd.ForeColor = Color.IndianRed;
            btnNewProductAdd.Location = new Point(24, 170);
            btnNewProductAdd.Name = "btnNewProductAdd";
            btnNewProductAdd.Size = new Size(356, 38);
            btnNewProductAdd.TabIndex = 4;
            btnNewProductAdd.Text = "ДОБАВИТЬ ТОВАР (ENTER)";
            btnNewProductAdd.UseVisualStyleBackColor = false;
            // 
            // cbNewProductCategory
            // 
            cbNewProductCategory.FormattingEnabled = true;
            cbNewProductCategory.Location = new Point(24, 122);
            cbNewProductCategory.Name = "cbNewProductCategory";
            cbNewProductCategory.Size = new Size(356, 29);
            cbNewProductCategory.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 94);
            label10.Name = "label10";
            label10.Size = new Size(181, 21);
            label10.TabIndex = 2;
            label10.Text = "Выберите категорию:";
            // 
            // tbNewProductTitle
            // 
            tbNewProductTitle.Location = new Point(24, 48);
            tbNewProductTitle.Name = "tbNewProductTitle";
            tbNewProductTitle.Size = new Size(356, 29);
            tbNewProductTitle.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 20);
            label9.Name = "label9";
            label9.Size = new Size(257, 21);
            label9.TabIndex = 0;
            label9.Text = "Введите наименование товара:";
            // 
            // RowNumber
            // 
            RowNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowNumber.HeaderText = "№";
            RowNumber.Name = "RowNumber";
            RowNumber.ReadOnly = true;
            RowNumber.Width = 48;
            // 
            // ProductCode
            // 
            ProductCode.FillWeight = 80F;
            ProductCode.HeaderText = "Код";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            // 
            // ProductTitle
            // 
            ProductTitle.FillWeight = 300F;
            ProductTitle.HeaderText = "Наименование";
            ProductTitle.MinimumWidth = 370;
            ProductTitle.Name = "ProductTitle";
            ProductTitle.ReadOnly = true;
            // 
            // ProductWeight
            // 
            ProductWeight.FillWeight = 80F;
            ProductWeight.HeaderText = "Вес";
            ProductWeight.Name = "ProductWeight";
            ProductWeight.ReadOnly = true;
            // 
            // RowDelete
            // 
            RowDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowDelete.HeaderText = "Удл.";
            RowDelete.Name = "RowDelete";
            RowDelete.ReadOnly = true;
            RowDelete.Width = 38;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 701);
            Controls.Add(panelMainBody);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = Properties.Resources.main_icon_white;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Складской Терминал v1.0";
            Load += MainForm_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMainBody.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderLines).EndInit();
            panelLeftContainer.ResumeLayout(false);
            panelGreenMode.ResumeLayout(false);
            tlpGreenMode.ResumeLayout(false);
            panelReady.ResumeLayout(false);
            panelReady.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgReady).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelRedMode.ResumeLayout(false);
            tlpRedMode.ResumeLayout(false);
            panelRedHeader.ResumeLayout(false);
            panelRedHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgRedWarning).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem настройкаToolStripMenuItem;
        private Panel panel1;
        private Label lblCustomer;
        private ComboBox cmbCustomers;
        private Panel panel2;
        private Panel panelMainBody;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewOrderLines;
        private Panel panelLeftContainer;
        private Panel panelGreenMode;
        private Panel panel3;
        private Panel panel4;
        private Label lblCurrentWeight;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblCodeAmount;
        private Label lblCodeWeight;
        private Label lblCurrentTitle;
        private Button btnCancel;
        private Button btnCreateReport;
        private Panel panelReady;
        private Panel panel5;
        private Label lblCurrentCategory;
        private Label lblReady;
        private Label lblResults;
        private Panel panelRedMode;
        private TableLayoutPanel tlpGreenMode;
        private TableLayoutPanel tlpRedMode;
        private Panel panelRedHeader;
        private PictureBox imgRedWarning;
        private Panel panel6;
        private Label label7;
        private Label label6;
        private TextBox tbNewProductWeight;
        private Label label8;
        private TextBox tbNewProductCode;
        private Panel panel7;
        private Label label9;
        private Button btnNewProductAdd;
        private ComboBox cbNewProductCategory;
        private Label label10;
        private TextBox tbNewProductTitle;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private PictureBox imgReady;
        private ToolStripMenuItem категорииToolStripMenuItem;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem контрагентыToolStripMenuItem;
        private ToolStripMenuItem общиеНастройкиToolStripMenuItem;
        private ToolStripMenuItem отчетыНастройкиToolStripMenuItem;
        private ToolStripMenuItem хранилищеНастройкиToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem справкаF1ToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem горячиеКлавишиToolStripMenuItem;
        private DataGridViewTextBoxColumn RowNumber;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductTitle;
        private DataGridViewTextBoxColumn ProductWeight;
        private DataGridViewButtonColumn RowDelete;
    }
}
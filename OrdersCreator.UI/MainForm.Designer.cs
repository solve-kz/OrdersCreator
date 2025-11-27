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
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            настройкаToolStripMenuItem = new ToolStripMenuItem();
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
            RowNumber = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductTitle = new DataGridViewTextBoxColumn();
            ProductWeight = new DataGridViewTextBoxColumn();
            RowDelete = new DataGridViewButtonColumn();
            panelLeftContainer = new Panel();
            panelGreenMode = new Panel();
            panelReady = new Panel();
            lblReady = new Label();
            panel5 = new Panel();
            lblCurrentCategory = new Label();
            lblCurrentTitle = new Label();
            panel4 = new Panel();
            lblCurrentWeight = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblCodeWeight = new Label();
            lblCodeAmount = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panelRedMode = new Panel();
            panel7 = new Panel();
            btnNewProductAdd = new Button();
            cbNewProductCategory = new ComboBox();
            label10 = new Label();
            tbNewProductTitle = new TextBox();
            label9 = new Label();
            panel6 = new Panel();
            tbNewProductWeight = new TextBox();
            label8 = new Label();
            tbNewProductCode = new TextBox();
            label7 = new Label();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelMainBody.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderLines).BeginInit();
            panelLeftContainer.SuspendLayout();
            panelGreenMode.SuspendLayout();
            panelReady.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelRedMode.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справочникиToolStripMenuItem, настройкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(180, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            справочникиToolStripMenuItem.Click += справочникиToolStripMenuItem_Click;
            // 
            // настройкаToolStripMenuItem
            // 
            настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            настройкаToolStripMenuItem.Size = new Size(78, 20);
            настройкаToolStripMenuItem.Text = "Настройка";
            настройкаToolStripMenuItem.Click += настройкаToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbCustomers);
            panel1.Controls.Add(lblCustomer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 60);
            panel1.TabIndex = 1;
            // 
            // cmbCustomers
            // 
            cmbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(134, 17);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(1038, 25);
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
            panel2.Location = new Point(0, 681);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 80);
            panel2.TabIndex = 2;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblResults.Location = new Point(371, 28);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(290, 30);
            lblResults.TabIndex = 2;
            lblResults.Text = "ИТОГО: 0 мест | 00,000 кг.";
            // 
            // btnCreateReport
            // 
            btnCreateReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateReport.BackColor = Color.Green;
            btnCreateReport.FlatAppearance.BorderSize = 0;
            btnCreateReport.FlatStyle = FlatStyle.Flat;
            btnCreateReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateReport.ForeColor = Color.White;
            btnCreateReport.Location = new Point(843, 16);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(301, 47);
            btnCreateReport.TabIndex = 1;
            btnCreateReport.Text = "СОЗДАТЬ ОТЧЕТ (F12)";
            btnCreateReport.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(32, 17);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 47);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "ОТМЕНА (DEL)";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // panelMainBody
            // 
            panelMainBody.Controls.Add(tableLayoutPanel1);
            panelMainBody.Dock = DockStyle.Fill;
            panelMainBody.Location = new Point(0, 84);
            panelMainBody.Name = "panelMainBody";
            panelMainBody.Size = new Size(1184, 597);
            panelMainBody.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(dataGridViewOrderLines, 1, 0);
            tableLayoutPanel1.Controls.Add(panelLeftContainer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1184, 597);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewOrderLines
            // 
            dataGridViewOrderLines.AllowUserToAddRows = false;
            dataGridViewOrderLines.BackgroundColor = Color.White;
            dataGridViewOrderLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderLines.Columns.AddRange(new DataGridViewColumn[] { RowNumber, ProductCode, ProductTitle, ProductWeight, RowDelete });
            dataGridViewOrderLines.Dock = DockStyle.Fill;
            dataGridViewOrderLines.Location = new Point(476, 3);
            dataGridViewOrderLines.MultiSelect = false;
            dataGridViewOrderLines.Name = "dataGridViewOrderLines";
            dataGridViewOrderLines.ReadOnly = true;
            dataGridViewOrderLines.RowHeadersVisible = false;
            dataGridViewOrderLines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderLines.Size = new Size(705, 591);
            dataGridViewOrderLines.TabIndex = 0;
            // 
            // RowNumber
            // 
            RowNumber.HeaderText = "№";
            RowNumber.Name = "RowNumber";
            RowNumber.ReadOnly = true;
            RowNumber.Width = 50;
            // 
            // ProductCode
            // 
            ProductCode.HeaderText = "Код";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            // 
            // ProductTitle
            // 
            ProductTitle.HeaderText = "Наименование";
            ProductTitle.Name = "ProductTitle";
            ProductTitle.ReadOnly = true;
            ProductTitle.Width = 390;
            // 
            // ProductWeight
            // 
            ProductWeight.HeaderText = "Вес";
            ProductWeight.Name = "ProductWeight";
            ProductWeight.ReadOnly = true;
            // 
            // RowDelete
            // 
            RowDelete.HeaderText = "Удл.";
            RowDelete.Name = "RowDelete";
            RowDelete.ReadOnly = true;
            RowDelete.Width = 50;
            // 
            // panelLeftContainer
            // 
            panelLeftContainer.Controls.Add(panelGreenMode);
            panelLeftContainer.Controls.Add(panelRedMode);
            panelLeftContainer.Dock = DockStyle.Fill;
            panelLeftContainer.Location = new Point(3, 3);
            panelLeftContainer.Name = "panelLeftContainer";
            panelLeftContainer.Size = new Size(467, 591);
            panelLeftContainer.TabIndex = 1;
            // 
            // panelGreenMode
            // 
            panelGreenMode.BackColor = Color.ForestGreen;
            panelGreenMode.Controls.Add(panelReady);
            panelGreenMode.Controls.Add(panel5);
            panelGreenMode.Controls.Add(lblCurrentTitle);
            panelGreenMode.Controls.Add(panel4);
            panelGreenMode.Controls.Add(label1);
            panelGreenMode.Controls.Add(panel3);
            panelGreenMode.Dock = DockStyle.Fill;
            panelGreenMode.Location = new Point(0, 0);
            panelGreenMode.Name = "panelGreenMode";
            panelGreenMode.Size = new Size(467, 591);
            panelGreenMode.TabIndex = 0;
            // 
            // panelReady
            // 
            panelReady.BackColor = Color.Green;
            panelReady.Controls.Add(lblReady);
            panelReady.Location = new Point(30, 16);
            panelReady.Name = "panelReady";
            panelReady.Size = new Size(409, 36);
            panelReady.TabIndex = 4;
            // 
            // lblReady
            // 
            lblReady.AutoSize = true;
            lblReady.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblReady.ForeColor = Color.White;
            lblReady.Location = new Point(92, 5);
            lblReady.Name = "lblReady";
            lblReady.Size = new Size(194, 21);
            lblReady.TabIndex = 0;
            lblReady.Text = "Выберите контрагента!";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblCurrentCategory);
            panel5.Location = new Point(30, 196);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 46);
            panel5.TabIndex = 3;
            // 
            // lblCurrentCategory
            // 
            lblCurrentCategory.AutoSize = true;
            lblCurrentCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCurrentCategory.ForeColor = Color.Green;
            lblCurrentCategory.Location = new Point(43, 10);
            lblCurrentCategory.Name = "lblCurrentCategory";
            lblCurrentCategory.Size = new Size(108, 25);
            lblCurrentCategory.TabIndex = 0;
            lblCurrentCategory.Text = "Категория";
            // 
            // lblCurrentTitle
            // 
            lblCurrentTitle.AutoSize = true;
            lblCurrentTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCurrentTitle.ForeColor = Color.White;
            lblCurrentTitle.Location = new Point(29, 98);
            lblCurrentTitle.Name = "lblCurrentTitle";
            lblCurrentTitle.Size = new Size(293, 25);
            lblCurrentTitle.TabIndex = 2;
            lblCurrentTitle.Text = "Наименование текущего товара";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.DarkGreen;
            panel4.Controls.Add(lblCurrentWeight);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(29, 261);
            panel4.Name = "panel4";
            panel4.Size = new Size(410, 137);
            panel4.TabIndex = 1;
            // 
            // lblCurrentWeight
            // 
            lblCurrentWeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentWeight.AutoSize = true;
            lblCurrentWeight.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCurrentWeight.ForeColor = Color.White;
            lblCurrentWeight.Location = new Point(112, 60);
            lblCurrentWeight.Name = "lblCurrentWeight";
            lblCurrentWeight.Size = new Size(166, 45);
            lblCurrentWeight.TabIndex = 1;
            lblCurrentWeight.Text = "00,000 кг";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(102, 18);
            label2.Name = "label2";
            label2.Size = new Size(195, 21);
            label2.TabIndex = 0;
            label2.Text = "ВЕС ТЕКУЩЕЙ ПОЗИЦИИ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 60);
            label1.Name = "label1";
            label1.Size = new Size(262, 21);
            label1.TabIndex = 1;
            label1.Text = "ПОСЛЕДНИЙ СЧИТАННЫЙ ТОВАР";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.DarkGreen;
            panel3.Controls.Add(lblCodeWeight);
            panel3.Controls.Add(lblCodeAmount);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(29, 421);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 137);
            panel3.TabIndex = 0;
            // 
            // lblCodeWeight
            // 
            lblCodeWeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCodeWeight.AutoSize = true;
            lblCodeWeight.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCodeWeight.ForeColor = Color.White;
            lblCodeWeight.Location = new Point(310, 81);
            lblCodeWeight.Name = "lblCodeWeight";
            lblCodeWeight.Size = new Size(26, 30);
            lblCodeWeight.TabIndex = 4;
            lblCodeWeight.Text = "0";
            // 
            // lblCodeAmount
            // 
            lblCodeAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCodeAmount.AutoSize = true;
            lblCodeAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCodeAmount.ForeColor = Color.White;
            lblCodeAmount.Location = new Point(310, 53);
            lblCodeAmount.Name = "lblCodeAmount";
            lblCodeAmount.Size = new Size(26, 30);
            lblCodeAmount.TabIndex = 3;
            lblCodeAmount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 88);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 2;
            label5.Text = "ВЕС:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 53);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 1;
            label4.Text = "КОЛИЧЕСТВО:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 13);
            label3.Name = "label3";
            label3.Size = new Size(194, 21);
            label3.TabIndex = 0;
            label3.Text = "ИТОГО ПО ЭТОМУ КОДУ:";
            // 
            // panelRedMode
            // 
            panelRedMode.BackColor = Color.LightCoral;
            panelRedMode.Controls.Add(panel7);
            panelRedMode.Controls.Add(panel6);
            panelRedMode.Controls.Add(label6);
            panelRedMode.Dock = DockStyle.Fill;
            panelRedMode.Location = new Point(0, 0);
            panelRedMode.Name = "panelRedMode";
            panelRedMode.Size = new Size(467, 591);
            panelRedMode.TabIndex = 5;
            panelRedMode.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Controls.Add(btnNewProductAdd);
            panel7.Controls.Add(cbNewProductCategory);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(tbNewProductTitle);
            panel7.Controls.Add(label9);
            panel7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(33, 303);
            panel7.Name = "panel7";
            panel7.Size = new Size(406, 255);
            panel7.TabIndex = 2;
            // 
            // btnNewProductAdd
            // 
            btnNewProductAdd.BackColor = Color.White;
            btnNewProductAdd.Cursor = Cursors.Hand;
            btnNewProductAdd.FlatAppearance.BorderSize = 0;
            btnNewProductAdd.FlatStyle = FlatStyle.Flat;
            btnNewProductAdd.ForeColor = Color.IndianRed;
            btnNewProductAdd.Location = new Point(24, 200);
            btnNewProductAdd.Name = "btnNewProductAdd";
            btnNewProductAdd.Size = new Size(356, 38);
            btnNewProductAdd.TabIndex = 4;
            btnNewProductAdd.Text = "ДОБАВИТЬ ТОВАР (ENTER)";
            btnNewProductAdd.UseVisualStyleBackColor = false;
            // 
            // cbNewProductCategory
            // 
            cbNewProductCategory.FormattingEnabled = true;
            cbNewProductCategory.Location = new Point(24, 149);
            cbNewProductCategory.Name = "cbNewProductCategory";
            cbNewProductCategory.Size = new Size(356, 29);
            cbNewProductCategory.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 113);
            label10.Name = "label10";
            label10.Size = new Size(181, 21);
            label10.TabIndex = 2;
            label10.Text = "Выберите категорию:";
            // 
            // tbNewProductTitle
            // 
            tbNewProductTitle.Location = new Point(24, 66);
            tbNewProductTitle.Name = "tbNewProductTitle";
            tbNewProductTitle.Size = new Size(356, 29);
            tbNewProductTitle.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 30);
            label9.Name = "label9";
            label9.Size = new Size(257, 21);
            label9.TabIndex = 0;
            label9.Text = "Введите наименование товара:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Controls.Add(tbNewProductWeight);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(tbNewProductCode);
            panel6.Controls.Add(label7);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(33, 88);
            panel6.Name = "panel6";
            panel6.Size = new Size(406, 167);
            panel6.TabIndex = 1;
            // 
            // tbNewProductWeight
            // 
            tbNewProductWeight.BackColor = Color.LightCoral;
            tbNewProductWeight.BorderStyle = BorderStyle.FixedSingle;
            tbNewProductWeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbNewProductWeight.ForeColor = Color.White;
            tbNewProductWeight.Location = new Point(24, 117);
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
            label8.Location = new Point(24, 86);
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
            tbNewProductCode.Location = new Point(24, 44);
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
            label7.Location = new Point(24, 14);
            label7.Name = "label7";
            label7.Size = new Size(173, 19);
            label7.TabIndex = 0;
            label7.Text = "Считанный код товара:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(71, 22);
            label6.Name = "label6";
            label6.Size = new Size(294, 30);
            label6.TabIndex = 0;
            label6.Text = "ТОВАР НЕ НАЙДЕН В БАЗЕ!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(panelMainBody);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Складской Терминал v1.0";
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
            panelGreenMode.PerformLayout();
            panelReady.ResumeLayout(false);
            panelReady.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelRedMode.ResumeLayout(false);
            panelRedMode.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Label label2;
        private Label label1;
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
        private DataGridViewTextBoxColumn RowNumber;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductTitle;
        private DataGridViewTextBoxColumn ProductWeight;
        private DataGridViewButtonColumn RowDelete;
    }
}
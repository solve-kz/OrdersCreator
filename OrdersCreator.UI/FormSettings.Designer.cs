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
            label1 = new Label();
            tbReportsRootFolder = new TextBox();
            label3 = new Label();
            btnReportsRootFolder = new Button();
            label2 = new Label();
            label4 = new Label();
            tbReportFileNameMask = new TextBox();
            btnReportTemplatePath = new Button();
            chbOpenReportAfterSave = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            numScannerCharTimeoutMs = new NumericUpDown();
            chbAllowManualBarcodeInput = new CheckBox();
            chbSoundsEnabled = new CheckBox();
            label7 = new Label();
            cmbUnknownProductMode = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            lblSqlServerConnectionString = new Label();
            cmbStorageType = new ComboBox();
            tbSqlServerConnectionString = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numScannerCharTimeoutMs).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // chbUseDailySubfolder
            // 
            chbUseDailySubfolder.AutoSize = true;
            chbUseDailySubfolder.Location = new Point(326, 111);
            chbUseDailySubfolder.Margin = new Padding(4);
            chbUseDailySubfolder.Name = "chbUseDailySubfolder";
            chbUseDailySubfolder.Size = new Size(233, 25);
            chbUseDailySubfolder.TabIndex = 4;
            chbUseDailySubfolder.Text = "Создавать подпапку с датой";
            chbUseDailySubfolder.UseVisualStyleBackColor = true;
            // 
            // tbReportTemplatePath
            // 
            tbReportTemplatePath.BorderStyle = BorderStyle.FixedSingle;
            tbReportTemplatePath.Location = new Point(326, 144);
            tbReportTemplatePath.Margin = new Padding(4);
            tbReportTemplatePath.Name = "tbReportTemplatePath";
            tbReportTemplatePath.Size = new Size(458, 29);
            tbReportTemplatePath.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.ForestGreen;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(793, 723);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(144, 43);
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
            btnCancel.Location = new Point(641, 723);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 43);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "ОТМЕНА";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(18, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 21);
            label1.TabIndex = 0;
            label1.Text = "Корневая папка для отчетов:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbReportsRootFolder
            // 
            tbReportsRootFolder.Anchor = AnchorStyles.Bottom;
            tbReportsRootFolder.BorderStyle = BorderStyle.FixedSingle;
            tbReportsRootFolder.Location = new Point(325, 72);
            tbReportsRootFolder.Margin = new Padding(4);
            tbReportsRootFolder.Name = "tbReportsRootFolder";
            tbReportsRootFolder.Size = new Size(458, 29);
            tbReportsRootFolder.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 0;
            label3.Text = "ОТЧЕТЫ ПО ЗАКАЗАМ";
            // 
            // btnReportsRootFolder
            // 
            btnReportsRootFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnReportsRootFolder.BackColor = Color.RoyalBlue;
            btnReportsRootFolder.FlatAppearance.BorderSize = 0;
            btnReportsRootFolder.FlatStyle = FlatStyle.Flat;
            btnReportsRootFolder.ForeColor = Color.White;
            btnReportsRootFolder.Location = new Point(792, 74);
            btnReportsRootFolder.Margin = new Padding(4);
            btnReportsRootFolder.Name = "btnReportsRootFolder";
            btnReportsRootFolder.Size = new Size(111, 27);
            btnReportsRootFolder.TabIndex = 11;
            btnReportsRootFolder.Text = "Выбрать";
            btnReportsRootFolder.UseVisualStyleBackColor = false;
            btnReportsRootFolder.Click += btnReportsRootFolder_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(17, 193);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 21);
            label2.TabIndex = 12;
            label2.Text = "Маска имени файла:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 146);
            label4.Name = "label4";
            label4.Size = new Size(161, 21);
            label4.TabIndex = 13;
            label4.Text = "Путь к .xlsx-шаблону:";
            // 
            // tbReportFileNameMask
            // 
            tbReportFileNameMask.Anchor = AnchorStyles.Bottom;
            tbReportFileNameMask.BorderStyle = BorderStyle.FixedSingle;
            tbReportFileNameMask.Location = new Point(325, 189);
            tbReportFileNameMask.Margin = new Padding(4);
            tbReportFileNameMask.Name = "tbReportFileNameMask";
            tbReportFileNameMask.Size = new Size(322, 29);
            tbReportFileNameMask.TabIndex = 14;
            // 
            // btnReportTemplatePath
            // 
            btnReportTemplatePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnReportTemplatePath.BackColor = Color.RoyalBlue;
            btnReportTemplatePath.FlatAppearance.BorderSize = 0;
            btnReportTemplatePath.FlatStyle = FlatStyle.Flat;
            btnReportTemplatePath.ForeColor = Color.White;
            btnReportTemplatePath.Location = new Point(792, 144);
            btnReportTemplatePath.Margin = new Padding(4);
            btnReportTemplatePath.Name = "btnReportTemplatePath";
            btnReportTemplatePath.Size = new Size(111, 27);
            btnReportTemplatePath.TabIndex = 15;
            btnReportTemplatePath.Text = "Выбрать";
            btnReportTemplatePath.UseVisualStyleBackColor = false;
            btnReportTemplatePath.Click += btnReportTemplatePath_Click;
            // 
            // chbOpenReportAfterSave
            // 
            chbOpenReportAfterSave.AutoSize = true;
            chbOpenReportAfterSave.Location = new Point(326, 228);
            chbOpenReportAfterSave.Margin = new Padding(4);
            chbOpenReportAfterSave.Name = "chbOpenReportAfterSave";
            chbOpenReportAfterSave.Size = new Size(283, 25);
            chbOpenReportAfterSave.TabIndex = 16;
            chbOpenReportAfterSave.Text = "Открывать отчет после сохранения";
            chbOpenReportAfterSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(17, 12);
            label5.Name = "label5";
            label5.Size = new Size(157, 21);
            label5.TabIndex = 17;
            label5.Text = "БЛОК ПОВЕДЕНИЯ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 66);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(301, 21);
            label6.TabIndex = 18;
            label6.Text = "Таймаут между символами сканера (мс):";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numScannerCharTimeoutMs
            // 
            numScannerCharTimeoutMs.Location = new Point(326, 64);
            numScannerCharTimeoutMs.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numScannerCharTimeoutMs.Name = "numScannerCharTimeoutMs";
            numScannerCharTimeoutMs.Size = new Size(120, 29);
            numScannerCharTimeoutMs.TabIndex = 19;
            // 
            // chbAllowManualBarcodeInput
            // 
            chbAllowManualBarcodeInput.AutoSize = true;
            chbAllowManualBarcodeInput.Location = new Point(326, 100);
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
            chbSoundsEnabled.Location = new Point(326, 133);
            chbSoundsEnabled.Margin = new Padding(4);
            chbSoundsEnabled.Name = "chbSoundsEnabled";
            chbSoundsEnabled.Size = new Size(144, 25);
            chbSoundsEnabled.TabIndex = 21;
            chbSoundsEnabled.Text = "Включить звуки";
            chbSoundsEnabled.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(21, 167);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(260, 21);
            label7.TabIndex = 22;
            label7.Text = "Действие при неизвестном товаре:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbUnknownProductMode
            // 
            cmbUnknownProductMode.FormattingEnabled = true;
            cmbUnknownProductMode.Items.AddRange(new object[] { "Запросить данные", "Показать ошибку" });
            cmbUnknownProductMode.Location = new Point(326, 165);
            cmbUnknownProductMode.Name = "cmbUnknownProductMode";
            cmbUnknownProductMode.Size = new Size(232, 29);
            cmbUnknownProductMode.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(16, 11);
            label8.Name = "label8";
            label8.Size = new Size(170, 21);
            label8.TabIndex = 24;
            label8.Text = "ХРАНЕНИЕ ДАННЫХ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(21, 65);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 21);
            label9.TabIndex = 25;
            label9.Text = "Тип хранилища:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSqlServerConnectionString
            // 
            lblSqlServerConnectionString.Anchor = AnchorStyles.None;
            lblSqlServerConnectionString.AutoSize = true;
            lblSqlServerConnectionString.Location = new Point(21, 119);
            lblSqlServerConnectionString.Margin = new Padding(4, 0, 4, 0);
            lblSqlServerConnectionString.Name = "lblSqlServerConnectionString";
            lblSqlServerConnectionString.Size = new Size(167, 21);
            lblSqlServerConnectionString.TabIndex = 26;
            lblSqlServerConnectionString.Text = "Строка подключения:";
            lblSqlServerConnectionString.TextAlign = ContentAlignment.MiddleCenter;
            lblSqlServerConnectionString.Visible = false;
            // 
            // cmbStorageType
            // 
            cmbStorageType.FormattingEnabled = true;
            cmbStorageType.Items.AddRange(new object[] { "В памяти", "SQLite", "SQLServer" });
            cmbStorageType.Location = new Point(326, 63);
            cmbStorageType.Name = "cmbStorageType";
            cmbStorageType.Size = new Size(232, 29);
            cmbStorageType.TabIndex = 27;
            cmbStorageType.SelectedIndexChanged += cmbStorageType_SelectedIndexChanged;
            // 
            // tbSqlServerConnectionString
            // 
            tbSqlServerConnectionString.BorderStyle = BorderStyle.FixedSingle;
            tbSqlServerConnectionString.Location = new Point(326, 117);
            tbSqlServerConnectionString.Margin = new Padding(4);
            tbSqlServerConnectionString.Name = "tbSqlServerConnectionString";
            tbSqlServerConnectionString.Size = new Size(577, 29);
            tbSqlServerConnectionString.TabIndex = 28;
            tbSqlServerConnectionString.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbReportsRootFolder);
            panel1.Controls.Add(btnReportsRootFolder);
            panel1.Controls.Add(chbUseDailySubfolder);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbReportTemplatePath);
            panel1.Controls.Add(btnReportTemplatePath);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chbOpenReportAfterSave);
            panel1.Controls.Add(tbReportFileNameMask);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 276);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 45);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(numScannerCharTimeoutMs);
            panel3.Controls.Add(chbAllowManualBarcodeInput);
            panel3.Controls.Add(chbSoundsEnabled);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmbUnknownProductMode);
            panel3.Location = new Point(12, 294);
            panel3.Name = "panel3";
            panel3.Size = new Size(925, 236);
            panel3.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(923, 45);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(cmbStorageType);
            panel5.Controls.Add(tbSqlServerConnectionString);
            panel5.Controls.Add(lblSqlServerConnectionString);
            panel5.Location = new Point(12, 536);
            panel5.Name = "panel5";
            panel5.Size = new Size(925, 180);
            panel5.TabIndex = 31;
            // 
            // panel6
            // 
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(923, 45);
            panel6.TabIndex = 0;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 775);
            ControlBox = false;
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)numScannerCharTimeoutMs).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox chbUseDailySubfolder;
        private TextBox tbReportTemplatePath;
        private Button btnOK;
        private Button btnCancel;
        private Label label3;
        private Label label1;
        private TextBox tbReportsRootFolder;
        private Button btnReportsRootFolder;
        private Label label2;
        private Label label4;
        private TextBox tbReportFileNameMask;
        private Button btnReportTemplatePath;
        private CheckBox chbOpenReportAfterSave;
        private Label label5;
        private Label label6;
        private NumericUpDown numScannerCharTimeoutMs;
        private CheckBox chbAllowManualBarcodeInput;
        private CheckBox chbSoundsEnabled;
        private Label label7;
        private ComboBox cmbUnknownProductMode;
        private Label label8;
        private Label label9;
        private Label lblSqlServerConnectionString;
        private ComboBox cmbStorageType;
        private TextBox tbSqlServerConnectionString;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
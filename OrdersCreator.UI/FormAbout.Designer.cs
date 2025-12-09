using System.Drawing;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    partial class FormAbout
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
            mainLayout = new TableLayoutPanel();
            leftLayout = new TableLayoutPanel();
            lblAbout = new Label();
            btnCheckUpdates = new Button();
            pbBarcode = new PictureBox();
            mainLayout.SuspendLayout();
            leftLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBarcode).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainLayout.Controls.Add(leftLayout, 0, 0);
            mainLayout.Controls.Add(pbBarcode, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(10, 10);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(644, 222);
            mainLayout.TabIndex = 0;
            // 
            // leftLayout
            // 
            leftLayout.ColumnCount = 1;
            leftLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftLayout.Controls.Add(lblAbout, 0, 0);
            leftLayout.Controls.Add(btnCheckUpdates, 0, 1);
            leftLayout.Dock = DockStyle.Fill;
            leftLayout.Location = new Point(3, 3);
            leftLayout.Name = "leftLayout";
            leftLayout.RowCount = 2;
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftLayout.RowStyles.Add(new RowStyle());
            leftLayout.Size = new Size(380, 216);
            leftLayout.TabIndex = 0;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Dock = DockStyle.Fill;
            lblAbout.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAbout.Location = new Point(3, 0);
            lblAbout.Margin = new Padding(3, 0, 3, 10);
            lblAbout.MaximumSize = new Size(380, 0);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(374, 152);
            lblAbout.TabIndex = 0;
            lblAbout.Text = "Складской терминал v1.1.0\n\nНазначение: работа со штрих-кодами и формирование отчётов по заказам.\n\nАвтор: Павел Приходько\n© 2025";
            // 
            // btnCheckUpdates
            // 
            btnCheckUpdates.BackColor = Color.RoyalBlue;
            btnCheckUpdates.Dock = DockStyle.Left;
            btnCheckUpdates.FlatAppearance.BorderSize = 0;
            btnCheckUpdates.FlatStyle = FlatStyle.Flat;
            btnCheckUpdates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCheckUpdates.ForeColor = Color.White;
            btnCheckUpdates.Location = new Point(3, 165);
            btnCheckUpdates.Margin = new Padding(3, 3, 3, 0);
            btnCheckUpdates.Name = "btnCheckUpdates";
            btnCheckUpdates.Size = new Size(190, 51);
            btnCheckUpdates.TabIndex = 1;
            btnCheckUpdates.Text = "Проверить обновления";
            btnCheckUpdates.UseVisualStyleBackColor = false;
            btnCheckUpdates.Click += btnCheckUpdates_Click;
            // 
            // pbBarcode
            // 
            pbBarcode.Dock = DockStyle.Fill;
            pbBarcode.Image = Properties.Resources.barcode_scanner;
            pbBarcode.Location = new Point(389, 3);
            pbBarcode.Name = "pbBarcode";
            pbBarcode.Size = new Size(252, 216);
            pbBarcode.SizeMode = PictureBoxSizeMode.Zoom;
            pbBarcode.TabIndex = 1;
            pbBarcode.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 242);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.icon_barcode_scanner_ico;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Padding = new Padding(10);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            mainLayout.ResumeLayout(false);
            leftLayout.ResumeLayout(false);
            leftLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBarcode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel leftLayout;
        private Label lblAbout;
        private Button btnCheckUpdates;
        private PictureBox pbBarcode;
    }
}

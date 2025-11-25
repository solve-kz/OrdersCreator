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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 72);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Путь к папке отчетов";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(111, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 138);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки штрих-кода";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(620, 69);
            button1.Name = "button1";
            button1.Size = new Size(38, 26);
            button1.TabIndex = 3;
            button1.Text = "…";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 37);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 0;
            label2.Text = "Общая длина штрих-кода:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(205, 29);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(103, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private NumericUpDown numericUpDown1;
    }
}
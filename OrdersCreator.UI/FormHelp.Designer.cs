namespace OrdersCreator.UI
{
    partial class FormHelp
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            flowLayoutPanelNavigation = new FlowLayoutPanel();
            btnHome = new Button();
            btnBack = new Button();
            btnForward = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            flowLayoutPanelNavigation.SuspendLayout();
            SuspendLayout();
            //
            // webView21
            //
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 48);
            webView21.Name = "webView21";
            webView21.Size = new Size(884, 513);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            //
            // flowLayoutPanelNavigation
            //
            flowLayoutPanelNavigation.AutoSize = true;
            flowLayoutPanelNavigation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelNavigation.Controls.Add(btnHome);
            flowLayoutPanelNavigation.Controls.Add(btnBack);
            flowLayoutPanelNavigation.Controls.Add(btnForward);
            flowLayoutPanelNavigation.Dock = DockStyle.Top;
            flowLayoutPanelNavigation.Location = new Point(0, 0);
            flowLayoutPanelNavigation.Name = "flowLayoutPanelNavigation";
            flowLayoutPanelNavigation.Padding = new Padding(8, 8, 0, 8);
            flowLayoutPanelNavigation.Size = new Size(884, 48);
            flowLayoutPanelNavigation.TabIndex = 0;
            //
            // btnHome
            //
            btnHome.AutoSize = true;
            btnHome.Location = new Point(8, 8);
            btnHome.Margin = new Padding(0, 0, 8, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(57, 31);
            btnHome.TabIndex = 0;
            btnHome.Text = "Домой";
            btnHome.UseVisualStyleBackColor = true;
            //
            // btnBack
            //
            btnBack.AutoSize = true;
            btnBack.Location = new Point(73, 8);
            btnBack.Margin = new Padding(0, 0, 8, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(62, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            //
            // btnForward
            //
            btnForward.AutoSize = true;
            btnForward.Location = new Point(143, 8);
            btnForward.Margin = new Padding(0, 0, 8, 0);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(70, 31);
            btnForward.TabIndex = 2;
            btnForward.Text = "Вперед";
            btnForward.UseVisualStyleBackColor = true;
            //
            // FormHelp
            //
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(webView21);
            Controls.Add(flowLayoutPanelNavigation);
            MinimizeBox = false;
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Справка";
            Load += HelpForm_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            flowLayoutPanelNavigation.ResumeLayout(false);
            flowLayoutPanelNavigation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private FlowLayoutPanel flowLayoutPanelNavigation;
        private Button btnHome;
        private Button btnBack;
        private Button btnForward;
    }
}
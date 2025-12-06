using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    public partial class FormHelp : Form
    {
        private readonly string _relativePage;
        private readonly string _helpRoot;

        public FormHelp(string relativePage = "index.html")
        {
            InitializeComponent();

            _relativePage = relativePage;
            _helpRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Help");
        }

        private async void HelpForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Инициализация движка WebView2
                await webView21.EnsureCoreWebView2Async(null);

                string pagePath = Path.Combine(_helpRoot, _relativePage);

                if (!File.Exists(pagePath))
                {
                    // Если указанной страницы нет — открываем индекс
                    pagePath = Path.Combine(_helpRoot, "index.html");
                }

                webView21.Source = new Uri(pagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "Не удалось открыть файл справки.\n\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }
    }

}

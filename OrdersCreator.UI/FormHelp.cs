using System;
using Microsoft.Web.WebView2.Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private const string DefaultHomePage = "index.html";

        public FormHelp(string relativePage = DefaultHomePage)
        {
            InitializeComponent();

            _relativePage = relativePage;
            _helpRoot = HelpDirectoryManager.HelpRoot;

            btnHome.Click += BtnHome_Click;
            btnBack.Click += BtnBack_Click;
            btnForward.Click += BtnForward_Click;
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
        }

        private async void HelpForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Инициализация движка WebView2
                await webView21.EnsureCoreWebView2Async(null);

                NavigateToPage(_relativePage);
                UpdateNavigationButtons();
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

        private void NavigateToPage(string relativePage)
        {
            string pagePath = Path.Combine(_helpRoot, relativePage);

            if (!File.Exists(pagePath))
            {
                // Если указанной страницы нет — открываем индекс
                pagePath = Path.Combine(_helpRoot, DefaultHomePage);
            }

            webView21.Source = new Uri(pagePath);
        }

        private void BtnHome_Click(object? sender, EventArgs e)
        {
            NavigateToPage(DefaultHomePage);
        }

        private void BtnBack_Click(object? sender, EventArgs e)
        {
            if (webView21.CoreWebView2?.CanGoBack == true)
            {
                webView21.CoreWebView2.GoBack();
            }
        }

        private void BtnForward_Click(object? sender, EventArgs e)
        {
            if (webView21.CoreWebView2?.CanGoForward == true)
            {
                webView21.CoreWebView2.GoForward();
            }
        }

        private void WebView21_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            var core = webView21.CoreWebView2;
            btnBack.Enabled = core?.CanGoBack ?? false;
            btnForward.Enabled = core?.CanGoForward ?? false;
        }
    }

}

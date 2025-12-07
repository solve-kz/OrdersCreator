using System;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            UpdateChecker.CheckForUpdates(true, this);
        }
    }
}

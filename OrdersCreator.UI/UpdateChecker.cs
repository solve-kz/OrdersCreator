using System;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace OrdersCreator.UI
{
    internal static class UpdateChecker
    {
        private const string UpdateUrl = "https://github.com/solve-kz/OrdersCreator/blob/main/update.xml";

        public static void CheckForUpdates(bool showErrors, IWin32Window? owner = null)
        {
            try
            {
                AutoUpdater.ReportErrors = showErrors;
                AutoUpdater.ShowSkipButton = false;
                AutoUpdater.ShowRemindLaterButton = false;
                AutoUpdater.Start(UpdateUrl);
            }
            catch (Exception ex)
            {
                if (showErrors)
                {
                    MessageBox.Show(owner,
                        ex.Message,
                        "Ошибка проверки обновлений",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}

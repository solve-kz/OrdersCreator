using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    internal static class ButtonCursorHelper
    {
        public static void ApplyHandCursor(Control root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            ApplyHandCursorToChildren(root);
        }

        private static void ApplyHandCursorToChildren(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.EnabledChanged -= Button_EnabledChanged;
                    button.EnabledChanged += Button_EnabledChanged;
                    UpdateButtonCursor(button);
                }

                if (control.HasChildren)
                {
                    ApplyHandCursorToChildren(control);
                }
            }
        }

        private static void Button_EnabledChanged(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                UpdateButtonCursor(button);
            }
        }

        private static void UpdateButtonCursor(Button button)
        {
            button.Cursor = button.Enabled ? Cursors.Hand : Cursors.Default;
        }
    }
}

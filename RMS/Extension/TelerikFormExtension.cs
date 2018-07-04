using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RMS.Extension
{
    public static class TelerikFormExtension
    {
        /// <summary>
        /// Show Telerik MessageBox
        /// ShowMessageBox(message, title, MessageBoxButtons.OKCancel, RadMessageIcon.Info);
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="btn"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static DialogResult ShowMessageBox(this RadForm radForm, string message, string title, MessageBoxButtons btn = MessageBoxButtons.OKCancel, RadMessageIcon icon = RadMessageIcon.None)
        {
            RadMessageBox.SetThemeName(radForm.ThemeName);
            RadMessageBox.Instance.MinimumSize = new Size(200, 150);
            RadMessageBox.Instance.Padding = new Padding(40);
            RadMessageBox.Instance.Font = new Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            return RadMessageBox.Show(message, title, btn, icon);
        }
    }
}

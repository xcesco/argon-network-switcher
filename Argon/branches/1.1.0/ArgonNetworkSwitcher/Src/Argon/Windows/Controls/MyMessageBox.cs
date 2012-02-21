using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Argon.Windows.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public static class MyMessageBox
    {
        /// <summary>
        /// Shows the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message,"Informartion",MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

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

        /// <summary>
        /// Asks the specified question.
        /// </summary>
        /// <param name="question">The question.</param>
        /// <returns></returns>
        public static bool Ask(string question)
        {
            MessageBoxResult result=MessageBox.Show(question, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}

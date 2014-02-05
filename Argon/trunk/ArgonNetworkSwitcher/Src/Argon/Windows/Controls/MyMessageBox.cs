using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
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
            MessageBox.Show(message,"Information",MessageBoxButton.OK, MessageBoxImage.Information);
        }
        
        /// <summary>
        /// Shows alert
        /// </summary>
        /// <param name="message">The message.</param>
        public static void ShowAlert(string message)
        {
            MessageBox.Show(message,"Alert",MessageBoxButton.OK, MessageBoxImage.Warning);
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

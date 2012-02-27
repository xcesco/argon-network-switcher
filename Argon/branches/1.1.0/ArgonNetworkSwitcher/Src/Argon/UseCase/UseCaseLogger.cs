using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Models;
using Argon.Common;

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
namespace Argon.UseCase
{
    public abstract class UseCaseLogger
    {
        public static void ClearMessages()
        {
        }

        /// <summary>
        /// Infoes the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public static void ShowInfo(string msg)
        {
            ShowMessage("INFO", msg);
        }

        /// <summary>
        /// Errors the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public static void ShowError(string msg)
        {
            ShowMessage("ERR", msg);            
        }

        /// <summary>
        /// Shows the message.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="msg">The MSG.</param>
        internal static void ShowMessage(string type, string msg)
        {
            string temp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - "+type.ToUpper()+"  - " + msg;
            ViewModel.ConsoleView.AddText(temp);
        }

        /// <summary>
        /// Called when [run status changed handler].
        /// </summary>
        /// <param name="profileSender">The profile sender.</param>
        /// <param name="e">The <see cref="Argon.Common.NotifyEventArgs"/> instance containing the event data.</param>
        public static void OnNotifyHandler(Object sender, NotifyEventArgs e)
        {
            if (!e.Error)
            {
                UseCaseLogger.ShowInfo(e.Description);
            }
            else
            {
                UseCaseLogger.ShowError(e.Description);

            }
        }

    }
}

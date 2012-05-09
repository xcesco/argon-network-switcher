using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Network.Profile;
using Argon.Models;
using System.Windows.Controls;
using Argon.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
using Argon.Windows.Network;
using Argon.Windows.Controls;
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
    /// <summary>
    /// 
    /// </summary>
    public static class UseCaseApplication
    {
  
        /// <summary>
        /// Loads the specified form main.
        /// </summary>
        /// <param name="formMain">The form main.</param>
        public static void Load(FormMain formMain)
        {
            Version curVersion = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;

            formMain.Text += " - " + curVersion.Major + "." + curVersion.Minor + "." + curVersion.Build;

            // default value
            DataModel.BlockAllOperation = false;
            DataModel.NetworkCardList = new List<WindowsNetworkCard>();
            DataModel.NetworkProfileList = new List<NetworkProfile>();

            // create other forms
            CreateForms(formMain);

            // display form
            DisplayFormsInDefaultPosition();
            
            UseCaseLogger.ShowInfo("Startup program");

            // set the event handler
            NetworkProfileHelper.NotifyEvent += UseCaseLogger.OnNotifyHandler;            

            // load the profiles
            UseCaseConfig.Load();

            // check autodetect
            if (Argon.Windows.Forms.Properties.Settings.Default.AutodetectOnStart)
            {
                UseCaseProfile.RunAutoDetect(false);
            }

            // check autodetect
            if (Argon.Windows.Forms.Properties.Settings.Default.CheckForUpdate)
            {
                // do not check info box if updated
                VerifyUpdate(false);
            }

            // check smart view
            if (Argon.Windows.Forms.Properties.Settings.Default.StartInSmartView)
            {
                UseCaseSmartView.ExecuteDisplaySmartView();
            }
           
        }

        /// <summary>
        /// Creates the forms.
        /// </summary>
        internal static void CreateForms(FormMain formMain)
        {
            // set the main window
            ViewModel.MainView = formMain;

            ViewModel.OptionsView = new FormOptions();
            ViewModel.ConsoleView = new FormConsole();

            ViewModel.ProfilesView = new FormProfiles();
            ViewModel.ProfileViewList = new List<FormProfile>();

            ViewModel.NetworkCardsView = new FormNetworkCards();
            ViewModel.NetworkCardViewList = new List<FormNetworkCard>();            
        }

        /// <summary>
        /// Displays the forms in default position.
        /// </summary>
        internal static void DisplayFormsInDefaultPosition()
        {
            WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel = ViewModel.MainView.dockPanel;

            // default position for nics form, profiles form and console form
            ViewModel.NetworkCardsView.Show(dockPanel);
            ViewModel.ProfilesView.Show(dockPanel);
            ViewModel.ConsoleView.Show(dockPanel);            

            UseCaseView.Display(ViewModel.NetworkCardsView, true, DockState.DockBottomAutoHide);            
            UseCaseView.Display(ViewModel.ConsoleView, true, DockState.DockBottomAutoHide);
            UseCaseView.Display(ViewModel.ProfilesView, true, DockState.DockLeft);          
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static System.Drawing.Image GetImage(string name)
        {
            return (System.Drawing.Image)Argon.Windows.Forms.Properties.Resources.ResourceManager.GetObject(name);  
        }


        /// <summary>
        /// Checks the is operation not allowed now.
        /// </summary>
        /// <returns></returns>
        public static bool CheckIsOperationNotAllowedNow()
        {
            // during profile application this operation is not allowed
            if (DataModel.BlockAllOperation)
            {
                MyMessageBox.ShowMessage("Now, this operation is not allowed!");
                return true;
            }

            return false;
        }


        /// <summary>
        /// Verifies the update.
        /// </summary>
        public static void VerifyUpdate(Boolean infoIfVersionUpdated=true)
        {
            string url = Argon.Windows.Forms.Properties.Settings.Default.CheckLastVersionUrl;
            CheckForUpdate.Verify(url, infoIfVersionUpdated);
        }
    }
}

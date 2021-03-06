﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.Models;
using Argon.Windows.Network.Profile;
using System.Drawing;
using System.ComponentModel;
using Argon.Windows.Network;
using Argon.Windows;
using Argon.Common;
using System.Diagnostics;
using Argon.Windows.Forms;
using BrightIdeasSoftware;
using System.Windows;
using Argon.Windows.Controls;

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
    public static class UseCaseProfile
    {
        public static string NEW_NIC_NAME = "NONE";

        /// <summary>
        /// Existses the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <returns></returns>
        public static bool Exists(NetworkProfile profile)
        {
            if (profile.Id >= DataModel.NetworkProfileList.Count) return false;
            NetworkProfile net = DataModel.NetworkProfileList[profile.Id];
            if (net == null) return false;
            return true;
        }

        /// <summary>
        /// Refreshes the specified refresh list view.
        /// </summary>
        /// <param name="refreshListView">if set to <c>true</c> [refresh list view].</param>
        public static void Refresh(bool refreshListView=true)
        {            
            RibbonButton rButton = null;            

            ViewModel.MainView.rbtnProfilesList.DropDownItems.Clear();
            ObjectListView listView = ViewModel.ProfilesView.listView;
             
            if (refreshListView)
            {
                listView.ClearObjects();

                // if last order is defined, we reset it
                if (listView.LastSortColumn != null)
                {
                    listView.LastSortOrder = SortOrder.None;
                    listView.LastSortColumn = null;                                       
                }
            }

            // can not  use context menu in windows form so we create it programmatically            
            NotifyIcon ni = ViewModel.MainView.notifyIcon;
            ContextMenuStrip cms = new ContextMenuStrip();
            //ToolStripMenuItem tsi = new ToolStripMenuItem("Open window", null, null, "mnuOpenWindow");
            //cms.Items.Add(tsi);
            ToolStripMenuItem tsi;
            ni.ContextMenuStrip = cms;

            // if there are no profile define, no separator.
            if (DataModel.NetworkProfileList.Count > 0)
            {
                tsi = new ToolStripMenuItem("Run Autodetect");
                tsi.Click += new System.EventHandler(ViewModel.MainView.rbtnProfileAutorun_Click);
                cms.Items.Add(tsi);

                ToolStripSeparator tss = new ToolStripSeparator();
                cms.Items.Add(tss);
            }
            

            foreach (NetworkProfile item in DataModel.NetworkProfileList)
            {
                // 1 - refresh the profileView   
                if (refreshListView)
                {
                    listView.AddObject(item);
                }

                // 2 - refresh the ribbonPanel in mainView            
                rButton = new RibbonButton();
                
                rButton.Text = item.Name;
                rButton.ToolTip = item.Name;
                rButton.ToolTipTitle = item.Name;
              
                rButton.SmallImage = UseCaseApplication.GetImage(item.ImageName);
                rButton.Tag = item;
                //rButton.Image = global::Argon.Windows.Forms.Properties.Resources.profile_0_48x48;
                rButton.Image = UseCaseApplication.GetImage(item.ImageName);
                //rButton.SmallImage = UseCaseApplication.GetImage(item.ImageName);
                rButton.Click += new System.EventHandler(ViewModel.MainView.btnRunProfile_Click);

                ViewModel.MainView.rbtnProfilesList.DropDownItems.Add(rButton);

                tsi = new ToolStripMenuItem("Run "+item.Name, UseCaseApplication.GetImage(item.ImageName));
                tsi.Click += new System.EventHandler(ViewModel.MainView.btnRunProfile_Click);
                cms.Items.Add(tsi);
           }

            // if there are no profile define, no separator.
            if (DataModel.NetworkProfileList.Count > 0)
            {
                ToolStripSeparator tss = new ToolStripSeparator();
                cms.Items.Add(tss);
            }

            tsi = new ToolStripMenuItem("Close program");
            tsi.Click += new System.EventHandler(ViewModel.MainView.btnClose_Click);
            cms.Items.Add(tsi);
            

            // bug on ribbon: if i don't do it, buttons are not display untill change tab
            ViewModel.MainView.Width += 1;
            ViewModel.MainView.Width -= -1;
        }
   

        /// <summary>
        /// Saves the current profile.
        /// </summary>
        public static void SaveProfile(NetworkProfile profile = null)
        {
            if (profile == null)
            {
                FormProfile viewProfile = ViewModel.SelectedView as FormProfile;

                if (viewProfile == null)
                {
                    MyMessageBox.ShowMessage("No profile selected!");
                    return;
                }

                // check if it is possibile do operation
                if (UseCaseApplication.CheckIsOperationNotAllowedNow()) return;


                viewProfile.StoreFormOnData();
                profile = viewProfile.Profile;
            }
            if (profile.IsNew)
            {
                profile.Id = CreateNewProfileId();
                // if not exist add it
                DataModel.NetworkProfileList.Add(profile);
            }
            else
            {
                // save profile
                for (int i = 0; i < DataModel.NetworkProfileList.Count; i++)
                {
                    if (profile.Id == DataModel.NetworkProfileList[i].Id)
                    {
                        // found e replace
                        DataModel.NetworkProfileList[i] = profile;
                        break;
                    }
                }
            }
            // list refresh
            Refresh();
        }


        /// <summary>
        /// Creates the new profile id.
        /// </summary>
        /// <returns></returns>
        internal static int CreateNewProfileId()
        {
            int max = 0;
            foreach (NetworkProfile item in DataModel.NetworkProfileList)
            {
                if (item.Id > max)
                {
                    max = item.Id;
                }
            }

            max++;

            return max;
        }

        /// <summary>
        /// Shows the specified profile. Set the profile as selectedProfile
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void Show(NetworkProfile profile)
        {
            // set the selected profile in model            
            if (SelectProfile(profile))
            {
                // selected the current ribbon
                ViewModel.MainView.ribbon.ActiveTab = ViewModel.MainView.rtOperations;
                ViewModel.MainView.rpProfile.Selected = true;

                // show
                Debug.WriteLine("Show profile " + profile.Name);
                UseCaseView.ShowProfile(profile);
            }
        }

        /// <summary>
        /// Called when [run status changed handler].
        /// </summary>
        /// <param name="profileSender">The profile sender.</param>
        /// <param name="e">The <see cref="Argon.Common.NotifyEventArgs"/> instance containing the event data.</param>
        public static void OnRunStatusChangedHandler(Object profileSender, NotifyEventArgs e)
        {            
            UseCaseLogger.ShowInfo(e.Description);
            ViewModel.MainView.backgroundWorker.ReportProgress(e.Percentage);
        }


        /// <summary>
        /// Runs the autodetect.
        /// </summary>
        /// <returns></returns>
        public static void RunAutoDetect(bool ask=true)
        {
            if (ask && MyMessageBox.Ask("Run profile automatic detect?"))
            {                
                ViewModel.MainView.backgroundWorker.RunWorkerAsync(null);
            }
            else if (!ask)
            {
                ViewModel.MainView.backgroundWorker.RunWorkerAsync(null);
            }            
        }

        /// <summary>
        /// Applies the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <param name="worker">The worker.</param>
        /// <param name="runOnlyDeviceConfig">if set to <c>true</c> [run only device config].</param>
        public static void Run(NetworkProfile profile, BackgroundWorker worker = null, bool runDeviceConfig = true)
        {

            if (profile == null) return;

            profile.RunStatusChangeEvent += OnRunStatusChangedHandler;

            try
            {
                DataModel.BlockAllOperation = true;
                profile.Run(runDeviceConfig);
            }
            finally
            {
                profile.RunStatusChangeEvent -= OnRunStatusChangedHandler;
                DataModel.BlockAllOperation = false;
            }
        }

        public static void ShowCurrent()
        {
            NetworkProfile current = DataModel.SelectedNetworkProfile;
            Show(current);
        }

        /// <summary>
        /// Selects the profile.
        /// </summary>
        /// <param name="networkProfile">The network profile.</param>
        public static bool SelectProfile(NetworkProfile networkProfile)
        {
            if (networkProfile == null)
            {
                MyMessageBox.ShowMessage("No profile selected!");
                return false;
            }
            DataModel.SelectedNetworkProfile = networkProfile;
            Debug.WriteLine("Selected profile " + networkProfile.Name);

            return true;
        }

        /// <summary>
        /// Deletes the profile.
        /// </summary>
        public static void DeleteProfile(NetworkProfile profile = null)
        {
            if (profile == null)
            {
                profile = DataModel.SelectedNetworkProfile;

                if (profile == null)
                {
                    MyMessageBox.ShowMessage("No profile selected!");
                    return;
                }
                
            }

            // check if it is possibile to do operation
            if (UseCaseApplication.CheckIsOperationNotAllowedNow()) return;            

            bool res = MyMessageBox.Ask("Do you want to delete profile " + profile.Name + "?");
            if (res)
            {
                UseCaseLogger.ShowInfo("Remove profile [" + profile.Name + "]");
                DataModel.NetworkProfileList.Remove(profile);
                DataModel.SelectedNetworkProfile = null;
                UseCaseView.FindAndCloseProfile(profile);
                UseCaseProfile.Refresh();
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="formProfile">The form profile.</param>
        public static void Hide(FormProfile formProfile)
        {
            DataModel.SelectedNetworkProfile = null;
            ViewModel.ProfileViewList.Remove(formProfile);
        }

        /// <summary>
        /// Duplicates the profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void DuplicateProfile(NetworkProfile profile)
        {
            // check if it is possibile to do operation
            if (UseCaseApplication.CheckIsOperationNotAllowedNow()) return; 

            NetworkProfile newProfile = new NetworkProfile();
            newProfile = NetworkProfile.Copy(profile);

            newProfile.Id = UseCaseProfile.CreateNewProfileId();
            newProfile.Name = "Copy of " + newProfile.Name;

            DataModel.NetworkProfileList.Add(newProfile);

            Refresh();
        }

        /// <summary>
        /// Runs current profile.
        /// </summary>
        public static void Run()
        {
            // check if it is possibile to do operation
            if (UseCaseApplication.CheckIsOperationNotAllowedNow()) return; 

            if (DataModel.SelectedNetworkProfile == null)
            {
                MyMessageBox.ShowMessage("No profile selected!");
                return;
            }           

            if (MyMessageBox.Ask("Do you want to run the profile " + DataModel.SelectedNetworkProfile.Name + "?"))
            {
                ViewModel.MainView.backgroundWorker.RunWorkerAsync(DataModel.SelectedNetworkProfile);
            }
        }


        /// <summary>
        /// Moves up. It's possible reorder profiles during autodetect
        /// </summary>
        public static void MoveUp()
        {
            if (DataModel.SelectedNetworkProfile == null)
            {
                MyMessageBox.ShowMessage("No profile selected!");
                return;
            }
            else
            {
                int index = DataModel.NetworkProfileList.IndexOf(DataModel.SelectedNetworkProfile);

                if (index < 0)
                {
                    MyMessageBox.ShowMessage("Error during profile selection!");
                }
                else if (index == 0)
                {
                    MyMessageBox.ShowMessage("Profile is already first element!");
                } else 
                {
                    int indexPrev = index - 1;

                    NetworkProfile temp = DataModel.SelectedNetworkProfile;
                    DataModel.NetworkProfileList[index] = DataModel.NetworkProfileList[indexPrev];
                    DataModel.NetworkProfileList[indexPrev] = temp;

                    Refresh();
                }
            }
        }

        /// <summary>
        /// Moves down. It's possible reorder profiles during autodetect
        /// </summary>
        public static void MoveDown()
        {
            if (DataModel.SelectedNetworkProfile == null)
            {
                MyMessageBox.ShowMessage("No profile selected!");
                return;
            }
            else
            {
                int index = DataModel.NetworkProfileList.IndexOf(DataModel.SelectedNetworkProfile);

                if (index < 0)
                {
                    MyMessageBox.ShowMessage("Error during profile selection!");
                }
                else if (index == DataModel.NetworkProfileList.Count-1)
                {
                    MyMessageBox.ShowMessage("Profile is already last element!");
                }
                else
                {
                    int indexPrev = index + 1;

                    NetworkProfile temp = DataModel.SelectedNetworkProfile;
                    DataModel.NetworkProfileList[index] = DataModel.NetworkProfileList[indexPrev];
                    DataModel.NetworkProfileList[indexPrev] = temp;

                    Refresh();
                }
            }
        }
    }
}

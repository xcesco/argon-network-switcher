using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Models;
using Argon.Windows.Network;
using BrightIdeasSoftware;
using Argon.Windows.Forms;
using Argon.UseCase;
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
    public static class UseCaseNetworkCard
    {
        /// <summary>
        /// Selects the network card.
        /// </summary>
        /// <param name="card">The card.</param>
        public static void SelectNetworkCard(WindowsNetworkCard card)
        {
            DataModel.SelectedNetworkCard = card;
            UseCaseLogger.ShowInfo("Selected network card " + card.Name);
        }

        /// <summary>
        /// Enables the network card.
        /// </summary>
        public static void EnableNetworkCard()
        {
            if (DataModel.SelectedNetworkCard == null){
                MyMessageBox.ShowMessage("No network card selected!");
                return;
            }

            // check if it is possibile to do operation
            if (UseCaseApplication.CheckIsOperationNotAllowedNow()) return; 

            if (MyMessageBox.Ask("Do you want to enable network card " + DataModel.SelectedNetworkCard.Name + "?"))
            {
                SetStatusCard(true);
            }
        }

        /// <summary>
        /// Sets the status card.
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        private static void SetStatusCard(bool enabled)
        {            
                WindowsNetworkCard ni = DataModel.SelectedNetworkCard;

                if (ni!=null && ni.HardwareName.Length > 0)
                {
                    String label = enabled ? "Enabled" : "Disabled";

                    bool status = WindowsNetworkCardHelper.SetDeviceStatus(ni, enabled);
                    UseCaseLogger.ShowInfo(label + " Network Card " + ni.HardwareName + " (" + status + ")");

                    RefreshNetworkCardListStatus();
                }         
        }

        /// <summary>
        /// Disables the network card.
        /// </summary>
        public static void DisableNetworkCard()
        {
            if (DataModel.SelectedNetworkCard == null)
            {
                MyMessageBox.ShowMessage("No network card selected!");
                return;
            }

            // check if it is possibile to do operation
            if (UseCaseApplication.CheckIsOperationNotAllowedNow()) return; 

            if (MyMessageBox.Ask("Do you want to disable network card " + DataModel.SelectedNetworkCard.Name + "?"))
            {
                SetStatusCard(false);
            }
        }

        /// <summary>
        /// Refreshes all network card status.
        /// </summary>
        public static void RefreshNetworkCardListStatus()
        {
            // refresh the card list in data model
            DataModel.NetworkCardList = WindowsNetworkCardManager.WindowsNetworkCardList;
            UseCaseLogger.ShowInfo("Refresh network card list status");

            // put datamodel list in listview
            ObjectListView listView = ViewModel.NetworkCardsView.listView;            
            listView.ClearObjects();
            listView.AddObjects(DataModel.NetworkCardList);

            // refresh list in every window profile form
            foreach(FormProfile item in ViewModel.ProfileViewList)
            {
                item.RefreshNetworkAdapter();
                // TODO fix me
               // item.ipControl.RefreshWifiCombo();
            }
        }

        /// <summary>
        /// Shows the selected network card.
        /// </summary>
        public static void ShowSelectedNetworkCard()
        {
            if (DataModel.SelectedNetworkCard == null)
            {
                MyMessageBox.ShowMessage("No network card selected!");
                return;
            }
            Show(DataModel.SelectedNetworkCard);
        }

        /// <summary>
        /// Visualizza una schermata con le informazioni relative ad una scheda di rete.
        /// Nel caso in cui tale finestra sia già presente, viene semplicemente
        /// messa in primo piano.
        /// </summary>
        /// <param name="nic"></param>
        public static void Show(WindowsNetworkCard nic)
        {
            if (nic == null) return;
            WindowsNetworkCard temp;

            foreach (FormNetworkCard form in ViewModel.NetworkCardViewList)
            {
                if ((form.Tag is WindowsNetworkCard))
                {
                    temp = (WindowsNetworkCard)form.Tag;

                    if (temp.Id.Equals(nic.Id))
                    {
                        form.TabText = "Network card " + nic.ViewId;
                        form.Text = "Network card " + nic.ViewId;

                        if (!form.Visible)
                        {
                            form.Show(ViewModel.MainView.Pannello);
                            UseCaseView.ActivateFormNetworkCard(form);
                        }

                        form.Focus();
                        return;
                    }
                }
            }

            FormNetworkCard formApp = new FormNetworkCard();

            // Visualizziamo le informazioni relative alla card            
            formApp.Tag = nic;

            //formApp.TabText = "NIC " + nic.ViewId;
            //formApp.Text = "NIC " + nic.ViewId;

            ViewModel.NetworkCardViewList.Add(formApp);
            formApp.Show(ViewModel.MainView.Pannello);
            //formApp.DockState = DockState.Document;
            //formApp.Show();

            formApp.TabText = "Network Card " + nic.ViewId;
            UseCaseView.ActivateFormNetworkCard(formApp);
        }
    }
}

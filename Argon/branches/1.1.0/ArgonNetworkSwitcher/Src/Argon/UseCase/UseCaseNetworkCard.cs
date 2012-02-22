using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Models;
using Argon.Windows.Network;
using BrightIdeasSoftware;
using Argon.Windows.Forms;
using Argon.UseCase;

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
            SetStatusCard(true);
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
            SetStatusCard(false);
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
            }
        }

        /// <summary>
        /// Shows the selected network card.
        /// </summary>
        public static void ShowSelectedNetworkCard()
        {
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

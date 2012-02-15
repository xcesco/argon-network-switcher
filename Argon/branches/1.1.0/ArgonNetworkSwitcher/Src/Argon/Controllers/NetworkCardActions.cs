using System;
using System.Collections.Generic;
using System.Text;
using Argon.Windows;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Windows.Forms;
using Argon.Controllers;
using BrightIdeasSoftware;
using Argon.Windows.Network;
using Argon.UseCase;
using Argon.Models;

namespace Argon.Controllers
{
    public abstract class NetworkCardActions : BaseActions
    {
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
                        form.TabText = "NIC " + nic.ViewId;
                        form.Text = "NIC " + nic.ViewId;

                        if (!form.Visible)
                        {
                            form.Show(ViewModel.MainView.Pannello);
                            Controller.Instance.ActivateFormNetworkCard(form);
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

            formApp.TabText = "NIC " + nic.ViewId;
            Controller.Instance.ActivateFormNetworkCard(formApp);
        }

        /// <summary>
        /// Show a network card
        /// </summary>
        public static void ShowNetworkCard()
        {
            ObjectListView list = ViewModel.NetworkCardsView.listView;
            if (list.SelectedItems.Count > 0)
            {
                WindowsNetworkCard ni = (WindowsNetworkCard)list.SelectedObject;

                NetworkCardActions.Show(ni);
            }
            
        }

        /// <summary>
        /// Shows all.
        /// </summary>
        public static void ShowAll()
        {
            ViewModel.MainView.rbtnViewNetworkCards.Checked = true;
            DisplayForm(ViewModel.NetworkCardsView);

            ViewModel.NetworkCardsView.Focus();
        }

        /// <summary>
        /// Reload the adapters status in form.
        /// </summary>
        public static void RefreshAll()
        {
            Controller.Instance.ActionRefreshNetworkAdapters();
        }

        /// <summary>
        /// Hides all.
        /// </summary>
        public static void HideAll()
        {
            ViewModel.MainView.rbtnViewNetworkCards.Checked = false;
            DisplayForm(ViewModel.NetworkCardsView);
        }


        /// <summary>
        /// Enables the network card.
        /// </summary>
        public static void EnableNetworkCard()
        {
            SetStatusCard(true);
        }

        protected static void SetStatusCard(bool enabled)
        {
            ObjectListView list = ViewModel.ProfilesView.listView;
            if (list.SelectedItems.Count > 0)
            {
                WindowsNetworkCard ni = (WindowsNetworkCard)list.SelectedObject;

                if (ni.HardwareName.Length > 0)
                {                    
                    String label=enabled?"Enabled":"Disabled";

                    bool status = WindowsNetworkCardHelper.SetDeviceStatus(ni, enabled);
                    UseCaseLogger.ShowInfo(label + " NIC " + ni.HardwareName + " (" + status + ")");

                    RefreshAll();                    
                }
            }    
        }

        /// <summary>
        /// Disables the network card.
        /// </summary>
        public static void DisableNetworkCard()
        {
            SetStatusCard(false);
        }
    }
}

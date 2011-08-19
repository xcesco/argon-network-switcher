using System;
using System.Collections.Generic;
using System.Text;
using Argon.OperatingSystem;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Windows.Forms;
using Argon.Controllers;
using BrightIdeasSoftware;
using Argon.Hardware;
using Argon.Network;

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

            foreach (FormCardInfo form in Controller.Instance.View.ListViewCardInfo)
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
                            form.Show(Controller.Instance.View.ViewMain.Pannello);
                            Controller.Instance.ActivateFormNetworkCard(form);
                        }

                        form.Focus();
                        return;
                    }
                }
            }

            FormCardInfo formApp = new FormCardInfo();

            // Visualizziamo le informazioni relative alla card            

            formApp.Tag = nic;

            //formApp.TabText = "NIC " + nic.ViewId;
            //formApp.Text = "NIC " + nic.ViewId;

            Controller.Instance.View.ListViewCardInfo.Add(formApp);
            formApp.Show(Controller.Instance.View.ViewMain.Pannello);
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
            ObjectListView list = Controller.Instance.View.ViewAdapters.listView;
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
            Controller.Instance.View.ViewMain.mnuViewNetworkAdapters.CheckState = CheckState.Checked;
            DisplayForm(Controller.Instance.View.ViewAdapters);

            Controller.Instance.View.ViewAdapters.Focus();
        }

        /// <summary>
        /// Reload the adapters status in form.
        /// </summary>
        public static void RefreshAll()
        {
            Controller.Instance.ActionRefreshNetworkAdapters(Controller.Instance.View.ViewAdapters.listView);
        }

        /// <summary>
        /// Hides all.
        /// </summary>
        public static void HideAll()
        {
            Controller.Instance.View.ViewMain.mnuViewNetworkAdapters.CheckState = CheckState.Unchecked;
            DisplayForm(Controller.Instance.View.ViewAdapters);
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
            ObjectListView list = Controller.Instance.View.ViewAdapters.listView;
            if (list.SelectedItems.Count > 0)
            {
                WindowsNetworkCard ni = (WindowsNetworkCard)list.SelectedObject;

                if (ni.HardwareName.Length > 0)
                {
                    HardwareLibrary hl = new HardwareLibrary();
                    String label=enabled?"Enabled":"Disabled";

                    bool status = hl.SetDeviceState(ni.Id, enabled);
                    Controller.Instance.ConsoleController.Info(label+" NIC " + ni.HardwareName + " (" + status + ")");

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

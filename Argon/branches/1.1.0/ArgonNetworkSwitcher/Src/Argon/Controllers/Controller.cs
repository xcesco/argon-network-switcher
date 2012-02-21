using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;
using System.Xml;
using Argon.Windows;
using System.IO;
using System.ComponentModel;
using Argon.Windows.Forms;
using Argon.Windows.Network.Profile;
using BrightIdeasSoftware;
using Argon.Windows.Network;
using Argon.UseCase;
using Argon.Models;


namespace Argon.Controllers
{
    public class Controller
    {                             

        protected Controller()
        {            

            // Initialize the controllers
            _consoleController = new ConsoleMiniController(this);
            
            _profileController = new ProfileMiniController(this);
            
        }

        private ProfileMiniController _profileController;

        public ProfileMiniController ProfileController
        {
            get { return _profileController; }
            set { _profileController = value; }
        }


        protected ConsoleMiniController _consoleController;

        public ConsoleMiniController ConsoleController
        {
            get { return _consoleController; }
            set { _consoleController = value; }
        }
   

        protected static Controller _instance;

        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Controller();
                }
                return _instance;
            }
        }


        /// <summary>
        /// Aggiorna la lista dei NIC presenti sulla macchina
        /// </summary>
        public List<WindowsNetworkCard> ActionRefreshNetworkAdapters(ComboBox comboBox)
        {
            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.WindowsNetworkCardList;

            comboBox.Items.Clear();
            comboBox.Items.Add("NONE");

            foreach (WindowsNetworkCard item in lista)
            {
                string tempName = item.ViewId + " " + item.Name;

                comboBox.Items.Add(tempName);
            }

            comboBox.SelectedIndex = 0;

            return lista;
        }

        




        /// <summary>
        /// Handles the Click event of the Profile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        ///         
        public void Profile_Click(object sender, EventArgs e)
        {
            NetworkProfile profile = null;
            if (sender is Control || sender is ToolStripItem || sender is NetworkProfile)
            {
                if (sender is Control)
                {
                    profile = (NetworkProfile)(((Control)sender).Tag);
                }
                else if (sender is ToolStripItem)
                {
                    profile = (NetworkProfile)(((ToolStripItem)sender).Tag);
                }
                else
                {
                    profile = (NetworkProfile)sender;
                }

                if (profile == null)
                {
                    MessageBox.Show(ViewModel.MainView, "Problem during the profile invocation (No tag found)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
            {
                MessageBox.Show(ViewModel.MainView, "Problem during the profile invocation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (ViewModel.MainView.backgroundWorker.IsBusy)
            {
                MessageBox.Show(ViewModel.MainView, "Please wait, the program is already applying a profile", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            DialogResult res = MessageBox.Show(ViewModel.MainView, "Do you want to apply profile " + profile.Name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (res == DialogResult.Yes)
            {
                ViewModel.MainView.backgroundWorker.RunWorkerAsync(profile);
            }

        }

    }
}

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
        /// Creates the new profile id.
        /// </summary>
        /// <returns></returns>
        public int CreateNewProfileId()
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
        /// Actions the save profile.
        /// </summary>
        /// <param name="viewProfile">The view profile.</param>
        public void ActionSaveProfile(FormProfile viewProfile)
        {
            NetworkProfile profile = (NetworkProfile)viewProfile.Tag;
            if (profile.IsNew && !UseCaseProfile.Exists(profile))
            {
                profile.Id = CreateNewProfileId();
                // dobbiamo aggiungerlo, ma solo se non esiste
                DataModel.NetworkProfileList.Add(profile);
            }
            // Facciamo il refresh dell'elenco dei profili
            ActionRefreshProfiles();
        }

        /// <summary>
        /// Refresh profiles
        /// </summary>
        public void ActionRefreshProfiles()
        {
            RibbonPanel rp = ViewModel.MainView.rpProfilesCollection;
            RibbonItemCollection rpc = rp.Items;
            RibbonButton rButton=null;

            rpc.Clear();
            // Lista dei profili nell'apposita finestra
            ViewModel.ProfilesView.listView.ClearObjects();

            foreach (NetworkProfile item in DataModel.NetworkProfileList)
            {
                ViewModel.ProfilesView.listView.AddObject(item);
                
                rButton=new RibbonButton();

                rButton.Text=item.Name;
                rButton.Tag=item;
                rButton.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
                rButton.Click += new System.EventHandler(ViewModel.MainView.btnRunProfile_Click);
                    // create in ribbon panel
                rpc.Add(rButton);
            }

            
           
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

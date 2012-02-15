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
        
        public void ActivateFormNetworkCard(FormNetworkCard selectedNetworkCardForm)
        {
            // profili
            ViewModel.MainView.rbtnProfileNew.Enabled = false;
            ViewModel.MainView.rbtnProfileView.Enabled = false;
            ViewModel.MainView.rbtnProfileDelete.Enabled = false;

            // profilo
            ViewModel.MainView.rbtnProfileRun.Enabled = false;
            ViewModel.MainView.rbtnProfileSave.Enabled = false;

            // documento
            ViewModel.MainView.rbtnConfigSave.Enabled = false;
            ViewModel.MainView.rbtnConfigLoad.Enabled = false;

            // networkcard
            ViewModel.MainView.rbtnCardsRefresh.Enabled = false;
            ViewModel.MainView.rbtnCardView.Enabled = false;

            // form selezionati            
            ViewModel.SelectedView = selectedNetworkCardForm;
        }
        
        public void ActivateFormProfile(FormProfile currentFormProfile)
        {            
            UseCaseView.Display(currentFormProfile);            

            // form selezionati
            ViewModel.SelectedView = currentFormProfile;            
        }

        public void ActivateFormProfiles()
        {
            FormMain main = ViewModel.MainView;

            UseCaseView.Display(ViewModel.ProfilesView);

            // form selezionati
            ViewModel.SelectedView = ViewModel.ProfilesView;            
        }

        public void ActivateFormCards()
        {
            FormMain main = ViewModel.MainView;
            
         
            // form selezionati
            ViewModel.SelectedView = ViewModel.NetworkCardsView;            
        }

        public static string NO_NIC_NAME = "NONE";


        protected Controller()
        {            

            // Initialize the controllers
            _consoleController = new ConsoleMiniController(this);
            
            _profileController = new ProfileMiniController(this);

            _model = new NetworkConfiguration();

            _model.SelectProfileEvent += Controller_SelectProfile;
        }

        private NetworkConfiguration _model;

        public NetworkConfiguration Model
        {
            get { return _model; }
            set { _model = value; }
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
            List<WindowsNetworkCard> lista = Controller.Instance.Model.GetNetworkAdapters();

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
        /// Aggiorna la lista dei NIC presenti sulla macchina
        /// </summary>
        public void ActionRefreshNetworkAdapters()
        {
            ObjectListView listView=ViewModel.NetworkCardsView.listView;
            List<WindowsNetworkCard> lista = _model.GetNetworkAdapters();
            listView.ClearObjects();
            listView.AddObjects(lista);
        }


        /// <summary>
        /// Creates the new profile id.
        /// </summary>
        /// <returns></returns>
        public int CreateNewProfileId()
        {
            int max = 0;
            foreach (NetworkProfile item in _model.Profiles)
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
        /// Existses the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <returns></returns>
        public bool Exists(NetworkProfile profile)
        {
            NetworkProfile net = _model.Profiles[profile.Id];
            if (net == null) return false;
            return true;
        }

        /// <summary>
        /// Actions the save profile.
        /// </summary>
        /// <param name="viewProfile">The view profile.</param>
        public void ActionSaveProfile(FormProfile viewProfile)
        {
            NetworkProfile profile = (NetworkProfile)viewProfile.Tag;
            if (profile.IsNew && !Exists(profile))
            {
                profile.Id = CreateNewProfileId();
                // dobbiamo aggiungerlo, ma solo se non esiste
                _model.AddProfile(profile);
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
           
            foreach (NetworkProfile item in _model.Profiles)
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

        #region Events

        /// <summary>
        /// Controller_s the select profile.
        /// </summary>
        /// <param name="objectsender">The objectsender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        public void Controller_SelectProfile(NetworkProfile objectsender, EventArgs e)
        {
            if (objectsender != null)
            {
                UseCaseLogger.ShowInfo("Selected profile [" + objectsender.Name + "]");                
            }
        }

        #endregion

    }
}

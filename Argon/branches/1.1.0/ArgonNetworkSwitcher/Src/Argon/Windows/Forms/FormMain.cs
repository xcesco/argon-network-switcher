using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using System.Threading;
using Argon.Windows.Network.Profile;
using Argon.Common;
using System.Configuration;
using Argon.UseCase;
using Argon.Models;

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
namespace Argon.Windows.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            _DeserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
        }

        private DeserializeDockContent _DeserializeDockContent;

        /// <summary>
        /// Handles the Load event of the FormMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            UseCaseApplication.Load(this);
        }

        /// <summary>
        /// Handles the FormClosing event of the FormMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");

            dockPanel.SaveAsXml(configFile);

            DialogResult ret = MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ret == DialogResult.Yes)
            {
                UseCaseConfig.Save();
                return;
            }
            else
            {
                // bug fix: if user says no the windows does not close
                e.Cancel = true;
            }
        }


        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FormNetworkCards).ToString())
            {
                ViewModel.NetworkCardsView.Show(dockPanel);
                return ViewModel.NetworkCardsView;
            }

            if (persistString == typeof(FormProfiles).ToString())
            {
                ViewModel.ProfilesView.Show(dockPanel);
                return ViewModel.ProfilesView;
            }
            /*
            if (persistString == typeof(FormActionBean).ToString())
            {
                m_ProjectController.EventOpenCloseForm(m_FormActionBean);
                return m_FormActionBean;
            }
            else if (persistString == typeof(FormWorkflow).ToString())
            {
                m_ProjectController.EventOpenCloseForm(m_FormWorkflow);
                return m_FormWorkflow;
            }
            else if (persistString == typeof(FormProject).ToString())
            {
                m_ProjectController.EventOpenCloseForm(m_FormProject);
                return m_FormProject;
            }
            else if (persistString == typeof(FormDao).ToString())
            {
                m_ProjectController.EventOpenCloseForm(m_FormDao);
                return m_FormDao;
            }
            else if (persistString == typeof(FormBusinessLogic).ToString())
            {
                m_ProjectController.EventOpenCloseForm(m_FormBusinessLogic);
                return m_FormBusinessLogic;
            }
            else
            {
                return null;
                */
            return null;
        }

        private void mnuViewNetworkAdapters_Click(object sender, EventArgs e)
        {
            UseCaseView.ToggleDisplay(ViewModel.NetworkCardsView);
        }



        /// <summary>
        /// Handles the Click event of the saveToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Controller.Instance.PersistenceController.Save();
        }

        /// <summary>
        /// Handles the DoWork event of the backgroundWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool runDeviceConfig = true;
            NetworkProfile profile = (NetworkProfile)e.Argument;
            if (profile == null)
            {
                // autodetect
                profile = NetworkProfileHelper.AutoDetectNetworkProfile(DataModel.NetworkProfileList);
                runDeviceConfig = false;
            }

            if (profile != null)
            {
                UseCaseProfile.Run(profile, backgroundWorker, runDeviceConfig);
            }

            e.Result = profile;
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the backgroundWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NetworkProfile profile = (NetworkProfile)e.Result;
            lblStatus.Text = "Completed";
            if (profile != null)
            {
                MessageBox.Show("Applied profile " + profile.Name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No profile applyed!!! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            lblStatus.Text = "Ready";
            progressBar.Value = 0;
        }

        /// <summary>
        /// Handles the ProgressChanged event of the backgroundWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.ProgressChangedEventArgs"/> instance containing the event data.</param>
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Working.. " + e.ProgressPercentage + "%";
            progressBar.Value = e.ProgressPercentage;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            // this.WindowState = FormWindowState.Normal;

            this.WindowState = FormWindowState.Normal;
            this.Width = 400;
            this.Height = 400;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnProfileNew_Click(object sender, EventArgs e)
        {
            UseCaseView.ShowNewProfile();
        }

        private void btnProfileSave_Click(object sender, EventArgs e)
        {
            //Controller.Instance.PersistenceController.Save();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            UseCaseProfile.ShowCurrent();
        }

        private void btnAllProfileLoad_Click(object sender, EventArgs e)
        {
            //Controller.Instance.PersistenceController.Load();

            UseCaseProfile.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the btnAllCardsRefresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnAllCardsRefresh_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.RefreshNetworkCardListStatus();
        }

        /// <summary>
        /// Handles the Click event of the btnCardView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCardView_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.ShowSelectedNetworkCard();
        }


        /// <summary>
        /// Handles the Click event of the btnProfileRefresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnProfileRefresh_Click(object sender, EventArgs e)
        {
            UseCaseProfile.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the btnProfileDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnProfileDelete_Click(object sender, EventArgs e)
        {
            UseCaseProfile.DeleteProfile();
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            // this.WindowState = FormWindowState.Normal;

            this.WindowState = FormWindowState.Normal;
            this.Width = 400;
            this.Height = 400;

            this.Visible = true;
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {

        }


        private void mnuViewConsole_Click(object sender, EventArgs e)
        {
            UseCaseView.ToggleDisplay(ViewModel.ConsoleView);
        }

        /// <summary>
        /// 
        /// See https://sourceforge.net/projects/dockpanelsuite/forums/forum/402316/topic/4482610
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dockPanel_SizeChanged(object sender, EventArgs e)
        {
            if (this.Handle != null)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    base.OnSizeChanged(e);
                });
            }
        }


        private void rbtnViewProfiles_Click(object sender, EventArgs e)
        {
            UseCaseView.ToggleDisplay(ViewModel.ProfilesView);
        }



        /// <summary>
        /// Handles the Click event of the btnRunProfile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        public void btnRunProfile_Click(object sender, EventArgs e)
        {
            DataModel.SelectedNetworkProfile = (NetworkProfile)(((RibbonButton)sender)).Tag;
            UseCaseProfile.Run();
        }

        /// <summary>
        /// Handles the Click event of the rbtnSmartView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnSmartView_Click(object sender, EventArgs e)
        {
            UseCaseSmartView.ExecuteToggleSmartView();
        }

        /// <summary>
        /// Gets or sets the old size.
        /// </summary>
        /// <value>
        /// The old size.
        /// </value>
        public Size OldSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [smart view].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [smart view]; otherwise, <c>false</c>.
        /// </value>
        public bool SmartView { get; set; }

        /// <summary>
        /// Handles the Click event of the btnConfigLoad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnConfigLoad_Click(object sender, EventArgs e)
        {
            UseCaseConfig.Load(showDialog: true);
        }

        /// <summary>
        /// Handles the Click event of the rbtnConfigSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnConfigSave_Click(object sender, EventArgs e)
        {
            UseCaseConfig.Save(showDialog: true);
        }

        /// <summary>
        /// Handles the Click event of the rbtnHelpDonate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnHelpDonate_Click(object sender, EventArgs e)
        {
            FormDonate form = new FormDonate();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Handles the Click event of the rbtnHelpUpdate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnHelpUpdate_Click(object sender, EventArgs e)
        {
            string url = "http://argon-network-switcher.googlecode.com/files/checkLastVersion.xml"; //ConfigurationManager.AppSettings.Get("updateUrl");            
            CheckForUpdate.Verify(url);
        }

        /// <summary>
        /// Handles the Click event of the rbtnHelpAbout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnHelpAbout_Click(object sender, EventArgs e)
        {
            FormAboutBox ab = new FormAboutBox();
            /*ab.AppTitle = txtTitle.Text;
            ab.AppDescription = txtDescription.Text;
            ab.AppVersion = txtVersion.Text;
            ab.AppCopyright = txtCopyright.Text;
            ab.AppMoreInfo = txtMoreInfo.Text;
            ab.AppDetailsButton = chkDetails.Checked;*/

            string app = "";
            app += "Visit http://argonswitcher.sourceforge.net for updates!" + Environment.NewLine;

            ab.AppMoreInfo = app;

            ab.ShowDialog(this);
        }

        /// <summary>
        /// Handles the Click event of the rbtnProfileRun control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnProfileRun_Click(object sender, EventArgs e)
        {            
            UseCaseProfile.Run();
        }

        /// <summary>
        /// Handles the Click event of the rbtnCardsRefresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnCardsRefresh_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.RefreshNetworkCardListStatus();
        }

        /// <summary>
        /// Handles the Click event of the rbtnCardView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnCardView_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.ShowSelectedNetworkCard();
        }

        private void rbtnProfileSave_Click(object sender, EventArgs e)
        {
            UseCaseProfile.SaveProfile();
        }

        /// <summary>
        /// Handles the Click event of the rbtnConsoleRefresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnConsoleRefresh_Click(object sender, EventArgs e)
        {
            UseCaseView.ClearConsole();
        }

        private void rbtnCardEnable_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.EnableNetworkCard();
        }

        /// <summary>
        /// Handles the Click event of the rbtnCardDisable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnCardDisable_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.DisableNetworkCard();
        }

        /// <summary>
        /// Handles the Click event of the rbtnProfileAutorun control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbtnProfileAutorun_Click(object sender, EventArgs e)
        {
            UseCaseProfile.RunAutoDetect();               
        }


    }
}

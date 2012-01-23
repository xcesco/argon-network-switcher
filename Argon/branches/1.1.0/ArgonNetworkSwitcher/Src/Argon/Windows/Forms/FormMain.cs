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
using Argon.Controllers;
using Argon.Model;
using Argon.Common;
using System.Configuration;

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");

            /*
            if (File.Exists(configFile))
            {
                dockPanel.LoadFromXml(configFile, _DeserializeDockContent);
            }
            else*/
            {                
                Controller.Instance.View.ViewAdapters.Show(dockPanel);
                Controller.Instance.View.ViewAdapters.DockState = DockState.DockBottomAutoHide;
                //Controller.Instance.View.ViewAdapters.IsHidden = true;
                Controller.Instance.View.ViewProfiles.Show(dockPanel);
                Controller.Instance.View.ViewProfiles.DockState = DockState.Document;
                Controller.Instance.View.ViewConsole.Show(dockPanel);
                Controller.Instance.View.ViewConsole.DockState = DockState.DockBottomAutoHide;

                rbtnViewNICs.Checked = true;
                rbtnViewConsole.Checked = true;                
            }

            
            Controller.Instance.Init();
            Controller.Instance.ConsoleController.Info("Startup program");
            /*
            if (Controller.Instance.ViewAdapters.DockState != DockState.Hidden && Controller.Instance.ViewAdapters.DockState != DockState.Unknown)
            {
                mnuViewNetworkAdapters.Checked = true;
            }

            if (Controller.Instance.ViewProfiles.DockState != DockState.Hidden && Controller.Instance.ViewProfiles.DockState != DockState.Unknown)
            {
                mnuViewProfiles.Checked = true;
            }*/

            Controller.Instance.PersistenceController.Load();
            Controller.Instance.ActionRefreshProfiles();
            
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
                Controller.Instance.PersistenceController.Save();
                return;
            } else {
                // bug fix: if user says no the windows does not close
                e.Cancel = true;
            }
            /*
            if (!Visible)
                return;

            DialogResult ret=MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ret == DialogResult.Yes)
                return;                

            
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }*/
           
        }


        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FormAdapters).ToString())
            {
                Controller.Instance.View.ViewAdapters.Show(dockPanel);
                return Controller.Instance.View.ViewAdapters;
            }

            if (persistString == typeof(FormProfiles).ToString())
            {
                Controller.Instance.View.ViewProfiles.Show(dockPanel);
                return Controller.Instance.View.ViewProfiles;
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
            if (!rbtnViewNICs.Checked)
            {
                Controller.Instance.View.ViewAdapters.Show();
            }
            else
            {
                Controller.Instance.View.ViewAdapters.Hide();
            }
        }

 

        /// <summary>
        /// Handles the Click event of the saveToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.Instance.PersistenceController.Save();
        }

        /// <summary>
        /// Handles the DoWork event of the backgroundWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {           
            NetworkProfileActions.Apply((NetworkProfile)e.Argument, backgroundWorker);

            e.Result = e.Argument;
            
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
            MessageBox.Show("Applied profile " + profile.Name,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            NetworkProfileActions.ShowNew(); 
        }

        private void btnProfileSave_Click(object sender, EventArgs e)
        {
            Controller.Instance.PersistenceController.Save();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            NetworkProfileActions.ShowProfile();
        }

        private void btnAllProfileLoad_Click(object sender, EventArgs e)
        {
            Controller.Instance.PersistenceController.Load();
            Controller.Instance.ActionRefreshProfiles();
        }

        private void btnAllCardsRefresh_Click(object sender, EventArgs e)
        {
            NetworkCardActions.RefreshAll();
        }

        private void btnCardView_Click(object sender, EventArgs e)
        {
            NetworkCardActions.ShowNetworkCard();
        }

        private void btnProfileRun_Click(object sender, EventArgs e)
        {
            NetworkProfileActions.ApplyProfile();
        }

        private void btnProfileRefresh_Click(object sender, EventArgs e)
        {
            NetworkProfileActions.RefrehProfiles();
        }

        private void btnProfileSave_Click_1(object sender, EventArgs e)
        {
            NetworkProfileActions.SaveProfile();
        }

        private void btnProfileDelete_Click(object sender, EventArgs e)
        {
            NetworkProfileActions.DeleteCurrentProfile();
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
            FormAboutBox ab = new FormAboutBox();
            /*ab.AppTitle = txtTitle.Text;
            ab.AppDescription = txtDescription.Text;
            ab.AppVersion = txtVersion.Text;
            ab.AppCopyright = txtCopyright.Text;
            ab.AppMoreInfo = txtMoreInfo.Text;
            ab.AppDetailsButton = chkDetails.Checked;*/

            string app="";
            app+="Visit http://argonswitcher.sourceforge.net for updates!"+Environment.NewLine;
            
            ab.AppMoreInfo = app;

            ab.ShowDialog(this);       
        }


        private void mnuViewConsole_Click(object sender, EventArgs e)
        {
            if (!rbtnViewConsole.Checked)
            {
                Controller.Instance.View.ViewConsole.Show();
            }
            else
            {
                Controller.Instance.View.ViewConsole.Hide();
            }
        }

        private void mnuCheckForUpdates_Click(object sender, EventArgs e)
        {
            string url = "http://argon-network-switcher.googlecode.com/files/checkLastVersion.xml"; //ConfigurationManager.AppSettings.Get("updateUrl");            
            CheckForUpdate.Verify(url);
        }

   
        private void makeADonationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonate form = new FormDonate();
            form.ShowDialog(this);  
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
            if (!rbtnViewProfiles.Checked)
            {
                if (Controller.Instance.View.ViewProfiles.OldDockState != DockState.Unknown)
                {
                    Controller.Instance.View.ViewProfiles.DockState = Controller.Instance.View.ViewProfiles.OldDockState;
                }
                Controller.Instance.View.ViewProfiles.Show();
            }
            else
            {
                Controller.Instance.View.ViewProfiles.OldDockState = Controller.Instance.View.ViewProfiles.DockState;
                Controller.Instance.View.ViewProfiles.DockState = DockState.DockBottom;
                Controller.Instance.View.ViewProfiles.Hide();                
            }

            //rbtnViewProfiles.Checked = !rbtnViewProfiles.Checked;
        }

        private void rbtnViewProfileNetwork_Click(object sender, EventArgs e)
        {
            List<FormProfile> list = Controller.Instance.View.ListViewProfile;
            if (rbtnViewProfileNetwork.Checked)
            {
                foreach (FormProfile item in list)
                {
                    //item.tabControl
                    item.HideTab(item.tp1NIC);
                }
            }
            else
            {
                foreach (FormProfile item in list)
                {
                    //item.tabControl
                    item.ShowTab(item.tp1NIC);
                }
            }

            rbtnViewProfileNetwork.Checked = !rbtnViewProfileNetwork.Checked;
        }

        public void btnRunProfile_Click(object sender, EventArgs e)
        {
        }
        
    }
}

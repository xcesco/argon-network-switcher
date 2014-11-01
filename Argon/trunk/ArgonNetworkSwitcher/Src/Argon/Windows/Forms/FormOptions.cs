using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.Models;
using Argon.Windows.Forms.Properties;
using System.Configuration;
using Microsoft.Win32;

namespace Argon.Windows.Forms
{
    public partial class FormOptions : ArgonDockContent
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the FormOptions control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FormOptions_Load(object sender, EventArgs e)
        {
            cbStartAndCheckForUpdate.Checked=Properties.Settings.Default.CheckForUpdate; 
                                
            rbStartSmartView.Checked=Properties.Settings.Default.StartInSmartView;
            rbStartTrayArea.Checked=Properties.Settings.Default.StartInTrayArea;
            rbStartNormal.Checked = Properties.Settings.Default.StartNormal;

            cbStartWithAutodetect.Checked=Properties.Settings.Default.AutodetectOnStart;
            cbStartWithWindows.Checked =Properties.Settings.Default.StartWithWindows;

            cbConfirmOnClose.Checked = Properties.Settings.Default.AskConfirmationOnClose;
            

            this.Activated += new System.EventHandler(this.ArgonDockContent_Activated);
        }

        /// <summary>
        /// Handles the VisibleChanged event of the FormOptions control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FormOptions_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                ViewModel.MainView.rbtnViewSettings.Checked = false;
            }
            else
            {
                ViewModel.MainView.rbtnViewSettings.Checked = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckForUpdate = cbStartAndCheckForUpdate.Checked;
            Properties.Settings.Default.StartInSmartView = rbStartSmartView.Checked;
            Properties.Settings.Default.StartInTrayArea= rbStartTrayArea.Checked;
            Properties.Settings.Default.AutodetectOnStart = cbStartWithAutodetect.Checked;
            Properties.Settings.Default.StartWithWindows=cbStartWithWindows.Checked;
            Properties.Settings.Default.StartNormal=rbStartNormal.Checked;
            Properties.Settings.Default.AskConfirmationOnClose = cbConfirmOnClose.Checked;

            RegistryKey rkApp;

            // ANS-14
            if (System.Environment.Is64BitOperatingSystem)
            {
                // The path for 64bit OS
                rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            }
            else
            {
                // The path for 32bit OS
                rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            }

            
            if (Properties.Settings.Default.StartWithWindows)
            {
                rkApp.SetValue("Argon Network Switcher", "\""+Application.ExecutablePath.ToString()+"\"");
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("Argon Network Switcher", false);
            }

            rkApp.Close();


            Properties.Settings.Default.Save();

            Hide();       
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();       
        }

    }
}

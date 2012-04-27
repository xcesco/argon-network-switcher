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
            cbStartInSmartView.Checked=Properties.Settings.Default.SmartViewOnStart;
            cbStartInTrayArea.Checked=Properties.Settings.Default.StartInTrayArea;
            cbStartWithAutodetect.Checked=Properties.Settings.Default.AutodetectOnStart;
            cbStartWithWindows.Checked =Properties.Settings.Default.StartWithWindows;


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
            Properties.Settings.Default.SmartViewOnStart = cbStartInSmartView.Checked;
            Properties.Settings.Default.StartInTrayArea= cbStartInTrayArea.Checked;
            Properties.Settings.Default.AutodetectOnStart = cbStartWithAutodetect.Checked;
            Properties.Settings.Default.StartWithWindows=cbStartWithWindows.Checked;

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

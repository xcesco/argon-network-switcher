using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.Models;

namespace Argon.Windows.Forms
{
    public partial class FormOptions : ArgonDockContent
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Windows.Forms;
using Argon.Controllers;
using Argon.Network.Profile;
using BrightIdeasSoftware;

namespace Argon.Windows.Forms
{
    /// <summary>
    /// Manage the list of profiles defined.
    /// </summary>
    public partial class FormProfiles : ArgonDockContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormProfiles"/> class.
        /// </summary>
        public FormProfiles()
        {            
            InitializeComponent();

            colName.ImageGetter = delegate(object rowObject)
            {
                return 0;
            };
            colName.Renderer = new ImageRenderer();
        }


        /// <summary>
        /// Handles the VisibleChanged event of the FormProfiles control.
        /// </summary>        
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FormProfiles_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                Controller.Instance.View.ViewMain.rbtnViewProfiles.Checked = false;
            }
            else
            {
                Controller.Instance.View.ViewMain.rbtnViewProfiles.Checked = true;
            }
        }
      
        private void FormProfiles_Activated(object sender, EventArgs e)
        {
            Controller.Instance.ActivateFormProfiles();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {

                Controller.Instance.Model.CurrentProfile = (NetworkProfile)listView.SelectedObject;                
                Controller.Instance.ActivateFormProfile();
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                Controller.Instance.Model.CurrentProfile = (NetworkProfile)listView.SelectedObject;                
                NetworkProfileActions.Show((NetworkProfile)listView.SelectedObject);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                Controller.Instance.Model.CurrentProfile = (NetworkProfile)listView.SelectedObject;                
                NetworkProfileActions.Show((NetworkProfile)listView.SelectedObject);
            }
        }

        private void mnuApply_Click(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                Controller.Instance.Model.CurrentProfile = (NetworkProfile)listView.SelectedObject;
                Controller.Instance.Profile_Click(Controller.Instance.Model.CurrentProfile, null);
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            NetworkProfileActions.DeleteCurrentProfile();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            NetworkProfileActions.ShowNew(); 
        }

        private void mnuDuplicateProfile_Click(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                Controller.Instance.Model.CurrentProfile = (NetworkProfile)listView.SelectedObject;                
                Controller.Instance.ProfileController.DuplicateProfile(Controller.Instance.Model.CurrentProfile);
                Controller.Instance.ActionRefreshProfiles();
            }
            
        }

        private void FormProfiles_Load(object sender, EventArgs e)
        {

        }

    }
}
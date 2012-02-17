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
using Argon.Windows.Network.Profile;
using BrightIdeasSoftware;
using Argon.UseCase;
using Argon.Models;

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
                NetworkProfile profile = (NetworkProfile)rowObject;

                return profile.ImageName;
                /*File theFile = (File)row;
                String extension = this.GetFileExtension(theFile);
                if (!this.listView.LargeImageList.Images.ContainsKey(extension)) {
                    Image smallImage = this.GetSmallIconForFileType(extension);
                    Image largeImage = this.GetLargeIconForFileType(extension);
                    this.listView.SmallImageList.Images.Add(extension, smallImage);
                    this.listView.LargeImageList.Images.Add(extension, largeImage);*/
                // return key;
                // };
                //return 0;
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
                ViewModel.MainView.rbtnViewProfiles.Checked = false;
            }
            else
            {
                ViewModel.MainView.rbtnViewProfiles.Checked = true;
            }
        }
      
        private void FormProfiles_Activated(object sender, EventArgs e)
        {
            //Controller.Instance.ActivateFormProfiles();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                UseCaseProfile.SelectProfile( (NetworkProfile)listView.SelectedObject);                
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                DataModel.SelectedNetworkProfile = (NetworkProfile)listView.SelectedObject;                
                UseCaseView.ShowProfile((NetworkProfile)listView.SelectedObject);
                
                UseCaseProfile.Show((NetworkProfile)listView.SelectedObject);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                DataModel.SelectedNetworkProfile = (NetworkProfile)listView.SelectedObject;                
                UseCaseView.ShowProfile((NetworkProfile)listView.SelectedObject);
            }
        }

        private void mnuApply_Click(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                DataModel.SelectedNetworkProfile = (NetworkProfile)listView.SelectedObject;
                Controller.Instance.Profile_Click(DataModel.SelectedNetworkProfile, null);
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            NetworkProfileActions.DeleteCurrentProfile();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            UseCaseView.ShowNewProfile(); 
        }

        private void mnuDuplicateProfile_Click(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                DataModel.SelectedNetworkProfile = (NetworkProfile)listView.SelectedObject;
                Controller.Instance.ProfileController.DuplicateProfile(DataModel.SelectedNetworkProfile);
                Controller.Instance.ActionRefreshProfiles();
            }
            
        }

        private void FormProfiles_Load(object sender, EventArgs e)
        {
            String[] imageNameList = ViewModel.ImageNames;

            ImageList imageList = ViewModel.ProfilesView.imageList48x48;

            // fill imageList in formProfiles
            foreach (String item in imageNameList)
            {
                imageList.Images.Add(item, UseCaseApplication.GetImage(item));
            }
        }

    }
}
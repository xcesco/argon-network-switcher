using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Windows.Forms;
using Argon.Windows.Network.Profile;
using BrightIdeasSoftware;
using Argon.UseCase;
using Argon.Models;
using Argon.Windows.Controls;

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
            // to avoid flicker problem
            // see http://stackoverflow.com/questions/64272/how-to-eliminate-flicker-in-windows-forms-custom-control-when-scrolling
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);


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

        /// <summary>
        /// Handles the Click event of the mnuDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            UseCaseProfile.DeleteProfile();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            UseCaseView.ShowNewProfile(); 
        }

        /// <summary>
        /// Handles the Click event of the mnuDuplicateProfile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuDuplicateProfile_Click(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count > 0)
            {
                DataModel.SelectedNetworkProfile = (NetworkProfile)listView.SelectedObject;
                UseCaseProfile.DuplicateProfile(DataModel.SelectedNetworkProfile);                
            }
            
        }

        private void FormProfiles_Load(object sender, EventArgs e)
        {
            this.Activated += new System.EventHandler(this.ArgonDockContent_Activated);
            String[] imageNameList = ViewModel.ImageNames;

            ImageList imageList = ViewModel.ProfilesView.imageList48x48;

            // fill imageList in formProfiles
            foreach (String item in imageNameList)
            {
                imageList.Images.Add(item, UseCaseApplication.GetImage(item));
            }
        }

        /// <summary>
        /// Stores the form on data.
        /// </summary>
        public override void StoreFormOnData()
        {
            //TODO: to implements
        }

        /// <summary>
        /// Views the data on form.
        /// </summary>
        public override void ViewDataOnForm()
        {
            //TODO: to implements
        }


        /// <summary>
        /// Handles the Click event of the mnuRun control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuRun_Click(object sender, EventArgs e)
        {
            UseCaseProfile.Run();
        }

        /// <summary>
        /// Handles the ColumnClick event of the listView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.ColumnClickEventArgs"/> instance containing the event data.</param>
        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Console.WriteLine("Item click");

            List<NetworkProfile> listaProfile = new List<NetworkProfile>();

            foreach (OLVListItem item in listView.Items)
            {
                Console.WriteLine("Item "+item.RowObject);
                listaProfile.Add((NetworkProfile)item.RowObject);
            }

            DataModel.NetworkProfileList = listaProfile;
            UseCaseProfile.Refresh(false);
        }

        /// <summary>
        /// Handles the Click event of the mnuMoveProfileUp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuMoveProfileUp_Click(object sender, EventArgs e)
        {
            UseCaseProfile.MoveUp();            
        }

        /// <summary>
        /// Handles the Click event of the mnuMoveProfileDown control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuMoveProfileDown_Click(object sender, EventArgs e)
        {
            UseCaseProfile.MoveDown();  
        }

    }
}
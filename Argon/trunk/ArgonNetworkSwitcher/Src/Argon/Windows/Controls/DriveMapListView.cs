using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Argon.Windows;

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
namespace Argon.Windows.Controls
{
    /// <summary>
    /// 
    /// </summary>
    [DesignTimeVisible(true), ToolboxItem(true),
   ToolboxBitmap(typeof(Button))]
    public partial class DriveMapListView : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        DriveMap currentItem;

        /// <summary>
        /// 
        /// </summary>
        internal SelectionType status;

        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMapListView"/> class.
        /// </summary>
        public DriveMapListView()
        {
            InitializeComponent();

            status = SelectionType.NONE;
            cbOperation.SelectedIndex = 0;

            // to avoid flicker problem
            // see http://stackoverflow.com/questions/64272/how-to-eliminate-flicker-in-windows-forms-custom-control-when-scrolling
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);
        }

        /// <summary>
        /// Displays the current item.
        /// </summary>
        protected void DisplayCurrentItem()
        {
            if (currentItem != null)
            {
                txtName.Text = currentItem.Name;
                txtDescription.Text = currentItem.Description;
                txtRealPath.Text = currentItem.RealPath;
                txtUsername.Text = currentItem.Username;
                txtPassword.Text = currentItem.Password;
                cbDrive.SelectedItem = currentItem.Drive;
                cbOperation.SelectedIndex = (int)currentItem.Type;
            }
            else
            {
                cbOperation.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Writes the current item.
        /// </summary>
        protected void WriteCurrentItem(DriveMap driveMap)
        {
            if (driveMap != null)
            {
                driveMap.Name = txtName.Text;
                driveMap.Description = txtDescription.Text;
                driveMap.RealPath = txtRealPath.Text;
                driveMap.Username = txtUsername.Text;
                driveMap.Password = txtPassword.Text;
                driveMap.Drive = cbDrive.Text;
                driveMap.Type = cbOperation.SelectedItem.ToString().ToUpper().Equals(DriveMapType.MOUNT.ToString()) ? DriveMapType.MOUNT : DriveMapType.UNMOUNT;
            }
        }

        /// <summary>
        /// Handles the Click event of the mnuNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuNew_Click(object sender, EventArgs e)
        {
            currentItem = new DriveMap();
            DisplayCurrentItem();
            status = SelectionType.NEW;
        }

        /// <summary>
        /// Handles the Click event of the mnuSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (status == SelectionType.NONE)
            {
                currentItem = new DriveMap();
            }

            WriteCurrentItem(currentItem);

            if (status == SelectionType.SELECTED)
            {
                listView.RefreshObject(currentItem);
            }
            else
            {
                listView.AddObject(currentItem);
                status = SelectionType.SELECTED;
                listView.SelectObject(currentItem);
                listView.RefreshSelectedObjects();
            }
        }

        /// <summary>
        /// Handles the Click event of the mnuDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (currentItem != null)
            {
                listView.RemoveObject(currentItem);
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the listView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listView_SelectionChanged(object sender, EventArgs e)
        {
            status = SelectionType.SELECTED;
            currentItem = (DriveMap)listView.SelectedObject;
            DisplayCurrentItem();
        }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        public List<DriveMap> Items
        {
            get
            {
                List<DriveMap> temp = new List<DriveMap>();

                if (listView.Items.Count != 0)
                {
                    foreach (DriveMap item in listView.Objects)
                    {
                        temp.Add(item);
                    }
                }

                return temp;
            }
        }

        /// <summary>
        /// Sets the items.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetItems(List<DriveMap> value)
        {
            if (value == null) return;
            List<DriveMap> temp = value;

            listView.SetObjects(temp);
        }

        /// <summary>
        /// Handles the Create event of the mnu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnu_Create(object sender, EventArgs e)
        {
            DriveMap driveMap = new DriveMap();

            WriteCurrentItem(driveMap);
            bool ret = DriveMapManager.Mount(driveMap);

            string title = "Mount network drive";
            string successMsg = "Operation executed!";
            string errorMsg = "Error during execution!";
            if (ret)
            {
                MessageBox.Show(this, successMsg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, errorMsg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Test event of the mnu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnu_Test(object sender, EventArgs e)
        {
            DriveMap driveMap = new DriveMap();

            WriteCurrentItem(driveMap);
            bool ret = DriveMapManager.Test(driveMap);

            string title = "Test network drive";
            string successMsg = "Operation executed!";
            string errorMsg = "Error during execution!";
            if (ret)
            {
                MessageBox.Show(this, successMsg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, errorMsg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Destroy event of the mnu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnu_Destroy(object sender, EventArgs e)
        {
            DriveMap driveMap = new DriveMap();

            WriteCurrentItem(driveMap);
            bool ret = DriveMapManager.Unmount(driveMap);

            string title = "Unmount network drive";
            string successMsg = "Operation executed!";
            string errorMsg = "Error during execution!";
            if (ret)
            {
                MessageBox.Show(this, successMsg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, errorMsg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

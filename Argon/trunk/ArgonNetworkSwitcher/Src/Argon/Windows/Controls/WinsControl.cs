using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.Windows.Network.Profile;

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

     [DesignTimeVisible(true), ToolboxItem(true),
    ToolboxBitmap(typeof(Button))]
    public partial class WinsControl : UserControl
    {
        public WinsControl()
        {
            InitializeComponent();           
        }

         /// <summary>
        /// Displays the configuration.
        /// </summary>
        public void DisplayConfiguration(WinsConfiguration config)
        {
            cbEnabled.Checked = config.Enabled;

            lstWinsServer.Items.Clear();
            if (config.SecondaryServer != null && config.SecondaryServer.Length > 0)
            {
                lstWinsServer.Items.Add(config.SecondaryServer);
            }

            if (config.PrimaryServer != null && config.PrimaryServer.Length > 0)
            {
                lstWinsServer.Items.Add(config.PrimaryServer);
            }
        }

        /// <summary>
        /// Displays the configuration.
        /// </summary>
        public WinsConfiguration StoreConfiguration()
        {
            WinsConfiguration config = new WinsConfiguration();
            config.Enabled = cbEnabled.Checked;

            if (lstWinsServer.Items.Count > 0)
            {
                config.PrimaryServer = (string)lstWinsServer.Items[0];
                config.SecondaryServer = (string)lstWinsServer.Items[1];
            }

            
            return config;
        }

        /// <summary>
        /// Handles the Click event of the btnAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ip=ipTextBox.IpAddress;
            if (ip.Equals("0.0.0.0"))
            {
                MyMessageBox.ShowMessage("Server definition not valid");
            }
            else
            {
                lstWinsServer.Items.Add(ip);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnRemove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstWinsServer.SelectedIndex>0)
            {
                lstWinsServer.Items.RemoveAt(lstWinsServer.SelectedIndex);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnMoveDown control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            int idx=lstWinsServer.SelectedIndex;
            if (idx > 0 && idx<lstWinsServer.Items.Count-1)
            {
                string temp=(string)lstWinsServer.Items[idx+1];
                lstWinsServer.Items[idx + 1] = lstWinsServer.Items[idx];
                lstWinsServer.Items[idx] = temp;
                
            }
        }

        /// <summary>
        /// Handles the Click event of the btnMoveUp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            int idx = lstWinsServer.SelectedIndex;
            if (idx > 1 && idx < lstWinsServer.Items.Count)
            {
                string temp = (string)lstWinsServer.Items[idx - 1];
                lstWinsServer.Items[idx - 1] = lstWinsServer.Items[idx];
                lstWinsServer.Items[idx] = temp;

            }
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

    }

     /// <summary>
     /// 
     /// </summary>
     public class WinsConfiguration
     {
         /// <summary>
         /// Gets or sets a value indicating whether [enabled wins server].
         /// </summary>
         /// <value>
         ///   <c>true</c> if [enabled wins server]; otherwise, <c>false</c>.
         /// </value>
         public bool Enabled { get; set; }

         /// <summary>
         /// Gets or sets the wins primary server.
         /// </summary>
         /// <value>
         /// The wins primary server.
         /// </value>
         public string PrimaryServer { get; set; }

         /// <summary>
         /// Gets or sets the wins secondary server.
         /// </summary>
         /// <value>
         /// The wins secondary server.
         /// </value>
         public string SecondaryServer { get; set; }

         /// <summary>
         /// Converts to.
         /// </summary>
         /// <param name="profile">The profile.</param>
         public static WinsConfiguration ValueOf(NetworkProfile profile)
         {
             WinsConfiguration config=new WinsConfiguration();

             config.Enabled=profile.NetworkCardInfo.WinsEnabled;
             config.PrimaryServer=profile.NetworkCardInfo.WinsPrimaryServer;
             config.SecondaryServer=profile.NetworkCardInfo.WinsSecondaryServer;             

             return config;
         }


         /// <summary>
         /// Copies the into profile.
         /// </summary>
         /// <param name="profile">The profile.</param>
         public void CopyIntoProfile(NetworkProfile profile)
         {
             profile.NetworkCardInfo.WinsEnabled = Enabled;
             profile.NetworkCardInfo.WinsPrimaryServer=PrimaryServer;
             profile.NetworkCardInfo.WinsSecondaryServer = SecondaryServer;             
         }
     }
    
}

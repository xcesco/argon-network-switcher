using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.Windows.Network.Profile;
using Argon.Models;
using Argon.Windows.Network.Wifi;
using Argon.Windows.Network;

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
    public partial class WifiProfileControl : UserControl
    {
        public WifiProfileControl()
        {
            // impostiamo il modo trasparente prima di inizializzare
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            InitializeComponent();

            // to avoid flicker problem
            // see http://stackoverflow.com/questions/64272/how-to-eliminate-flicker-in-windows-forms-custom-control-when-scrolling
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);            
        }


        /// <summary>
        /// Gets or sets a value indicating whether [wifi profile selected].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [wifi profile selected]; otherwise, <c>false</c>.
        /// </value>
        public bool WifiProfileSelected
        {
            get { return this.cbWifi.Checked; }
            set { this.cbWifi.Checked = value; }
        }

        /// <summary>
        /// Gets or sets the wifi profile SSID.
        /// </summary>
        /// <value>
        /// The wifi profile SSID.
        /// </value>
        public String WifiProfileSSID
        {
            get;
            set;
        }

        /// <summary>
        /// Displays the configuration.
        /// </summary>
        public void DisplayConfiguration(NetworkProfile profile)
        {
            WifiProfileSSID=profile.AssociatedWifiSSID;
            RefreshWifiCombo(profile);
        }

        /// <summary>
        /// Refreshes the wifi combo.
        /// </summary>
        protected void RefreshWifiCombo(NetworkProfile profile)
        {
            WindowsNetworkCard config = profile.NetworkCardInfo;
            if (config == null) return;

            // get the correct type from dataModel, cause _configuration.CardType is not affidable            
            WindowsNetworkCard wnc = DataModel.FindNetworkCard(config.Id);
            WindowsNetworkCardType type = WindowsNetworkCardType.UNKNOWN;
            if (wnc != null)
            {
                type = wnc.CardType;
            }

            // for wifi card
            if (WindowsNetworkCardType.WIRELESS == type)
            {
                WifiProfile currentWifiProfile = WifiProfileManager.GetActiveWifiProfileForCard(config);

                List<WifiProfile> listWifiProfile = WifiProfileManager.GetWifiProfilesForCard(config);

                cbWifiProfile.Items.Clear();
                cbWifiProfile.Items.Add("");
                foreach (WifiProfile item in listWifiProfile)
                {
                    cbWifiProfile.Items.Add(item.SSID);
                }

                // if nic is disable, no wireless profile found. Add the selected profile
                if (listWifiProfile.Count == 0)
                {
                    cbWifiProfile.Items.Add(WifiProfileSSID);
                }

                cbWifi.Checked = WifiProfileSelected;
                cbWifiProfile.Text = WifiProfileSSID;
            }
            else
            {
                cbWifi.Checked = false;
                cbWifiProfile.Text = "";
            }
        }

        /// <summary>
        /// Saves the configuration.
        /// </summary>
        public void SaveConfiguration(NetworkProfile profile)
        {
            if (profile == null) return;
           
            WifiProfileSSID = cbWifiProfile.Text;
            profile.AssociatedWifiSSID = WifiProfileSSID;

        }

        /// <summary>
        /// Handles the CheckedChanged event of the cbWifi control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cbWifi_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbWifi.Checked) cbWifiProfile.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Argon.Windows;
using Argon.Windows.Network;
using Argon.Windows.Network.Wifi;

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
    public partial class IpControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpControl"/> class.
        /// </summary>
        public IpControl()
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

            DisplayConfiguration();
        }

        /// <summary>
        /// 
        /// </summary>
        protected WindowsNetworkCard _configuration;

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public WindowsNetworkCard Configuration
        {
            get
            {
                SaveConfiguration();
                return _configuration;
            }
            set
            {
                _configuration = value;
                DisplayConfiguration();
            }
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
        protected void DisplayConfiguration()
        {
            if (_configuration == null)
            {
                cbDHCPEnabled.Checked = true;
                cbDynamicDNS.Checked = true;
                return;
            }
            
            cbDHCPEnabled.Checked = _configuration.Dhcp;
            txtIP.IpAddress = _configuration.IpAddress;
            txtSubnetMask.IpAddress = _configuration.SubnetMask;
            txtDefaultGateway.IpAddress = _configuration.GatewayAddress;

            cbDynamicDNS.Checked = _configuration.DynamicDNS;
            txtPrimaryDNS.IpAddress = _configuration.Dns;
            txtAlternativeDNS.IpAddress = _configuration.Dns2;

            txtMacAddress.Text = _configuration.MacAddress;

            // for wifi card
            if (_configuration.CardType == WindowsNetworkCardType.WIRELESS)
            {                
                WifiProfile currentWifiProfile = WifiProfileManager.GetActiveWifiProfileForCard(_configuration);

                List<WifiProfile> listWifiProfile=WifiProfileManager.GetWifiProfilesForCard(_configuration);

                cbWifiProfile.Items.Clear();
                cbWifiProfile.Items.Add("");
                foreach (WifiProfile item in listWifiProfile)
                {
                    cbWifiProfile.Items.Add(item.SSID);
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
        protected void SaveConfiguration()
        {
            if (_configuration == null) return;

            _configuration.Dhcp = cbDHCPEnabled.Checked;
            _configuration.IpAddress = txtIP.IpAddress;
            _configuration.SubnetMask = txtSubnetMask.IpAddress;
            _configuration.GatewayAddress = txtDefaultGateway.IpAddress;
            _configuration.DynamicDNS = cbDynamicDNS.Checked;
            _configuration.Dns = txtPrimaryDNS.IpAddress;
            _configuration.Dns2 = txtAlternativeDNS.IpAddress;

            WifiProfileSSID = cbWifiProfile.Text;
        }

        private void cbDHCPEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDHCPEnabled.Checked)
            {
                txtIP.Enabled = false;
                txtSubnetMask.Enabled = false;
                txtDefaultGateway.Enabled = false;

                cbDynamicDNS.Enabled = true;
            }
            else
            {
                txtIP.Enabled = true;
                txtSubnetMask.Enabled = true;
                txtDefaultGateway.Enabled = true;

                cbDynamicDNS.Checked = false;
                cbDynamicDNS.Enabled = false;
            }
        }

        private void cbDynamicDNS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDynamicDNS.Checked)
            {
                txtPrimaryDNS.Enabled = false;
                txtAlternativeDNS.Enabled = false;
            }
            else
            {
                txtPrimaryDNS.Enabled = true;
                txtAlternativeDNS.Enabled = true;
            }
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

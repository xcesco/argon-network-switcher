using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
    public partial class DNSConfiguration : UserControl
    {
        public DNSConfiguration()
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
        /// Displays the configuration.
        /// </summary>
        public void DisplayConfiguration(WindowsNetworkCard config)
        {
            if (config == null)
            {                
                cbDynamicDNS.Checked = true;
                return;
            }

            cbDynamicDNS.Checked = config.DynamicDNS;
            txtPrimaryDNS.IpAddress = config.Dns;
            txtAlternativeDNS.IpAddress = config.Dns2;
        }

        /// <summary>
        /// Saves the configuration.
        /// </summary>
        public void SaveConfiguration(WindowsNetworkCard config)
        {
            if (config == null) return;

            config.DynamicDNS = cbDynamicDNS.Checked;
            config.Dns = txtPrimaryDNS.IpAddress;
            config.Dns2 = txtAlternativeDNS.IpAddress;
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
    }

    
       
}

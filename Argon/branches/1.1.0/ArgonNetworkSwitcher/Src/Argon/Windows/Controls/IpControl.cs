using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Argon.Windows;
using Argon.Windows.Network;

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
    }
}

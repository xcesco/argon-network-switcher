using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Argon.OperatingSystem;
using Argon.OperatingSystem.Network;

namespace Argon.Windows.Controls
{
    /// <summary>
    /// 
    /// </summary>
    /// [DesignTimeVisible(true), ToolboxItem(true),
    [ToolboxBitmap(typeof(Button))]
    public partial class ProxyControl : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        protected ProxyConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyControl"/> class.
        /// </summary>
        public ProxyControl()
        {
            // impostiamo il modo trasparente prima di inizializzare
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            InitializeComponent();
            
            DisplayConfiguration();
        }

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public ProxyConfiguration Configuration
        {
            get
            {
                SaveConfiguration();
                return configuration; 
            }
            set {
                configuration = value;
                DisplayConfiguration();
            }
        }

        /// <summary>
        /// Saves the configuration.
        /// </summary>
        protected void SaveConfiguration()
        {
            if (configuration == null) return;

            configuration.Enabled = cbEnabledProxy.Checked;
            configuration.ServerAddress = txtProxyAddress.Text;
            try
            {
                configuration.Port = Int32.Parse(txtProxyPort.Text);
            } catch(Exception)
            {
                configuration.Port=80;
            }
            configuration.ProxyOverrideEnabled = cbProxyOverrideEnabled.Checked;
            configuration.ProxyOverride=txtProxyOverride.Text;
        }

        /// <summary>
        /// Displays the configuration.
        /// </summary>
        protected void DisplayConfiguration()
        {
            if (configuration == null) return;

            cbEnabledProxy.Checked = configuration.Enabled;

            if (configuration.Enabled)
            {                
                txtProxyAddress.Enabled = true;
                txtProxyPort.Enabled = true;
                txtProxyOverride.Enabled = true;
                cbProxyOverrideEnabled.Enabled = true;
                
                txtProxyAddress.Text = configuration.ServerAddress;
                txtProxyPort.Text = configuration.Port.ToString();

                if (configuration.ProxyOverrideEnabled)
                {
                    cbProxyOverrideEnabled.Checked = true;
                }
                else
                {
                    cbProxyOverrideEnabled.Checked = false;
                }

                txtProxyOverride.Text = configuration.ProxyOverride;
            }
            else
            {
                cbEnabledProxy.Checked = false;
                cbProxyOverrideEnabled.Checked = false;

                txtProxyAddress.Enabled = false;
                txtProxyPort.Enabled = false;
                txtProxyOverride.Enabled = false;
                cbProxyOverrideEnabled.Enabled = false;

                txtProxyAddress.Text = configuration.ServerAddress;
                txtProxyPort.Text = configuration.Port.ToString();

                txtProxyOverride.Text = configuration.ProxyOverride;
            }
        }

        private void cbEnabledProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnabledProxy.Checked)
            {
                txtProxyAddress.Enabled = true;
                txtProxyPort.Enabled = true;

                cbProxyOverrideEnabled.Enabled = true;
                txtProxyOverride.Enabled = true;
            }
            else
            {
                txtProxyAddress.Enabled = false;
                txtProxyPort.Enabled = false;

                cbProxyOverrideEnabled.Enabled = false;
                txtProxyOverride.Enabled = false;
            }
        }

        private void cbProxyOverrideEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbProxyOverrideEnabled.Checked)
            {
                txtProxyOverride.Enabled = false;
            }
            else
            {
                txtProxyOverride.Enabled = true;
            }
        }
    }
}

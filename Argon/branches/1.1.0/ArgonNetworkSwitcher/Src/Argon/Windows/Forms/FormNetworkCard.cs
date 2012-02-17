using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Net.NetworkInformation;
using Argon.Windows;
using Argon.Controllers;
using Argon.Windows.Network;
using Argon.UseCase;
using Argon.Models;


namespace Argon.Windows.Forms
{
    public partial class FormNetworkCard : ArgonDockContent
    {
        /// <summary>
        /// Gets or sets the NIC.
        /// </summary>
        /// <value>
        /// The NIC.
        /// </value>
        public WindowsNetworkCard NetworkCard
        {
            get { return (WindowsNetworkCard)Tag; }
            set { Tag = value; }
        }

        public FormNetworkCard()
        {
            InitializeComponent();
        }

        private string formatIpString(string input)
        {
            return input;
        }


        private void FormCardInfo_Load(object sender, EventArgs e)
        {
            txtDescription.Text = NetworkCard.Description;
            txtName.Text = NetworkCard.Name;
            txtMAC.Text = NetworkCard.MacAddress;
            txtDHCP.Text = NetworkCard.Dhcp.ToString();
            txtIP.Text = NetworkCard.IpAddress;
            txtGateway.Text = NetworkCard.GatewayAddress;
            txtSubnetMask.Text = NetworkCard.SubnetMask;
            txtDns1.Text = NetworkCard.Dns;
            txtDns2.Text = NetworkCard.Dns2;
            txtStatus.Text = NetworkCard.Status;
        }

        private void FormCardInfo_Activated(object sender, EventArgs e)
        {
            UseCaseView.ActivateFormNetworkCard(this);
        }

        private void FormCardInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool ret = ViewModel.NetworkCardViewList.Remove(this);
            UseCaseLogger.ShowInfo("NIC form closed " + ret);
        }


    }
}
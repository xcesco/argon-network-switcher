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
        public WindowsNetworkCard NIC
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
         
            txtDescription.Text = NIC.Description;
            txtName.Text = NIC.Name;
            txtMAC.Text = NIC.MacAddress;
            txtDHCP.Text = NIC.Dhcp.ToString();
            txtIP.Text = NIC.IpAddress;
            txtGateway.Text = NIC.GatewayAddress;
            txtSubnetMask.Text = NIC.SubnetMask;
            txtDns1.Text = NIC.Dns;
            txtDns2.Text = NIC.Dns2;
            txtStatus.Text = NIC.Status;
        }

        private void FormCardInfo_Activated(object sender, EventArgs e)
        {
            Controller.Instance.ActivateFormNetworkCard(this);
        }

        private void FormCardInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool ret = ViewModel.NetworkCardViewList.Remove(this);
            UseCaseLogger.ShowInfo("NIC form closed " + ret);
        }


    }
}
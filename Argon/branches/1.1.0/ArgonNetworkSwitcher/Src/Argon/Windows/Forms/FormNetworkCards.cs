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
using Argon.Windows.Forms;
using Argon.Controllers;
using BrightIdeasSoftware;
using Argon.Models;

namespace Argon.Windows.Forms
{
    public partial class FormNetworkCards : ArgonDockContent
    {
        public FormNetworkCards()
        {
            InitializeComponent();

            colName.ImageGetter = delegate(Object row)
            {
                return 0;
            };
            colName.Renderer = new ImageRenderer();
        }

        private void FormAdapters_Load(object sender, EventArgs e)
        {
            Controller.Instance.ActionRefreshNetworkAdapters();
        }

        private void actionDisplayCardInfo_Click(object sender, EventArgs e)
        {
            NetworkCardActions.ShowNetworkCard();
        }

        private void FormAdapters_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                ViewModel.MainView.rbtnViewNetworkCards.Checked = false;
            }
            else
            {
                ViewModel.MainView.rbtnViewNetworkCards.Checked = true;
            }
        }

        private void FormAdapters_Activated(object sender, EventArgs e)
        {
            Controller.Instance.ActivateFormCards();
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            NetworkCardActions.ShowNetworkCard();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mnuEnableDisableNetworkInterfaceCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }


        private void mnuEnable_Click(object sender, EventArgs e)
        {
            NetworkCardActions.EnableNetworkCard();
        }

        private void mnuDisable_Click(object sender, EventArgs e)
        {
            NetworkCardActions.DisableNetworkCard();
        }  
    }
}
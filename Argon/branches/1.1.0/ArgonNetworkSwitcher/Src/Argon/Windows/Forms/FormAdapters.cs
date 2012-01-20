using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Net.NetworkInformation;
using Argon.OperatingSystem;
using Argon.Windows.Forms;
using Argon.Controllers;
using BrightIdeasSoftware;

namespace Argon.Windows.Forms
{
    public partial class FormAdapters : ArgonDockContent
    {
        public FormAdapters()
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
            Controller.Instance.ActionRefreshNetworkAdapters(listView);
        }

        private void actionDisplayCardInfo_Click(object sender, EventArgs e)
        {
            NetworkCardActions.ShowNetworkCard();
        }

        private void FormAdapters_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                Controller.Instance.View.ViewMain.rbtnViewNICs.Checked = false;
            }
            else
            {
                Controller.Instance.View.ViewMain.rbtnViewNICs.Checked = true;
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
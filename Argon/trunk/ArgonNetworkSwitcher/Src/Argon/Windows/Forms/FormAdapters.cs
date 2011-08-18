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
    public partial class FormAdapters : DockContent
    {
        public FormAdapters()
        {
            InitializeComponent();

            colName.ImageGetter = delegate(Object row)
            {
                return 0;
            };
            colName.Renderer=new BaseRenderer();
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
                Controller.Instance.View.ViewMain.mnuViewNetworkAdapters.Checked = false;
            }
            else
            {
                Controller.Instance.View.ViewMain.mnuViewNetworkAdapters.Checked = true;
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
    }
}
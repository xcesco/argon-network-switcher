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
using Argon.UseCase;
using Argon.Windows.Network;

namespace Argon.Windows.Forms
{
    public partial class FormNetworkCards : ArgonDockContent
    {
        public FormNetworkCards()
        {
            InitializeComponent();
            // to avoid flicker problem
            // see http://stackoverflow.com/questions/64272/how-to-eliminate-flicker-in-windows-forms-custom-control-when-scrolling
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);


            colName.ImageGetter = delegate(Object row)
            {
                return 0;
            };
            colName.Renderer = new ImageRenderer();
        }

        private void FormAdapters_Load(object sender, EventArgs e)
        {
            this.Activated += new System.EventHandler(this.ArgonDockContent_Activated);
            UseCaseNetworkCard.RefreshNetworkCardListStatus();
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

        /// <summary>
        /// Handles the DoubleClick event of the listView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            ObjectListView list = listView;
            if (list.SelectedItems.Count > 0)
            {
                UseCaseNetworkCard.SelectNetworkCard((WindowsNetworkCard)list.SelectedObject);
                UseCaseNetworkCard.ShowSelectedNetworkCard();
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectListView list = listView;
            if (list.SelectedItems.Count > 0)
            {
                UseCaseNetworkCard.SelectNetworkCard((WindowsNetworkCard)list.SelectedObject);
            }
        }

        /// <summary>
        /// Handles the Click event of the mnuEnable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuEnable_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.EnableNetworkCard();
        }

        /// <summary>
        /// Handles the Click event of the mnuDisable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuDisable_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.DisableNetworkCard();
        }

        /// <summary>
        /// Handles the Click event of the mnuShowInfo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mnuShowInfo_Click(object sender, EventArgs e)
        {
            UseCaseNetworkCard.ShowSelectedNetworkCard();
        }

        /// <summary>
        /// Stores the form on data.
        /// </summary>
        public override void StoreFormOnData()
        {
            //TODO: to implements
        }

        /// <summary>
        /// Views the data on form.
        /// </summary>
        public override void ViewDataOnForm()
        {
            //TODO: to implements
        }
    }
}
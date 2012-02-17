using System;
using System.Collections.Generic;
using System.Text;
using Argon.Windows;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Windows.Forms;
using Argon.Controllers;
using BrightIdeasSoftware;
using Argon.Windows.Network;
using Argon.UseCase;
using Argon.Models;

namespace Argon.Controllers
{
    public abstract class NetworkCardActions : BaseActions
    {
 
        /// <summary>
        /// Shows all.
        /// </summary>
        public static void ShowAll()
        {
            ViewModel.MainView.rbtnViewNetworkCards.Checked = true;
            DisplayForm(ViewModel.NetworkCardsView);

            ViewModel.NetworkCardsView.Focus();
        }

        /// <summary>
        /// Reload the adapters status in form.
        /// </summary>
        public static void RefreshAll()
        {
            UseCaseNetworkCard.RefreshNetworkCardListStatus();
        }

        /// <summary>
        /// Hides all.
        /// </summary>
        public static void HideAll()
        {
            ViewModel.MainView.rbtnViewNetworkCards.Checked = false;
            DisplayForm(ViewModel.NetworkCardsView);
        }

        
    }
}

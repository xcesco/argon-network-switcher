using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Network.Profile;
using Argon.Models;
using System.Windows.Controls;
using Argon.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
using Argon.Windows.Network;

namespace Argon.UseCase
{
    /// <summary>
    /// 
    /// </summary>
    public static class UseCaseApplication
    {
  
        /// <summary>
        /// Loads the specified form main.
        /// </summary>
        /// <param name="formMain">The form main.</param>
        public static void Load(FormMain formMain)
        {

            // create other forms
            CreateForms(formMain);

            // set 
            DisplayFormsInDefaultPosition();
            
            UseCaseLogger.ShowInfo("Startup program");

            // set the event handler
            NetworkProfileHelper.NotifyEvent += UseCaseLogger.OnNotifyHandler;

            // default value
            DataModel.NetworkCardList = new List<WindowsNetworkCard>();
            DataModel.NetworkProfileList = new List<NetworkProfile>();

            // load the profiles
            UseCaseConfig.Load();
        }

        /// <summary>
        /// Creates the forms.
        /// </summary>
        internal static void CreateForms(FormMain formMain)
        {
            // set the main window
            ViewModel.MainView = formMain;

            ViewModel.ConsoleView = new FormConsole();

            ViewModel.ProfilesView = new FormProfiles();
            ViewModel.ProfileViewList = new List<FormProfile>();

            ViewModel.NetworkCardsView = new FormNetworkCards();
            ViewModel.NetworkCardViewList = new List<FormNetworkCard>();            
        }

        /// <summary>
        /// Displays the forms in default position.
        /// </summary>
        internal static void DisplayFormsInDefaultPosition()
        {
            WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel = ViewModel.MainView.dockPanel;

            // default position for nics form, profiles form and console form
            ViewModel.NetworkCardsView.Show(dockPanel);
            ViewModel.ProfilesView.Show(dockPanel);
            ViewModel.ConsoleView.Show(dockPanel);

            UseCaseView.Display(ViewModel.NetworkCardsView, DockState.DockBottomAutoHide);
            UseCaseView.Display(ViewModel.ProfilesView, DockState.Document);
            UseCaseView.Display(ViewModel.ConsoleView, DockState.DockBottomAutoHide);                           
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static System.Drawing.Image GetImage(string name)
        {
            return (System.Drawing.Image)Argon.Windows.Forms.Properties.Resources.ResourceManager.GetObject(name);  
        }

    }
}

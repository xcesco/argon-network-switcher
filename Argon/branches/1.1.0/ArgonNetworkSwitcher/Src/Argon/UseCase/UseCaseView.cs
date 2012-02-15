using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Models;
using System.Windows.Forms;
using Argon.Windows.Network.Profile;

namespace Argon.UseCase
{
    public abstract class UseCaseView
    {
        /// <summary>
        /// Toggles the display.
        /// </summary>
        /// <param name="dockContent">Content of the dock.</param>
        public static void ToggleDisplay(ArgonDockContent dockContent)
        {
            if (dockContent.Visible)
            {
                // hide content
                Hide(dockContent);
            }
            else
            {
                // display content
                Display(dockContent, dockContent.OldDockState);
            }
        }

        /// <summary>
        /// Displays the specified dock content.
        /// </summary>
        /// <param name="dockContent">Content of the dock.</param>
        /// <param name="dockState">State of the dock.</param>
        /// <returns></returns>
        public static bool Display(ArgonDockContent dockContent, DockState dockState=DockState.Unknown)
        {            
            dockContent.DockState = dockState;

            if (dockState == DockState.Unknown && dockContent.OldDockState != DockState.Unknown)
            {
                dockContent.DockState = dockContent.OldDockState;                
            }

            dockContent.Show();            

            // check ribbon button
            if (dockContent == ViewModel.ProfilesView)
            {                
                CheckRibbonButton(dockContent, ViewModel.MainView.rbtnViewProfiles);
            }
            else if (dockContent == ViewModel.NetworkCardsView)
            {
                CheckRibbonButton(dockContent, ViewModel.MainView.rbtnViewNetworkCards);
            }
            else if (dockContent == ViewModel.ConsoleView)
            {
                CheckRibbonButton(dockContent, ViewModel.MainView.rbtnViewConsole);
            }                                    

            return true;
        }

        /// <summary>
        /// Displays the specified dock content.
        /// </summary>
        /// <param name="dockContent">Content of the dock.</param>
        /// <param name="dockState">State of the dock.</param>
        /// <returns></returns>
        public static void Hide(ArgonDockContent dockContent)
        {            
            dockContent.OldDockState = dockContent.DockState;
            dockContent.DockState = DockState.DockBottom;
            dockContent.Hide();

            // check ribbon button
            if (dockContent == ViewModel.ProfilesView)
            {
                CheckRibbonButton(dockContent, ViewModel.MainView.rbtnViewProfiles);
            }
            else if (dockContent == ViewModel.NetworkCardsView)
            {
                CheckRibbonButton(dockContent, ViewModel.MainView.rbtnViewNetworkCards);
            }
            else if (dockContent == ViewModel.ConsoleView)
            {
                CheckRibbonButton(dockContent, ViewModel.MainView.rbtnViewConsole);
            }
            
        }

        /// <summary>
        /// Checks the ribbon button.
        /// </summary>
        /// <param name="dockContent">Content of the dock.</param>
        /// <param name="button">The button.</param>
        /// <returns></returns>
        internal static void CheckRibbonButton(ArgonDockContent dockContent, RibbonButton button)
        {
            //ActionRefreshNetworkAdapters();
            if (dockContent.Visible)
            {
                button.Checked = true;
            }
            else
            {
                button.Checked = false;
            }
        }


        public static void Display(NetworkProfile networkProfile)
        {
            // set the profile as current selected
            DataModel.SelectedNetworkProfile = networkProfile;

            UseCaseProfile.Show(networkProfile);
        }
    }
}

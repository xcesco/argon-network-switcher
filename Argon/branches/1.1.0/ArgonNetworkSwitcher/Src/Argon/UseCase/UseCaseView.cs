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
                Display(dockContent, true, dockContent.OldDockState);
            }
        }

        /// <summary>
        /// Displays the specified dock content.
        /// </summary>
        /// <param name="dockContent">Content of the dock.</param>
        /// <param name="dockState">State of the dock.</param>
        /// <returns></returns>
        public static bool Display(ArgonDockContent dockContent, bool forceShow=false,DockState dockState=DockState.Unknown)
        {
            if (forceShow)
            {
                dockContent.DockState = dockState;

                if (dockState == DockState.Unknown && dockContent.OldDockState != DockState.Unknown)
                {
                    dockContent.DockState = dockContent.OldDockState;
                }

                dockContent.Show();
            }

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


        /// <summary>
        /// Activates the form cards.
        /// </summary>
        public static void ActivateFormCards()
        {
            FormMain main = ViewModel.MainView;

            // form selezionati
            ViewModel.SelectedView = ViewModel.NetworkCardsView;
        }

        /// <summary>
        /// Activates the form network card.
        /// </summary>
        /// <param name="selectedNetworkCardForm">The selected network card form.</param>
        public static void ActivateFormNetworkCard(FormNetworkCard selectedNetworkCardForm)
        {/*
            // profili
            ViewModel.MainView.rbtnProfileNew.Enabled = false;
            ViewModel.MainView.rbtnProfileView.Enabled = false;
            ViewModel.MainView.rbtnProfileDelete.Enabled = false;

            // profilo
            ViewModel.MainView.rbtnProfileRun.Enabled = false;
            ViewModel.MainView.rbtnProfileSave.Enabled = false;

            // documento
            ViewModel.MainView.rbtnConfigSave.Enabled = false;
            ViewModel.MainView.rbtnConfigLoad.Enabled = false;

            // networkcard
            ViewModel.MainView.rbtnCardsRefresh.Enabled = false;
            ViewModel.MainView.rbtnCardView.Enabled = false;*/

            ViewModel.MainView.ribbon.ActiveTab = ViewModel.MainView.rtOperations;

            // form selezionati            
            ViewModel.SelectedView = selectedNetworkCardForm;
        }

        /// <summary>
        /// Activates the form network card.
        /// </summary>
        /// <param name="selectedNetworkCardForm">The selected network card form.</param>
        public static void ActivateFormProfile(FormProfile selectedProfileForm)
        {
            /*
            // profili
            ViewModel.MainView.rbtnProfileNew.Enabled = true;
            ViewModel.MainView.rbtnProfileView.Enabled = true;
            ViewModel.MainView.rbtnProfileDelete.Enabled = true;

            // profilo
            ViewModel.MainView.rbtnProfileRun.Enabled = true;
            ViewModel.MainView.rbtnProfileSave.Enabled = true;

            // documento
            ViewModel.MainView.rbtnConfigSave.Enabled = true;
            ViewModel.MainView.rbtnConfigLoad.Enabled = true;

            // networkcard
            ViewModel.MainView.rbtnCardsRefresh.Enabled = false;
            ViewModel.MainView.rbtnCardView.Enabled = false;*/

            ViewModel.MainView.ribbon.ActiveTab = ViewModel.MainView.rtOperations;

            // form selezionati            
            ViewModel.SelectedView = selectedProfileForm;
        }

        /// <summary>
        /// Shows the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void ShowProfile(NetworkProfile profile)
        {
            if (profile == null) return;

            NetworkProfile item;

            foreach (FormProfile itemForm in ViewModel.ProfileViewList)
            {
                if ((itemForm.Tag is NetworkProfile))
                {
                    item = (NetworkProfile)itemForm.Tag;

                    if (item.Id.Equals(profile.Id))
                    {
                        if (!itemForm.Visible)
                        {
                            itemForm.Show(ViewModel.MainView.Pannello);
                        }

                        itemForm.Focus();
                        //UseCaseView.ActivateFormProfile(itemForm);
                        return;
                    }
                }
            }            

            FormProfile form = new FormProfile();
            form.Tag = profile;
            form.txtName.Text = profile.Name;
            form.LoadProfile(profile);

            ViewModel.ProfileViewList.Add(form);
            form.Show(ViewModel.MainView.Pannello);
            form.DockState = DockState.Document;            
        }



        /// <summary>
        /// Shows the new profile.
        /// </summary>
        public static void ShowNewProfile()
        {
            NetworkProfile profile = new NetworkProfile();
            profile.Name = UseCaseProfile.NEW_NIC_NAME;

            ShowProfile(profile);
        }
    }
}

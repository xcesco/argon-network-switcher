using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Windows;
using System.ComponentModel;
using Argon.Windows.Forms;
using System.Drawing.Printing;
using Argon.Controllers;
using Argon.Windows.Network.Profile;
using System.Collections;
using BrightIdeasSoftware;
using System.Windows;
using Argon.Windows.Network;
using Argon.UseCase;
using Argon.Models;

namespace Argon.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class NetworkProfileActions : BaseActions
    {
        /// <summary>
        /// Shows the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void Show(NetworkProfile profile)
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
                        Controller.Instance.ActivateFormProfile(itemForm);
                        return;
                    }
                }
            }
            Controller controller = Controller.Instance;

            FormProfile form = new FormProfile();
            form.Tag = profile;
            form.txtName.Text = profile.Name;
            form.LoadProfile(profile);

            ViewModel.ProfileViewList.Add(form);
            form.Show(ViewModel.MainView.Pannello);
            form.DockState = DockState.Document;

            Controller.Instance.ActivateFormProfile(form);
        }

        /// <summary>
        /// Shows the new.
        /// </summary>
        public static void ShowNew()
        {
            NetworkProfile profile = new NetworkProfile();
            profile.Name = Controller.NO_NIC_NAME;            

            Show(profile);
        }

        public static void ShowAll()
        {
            ViewModel.MainView.rbtnViewProfiles.Checked = true;

            DisplayForm(ViewModel.ProfilesView);

            ViewModel.ProfilesView.Focus();
        }

        public static void HideAll()
        {
            ViewModel.MainView.rbtnViewProfiles.Checked = false;
            DisplayForm(ViewModel.ProfilesView);
        }



        public static void ApplyProfile()
        {
            NetworkProfile profile = Controller.Instance.Model.CurrentProfile;

            ApplyProfile(profile);
        }

        public static void ApplyProfile(NetworkProfile profile)
        {
            
            if (profile != null)
            {
                Controller.Instance.Profile_Click(profile, null);                
            }
        }

        public static void SaveProfile()
        {
            FormProfile form = ViewModel.SelectedView as FormProfile;

            if (form != null)
            {
                form.btnSave_Click(null, null);                
            }
        }

        public static void RefrehProfile()
        {

            FormProfile form=ViewModel.SelectedView as FormProfile;

            if (form!=null)
            {                
                form.RefreshView();
            }
        }

        public static void DeleteCurrentProfile()
        {
            ObjectListView list = ViewModel.NetworkCardsView.listView;
            if (list.SelectedObjects.Count > 0)
            {
                
                Controller.Instance.Model.CurrentProfile = null;

                NetworkProfile profile = (NetworkProfile)list.SelectedObject;

                MessageBoxResult res=System.Windows.MessageBox.Show("Do you want to delete profile "+profile.Name+"?","Delete confirmation",MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res==MessageBoxResult.Yes)
                {
                    UseCaseLogger.ShowInfo("Remove profile [" + profile.Name + "]");
                    Controller.Instance.Model.Profiles.Remove(profile);
                    Controller.Instance.ActionRefreshProfiles();
                }
             
            }
        }

    }
}

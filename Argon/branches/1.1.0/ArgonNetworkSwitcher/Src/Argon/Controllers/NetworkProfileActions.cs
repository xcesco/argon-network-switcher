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
            NetworkProfile profile = DataModel.SelectedNetworkProfile;

            ApplyProfile(profile);
        }

        public static void ApplyProfile(NetworkProfile profile)
        {
            
            if (profile != null)
            {
                Controller.Instance.Profile_Click(profile, null);                
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


    }
}

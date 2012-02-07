using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.Models;
using Argon.OperatingSystem.Network.Profile;

namespace Argon.UseCase
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class UseCaseProfile
    {
        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        public static void Refresh()
        {
            RibbonPanel rp =  ViewModel.MainView.rpProfilesCollection;
            RibbonItemCollection rpc = rp.Items;
            RibbonButton rButton=null;

            rpc.Clear();
            // Lista dei profili nell'apposita finestra
            ViewModel.ProfilesView.listView.ClearObjects();
           
            foreach (NetworkProfile item in DataModel.NetworkProfileList)
            {
                ViewModel.ProfilesView.listView.AddObject(item);
                
                rButton=new RibbonButton();

                rButton.Text=item.Name;
                rButton.Tag=item;
                rButton.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
                rButton.Click += new System.EventHandler(ViewModel.MainView.btnRunProfile_Click);
                // create in ribbon panel
                rpc.Add(rButton);
            }

            // bug on ribbon: if i don't do it, buttons are not display untill change tab
            ViewModel.MainView.Width +=1;
            ViewModel.MainView.Width -= -1;            
        }

        /// <summary>
        /// Shows the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void Show(NetworkProfile profile)
        {
            // set the selected profile in model
            DataModel.SelectedNetworkProfile = profile;

            // selected the current ribbonù
            //ViewModel.MainView.ribbon.T  = ViewModel.MainView.rtOperations;
            //ViewModel.MainView.rtOperations.
            //ViewModel.MainView.rpProfile.Selected = true;
        }
    }
}

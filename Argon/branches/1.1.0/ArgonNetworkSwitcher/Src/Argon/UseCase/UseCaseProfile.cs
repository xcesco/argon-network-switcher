using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.Models;
using Argon.Windows.Network.Profile;
using System.Drawing;
using System.ComponentModel;
using Argon.Windows.Network;
using Argon.Windows;
using Argon.Common;

namespace Argon.UseCase
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class UseCaseProfile
    {
        /// <summary>
        /// Refreshes this instance.
        /// <list type="">
        ///     <item>refresh the list in profileView</item>
        ///     <item>refresh the ribbon in mainView</item>
        /// </list>
        /// </summary>
        public static void Refresh()
        {                        
            
            RibbonPanel rp = ViewModel.MainView.rpProfilesCollection;
            RibbonItemCollection rpc = rp.Items;
            RibbonButton rButton = null;
            rpc.Clear();

            foreach (NetworkProfile item in DataModel.NetworkProfileList)
            {
                // 1 - refresh the profileView                
                ViewModel.ProfilesView.listView.AddObject(item);

                // 2 - refresh the ribbonPanel in mainView            
                rButton=new RibbonButton();

                rButton.Text=item.Name;
                rButton.Tag=item;
                //rButton.Image = global::Argon.Windows.Forms.Properties.Resources.profile_0_48x48;
                rButton.Image = UseCaseApplication.GetImage(item.ImageName);
                //rButton.SmallImage = UseCaseApplication.GetImage(item.ImageName);
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
            ViewModel.MainView.ribbon.ActiveTab = ViewModel.MainView.rtOperations;            
            ViewModel.MainView.rpProfile.Selected = true;
        }

        /// <summary>
        /// Called when [run status changed handler].
        /// </summary>
        /// <param name="profileSender">The profile sender.</param>
        /// <param name="e">The <see cref="Argon.Common.NotifyEventArgs"/> instance containing the event data.</param>
        public static void OnRunStatusChangedHandler(Object profileSender, NotifyEventArgs e)
        {
            UseCaseLogger.ShowInfo(e.Description);
            ViewModel.MainView.backgroundWorker.ReportProgress(e.Percentage);            
        }


        /// <summary>
        /// Runs the autodetect.
        /// </summary>
        /// <returns></returns>
        public static NetworkProfile RunAutodetect()
        {
            return NetworkProfileHelper.AutodetectNetworkProfile(DataModel.NetworkProfileList);                       
        }

        /// <summary>
        /// Applies the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <param name="worker">The worker.</param>
        /// <param name="runOnlyDeviceConfig">if set to <c>true</c> [run only device config].</param>
        public static void Run(NetworkProfile profile, BackgroundWorker worker=null, bool runDeviceConfig=true)
        {

            if (profile == null) return;

            profile.RunStatusChangeEvent += OnRunStatusChangedHandler;

            try
            {
                profile.Run(runDeviceConfig);
            }
            finally
            {
                profile.RunStatusChangeEvent -= OnRunStatusChangedHandler;
            }
        }
    }
}

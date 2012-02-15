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
        /// Applies the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <param name="worker">The worker.</param>
        /// <param name="runOnlyDeviceConfig">if set to <c>true</c> [run only device config].</param>
        public static void Run(NetworkProfile profile, BackgroundWorker worker=null, bool runDeviceConfig=true)
        {

            UseCaseLogger.ShowInfo("Start applying profile " + profile.Name);
            if (worker != null) worker.ReportProgress(0);

            // disable cards
            if (runDeviceConfig) NetworkProfileHelper.RunDisableNetworkCardsSetup(profile);
            foreach (IWindowsNetworkCardInfo nic in profile.DisabledNetworkCards)
            {
                UseCaseLogger.ShowInfo("Disable network card " + nic.HardwareName);                
            }
            if (worker != null) worker.ReportProgress(15);

            UseCaseLogger.ShowInfo("Change netword card configuration");
            if (runDeviceConfig) NetworkProfileHelper.RunNetworkCardSetup(profile);            
            if (worker != null) worker.ReportProgress(30);

            if (runDeviceConfig)
            {
                UseCaseLogger.ShowInfo("Wait for "+NetworkProfileHelper.TIME_WAIT * 4+" ms");
                System.Threading.Thread.Sleep(NetworkProfileHelper.TIME_WAIT * 4);
            }
           
            UseCaseLogger.ShowInfo("Change proxy configuration");
            NetworkProfileHelper.RunProxySetup(profile);             
            if (worker != null) worker.ReportProgress(40);

            UseCaseLogger.ShowInfo("Change network drive configuration");
            NetworkProfileHelper.RunDriveMapping(profile);                
            if (worker != null) worker.ReportProgress(50);

            UseCaseLogger.ShowInfo("Change windows service configuration");
            NetworkProfileHelper.RunServicesSetup(profile);            
            if (worker != null) worker.ReportProgress(60);

            UseCaseLogger.ShowInfo("Executing programs");
            NetworkProfileHelper.RunProgramsSetup(profile);            
            if (worker != null) worker.ReportProgress(70);

            UseCaseLogger.ShowInfo("Change default printer configuration");
            NetworkProfileHelper.RunPrinterSetup(profile);           
            if (worker != null) worker.ReportProgress(80);
            
            UseCaseLogger.ShowInfo("End profile " + profile.Name);
            if (worker != null) worker.ReportProgress(100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using Argon.OperatingSystem;
using System.ComponentModel;
using Argon.Windows.Forms;
using System.Drawing.Printing;
using Argon.Controllers;
using Argon.OperatingSystem.Network.Profile;
using System.Collections;
using BrightIdeasSoftware;
using System.Windows;
using Argon.OperatingSystem.Network;
using Argon.UseCase;

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

            foreach (FormProfile itemForm in Controller.Instance.View.ListViewProfile)
            {
                if ((itemForm.Tag is NetworkProfile))
                {
                    item = (NetworkProfile)itemForm.Tag;

                    if (item.Id.Equals(profile.Id))
                    {
                        if (!itemForm.Visible)
                        {
                            itemForm.Show(Controller.Instance.View.ViewMain.Pannello);
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

            Controller.Instance.View.ListViewProfile.Add(form);
            form.Show(controller.View.ViewMain.Pannello);
            form.DockState = DockState.Document;

            Controller.Instance.ActivateFormProfile(form);
        }

        public static void ShowProfile()
        {
            ObjectListView list = Controller.Instance.View.ViewProfiles.listView;
            if (list.SelectedObjects.Count > 0)
            {
                NetworkProfileActions.Show((NetworkProfile)list.SelectedObject);
            }
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
            Controller.Instance.View.ViewMain.rbtnViewProfiles.Checked = true;

            DisplayForm(Controller.Instance.View.ViewProfiles);

            Controller.Instance.View.ViewProfiles.Focus();
        }

        public static void HideAll()
        {
            Controller.Instance.View.ViewMain.rbtnViewProfiles.Checked = false;
            DisplayForm(Controller.Instance.View.ViewProfiles);
        }

        /// <summary>
        /// Applies the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <param name="worker">The worker.</param>
        public static void Apply(NetworkProfile profile, BackgroundWorker worker)
        {

            UseCaseLogger.ShowInfo("Start applying profile "+profile.Name);
            if (worker != null) worker.ReportProgress(0);

            foreach (IWindowsNetworkCardInfo nic in profile.DisabledNetworkCards)
            {
                UseCaseLogger.ShowInfo("Disable network card " + nic.HardwareName);
                NetworkAdapterHelper.SetDeviceStatus(nic, false);
            }


            UseCaseLogger.ShowInfo("Change netword card configuration");
            WindowsNetworkCardManager.Apply(profile.NetworkCardInfo);

            if (worker != null) worker.ReportProgress(20);

            UseCaseLogger.ShowInfo("Change proxy configuration");
            ProxyConfigurationManager.Apply(profile.ProxyConfig);

            if (worker != null) worker.ReportProgress(40);

            UseCaseLogger.ShowInfo("Change network drive configuration");
            DriveMapManager.Apply(profile.DriveMapList);

            if (worker != null) worker.ReportProgress(60);

            UseCaseLogger.ShowInfo("Change windows service configuration");
            WindowsServiceManager.Apply(profile.ServiceList);

            if (worker != null) worker.ReportProgress(80);

            UseCaseLogger.ShowInfo("Executing programs");
            WindowsExecutableManager.Apply(profile.ExecList);

            if (worker != null) worker.ReportProgress(90);

            UseCaseLogger.ShowInfo("Change default printer configuration");
            PrinterManager.SetDefaultPrinter(profile.DefaultPrinter);

            if (worker != null) worker.ReportProgress(100);
            UseCaseLogger.ShowInfo("End profile " + profile.Name);
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
                //form.btnSave_Click(null,null);
                Controller.Instance.Profile_Click(profile, null);                
            }
        }

        public static void SaveProfile()
        {
            FormProfile form = Controller.Instance.View.CurrentFormProfile;

            if (form != null)
            {
                form.btnSave_Click(null, null);                
            }
        }

        public static void RefrehProfile()
        {
            FormProfile form = Controller.Instance.View.CurrentFormProfile;

            if (form != null)
            {
                form.RefreshView();
            }
        }

        public static void DeleteCurrentProfile()
        {
            ObjectListView list = Controller.Instance.View.ViewProfiles.listView;
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

        public static void RefrehProfiles()
        {
            Controller.Instance.View.ViewProfiles.listView.ClearObjects();

            foreach (NetworkProfile item in Controller.Instance.Model.Profiles)
            {
                Controller.Instance.View.ViewProfiles.listView.AddObject(item);
            }
            
        }
    }
}

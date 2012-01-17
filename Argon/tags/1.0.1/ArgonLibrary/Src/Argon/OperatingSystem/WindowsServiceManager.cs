using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.ServiceProcess;
using System.Collections;

namespace Argon.OperatingSystem
{
    /// <summary>
    /// Windows Service Controller
    /// </summary>
    public abstract class WindowsServiceManager
    {
        /*
         * 
         RegistryKey registrykey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\" + serviceInstaller.ServiceName,true);     registrykey.SetValue("Description",description);
         */

        /// <summary>
        /// Gets the windows services list.
        /// </summary>
        /// <returns></returns>
        public static List<WindowsService> GetWindowsServicesList()
        {
            ServiceController[] temp = ServiceController.GetServices();
            List<WindowsService> array = new List<WindowsService>();

            foreach (ServiceController item in temp)
            {
                if (item.ServiceType == ServiceType.Win32OwnProcess)
                {
                    array.Add(new WindowsService(item, GetServiceDescription(item.ServiceName)));
                }
            }

            return array;
        }

        /// <summary>
        /// Gets the windows services table.
        /// </summary>
        /// <returns></returns>
        public static Hashtable GetWindowsServicesTable()
        {
            ServiceController[] temp = ServiceController.GetServices();
            Hashtable table = new Hashtable();

            foreach (ServiceController item in temp)
            {
                table.Add(item.ServiceName, new WindowsService(item, GetServiceDescription(item.ServiceName)));
            }

            return table;
        }



        /// <summary>
        /// Sets the service description.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <param name="description">The description.</param>
        protected static void SetServiceDescription(string serviceName, string description)
        {
            RegistryKey regKey = null;
            try
            {
                regKey = Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Services\" + serviceName, true);
                regKey.SetValue("Description", description);
            }
            finally
            {
                if (regKey != null)
                {
                    regKey.Close();
                }
            }
        }

        /// <summary>
        /// Gets the service description.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns></returns>
        protected static string GetServiceDescription(string serviceName)
        {
            string ret = "<No name>";
            RegistryKey regKey = null;

            try
            {                
                regKey = Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Services\" + serviceName, false);
                ret = (string)regKey.GetValue("Description", "");
            }
            finally
            {
                if (regKey != null)
                {
                    regKey.Close();
                }
            }

            return ret;
        }

        /// <summary>
        /// Applies the specified service list.
        /// </summary>
        /// <param name="serviceList">The service list.</param>
        public static void Apply(List<IWindowsServiceInfo> serviceList)
        {
            Hashtable serviceTable = WindowsServiceManager.GetWindowsServicesTable();
            WindowsService temp;

            foreach (IWindowsServiceInfo item in serviceList)
            {
                temp = (WindowsService)serviceTable[item.ServiceName];

                if (temp != null)
                {
                    try
                    {
                        switch (item.ForcedStatus)
                        {
                            case ServiceForcedStatus.RUNNING:
                                if (temp.Status != ServiceControllerStatus.Running)
                                {
                                    temp.Service.Start();
                                }
                                break;
                            case ServiceForcedStatus.STOPPED:
                                if (temp.Status != ServiceControllerStatus.Stopped)
                                {
                                    temp.Service.Stop();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    finally { }
                }
            }
        }

        /// <summary>
        /// Forces the services to start.
        /// </summary>
        /// <param name="service">The service.</param>
        public static void ForceServicesToStart(string[] service)
        {
            ForceServices(service, ServiceForcedStatus.RUNNING);
        }

        /// <summary>
        /// Forces the services to start.
        /// </summary>
        /// <param name="service">The service.</param>
        public static void ForceServicesToStop(string[] service)
        {
            ForceServices(service, ServiceForcedStatus.STOPPED);
        }


        /// <summary>
        /// Forces the services.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="forcedStatus">The forced status.</param>
        public static void ForceServices(string[] service, ServiceForcedStatus forcedStatus)
        {
            Hashtable serviceTable = WindowsServiceManager.GetWindowsServicesTable();
            WindowsService temp;

            foreach (string item in service)
            {
                temp = (WindowsService)serviceTable[item];

                if (temp != null)
                {
                    try
                    {
                        if ((temp.Status == ServiceControllerStatus.Running && forcedStatus == ServiceForcedStatus.RUNNING) ||
                        (temp.Status == ServiceControllerStatus.Stopped && forcedStatus == ServiceForcedStatus.STOPPED))
                        {
                            // non dobbiamo fare nulla
                            continue;
                        }

                        if (forcedStatus == ServiceForcedStatus.RUNNING)
                        {
                            temp.Service.Start();
                        }
                        else if (forcedStatus == ServiceForcedStatus.STOPPED)
                        {
                            temp.Service.Stop();
                        }
                    }
                    catch (Exception)
                    {
                    }
                    finally { }
                }
            }
        }

    }
}

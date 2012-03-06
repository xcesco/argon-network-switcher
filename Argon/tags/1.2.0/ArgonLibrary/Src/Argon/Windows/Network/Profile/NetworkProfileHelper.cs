using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;

using System.IO;
using Argon.Windows.Network.Wifi;
using Argon.Common;


/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
namespace Argon.Windows.Network.Profile
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public static class NetworkProfileHelper
    {
        public const int TIME_WAIT = 3500;

        #region Event
        // declare the run status change event
        public static event NotifyHandler NotifyEvent;

        public static void FireNotifyEvent(string description)
        {
            NotifyEventArgs e = new NotifyEventArgs(description);
            if (NotifyEvent != null)
            {
                NotifyEvent("NetworkProfileHelper", e);
            }
        }
        #endregion

        /// <summary>
        /// Saves the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="document">The document.</param>
        public static bool Save(List<NetworkProfile> profiles, string filename = "Profiles.xml")
        {
            XmlTextWriter writer = new XmlTextWriter(filename, null);
            writer.WriteStartDocument();
            writer.Indentation = 1;
            writer.IndentChar = '\t';

            writer.WriteStartElement("profiles");

            foreach (NetworkProfile item in profiles)
            {
                
                writer.WriteStartElement("profile");
                writer.WriteAttributeString("name", item.Name);
                writer.WriteAttributeString("id", item.Id.ToString());
                writer.WriteAttributeString("imageName", item.ImageName);

                {
                    WindowsNetworkCard nic = item.NetworkCardInfo;

                    writer.WriteStartElement("networkcard");

                    if (nic.Id.Length > 0)
                    {
                        XmlUtility.WriteAttributeIfPresent(writer, "id", nic.Id);
                        XmlUtility.WriteAttributeIfPresent(writer, "viewId", nic.ViewId);
                        XmlUtility.WriteAttributeIfPresent(writer, "hardwareName", nic.HardwareName);
                        XmlUtility.WriteAttributeIfPresent(writer, "name", nic.Name);
                        XmlUtility.WriteAttributeIfPresent(writer, "dhcp", nic.Dhcp.ToString());
                        XmlUtility.WriteAttributeIfPresent(writer, "ipAddress", nic.IpAddress);
                        XmlUtility.WriteAttributeIfPresent(writer, "subnetMask", nic.SubnetMask);
                        XmlUtility.WriteAttributeIfPresent(writer, "defaultGateway", nic.GatewayAddress);
                        XmlUtility.WriteAttributeIfPresent(writer, "macAddress", nic.MacAddress);
                        XmlUtility.WriteAttributeIfPresent(writer, "dynamicDns", nic.DynamicDNS.ToString());
                        XmlUtility.WriteAttributeIfPresent(writer, "dns", nic.Dns);
                        XmlUtility.WriteAttributeIfPresent(writer, "dns2", nic.Dns2);
                    }
                    writer.WriteEndElement();
                }

                {
                    ProxyConfiguration proxy = item.ProxyConfig;

                    writer.WriteStartElement("proxy");
                    writer.WriteAttributeString("enabled", proxy.Enabled.ToString());
                    XmlUtility.WriteAttributeIfPresent(writer, "serverAddress", proxy.ServerAddress);
                    XmlUtility.WriteAttributeIfPresent(writer, "port", proxy.Port.ToString());
                    writer.WriteAttributeString("overrideEnabled", proxy.ProxyOverrideEnabled.ToString());
                    XmlUtility.WriteAttributeIfPresent(writer, "proxyOverride", proxy.ProxyOverride.ToString());
                    writer.WriteEndElement();
                }

                {
                    writer.WriteStartElement("driveMaps");

                    List<DriveMap> listDriveMap = item.DriveMapList;

                    foreach (DriveMap itemDriveMap in listDriveMap)
                    {
                        writer.WriteStartElement("driveMap");
                        writer.WriteAttributeString("name", itemDriveMap.Name);
                        XmlUtility.WriteAttributeIfPresent(writer, "drive", itemDriveMap.Drive);
                        XmlUtility.WriteAttributeIfPresent(writer, "description", itemDriveMap.Description);
                        XmlUtility.WriteAttributeIfPresent(writer, "username", itemDriveMap.Username);
                        XmlUtility.WriteAttributeIfPresent(writer, "password", itemDriveMap.Password);
                        XmlUtility.WriteAttributeIfPresent(writer, "realPath", itemDriveMap.RealPath);
                        XmlUtility.WriteAttributeIfPresent(writer, "type", itemDriveMap.Type.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                {
                    writer.WriteStartElement("applications");

                    List<WindowsExecutable> listExe = item.ExecList;

                    foreach (WindowsExecutable itemExec in listExe)
                    {
                        writer.WriteStartElement("application");
                        writer.WriteAttributeString("name", itemExec.Name);
                        XmlUtility.WriteAttributeIfPresent(writer, "description", itemExec.Description);

                        XmlUtility.WriteAttributeIfPresent(writer, "directory", itemExec.Directory);
                        XmlUtility.WriteAttributeIfPresent(writer, "fileName", itemExec.File);
                        XmlUtility.WriteAttributeIfPresent(writer, "arguments", itemExec.Arguments);
                        XmlUtility.WriteAttributeIfPresent(writer, "wait", itemExec.WaitForExit.ToString());
                        XmlUtility.WriteAttributeIfPresent(writer, "kill", itemExec.Kill.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                {
                    writer.WriteStartElement("services");

                    List<IWindowsServiceInfo> listService = item.ServiceList;

                    foreach (IWindowsServiceInfo itemService in listService)
                    {
                        writer.WriteStartElement("service");
                        writer.WriteAttributeString("name", itemService.ServiceName);

                        XmlUtility.WriteAttributeIfPresent(writer, "status", itemService.ForcedStatus.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                // Printer
                {
                    writer.WriteStartElement("printer");
                    XmlUtility.WriteAttributeIfPresent(writer, "defaultPrinter", item.DefaultPrinter);
                    writer.WriteEndElement();
                }

                // disabled nic
                {
                    writer.WriteStartElement("forcedNics");

                    IList<WindowsNetworkCard> listDisabledNics = item.DisabledNetworkCards;

                    foreach (WindowsNetworkCard itemNIC in listDisabledNics)
                    {
                        writer.WriteStartElement("forcedNic");
                        writer.WriteAttributeString("id", itemNIC.Id);
                        writer.WriteAttributeString("hardwareName", itemNIC.HardwareName);
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                // wifi
                {
                    writer.WriteStartElement("wifi");
                    writer.WriteAttributeString("associatedSSID", item.AssociatedWifiSSID);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();

            return true;
        }

 


        /// <summary>
        /// Loads the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="imageName">default name of the image.</param>
        /// <returns></returns>
        public static List<NetworkProfile> Load(string fileName, string imageName = NetworkProfile.DEFAULT_PROFILE_IMAGE_NAME)
        {
            List<NetworkProfile> profiles = new List<NetworkProfile>();

            if (!File.Exists(fileName))
            {
                return null;
            }

            profiles.Clear();
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(fileName);
                NetworkProfile currentProfile = null;

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            switch (reader.Name)
                            {
                                case "profile":
                                    currentProfile = new NetworkProfile();
                                    currentProfile.Id = Int32.Parse(reader.GetAttribute("id"));
                                    currentProfile.Name = reader.GetAttribute("name");
                                    currentProfile.ImageName = XmlUtility.ReadAttributeIfPresent(reader, "imageName", imageName);
                                    profiles.Add(currentProfile);
                                    break;
                                case "networkcard":
                                    currentProfile.NetworkCardInfo = new WindowsNetworkCard();
                                    currentProfile.NetworkCardInfo.Id = XmlUtility.ReadAttributeIfPresent(reader, "id", "");

                                    currentProfile.NetworkCardInfo.ViewId = XmlUtility.ReadAttributeIfPresent(reader, "viewId", "");
                                    currentProfile.NetworkCardInfo.Name = XmlUtility.ReadAttributeIfPresent(reader, "name", "");

                                    currentProfile.NetworkCardInfo.Dhcp = Boolean.Parse(XmlUtility.ReadAttributeIfPresent(reader, "dhcp", Boolean.FalseString));
                                    currentProfile.NetworkCardInfo.IpAddress = XmlUtility.ReadAttributeIfPresent(reader, "ipAddress", "");
                                    currentProfile.NetworkCardInfo.SubnetMask = XmlUtility.ReadAttributeIfPresent(reader, "subnetMask", "");
                                    currentProfile.NetworkCardInfo.GatewayAddress = XmlUtility.ReadAttributeIfPresent(reader, "defaultGateway", "");

                                    currentProfile.NetworkCardInfo.MacAddress = XmlUtility.ReadAttributeIfPresent(reader, "macAddress", "");
                                    currentProfile.NetworkCardInfo.DynamicDNS = Boolean.Parse(XmlUtility.ReadAttributeIfPresent(reader, "dynamicDns", Boolean.FalseString));
                                    currentProfile.NetworkCardInfo.Dns = XmlUtility.ReadAttributeIfPresent(reader, "dns", "");
                                    currentProfile.NetworkCardInfo.Dns2 = XmlUtility.ReadAttributeIfPresent(reader, "dns2", "");

                                    currentProfile.NetworkCardInfo.HardwareName = XmlUtility.ReadAttributeIfPresent(reader, "hardwareName", "");

                                    break;
                                case "proxy":
                                    currentProfile.ProxyConfig = new ProxyConfiguration();
                                    currentProfile.ProxyConfig.Enabled = Boolean.Parse(XmlUtility.ReadAttributeIfPresent(reader, "enabled", Boolean.FalseString));
                                    currentProfile.ProxyConfig.ServerAddress = XmlUtility.ReadAttributeIfPresent(reader, "serverAddress", "");
                                    currentProfile.ProxyConfig.Port = Int32.Parse(XmlUtility.ReadAttributeIfPresent(reader, "port", "80"));
                                    currentProfile.ProxyConfig.ProxyOverrideEnabled = Boolean.Parse(XmlUtility.ReadAttributeIfPresent(reader, "overrideEnabled", Boolean.FalseString));
                                    currentProfile.ProxyConfig.ProxyOverride = XmlUtility.ReadAttributeIfPresent(reader, "proxyOverride", "");
                                    break;

                                case "application":
                                    WindowsExecutable application = new WindowsExecutable();
                                    application.Name = XmlUtility.ReadAttributeIfPresent(reader, "name", "");
                                    application.Arguments = XmlUtility.ReadAttributeIfPresent(reader, "arguments", "");
                                    application.Description = XmlUtility.ReadAttributeIfPresent(reader, "description", "");
                                    application.Directory = XmlUtility.ReadAttributeIfPresent(reader, "directory", "");
                                    application.File = XmlUtility.ReadAttributeIfPresent(reader, "fileName", "");
                                    application.WaitForExit = Boolean.Parse(XmlUtility.ReadAttributeIfPresent(reader, "wait", Boolean.TrueString));
                                    application.Kill = Boolean.Parse(XmlUtility.ReadAttributeIfPresent(reader, "kill", Boolean.TrueString));

                                    currentProfile.ExecList.Add(application);
                                    break;
                                case "service":
                                    WindowsServiceInfoImpl service = new WindowsServiceInfoImpl();

                                    service.ServiceName = XmlUtility.ReadAttributeIfPresent(reader, "name", "");

                                    string temp = XmlUtility.ReadAttributeIfPresent(reader, "status", ServiceForcedStatus.STOPPED.ToString());

                                    if (temp.Equals(ServiceForcedStatus.RUNNING.ToString()))
                                    {
                                        service.ForcedStatus = ServiceForcedStatus.RUNNING;
                                    }
                                    else if (temp.Equals(ServiceForcedStatus.STOPPED.ToString()))
                                    {
                                        service.ForcedStatus = ServiceForcedStatus.STOPPED;
                                    }
                                    else
                                    {
                                        service.ForcedStatus = ServiceForcedStatus.NONE;
                                    }
                                    currentProfile.ServiceList.Add(service);

                                    break;
                                case "driveMap":
                                    DriveMap drive = new DriveMap();
                                    drive.Name = XmlUtility.ReadAttributeIfPresent(reader, "name", "");
                                    drive.Drive = XmlUtility.ReadAttributeIfPresent(reader, "drive", "");
                                    drive.Description = XmlUtility.ReadAttributeIfPresent(reader, "description", "");
                                    drive.Username = XmlUtility.ReadAttributeIfPresent(reader, "username", "");
                                    drive.Password = XmlUtility.ReadAttributeIfPresent(reader, "password", "");
                                    drive.RealPath = XmlUtility.ReadAttributeIfPresent(reader, "realPath", "");
                                    string temp1 = XmlUtility.ReadAttributeIfPresent(reader, "type", DriveMapType.MOUNT.ToString());

                                    if (temp1.Equals(DriveMapType.MOUNT.ToString()))
                                    {
                                        drive.Type = DriveMapType.MOUNT;
                                    }
                                    else
                                    {
                                        drive.Type = DriveMapType.UNMOUNT;
                                    }

                                    currentProfile.DriveMapList.Add(drive);
                                    break;
                                case "printer":
                                    currentProfile.DefaultPrinter = XmlUtility.ReadAttributeIfPresent(reader, "defaultPrinter", "");
                                    break;
                                case "forcedNic":
                                    // disabled nic
                                    WindowsNetworkCard disabledNIC;

                                    disabledNIC = new WindowsNetworkCard();
                                    disabledNIC.Id = XmlUtility.ReadAttributeIfPresent(reader, "id", "");
                                    disabledNIC.HardwareName = XmlUtility.ReadAttributeIfPresent(reader, "hardwareName", "");

                                    currentProfile.DisabledNetworkCards.Add(disabledNIC);
                                    break;
                                case "wifi":
                                    // wifi
                                    string associatedSSID = XmlUtility.ReadAttributeIfPresent(reader, "associatedSSID", "");

                                    currentProfile.AssociatedWifiSSID = associatedSSID;
                                    break;
                            }
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            Console.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.                            
                            break;
                    }
                }



            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
            }

            return profiles;
        }

       

  

  
  


        /// <summary>
        /// Runs the disable network cards setup.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void RunDisableNetworkCardsSetup(NetworkProfile profile)
        {
            foreach (WindowsNetworkCard nic in profile.DisabledNetworkCards)
            {
                WindowsNetworkCardHelper.SetDeviceStatus(nic, false);
            }
        }

        /// <summary>
        /// Runs the network card setup.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void RunNetworkCardSetup(NetworkProfile profile)
        {
            WindowsNetworkCardManager.Apply(profile.NetworkCardInfo);
        }

        /// <summary>
        /// Runs the setup proxy.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void RunProxySetup(NetworkProfile profile)
        {
            ProxyConfigurationManager.Apply(profile.ProxyConfig);
        }

        /// <summary>
        /// Runs the drive mapping.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void RunDriveMapping(NetworkProfile profile)
        {
            DriveMapManager.Apply(profile.DriveMapList);
        }

        /// <summary>
        /// Runs the services setup.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void RunServicesSetup(NetworkProfile profile)
        {
            WindowsServiceManager.Apply(profile.ServiceList);
        }

        /// <summary>
        /// Runs the programs setup.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void RunProgramsSetup(NetworkProfile profile)
        {
            WindowsExecutableManager.Apply(profile.ExecList);
        }

        /// <summary>
        /// Runs the printer setup.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void RunPrinterSetup(NetworkProfile profile)
        {
            PrinterManager.SetDefaultPrinter(profile.DefaultPrinter);
        }

        /// <summary>
        /// Autoes the detect network profile.
        /// </summary>
        /// <param name="networkProfileList">The network profile list.</param>
        /// <returns></returns>
        public static NetworkProfile AutoDetectNetworkProfile(List<NetworkProfile> networkProfileList)
        {
            return AutoDetect.AutodetectNetworkProfile(networkProfileList);
        }
    }
}

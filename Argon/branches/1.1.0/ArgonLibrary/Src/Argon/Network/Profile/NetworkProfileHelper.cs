using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Argon.OperatingSystem;
using System.Diagnostics;
using Argon.Network.Profile;
using Argon.Network;
using System.IO;
using Argon.Network.Wifi;
using Argon.Network.Wifi.Windows7;

namespace Argon.Network.Profile
{
    public abstract class NetworkProfileHelper
    {

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public static bool Save(List<NetworkProfile> profiles, string fileName = "Profiles.xml")
        {            
            return Save(profiles, fileName);
        }


        /// <summary>
        /// Saves the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="document">The document.</param>
        protected static void Save(string filename, List<NetworkProfile> profiles)
        {           
            XmlTextWriter writer = new XmlTextWriter(filename, null);
            writer.WriteStartDocument();

            writer.WriteStartElement("profiles");

            foreach (NetworkProfile item in profiles)
            {
                writer.WriteStartElement("profile");
                writer.WriteAttributeString("name", item.Name);
                writer.WriteAttributeString("id", item.Id.ToString());

                {
                    IWindowsNetworkCardInfo nic = item.NetworkCardInfo;

                    writer.WriteStartElement("networkcard");

                    if (nic.Id.Length > 0)
                    {
                        WriteAttributeIfPresent(writer, "id", nic.Id);
                        WriteAttributeIfPresent(writer, "viewId", nic.ViewId);                        
                        WriteAttributeIfPresent(writer, "hardwareName", nic.HardwareName);
                        WriteAttributeIfPresent(writer, "name", nic.Name);                        
                        WriteAttributeIfPresent(writer, "dhcp", nic.Dhcp.ToString());
                        WriteAttributeIfPresent(writer, "ipAddress", nic.IpAddress);
                        WriteAttributeIfPresent(writer, "subnetMask", nic.SubnetMask);
                        WriteAttributeIfPresent(writer, "defaultGateway", nic.GatewayAddress);
                        WriteAttributeIfPresent(writer, "macAddress", nic.MacAddress);
                        WriteAttributeIfPresent(writer, "dynamicDns", nic.DynamicDNS.ToString());
                        WriteAttributeIfPresent(writer, "dns", nic.Dns);
                        WriteAttributeIfPresent(writer, "dns2", nic.Dns2);
                    }
                    writer.WriteEndElement();
                }

                {
                    ProxyConfiguration proxy = item.ProxyConfig;

                    writer.WriteStartElement("proxy");
                    writer.WriteAttributeString("enabled", proxy.Enabled.ToString());
                    WriteAttributeIfPresent(writer, "serverAddress", proxy.ServerAddress);
                    WriteAttributeIfPresent(writer, "port", proxy.Port.ToString());
                    writer.WriteAttributeString("overrideEnabled", proxy.ProxyOverrideEnabled.ToString());
                    WriteAttributeIfPresent(writer, "proxyOverride", proxy.ProxyOverride.ToString());
                    writer.WriteEndElement();
                }

                {
                    writer.WriteStartElement("driveMaps");

                    List<DriveMap> listDriveMap = item.DriveMapList;

                    foreach (DriveMap itemDriveMap in listDriveMap)
                    {
                        writer.WriteStartElement("driveMap");
                        writer.WriteAttributeString("name", itemDriveMap.Name);
                        WriteAttributeIfPresent(writer, "drive", itemDriveMap.Drive);
                        WriteAttributeIfPresent(writer, "description", itemDriveMap.Description);
                        WriteAttributeIfPresent(writer, "username", itemDriveMap.Username);
                        WriteAttributeIfPresent(writer, "password", itemDriveMap.Password);
                        WriteAttributeIfPresent(writer, "realPath", itemDriveMap.RealPath);
                        WriteAttributeIfPresent(writer, "type", itemDriveMap.Type.ToString());
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
                        WriteAttributeIfPresent(writer, "description", itemExec.Description);

                        WriteAttributeIfPresent(writer, "directory", itemExec.Directory);
                        WriteAttributeIfPresent(writer, "fileName", itemExec.File);
                        WriteAttributeIfPresent(writer, "arguments", itemExec.Arguments);
                        WriteAttributeIfPresent(writer, "wait", itemExec.WaitForExit.ToString());
                        WriteAttributeIfPresent(writer, "kill", itemExec.Kill.ToString());
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

                        WriteAttributeIfPresent(writer, "status", itemService.ForcedStatus.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                // Printer
                {
                    writer.WriteStartElement("printer");
                    WriteAttributeIfPresent(writer, "defaultPrinter", item.DefaultPrinter);
                    writer.WriteEndElement();
                }

                // disabled nic
                {
                    writer.WriteStartElement("forcedNics");

                    IList<IWindowsNetworkCardInfo> listDisabledNics = item.DisabledNetworkCards;

                    foreach (IWindowsNetworkCardInfo itemNIC in listDisabledNics)
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
        }

        /// <summary>
        /// Writes the attribute if present.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <param name="value">The value.</param>
        internal static void WriteAttributeIfPresent(XmlTextWriter writer, string attributeName, string value)
        {
            if (value != null)
            {
                writer.WriteAttributeString(attributeName, value);
            }
        }

        /// <summary>
        /// Reads the attribute if present.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        internal static string ReadAttributeIfPresent(XmlTextReader reader, string attributeName, string value)
        {
            string ret;

            ret = reader.GetAttribute(attributeName);
            if (ret == null) ret = value;
            return ret;

        }

        /// <summary>
        /// Loads the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public static List<NetworkProfile> Load(string fileName)
        {
            List<NetworkProfile> profiles = new List<NetworkProfile>();

            if (!File.Exists(fileName))
            {
                return profiles;
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
                                    profiles.Add(currentProfile);
                                    break;
                                case "networkcard":
                                    currentProfile.NetworkCardInfo = new NetworkCardInfoImpl();
                                    currentProfile.NetworkCardInfo.Id = ReadAttributeIfPresent(reader, "id", "");

                                    currentProfile.NetworkCardInfo.ViewId = ReadAttributeIfPresent(reader, "viewId", "");
                                    currentProfile.NetworkCardInfo.Name = ReadAttributeIfPresent(reader, "name", "");

                                    currentProfile.NetworkCardInfo.Dhcp = Boolean.Parse(ReadAttributeIfPresent(reader, "dhcp",Boolean.FalseString));
                                    currentProfile.NetworkCardInfo.IpAddress = ReadAttributeIfPresent(reader, "ipAddress", "");
                                    currentProfile.NetworkCardInfo.SubnetMask = ReadAttributeIfPresent(reader, "subnetMask", "");
                                    currentProfile.NetworkCardInfo.GatewayAddress = ReadAttributeIfPresent(reader, "defaultGateway", "");

                                    currentProfile.NetworkCardInfo.MacAddress = ReadAttributeIfPresent(reader, "macAddress", "");
                                    currentProfile.NetworkCardInfo.DynamicDNS = Boolean.Parse(ReadAttributeIfPresent(reader, "dynamicDns", Boolean.FalseString));
                                    currentProfile.NetworkCardInfo.Dns = ReadAttributeIfPresent(reader, "dns", "");
                                    currentProfile.NetworkCardInfo.Dns2 = ReadAttributeIfPresent(reader, "dns2", "");
                                    
                                    currentProfile.NetworkCardInfo.HardwareName = ReadAttributeIfPresent(reader, "hardwareName", "");
                                    
                                    break;
                                case "proxy":
                                    currentProfile.ProxyConfig = new ProxyConfiguration();
                                    currentProfile.ProxyConfig.Enabled = Boolean.Parse(ReadAttributeIfPresent(reader,"enabled", Boolean.FalseString));
                                    currentProfile.ProxyConfig.ServerAddress = ReadAttributeIfPresent(reader, "serverAddress", "");
                                    currentProfile.ProxyConfig.Port = Int32.Parse(ReadAttributeIfPresent(reader, "port", "80"));
                                    currentProfile.ProxyConfig.ProxyOverrideEnabled = Boolean.Parse(ReadAttributeIfPresent(reader, "overrideEnabled", Boolean.FalseString));
                                    currentProfile.ProxyConfig.ProxyOverride = ReadAttributeIfPresent(reader, "proxyOverride", "");                    
                                    break;

                                case "application":
                                    WindowsExecutable application = new WindowsExecutable();
                                    application.Name = ReadAttributeIfPresent(reader, "name", "");
                                    application.Arguments = ReadAttributeIfPresent(reader, "arguments", "");
                                    application.Description = ReadAttributeIfPresent(reader, "description", "");
                                    application.Directory = ReadAttributeIfPresent(reader, "directory", "");
                                    application.File = ReadAttributeIfPresent(reader, "fileName", "");
                                    application.WaitForExit = Boolean.Parse(ReadAttributeIfPresent(reader, "wait", Boolean.TrueString));
                                    application.Kill = Boolean.Parse(ReadAttributeIfPresent(reader, "kill", Boolean.TrueString));

                                    currentProfile.ExecList.Add(application);
                                    break;
                                case "service":
                                    WindowsServiceInfoImpl service = new WindowsServiceInfoImpl();

                                    service.ServiceName = ReadAttributeIfPresent(reader, "name", "");

                                    string temp = ReadAttributeIfPresent(reader, "status", ServiceForcedStatus.STOPPED.ToString());

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
                                    drive.Name = ReadAttributeIfPresent(reader, "name", "");
                                    drive.Drive = ReadAttributeIfPresent(reader, "drive", "");
                                    drive.Description = ReadAttributeIfPresent(reader, "description", "");
                                    drive.Username = ReadAttributeIfPresent(reader, "username", "");
                                    drive.Password = ReadAttributeIfPresent(reader, "password", "");
                                    drive.RealPath = ReadAttributeIfPresent(reader, "realPath", "");
                                    string temp1 = ReadAttributeIfPresent(reader, "type",DriveMapType.MOUNT.ToString());

                                    if (temp1.Equals(DriveMapType.MOUNT.ToString()))
                                    {
                                        drive.Type=DriveMapType.MOUNT;
                                    } else 
                                    {
                                        drive.Type=DriveMapType.UNMOUNT;
                                    }

                                    currentProfile.DriveMapList.Add(drive);
                                    break;
                                case "printer":                                    
                                    currentProfile.DefaultPrinter = ReadAttributeIfPresent(reader, "defaultPrinter", "");
                                    break;
                                case "forcedNic":                                    
                                        // disabled nic
                                        WindowsNetworkCard disabledNIC;

                                        disabledNIC = new WindowsNetworkCard();
                                        disabledNIC.Id = ReadAttributeIfPresent(reader, "id", "");
                                        disabledNIC.HardwareName= ReadAttributeIfPresent(reader, "hardwareName", "");    

                                        currentProfile.DisabledNetworkCards.Add(disabledNIC);                                    
                                    break;
                                case "wifi":
                                    // wifi
                                   string associatedSSID=ReadAttributeIfPresent(reader, "associatedSSID", "");

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
        /// Autodetects the network profile. For the moment it works only for wifi connections!
        /// If no connections found, it return null.
        /// </summary>
        /// 
        /// <param name="profiles">The profiles.</param>
        /// <returns></returns>
        public static NetworkProfile AutodetectNetworkProfile(List<NetworkProfile> profiles)
        {            
            List<WindowsNetworkCard> enabledCardList = new List<WindowsNetworkCard>();

            // get nic enabled
            List<WindowsNetworkCard> listCard = WindowsNetworkCardManager.GetWindowsNetworkCardList();

            foreach (WindowsNetworkCard nic in listCard)
            {
                Console.WriteLine(nic.Description + " = " + nic.Enabled + " " + nic.Status);
                Console.WriteLine(nic.Connected);

                if (nic.Connected)
                {
                    enabledCardList.Add(nic);
                }
            }

            // if there's no enabled card, it's a problem!
            if (enabledCardList.Count == 0) { Console.WriteLine("No nic found"); return null; }

            // get wifi connected 
            WifiProfile currentWifiProfile = WifiConfigurationManager.GetActiveWifiProfile();            

            // if there's a wifi connection
            if (currentWifiProfile != null)
            {
                // check there is a profile for that ssid and nic
                foreach (NetworkProfile profile in profiles)
                {
                    if (currentWifiProfile.SSID.Equals(profile.AssociatedWifiSSID) && currentWifiProfile.InterfaceMAC.Equals(profile.NetworkCardInfo.MacAddress))
                    {
                        // found profile associated wifi ssid
                        Console.WriteLine("Found profile " + profile.Name + " for ssid " + profile.AssociatedWifiSSID);
                        return profile;
                    }
                }

                // there's no appropriated profile for wifi!                                     
            }
            else
            {
                // no wifi avaiable
                
            }

            return null;
        }
    }
}

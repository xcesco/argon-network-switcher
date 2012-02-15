using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;

using System.IO;
using Argon.Windows.Network.Wifi;


namespace Argon.Windows.Network.Profile
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class NetworkProfileHelper
    {

        /// <summary>
        /// Saves the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="document">The document.</param>
        public static bool Save(List<NetworkProfile> profiles, string filename = "Profiles.xml")
        {
            XmlTextWriter writer = new XmlTextWriter(filename, null);
            writer.WriteStartDocument();

            writer.WriteStartElement("profiles");

            foreach (NetworkProfile item in profiles)
            {
                writer.WriteStartElement("profile");
                writer.WriteAttributeString("name", item.Name);
                writer.WriteAttributeString("id", item.Id.ToString());
                writer.WriteAttributeString("imageName", item.ImageName);

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

                    IList<WindowsNetworkCard> listDisabledNics = item.DisabledNetworkCards;

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

            return true;
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
                                    currentProfile.ImageName = ReadAttributeIfPresent(reader, "imageName", imageName);
                                    profiles.Add(currentProfile);
                                    break;
                                case "networkcard":
                                    currentProfile.NetworkCardInfo = new NetworkCardInfoImpl();
                                    currentProfile.NetworkCardInfo.Id = ReadAttributeIfPresent(reader, "id", "");

                                    currentProfile.NetworkCardInfo.ViewId = ReadAttributeIfPresent(reader, "viewId", "");
                                    currentProfile.NetworkCardInfo.Name = ReadAttributeIfPresent(reader, "name", "");

                                    currentProfile.NetworkCardInfo.Dhcp = Boolean.Parse(ReadAttributeIfPresent(reader, "dhcp", Boolean.FalseString));
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
                                    currentProfile.ProxyConfig.Enabled = Boolean.Parse(ReadAttributeIfPresent(reader, "enabled", Boolean.FalseString));
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
                                    string temp1 = ReadAttributeIfPresent(reader, "type", DriveMapType.MOUNT.ToString());

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
                                    currentProfile.DefaultPrinter = ReadAttributeIfPresent(reader, "defaultPrinter", "");
                                    break;
                                case "forcedNic":
                                    // disabled nic
                                    WindowsNetworkCard disabledNIC;

                                    disabledNIC = new WindowsNetworkCard();
                                    disabledNIC.Id = ReadAttributeIfPresent(reader, "id", "");
                                    disabledNIC.HardwareName = ReadAttributeIfPresent(reader, "hardwareName", "");

                                    currentProfile.DisabledNetworkCards.Add(disabledNIC);
                                    break;
                                case "wifi":
                                    // wifi
                                    string associatedSSID = ReadAttributeIfPresent(reader, "associatedSSID", "");

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

        public const int TIME_WAIT = 5000;

        /// <summary>
        /// Setups the network card for autodetect. Gets the nic associated to profiles and
        /// try to enable it. Then, disable every nic that not have a profile associated.
        /// Then wait for a while
        /// </summary>
        /// <param name="profiles">The profiles.</param>
        internal static void SetupNetworkCardForAutodetect(List<NetworkProfile> profiles)
        {
            // Get every card and try to enable it
            List<WindowsNetworkCard> allCardList = WindowsNetworkCardManager.WindowsNetworkCardList;
            HashSet<WindowsNetworkCard> validCardSet = new HashSet<WindowsNetworkCard>();

            // take only the card with a profile associated
            foreach (WindowsNetworkCard item in allCardList)
            {
                foreach (NetworkProfile itemProfile in profiles)
                {
                    if (item.Id.Equals(itemProfile.NetworkCardInfo.Id) && !validCardSet.Contains(item))
                    {
                        validCardSet.Add(item);
                        Debug.WriteLine("Add card " + item.Name + " to enabled card set");
                        break;
                    }
                }
            }

            Debug.WriteLine("Found " + validCardSet.Count + " valid card!");
            Debug.WriteLine("Now disable every card not in valid set and enable all the card in valid set are disabled");

            // if a nic is used in a profile, we enable it,
            // otherwise disable it
            foreach (WindowsNetworkCard item in allCardList)
            {
                if (item.Enabled && !validCardSet.Contains(item))
                {
                    Debug.WriteLine("Disable card " + item.Name, ", it's not in valid set");
                    WindowsNetworkCardHelper.SetDeviceStatus(item, false);
                }
                else if (!item.Enabled && validCardSet.Contains(item))
                {
                    Debug.WriteLine("Enable card " + item.Name + " it's in valid set but disabled");
                    WindowsNetworkCardHelper.SetDeviceStatus(item, true);
                }
            }
            // wait for a while
            Debug.WriteLine("Wait " + (TIME_WAIT * 2) + " ms.");
            System.Threading.Thread.Sleep(TIME_WAIT * 2);
        }

        /// <summary>
        /// Finds the valid network profiles. Filter the profile with enabled card. If a profile has an SSI associated
        /// this SSID must be the current SSID
        /// </summary>
        /// <param name="profiles">The profiles.</param>
        /// <param name="enabledCardList">The enabled card list.</param>
        /// <param name="currentWifiProfile">The current wifi profile.</param>
        /// <returns></returns>
        internal static List<NetworkProfile> FindValidNetworkProfiles(List<NetworkProfile> profiles, List<WindowsNetworkCard> enabledCardList, WifiProfile currentWifiProfile)
        {
            List<NetworkProfile> enabledProfileList = new List<NetworkProfile>();
            foreach (WindowsNetworkCard itemCard in enabledCardList)
            {
                foreach (NetworkProfile itemProfile in profiles)
                {
                    // check if card is right
                    if (itemCard.Id.Equals(itemProfile.NetworkCardInfo.Id))
                    {
                        // check if is a wifi connection
                        if (currentWifiProfile != null)
                        {
                            // check if card has an associated ssid
                            if (itemProfile.AssociatedWifiSSID != null && itemProfile.AssociatedWifiSSID.Trim().Length > 0)
                            {
                                // check if profile ssid and current ssid are equal
                                if (currentWifiProfile.SSID.Equals(itemProfile.AssociatedWifiSSID))
                                {
                                    enabledProfileList.Add(itemProfile);
                                }
                                else
                                {
                                    // wrogin SSID, ignore it
                                }
                            }
                            else
                            {
                                // no SSID associated, every SSID is ok
                                enabledProfileList.Add(itemProfile);
                            }
                        }
                        else
                        {
                            // there's no current wifi network connected
                            // card is enabled, profile is associated this profile
                            enabledProfileList.Add(itemProfile);
                        }
                    }
                }
            }
            return enabledProfileList;
        }

        private static int CompareCardBySpeed(WindowsNetworkCard x, WindowsNetworkCard y)
        {
            return x.MaxSpeed.CompareTo(y.MaxSpeed);
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
            if (profiles == null || profiles.Count == 0)
            {
                Debug.WriteLine("There're no profiles!!!");
                return null;
            }
            // initial setup for cards
            SetupNetworkCardForAutodetect(profiles);

            NetworkProfile selectedProfile = null;

            // enable card
            List<WindowsNetworkCard> enabledCardList = WindowsNetworkCardManager.EnabledWindowsNetworkCardList;
            // wifi connected 
            WifiProfile currentWifiProfile = WifiProfileManager.ActiveWifiProfile;

            // order list by maxSpeed
            enabledCardList.Sort(CompareCardBySpeed);

            // if there's no enabled card, it's a problem!
            if (enabledCardList.Count == 0) { Debug.WriteLine("No card enabled, found"); return null; }

            List<NetworkProfile> enabledProfileList = FindValidNetworkProfiles(profiles, enabledCardList, currentWifiProfile);

            // assert: enabledProfile contains the right profiles. Now we have to test it. 
            // the first with ping ok it's ok!
            bool pingOk;
            foreach (NetworkProfile item in enabledProfileList)
            {
                Debug.WriteLine("Start analizing profile " + item.Name + " with card " + item.NetworkCardInfo.Name);

                WindowsNetworkCardHelper.SetDeviceStatus(item.NetworkCardInfo, false);

                RunDisableNetworkCardsSetup(item);

                RunNetworkCardSetup(item);

                //WindowsNetworkCardHelper.SetDeviceStatus(item.NetworkCardInfo, true);

                // wait for a while
                Debug.WriteLine("Wait " + (TIME_WAIT * 4) + " ms.");
                System.Threading.Thread.Sleep(TIME_WAIT * 4);

                WindowsNetworkCard card = WindowsNetworkCardManager.RefreshStatus(item.NetworkCardInfo.Id);

                // refresh current WifiProfile
                currentWifiProfile = WifiProfileManager.GetActiveWifiProfileForCard(card);

                if (currentWifiProfile != null && currentWifiProfile.SSID.Equals(item.AssociatedWifiSSID) && card.NetConnectionStatus == 2)
                {
                    // ok, we found it!!!
                    selectedProfile = item;
                    Debug.WriteLine("The card " + card.Name + " are connected with right SSID (" + currentWifiProfile.SSID + ")");
                    Debug.WriteLine("Selected profile " + item.Name + " without do anything else!!");
                    break;
                }
                else
                {
                    pingOk = false;

                    Debug.WriteLine("The card " + card.Name + " are in status " + card.NetConnectionStatus);

                    // test both static config or dynamic config
                    pingOk = PingHelper.RunPing(card.GatewayAddress);
                    pingOk = pingOk || PingHelper.RunPing(card.CurrentGatewayAddress);

                    Debug.WriteLine("For card " + card.Name + " and profile " + item.Name + ", ping to gateway are " + pingOk);

                    if (pingOk)
                    {
                        selectedProfile = item;
                        Debug.WriteLine("Selected profile " + item.Name + "!!");
                        break;
                    }
                }

                Debug.WriteLine("Stop analizing profile " + item.Name + ", go to next profile");
            }

            // restore initial enabled card
            if (selectedProfile == null)
            {
                Debug.WriteLine("No profile found, so restore status card");
                foreach (WindowsNetworkCard item in enabledCardList)
                {
                    Debug.WriteLine("Enable card " + item.Name);
                    WindowsNetworkCardHelper.SetDeviceStatus(item, true);
                }
            }

            return selectedProfile;
        }


        /// <summary>
        /// Runs the disable network cards setup.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public static void RunDisableNetworkCardsSetup(NetworkProfile profile)
        {
            foreach (IWindowsNetworkCardInfo nic in profile.DisabledNetworkCards)
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
    }
}

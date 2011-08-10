using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
using System.Management;
using Microsoft.Win32;
using Argon.FileSystem;
using System.Threading;
using System.Windows.Forms;
using Argon.Hardware;

namespace Argon.OperatingSystem
{
    /// <summary>
    /// Manager for the Network Card Interfaces
    /// </summary>
    public abstract class WindowsNetworkCardManager
    {
        /// <summary>
        /// Gets the windows services list.
        /// </summary>
        /// <returns></returns>
        public static List<WindowsNetworkCard> GetWindowsNetworkCardList()
        {
            List<WindowsNetworkCard> array = GetListFromWMI();
            
            return array;
        }

       

        /// <summary>
        /// Gets the list from WMI.
        /// </summary>
        /// <returns></returns>
        protected static List<WindowsNetworkCard> GetListFromWMI()
        {
            List<WindowsNetworkCard> lista = new List<WindowsNetworkCard>();
            // prepariamo WMI
            //ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled='TRUE'");
            ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled='TRUE'");
            ManagementObjectCollection queryCollection = query.Get();

            // prepariamo .NET library
            NetworkInterface[] listaNI = NetworkInterface.GetAllNetworkInterfaces();

            WindowsNetworkCard card;

            foreach (NetworkInterface item in listaNI)
            {
                if (item.Id.Contains("Loopback") || item.Name.Contains("Loopback"))
                {
                    continue;
                }

                // create card and put info from WMI
                card = new WindowsNetworkCard();                
                MapDataFromNetwork(item, card);

                // check if we can access to registry for the nic
                if (!IsNetworkCardInRegistry(card)) continue;                
                MapDataFromRegistry(card);
                lista.Add(card);

                foreach (ManagementObject item2 in queryCollection)
                {
                    if (card.Id.Equals((string)item2["SettingID"]))
                    {
                        /*
                        foreach (PropertyData p in item2.Properties)
                        {
                            Console.WriteLine(p.Name + "=" + p.Value);
                        }

                        Console.WriteLine(@"----------------------------\n\n\n");                        
                        */
                        MapDataFromWMI(item2, card);
                    }

                }

            }

            return lista;
        }

        internal static Boolean IsNetworkCardInRegistry(WindowsNetworkCard card)
        {
            string sKey = @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\" + card.Id;
            return RegistryUtility.Exists(RegistryKeyType.LocalMachine, sKey);
        }


        /// <summary>
        /// Maps the data from network.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="card">The card.</param>
        internal static void MapDataFromNetwork(NetworkInterface item, WindowsNetworkCard card)
        {
            card.Name = item.Name;
            card.Id = item.Id;
        }

        /// <summary>
        /// Maps the data from WMI.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="card">The card.</param>
        internal static void MapDataFromWMI(ManagementObject input, WindowsNetworkCard card)
        {
            //card.Id = (string)input["SettingID"];
            card.ViewId = fixViewId((string)input["Caption"]);
            card.HardwareName=fixHardwareName((string)input["Caption"]);
            card.Description = (string)input["Description"];
            card.MacAddress = (string)input["MACAddress"];
            card.Dhcp = (bool)input["DHCPEnabled"];

            /*
            string[] tempIpAddress=(string[])input["IPAddress"];

            if (tempIpAddress!=null)
            {
                card.CurrentIpAddress = tempIpAddress[0];
            }

            string[] tempDefaultGatewayAddress = (string[])input["DefaultIpGateway"];

            if (tempDefaultGatewayAddress != null)
            {
                card.CurrentDefaultGateway = tempDefaultGatewayAddress[0];
            }*/

            card.WinsEnableLMHostsLookup = (bool)input["WINSEnableLMHostsLookup"];
            card.WinsHostLookupFile = (string)input["WINSHostLookupFile"];
            card.WinsPrimaryServer = (string)input["WINSPrimaryServer"];
            card.WinsSecondaryServer = (string)input["WINSSecondaryServer"];          
        }

        /// <summary>
        /// Maps the data from registry.
        /// </summary>
        /// <param name="card">The card.</param>
        internal static void MapDataFromRegistry(WindowsNetworkCard card)
        {
            RegistryKey regKey = null;

            string sKey = @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\" + card.Id;

            try
            {
                regKey = Registry.LocalMachine.OpenSubKey(sKey);
                card.IpAddress = RegistryUtility.ReadStringValue(RegistryKeyType.LocalMachine, sKey, "IPAddress");
                card.GatewayAddress = RegistryUtility.ReadStringValue(RegistryKeyType.LocalMachine, sKey, "DefaultGateway");
                card.SubnetMask = RegistryUtility.ReadStringValue(RegistryKeyType.LocalMachine, sKey, "SubnetMask");

                card.Dhcp = RegistryUtility.ReadIntValue(RegistryKeyType.LocalMachine, sKey, "EnableDhcp") == 1 ? true : false;

                string[] dns = RegistryUtility.ReadStringValue(RegistryKeyType.LocalMachine, sKey, "NameServer").Split(',');

                if (dns.Length >= 1) card.Dns = dns[0];
                if (dns.Length >= 2) card.Dns2 = dns[1];

                card.CurrentIpAddress = RegistryUtility.ReadStringValue(RegistryKeyType.LocalMachine, sKey, "DhcpIPAddress");
                card.CurrentGatewayAddress = RegistryUtility.ReadStringValue(RegistryKeyType.LocalMachine, sKey, "DhcpDefaultGateway");
                card.CurrentSubnetMask = RegistryUtility.ReadStringValue(RegistryKeyType.LocalMachine, sKey, "DhcpSubnetMask");

                string[] cdns = RegistryUtility.ReadStringValue(RegistryKeyType.LocalMachine, sKey, "DhcpServer").Split(' ');

                if (cdns.Length >= 1) card.CurrentDns = cdns[0];
                if (cdns.Length >= 2) card.CurrentDns2 = cdns[1];

            }
            finally
            {
                if (regKey != null) regKey.Close();
            }

        }

        /// <summary>
        /// Writes the data into registry.
        /// </summary>
        /// <param name="card">The card.</param>
        public static void WriteDataIntoRegistry(IWindowsNetworkCardInfo card)
        {
            RegistryKey regKey = null;
            
            string sKey = @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\" + card.Id;

            try
            {
                regKey = Registry.LocalMachine.OpenSubKey(sKey);

                RegistryUtility.WriteIntValue(RegistryKeyType.LocalMachine, sKey, "EnableDhcp", card.Dhcp ? 1 : 0);

                if (card.Dhcp)
                {
                    String[] temp={"0.0.0.0"};
                    RegistryUtility.WriteMultiStringValue(RegistryKeyType.LocalMachine, sKey, "IPAddress", temp);
                    RegistryUtility.WriteMultiStringValue(RegistryKeyType.LocalMachine, sKey, "SubnetMask", temp);

                    temp[0] = "";
                    RegistryUtility.WriteMultiStringValue(RegistryKeyType.LocalMachine, sKey, "DefaultGateway", temp);
                }
                else
                {
                    String[] temp = { "0.0.0.0" };

                    temp[0]=card.IpAddress;
                    RegistryUtility.WriteMultiStringValue(RegistryKeyType.LocalMachine, sKey, "IPAddress",temp );
                    temp[0]=card.SubnetMask;
                    RegistryUtility.WriteMultiStringValue(RegistryKeyType.LocalMachine, sKey, "SubnetMask", temp);
                    temp[0] = card.GatewayAddress;
                    RegistryUtility.WriteMultiStringValue(RegistryKeyType.LocalMachine, sKey, "DefaultGateway",temp );
                }                                                                

               string dns = "";
               if (!card.DynamicDNS)
               {
                   if (card.Dns.Length >= 1) dns = card.Dns;
                   if (card.Dns2.Length >= 1) dns += "," + card.Dns2;
               }
               RegistryUtility.WriteStringValue(RegistryKeyType.LocalMachine, sKey, "NameServer", dns);                              
            }
            finally
            {
                if (regKey != null) regKey.Close();
            }
        }



        /// <summary>
        /// Fixes the caption.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        internal static string fixCaption(string name)
        {
            int a = name.IndexOf("[");
            int b = name.IndexOf("]");

            name = name.Substring(0, a) + name.Substring(b + 2);

            return name;
        }

        /// <summary>
        /// Fixes the view id.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        internal static string fixViewId(string name)
        {
            int a = name.IndexOf("[");
            int b = name.IndexOf("]");

            name = name.Substring(a, b + 1);

            return name;
        }

        /// <summary>
        /// Fixes the view id.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        internal static string fixHardwareName(string name)
        {            
            int b = name.IndexOf("]");

            name = name.Substring(b+1).Trim();

            return name;
        }


        /// <summary>
        /// Gets the windows services table.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, WindowsNetworkCard> GetWindowsNetworkCardTable()
        {
            List<WindowsNetworkCard> lista = GetListFromWMI();
            Dictionary<string, WindowsNetworkCard> table = new Dictionary<string, WindowsNetworkCard>();

            foreach (WindowsNetworkCard item in lista)
            {
                table.Add(item.Id, item);
            }

            return table;
        }       

        /// <summary>
        /// Applies the specified card.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns></returns>
        public static bool Apply(IWindowsNetworkCardInfo card)
        {            
            bool ret = true;
            HardwareLibrary hl = new HardwareLibrary();

            if (card.HardwareName.Length > 0)
            {
                string[] hwName={card.HardwareName};
                hl.SetDeviceState(hwName, false);
            }
            WindowsNetworkCardManager.WriteDataIntoRegistry(card);

            if (card.HardwareName.Length > 0)
            {
                string[] hwName = { card.HardwareName };
                hl.SetDeviceState(hwName, true);
            }
            
            return ret;

        }
    }
}

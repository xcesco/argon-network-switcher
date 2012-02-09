using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.OperatingSystem;
using System.Diagnostics;
using System.Management;
using Argon.Network;
using Argon.OperatingSystem.Network;
//using NUnit.Framework;

namespace Argon.OperatingSystem
{
    [TestClass]
    public class WindowsNetworkCardManagerTest
    {
        [TestMethod]
        public void ApplyNetworkCardNoDhcp()
        {
            string name = "VMware Network Adapter VMnet9";

            string ip = "192.168.2.10";
            string subnet = "255.255.255.0";
            string gateway = "192.168.2.1";

            string dns1 = "192.168.2.60";
            string dns2 = "192.168.2.70";

            bool dhcp = false;

            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.GetWindowsNetworkCardList();

            foreach (WindowsNetworkCard item in lista)
            {
                if (item.Name.Equals(name))
                {
                    item.Dhcp = dhcp;
                    item.IpAddress = ip;
                    item.SubnetMask = subnet;
                    item.GatewayAddress = gateway;
                    item.Dns = dns1;
                    item.Dns2 = dns2;

                    Debug.WriteLine("Eseguo cambio per " + item.Id);
                    WindowsNetworkCardManager.Apply(item);
                }
            }
            Debug.WriteLine("Esecuzione terminata");
        }

        [TestMethod]
        public void ApplyNetworkCardDhcp()
        {
            string name = "VMware Network Adapter VMnet9";

            bool dhcp = true;

            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.GetWindowsNetworkCardList();

            foreach (WindowsNetworkCard item in lista)
            {
                if (item.Name.Equals(name))
                {
                    item.Dhcp = dhcp;
                    
                    Console.WriteLine("Eseguo cambio per " + item.Id);
                    WindowsNetworkCardManager.Apply(item);
                }
            }
            Debug.WriteLine("Esecuzione terminata");
        }

        /// <summary>
        /// Lists result of a WMI query.
        /// </summary>
        [TestMethod]
        public void ListWMIQuery()
        {
            {
                // adapters
                ManagementObjectSearcher queryDevice = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter ");//where GUID is not null ");
                //ManagementObjectSearcher queryDevice = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");//where GUID is not null ");
                // configurations
                //ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter  WHERE (ConfigManagerErrorCode = 0  OR (ConfigManagerErrorCode = 22 AND NetConnectionStatus = 0))");// where IPEnabled='TRUE'");

                ManagementObjectCollection collection = queryDevice.Get();

                foreach (ManagementObject item in collection)
                {
                    Debug.WriteLine("-------");
                    foreach (PropertyData item2 in item.Properties)
                    {
                        Debug.WriteLine(item2.Name + "=" + item2.Value);
                    }

                    
                }
            }

            Debug.WriteLine("=============================================================");
            Debug.WriteLine("=============================================================");
            Debug.WriteLine("=============================================================");

            {
                ManagementObjectSearcher queryDevice = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");//where GUID is not null ");
                // configurations
                //ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter  WHERE (ConfigManagerErrorCode = 0  OR (ConfigManagerErrorCode = 22 AND NetConnectionStatus = 0))");// where IPEnabled='TRUE'");

                ManagementObjectCollection collection = queryDevice.Get();

                foreach (ManagementObject item in collection)
                {
                    Debug.WriteLine("-------");
                    foreach (PropertyData item2 in item.Properties)
                    {
                        Debug.WriteLine(item2.Name + "=" + item2.Value);
                    }
                }
            }

        }
        
        [TestMethod]
        public void ListAllNetwork()
        {
            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.GetWindowsNetworkCardList();

            foreach (WindowsNetworkCard item in lista)
            {
                Debug.WriteLine("-------------------------------------------");
                Debug.WriteLine("Id           : " + item.Id);
                Debug.WriteLine("Adapter Type : " + item.AdapterType);
                Debug.WriteLine("ViewId       : " + item.ViewId);
                Debug.WriteLine("Name         : " + item.Name);
                Debug.WriteLine("HardwareName : " + item.HardwareName);
                Debug.WriteLine("Description  : " + item.Description);
                Debug.WriteLine("MAC          : " + item.MacAddress);
                Debug.WriteLine("DHCP         : " + item.Dhcp);
                Debug.WriteLine("IP           : " + item.IpAddress);
                Debug.WriteLine("SubnetMask   : " + item.SubnetMask);
                Debug.WriteLine("Gateway      : " + item.GatewayAddress);
                Debug.WriteLine("DNS1         : " + item.Dns);
                Debug.WriteLine("DNS2         : " + item.Dns2);

                Debug.WriteLine("Current IP           : " + item.CurrentIpAddress);
                Debug.WriteLine("Current SubnetMask   : " + item.CurrentSubnetMask);
                Debug.WriteLine("Current Gateway      : " + item.CurrentGatewayAddress);
                Debug.WriteLine("Current DNS1         : " + item.CurrentDns);
                Debug.WriteLine("Current DNS2         : " + item.CurrentDns2);

                Debug.WriteLine("");
                Debug.WriteLine("WinsEnableLMHostsLookup: " + item.WinsEnableLMHostsLookup);
                Debug.WriteLine("WinsHostLookupFile     : " + item.WinsHostLookupFile);
                Debug.WriteLine("WinsPrimaryServer      : " + item.WinsPrimaryServer);
                Debug.WriteLine("WinsSecondaryServer    : " + item.WinsSecondaryServer);

                Debug.WriteLine("Status    : " + item.Status);
                Debug.WriteLine("NetConnectionStatus    : " + item.NetConnectionStatus);           
               
                // Gateway
                // DDNS
                // DNS1
                // DNS2
                // LMHOSTS
                // ServerWINS
                // ServerWINS2

            }
            Debug.WriteLine("Esecuzione terminata");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.OperatingSystem;
using System.Diagnostics;
using System.Management;
using Argon.Windows.Network;
using Argon.Common;
using Argon.Windows.Network.Wifi;
using System.Net.NetworkInformation;
using System.Threading;

namespace Argon.Windows.Network
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

            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.WindowsNetworkCardList;

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

            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.WindowsNetworkCardList;

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
            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.WindowsNetworkCardList;

            foreach (WindowsNetworkCard item in lista)
            {
                Debug.WriteLine("-------------------------------------------");
                Debug.WriteLine("Id           : " + item.Id);
                Debug.WriteLine("Adapter Type : " + item.AdapterType);
                Debug.WriteLine("Card Type : " + item.CardType);
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

                Debug.WriteLine("MaxSpeed    : " + item.MaxSpeed); 
               
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

        [TestMethod]
        public void TestPerformance1()
        {
            PerformanceUtility pu = new PerformanceUtility();
            pu.StartTimer();
            List<WindowsNetworkCard> items=WindowsNetworkCardManager.EnabledWindowsNetworkCardList;
            long time=pu.GetEnlapsedTime();

            Debug.WriteLine("Executed EnabledWindowsNetworkCardList in "+time+" ms");
        }

        [TestMethod]
        public void TestPerformance2()
        {
            PerformanceUtility pu = new PerformanceUtility();
            pu.StartTimer();
            List<WindowsNetworkCard> items = WindowsNetworkCardManager.WindowsNetworkCardList;
            long time = pu.GetEnlapsedTime();

            Debug.WriteLine("Executed WindowsNetworkCardList in " + time + " ms");
        }

        [TestMethod]
        public void TestPerformance3()
        {
            PerformanceUtility pu = new PerformanceUtility();
            pu.StartTimer();
            WifiProfile items = WifiProfileManager.ActiveWifiProfile;
            long time = pu.GetEnlapsedTime();

            Debug.WriteLine("Executed WifiProfileManager.ActiveWifiProfile in " + time + " ms");
        }

        [TestMethod]
        public void Test04()
        {
            finito = false;
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);

            StatisticalData data = ClimbSmallHill;
            IAsyncResult ar = data.BeginInvoke(null, null);
            
            while (!ar.IsCompleted)
            {
                Console.WriteLine("Waiting.....");
                Thread.Sleep(20*IDLE_TIME);

            }
            Console.WriteLine("Wait is finished...");
            Console.WriteLine("Time Taken for  climbing ....{0}",
            data.EndInvoke(ar).ToString() + "..Seconds");

            Console.ReadLine();
            Console.WriteLine("Esecuzione terminata");

            NetworkChange.NetworkAvailabilityChanged -= NetworkChange_NetworkAvailabilityChanged;
        }

        public static int numberofFeets = 0;
        public delegate long StatisticalData();

        public bool finito;

        public int MAX_WAIT = 15000;
        public int IDLE_TIME = 10;


        long ClimbSmallHill()
        {
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < MAX_WAIT / IDLE_TIME; i++)
            {
                Thread.Sleep(IDLE_TIME);

                if (finito)
                {
                    sw.Stop();
                    Console.WriteLine("Termino");
                    return sw.ElapsedMilliseconds;
                }

            }
            
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }


        void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
            {
                finito = true;
                Console.WriteLine("Network is Available");
            }
            else
            {
                Console.WriteLine("Network is Unavailable");
            }
        }
        

    }
}

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.Windows7.Network.Wifi;
using Argon.OperatingSystem.Network.Wifi;

namespace Argon.Windows7.Network.Wifi
{
    [TestClass]
    public class WifiConfigManagerTest
    {
        [TestMethod]
        public void TestListNetwork()
        {
            List<WifiConfiguration> items=WifiConfigurationManager.GetWifiNetworkList(null);

            foreach (WifiConfiguration item in items)
            {
                Console.WriteLine("Name {0} Guid {1} Description {2} MAC {3}", item.InterfaceName, item.InterfaceGuid, item.InterfaceDescription, item.InterfaceMAC);
                Console.WriteLine("Algorithm [{0}] ID [{1}] SSID [{2}]", item.NetworkAuthAlgorithm, item.NetworkID, item.NetworkSSID);
               

                Console.WriteLine("Signal Quality {0}", item.SignalQuality);
            }
        }

         [TestMethod]
        public void TestGetActiveWifiProfile()
        {
            WifiProfile item = WifiConfigurationManager.ActiveWifiProfile;

            if (item != null)
            {
                Console.WriteLine("Profile name '{0}'", item.SSID);
                Console.WriteLine("\tName '{0}' Guid '{1}' \tDescription '{2}' \tMAC '{3}'", item.InterfaceName, item.InterfaceGuid, item.InterfaceDescription, item.InterfaceMAC);
                Console.WriteLine("\tConnected {0}", item.Connected);
                //Console.WriteLine("Name [{0}]", item.Name);
                // Console.WriteLine("Xml [{0}]", item.Xml);
            }
            else
            {
                Console.WriteLine("No active profile wifi found");
            }
        }

        

        [TestMethod]
        public void TestListProfile()
        {
            List<WifiProfile> items = WifiConfigurationManager.GetWifiProfileList(null);

            foreach (WifiProfile item in items)
            {
                Console.WriteLine("Profile name '{0}'", item.SSID);
                Console.WriteLine("\tName '{0}' Guid '{1}' \tDescription '{2}' \tMAC '{3}'", item.InterfaceName, item.InterfaceGuid, item.InterfaceDescription, item.InterfaceMAC);
                Console.WriteLine("\tConnected {0}", item.Connected);
                //Console.WriteLine("Name [{0}]", item.Name);
               // Console.WriteLine("Xml [{0}]", item.Xml);
            }
        }
    }
}

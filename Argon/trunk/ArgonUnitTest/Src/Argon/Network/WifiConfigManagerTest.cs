using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Argon.Network
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
        public void TestListProfile()
        {
            List<WifiProfile> items = WifiConfigurationManager.GetWifiProfileList(null);

            foreach (WifiProfile item in items)
            {
                Console.WriteLine("Name {0} Guid {1} Description {2} MAC {3}", item.InterfaceName, item.InterfaceGuid, item.InterfaceDescription, item.InterfaceMAC);
                Console.WriteLine("Name [{0}]", item.Name);
                Console.WriteLine("Xml [{0}]", item.Xml);
            }
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.Windows.Network.Wifi;

namespace Argon.Network.Wifi
{
    [TestClass]
    public class WifiProfileManagerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            List<WifiProfile> WifiProfiles=WifiProfileManager.WifiProfiles;

            foreach (WifiProfile item in WifiProfiles)
            {
                Console.WriteLine(item.SSID + " " + item.InterfaceName);
            }
        }
    }
}

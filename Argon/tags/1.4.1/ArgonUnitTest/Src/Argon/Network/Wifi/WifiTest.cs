using System;
using System.Collections.Generic;
using System.Management;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Argon.Windows.Network.Wifi
{

    [TestClass]
    public class WifiTest
    {
        [TestMethod]
        public void TestWifiProfileOnCards()
        {            
            List<WifiProfile> profile = WifiProfileManager.WifiProfiles;

            foreach (WifiProfile item in profile)
            {
                Debug.WriteLine(" Current wifi profile " + item.SSID + " on " +item.InterfaceName+" "+ item.InterfaceGuid);
            }

        }
        
        [TestMethod]
        public void TestCurrentWifiProfile()
        {
            try
            {
                WifiProfile profile = WifiProfileManager.ActiveWifiProfile;

                if (profile != null)
                {                                     
                    Debug.WriteLine(" Current wifi profile "+profile.SSID+" on "+profile.InterfaceName+" "+profile.InterfaceGuid);
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("An error occurred while querying for WMI data: " + e.Message);
            }
        }
    }
}

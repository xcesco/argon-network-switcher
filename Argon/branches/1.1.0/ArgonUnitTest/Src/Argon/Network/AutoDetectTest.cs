using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Argon.OperatingSystem;
using Argon.Network.Wifi;
using Argon.Network.Wifi.Windows7;

namespace Argon.Network
{
    [TestClass]
    public class AutoDetectTest
    {
       
        [TestMethod]
        public void TestAutoDetect()
        {
            Console.WriteLine("Start");

            List<WindowsNetworkCard> enabledCardList = new List<WindowsNetworkCard>();

            // get nic enabled
            List<WindowsNetworkCard> listCard=WindowsNetworkCardManager.GetWindowsNetworkCardList();

            foreach (WindowsNetworkCard nic in listCard)
            {
                Console.WriteLine(nic.Description +" = "+nic.Enabled+" "+nic.Status);
                Console.WriteLine(nic.Connected);

                if (nic.Connected)
                {
                    enabledCardList.Add(nic);
                }        
            }

            // get wifi connected 
            WifiProfile item = WifiConfigurationManager.GetActiveWifiProfile();
            WindowsNetworkCard currentNic = null;

            // if there's a wifi connection
            if (item != null)
            {
                // get the nic
                foreach (WindowsNetworkCard wnc in enabledCardList)
                {
                    if (wnc.MacAddress.Equals(item.InterfaceMAC))
                    {
                        currentNic = wnc;
                        break;
                    }
                }
                
            }
            else
            {
                // no wifi avaiable
            }

            Console.WriteLine("Current nic "+currentNic.HardwareName);

            Console.WriteLine("Finished!");
        }
    }
}

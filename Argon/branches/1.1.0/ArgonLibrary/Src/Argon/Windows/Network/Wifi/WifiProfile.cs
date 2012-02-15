using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Argon.Windows.Network.Wifi
{
    /// <summary>
    /// TODO:http://theroadtodelphi.wordpress.com/2011/10/15/all-about-wifi-networks-and-wifi-adapters-using-the-wmi-and-delphi/
    /// </summary>
    public class WifiProfile
    {
        public string SSID { get; set; }
        
        public string InterfaceName { get; set; }

        public string InterfaceGuid { get; set; }

        public string InterfaceDescription { get; set; }

        public string InterfaceMAC { get; set; }
        
    }
}

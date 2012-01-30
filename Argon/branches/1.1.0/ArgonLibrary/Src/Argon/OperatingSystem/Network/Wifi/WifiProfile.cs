using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Argon.OperatingSystem.Network.Wifi
{
    /// <summary>
    /// 
    /// </summary>
    public class WifiProfile
    {
        public string SSID { get; set; }
        
        public string InterfaceName { get; set; }

        public string InterfaceGuid { get; set; }

        public string InterfaceDescription { get; set; }

        public string InterfaceMAC { get; set; }

        public Boolean Connected { get; set; }
    }
}

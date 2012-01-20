using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Argon.Network.Wifi.Windows7
{
    public class WifiConfiguration
    {
        public string InterfaceDescription { get; set; }

        public string InterfaceName { get; set; }

        public string InterfaceGuid { get; set; }

        public Wlan.Dot11Ssid NetworkSSID { get; set; }

        public string NetworkID { get; set; }

        public uint SignalQuality { get; set; }

        public Wlan.Dot11AuthAlgorithm NetworkAuthAlgorithm { get; set; }

        public string InterfaceMAC { get; set; }
    }
}

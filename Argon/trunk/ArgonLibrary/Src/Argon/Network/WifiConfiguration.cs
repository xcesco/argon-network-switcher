using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Argon.Network
{
    public class WifiConfiguration
    {
        public string InterfaceDescription { get; set; }

        public string InterfaceName { get; set; }

        public Guid InterfaceGuid { get; set; }

        public NativeWifi.Wlan.Dot11Ssid NetworkSSID { get; set; }

        public string NetworkID { get; set; }

        public uint SignalQuality { get; set; }

        public NativeWifi.Wlan.Dot11AuthAlgorithm NetworkAuthAlgorithm { get; set; }

        public string InterfaceMAC { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Network.Wifi;
using Argon.OperatingSystem;
using Argon.Network.Wifi.Windows7;

namespace Argon.Src.Argon.Network.Wifi
{
    public abstract class WifiProfileHelper
    {
        public static WifiProfile GetActiveWifiProfile()
        {
            switch (OSInfo.OperatingSystem)
            {
                case OperatingSystemType.WINDOWS_XP:
                    throw(new Exception("Not supported for now"));                    
                case OperatingSystemType.WINDOWS_7:
                    return WifiConfigurationManager.GetActiveWifiProfile();                    
                default:
                    throw (new Exception("Operating system not supported!"));                    
            }

            throw (new Exception("Operating system not supported!"));
        }
    }
}

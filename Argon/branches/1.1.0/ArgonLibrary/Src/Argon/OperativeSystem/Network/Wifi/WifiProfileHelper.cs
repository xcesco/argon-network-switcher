using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.OperatingSystem;
using Argon.Windows7.Network.Wifi;

namespace Argon.OperatingSystem.Network.Wifi
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
                    return WifiConfigurationManager.ActiveWifiProfile;                    
                default:
                    throw (new Exception("Operating system not supported!"));                    
            }

            throw (new Exception("Operating system not supported!"));
        }
    }
}

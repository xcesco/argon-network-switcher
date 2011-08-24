using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.OperatingSystem;

namespace Argon.Hardware
{
    public class HardwareHelper
    {
        public static bool SetDeviceStatus(IWindowsNetworkCardInfo card, bool status)
        {
            if (OSInfo.Name == "Windows XP")
            {
                WinXPHardwareLibrary hl = new WinXPHardwareLibrary();
                string[] oparams={card.HardwareName};
                return hl.SetDeviceState(oparams, status);
            }
            else
            {
                Win7HardwareLibrary hl = new Win7HardwareLibrary();
                return hl.SetDeviceState(card.Id, status);
            }            
        }
    }
}

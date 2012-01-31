using System;
using System.Collections.Generic;
using System.Text;
using Argon.OperatingSystem;
using Argon.WindowsXP;
using Argon.Windows7;

namespace Argon.OperatingSystem.Network
{
    /// <summary>
    /// Helper for network adapters
    /// </summary>
    public class NetworkAdapterHelper
    {
        /// <summary>
        /// Sets the device status.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <param name="status">if set to <c>true</c> [status].</param>
        /// <returns></returns>
        public static bool SetDeviceStatus(IWindowsNetworkCardInfo card, bool status)
        {
            bool ret;
            switch (OSInfo.OperatingSystem)
            {
                case OperatingSystemType.WINDOWS_XP:
                    {
                        WinXPHardwareLibrary hl = new WinXPHardwareLibrary();
                        string[] oparams = { card.HardwareName };
                        ret = hl.SetDeviceState(oparams, status);
                    }
                    break;
                case OperatingSystemType.WINDOWS_7:
                    {
                        Win7HardwareLibrary hl = new Win7HardwareLibrary();
                        ret = hl.SetDeviceState(card.Id, status);
                    }
                    break;
                default:
                    {
                        throw (new Exception("Operating system not supported!"));
                    }
            }

            return ret;

        }
    }
}

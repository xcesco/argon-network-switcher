using System;
using System.Collections.Generic;
using System.Text;
using Argon.OperatingSystem;
using Argon.WindowsXP;
using Argon.Windows7;
using Argon.WindowsXP.Network;
using Argon.Windows7.Network;

namespace Argon.OperatingSystem.Network
{
    /// <summary>
    /// Helper for network adapters
    /// </summary>
    public class WindowsNetworkCardHelper
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
                        WinXPNetworkCardHelper hl = new WinXPNetworkCardHelper();
                        string[] oparams = { card.HardwareName };
                        ret = hl.SetDeviceState(oparams, status);
                    }
                    break;
                case OperatingSystemType.WINDOWS_7:
                    {
                        Win7NetworkCardHelper hl = new Win7NetworkCardHelper();
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

using System;
using System.Collections.Generic;
using System.Text;
using Argon.WindowsXP;
using Argon.Windows7;
using Argon.WindowsXP.Network;
using Argon.Windows7.Network;

/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
namespace Argon.Windows.Network
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

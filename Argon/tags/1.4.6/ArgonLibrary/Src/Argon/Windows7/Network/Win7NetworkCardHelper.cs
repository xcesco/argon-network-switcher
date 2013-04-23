using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Management;
using Argon.WindowsXP.Network;


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
namespace Argon.Windows7.Network
{

    /// <summary>
    /// Hardware library for windows seven
    /// </summary>
    public class Win7NetworkCardHelper
    {

        /// <summary>
        /// Sets the state of the device.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="bEnable">if set to <c>true</c> [b enable].</param>
        /// <returns></returns>
        public bool SetDeviceState(string guid, bool bEnable)
        {
            SelectQuery query = new SelectQuery("Win32_NetworkAdapter","GUID='"+guid+"'");
            ManagementObjectSearcher search = new ManagementObjectSearcher(query);
            foreach (ManagementObject result in search.Get())
            {
                //result.Pu
                WmiNetworkAdapter adapter = new WmiNetworkAdapter(result);

                if (adapter.GUID.Equals(guid))
                {
                    Object[] invokerParam={};
                    uint ret = 0;

                    if (bEnable)
                    {
                        ret = adapter.Enable();
                    }
                    else
                    {
                        ret = adapter.Disable();
                    }
                    
                    return true;
                }
            }

            return false;
        }
    }

           
}

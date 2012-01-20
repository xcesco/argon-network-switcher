using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Management;


namespace Argon.OperatingSystem.Windows7
{

    /// <summary>
    /// Hardware library for windows seven
    /// </summary>
    public class Win7HardwareLibrary
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

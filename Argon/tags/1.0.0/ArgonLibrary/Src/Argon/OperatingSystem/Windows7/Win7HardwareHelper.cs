﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Management;
/*
 * HardwareHelperLib
 * ===========================================================
 * Windows XP SP2, VS2005 C#.NET, DotNet 2.0
 * HH Lib is a hardware helper for library for C#.
 * It can be used for notifications of hardware add/remove
 * events, retrieving a list of hardware currently connected,
 * and enabling or disabling devices.
 * ===========================================================
 * LOG:      Who?    When?       What?
 * (v)1.0.0  WJF     11/26/07    Original Implementation
 */
namespace Argon.OperatingSystem
{
    

    /// <summary>
    /// 
    /// </summary>
    public class Win7HardwareLibrary
    {        

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

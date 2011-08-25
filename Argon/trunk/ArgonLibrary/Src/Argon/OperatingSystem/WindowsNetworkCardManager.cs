using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
using System.Management;
using Microsoft.Win32;
using Argon.FileSystem;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using Argon.OperatingSystem.WindowsXP;
using Argon.OperatingSystem.Windows7;

namespace Argon.OperatingSystem
{
    /// <summary>
    /// Manager for the Network Card Interfaces
    /// </summary>
    public abstract class WindowsNetworkCardManager
    {
        /// <summary>
        /// Gets the windows services list.
        /// </summary>
        /// <returns></returns>
        public static List<WindowsNetworkCard> GetWindowsNetworkCardList()
        {
            List<WindowsNetworkCard> array;
            if (OSInfo.Name == "Windows XP")
            {
                array=WinXPNetworkCardManager.GetWindowsNetworkCardList();
            }
            else
            {
                array = Win7NetworkCardManager.GetWindowsNetworkCardList();
            }
                        
            return array;
        }


        public static void WriteDataIntoRegistry(IWindowsNetworkCardInfo card)
        {
            if (OSInfo.Name == "Windows XP")
            {
                WinXPNetworkCardManager.WriteDataIntoRegistry(card);
            }
            else
            {
                Win7NetworkCardManager.WriteDataIntoRegistry(card);
            }
        }


        public static void Apply(IWindowsNetworkCardInfo card)
        {
            if (OSInfo.Name == "Windows XP")
            {
                WinXPNetworkCardManager.Apply(card);
            }
            else
            {
                Win7NetworkCardManager.Apply(card);
            }
        }
    }
}

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
using Argon.OperatingSystem;
using Argon.WindowsXP.Network;
using Argon.Windows7.Network;

namespace Argon.OperatingSystem.Network
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

            switch (OSInfo.OperatingSystem)
            {
                case OperatingSystemType.WINDOWS_XP:
                    {
                        array = WinXPNetworkCardManager.GetWindowsNetworkCardList();
                        break;
                    }

                case OperatingSystemType.WINDOWS_7:
                    {
                        array = Win7NetworkCardManager.GetWindowsNetworkCardList();
                        break;
                    }
                default:
                    throw (new Exception("Operating system not supported"));


            }


            return array;
        }


        /// <summary>
        /// Writes the data into registry.
        /// </summary>
        /// <param name="card">The card.</param>
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

        /// <summary>
        /// Applies the specified card.
        /// </summary>
        /// <param name="card">The card.</param>
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

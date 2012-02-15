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
using Argon.WindowsXP.Network;
using Argon.Windows7.Network;
using Argon.Windows;

namespace Argon.Windows.Network
{
   

    /// <summary>
    /// Manager for the Network Card Interfaces
    /// </summary>
    public abstract class WindowsNetworkCardManager
    {

        /// <summary>
        /// Refreshes status.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public static WindowsNetworkCard RefreshStatus(string id)
        {
            List<WindowsNetworkCard> networkCardList = WindowsNetworkCardList;

            foreach (WindowsNetworkCard item in networkCardList)
            {
                if (item.Id.Equals(id))
                {
                    return item;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the enabled windows network cards list.
        /// Every card in this list has the MaxSpeed and AdapterType valorized.
        /// </summary>
        public static List<WindowsNetworkCard> EnabledWindowsNetworkCardList
        {
            get
            {
                List<WindowsNetworkCard> enabledCardList = new List<WindowsNetworkCard>();
                // get nic enabled
                List<WindowsNetworkCard> listCard = GetWindowsNetworkCardList();

                foreach (WindowsNetworkCard nic in listCard)
                {
                    Console.WriteLine(nic.Description + " = " + nic.Enabled + " " + nic.Status);
                    Console.WriteLine(nic.Connected);
                    // if nic is connected we insert it in enabled card list
                    if (nic.Connected)
                    {
                        enabledCardList.Add(nic);
                    }
                }

                return enabledCardList;
            }
        }

        /// <summary>
        /// Gets the windows network cards list.
        /// The disabled cards in this list has the MaxSpeed and AdapterType set to null.
        /// </summary>
        public static List<WindowsNetworkCard> WindowsNetworkCardList
        {
            get
            {
                return GetWindowsNetworkCardList();
            }
        }

        /// <summary>
        /// Gets the windows services list.
        /// The disabled cards in this list has the MaxSpeed and AdapterType set to null.
        /// </summary>
        /// <returns></returns>
        internal static List<WindowsNetworkCard> GetWindowsNetworkCardList()
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

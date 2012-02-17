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
    public static class WindowsNetworkCardManager
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

        public static Dictionary<string, WindowsNetworkCard> WindowsNetworkCardTable
        {
            get
            {
                List<WindowsNetworkCard> list = GetWindowsNetworkCardList();

                return ConvertListToTable(list);                
            }
        }


        public static Dictionary<string, WindowsNetworkCard> EnabledWindowsNetworkCardTable
        {
            get
            {
                List<WindowsNetworkCard> list = EnabledWindowsNetworkCardList;

                return ConvertListToTable(list);                
            }
        }

        internal static Dictionary<string, WindowsNetworkCard> ConvertListToTable(List<WindowsNetworkCard> list)
        {
            Dictionary<string, WindowsNetworkCard> table = new Dictionary<string, WindowsNetworkCard>();

            foreach (WindowsNetworkCard item in list)
            {
                table.Add(item.Id, item);
            }

            return table;
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

            foreach(WindowsNetworkCard item in array)
            {
                // try to determine the card type
                // wifi
                if (CheckIfWirelessCard(item)) item.CardType = WindowsNetworkCardType.WIRELESS;
                if (CheckIfVirtualCard(item)) item.CardType = WindowsNetworkCardType.VIRTUAL;
                if (CheckIfBluetoothCard(item)) item.CardType = WindowsNetworkCardType.BLUETOOTH;
                if (CheckIfFireWireCard(item)) item.CardType = WindowsNetworkCardType.FIREWIRE;
                item.CardType = WindowsNetworkCardType.ETHERNET;
            }


            return array;
        }

        /// <summary>
        /// Checks the name of if present in hardware.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <param name="checkValues">The check values.</param>
        /// <returns></returns>
        internal static bool CheckIfPresentInHardwareName(WindowsNetworkCard card, params string[] checkValues)
        {
            string value = card.HardwareName.ToLower();

            foreach (string item in checkValues)
            {
                if (value.Contains(item.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if wireless card.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns></returns>
        internal static bool CheckIfWirelessCard(WindowsNetworkCard card)
        {
            return CheckIfPresentInHardwareName(card,"Wireless","WLAN","Wi-Fi","802.11a", "802.11b", "802.11g", "802.11n");            
        }

        /// <summary>
        /// Checks if virtual card.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns></returns>
        internal static bool CheckIfVirtualCard(WindowsNetworkCard card)
        {
            return CheckIfPresentInHardwareName(card,"VMWare", "VirtualBox");            
        }

        /// <summary>
        /// Checks if bluetooth card.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns></returns>
        internal static bool CheckIfBluetoothCard(WindowsNetworkCard card)
        {
            return CheckIfPresentInHardwareName(card,"Bluetooth");            
        } 

        internal static bool CheckIfFireWireCard(WindowsNetworkCard card)
        {
            return CheckIfPresentInHardwareName(card,"1394","Firewire" );            
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

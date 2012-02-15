using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Management;

namespace Argon.Windows.Network.Wifi
{
    public class WifiProfileManager
    {
        /// <summary>
        /// Gets the current wifi profile.
        /// </summary>
        public static WifiProfile ActiveWifiProfile
        {
            get
            {
                WifiProfile profile = null;
                string infoString = "";

                infoString = ExecuteNetsh("wlan show interfaces");
                string[] buffer = SplitStringInLines(infoString);
                if (buffer.Length <= 4) return profile;
                profile = GetCurrentProfile(buffer);

                return profile;
            }
        }

        /// <summary>
        /// Gets the wifi profiles.
        /// </summary>
        public static List<WifiProfile> WifiProfiles
        {
            get
            {
                List<WifiProfile> listProfiles = new List<WifiProfile>();
                string infoString = "";

                infoString = ExecuteNetsh("wlan show profiles");
                string[] buffer = SplitStringInLines(infoString);

                if (buffer.Length <= 2) return listProfiles;
                listProfiles = GetProfiles(buffer);

                return listProfiles;
            }
        }



        /// <summary>
        /// Executes the netsh.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        internal static string ExecuteNetsh(string parameters)
        {
            ProcessStartInfo info = new ProcessStartInfo("netsh", parameters);
            info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = info;
            proc.Start();
            string infoString = proc.StandardOutput.ReadToEnd();

            Debug.WriteLine(infoString);

            return infoString;
        }

        /// <summary>
        /// Splits the string in lines.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        internal static string[] SplitStringInLines(string text)
        {
            string[] result = Regex.Split(text, "\r\n");

            return result;
        }

        /// <summary>
        /// Gets the profiles.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <returns></returns>
        internal static List<WifiProfile> GetProfiles(string[] buffer)
        {
            List<WifiProfile> ret = new List<WifiProfile>();
            List<WindowsNetworkCard> cards = WindowsNetworkCardManager.WindowsNetworkCardList;
            WindowsNetworkCard currentNic = null;
            WifiProfile currentWifiProfile = null;

            foreach (string item in buffer)
            {
                if (item.EndsWith(":"))
                {
                    currentNic = null;
                    // first row, get the current nics
                    foreach (WindowsNetworkCard nic in cards)
                    {
                        if (item.Contains(nic.Description + ":"))
                        {
                            currentNic = nic;
                            break;
                        }
                    }
                }
                else if (item.Contains(":") && currentNic != null)
                {
                    currentWifiProfile = new WifiProfile();
                    string ssid = item.Substring(item.IndexOf(":") + 1).Trim();
                    currentWifiProfile.SSID = ssid;
                    currentWifiProfile.InterfaceGuid = currentNic.Id;

                    currentWifiProfile.InterfaceMAC = currentNic.MacAddress;
                    currentWifiProfile.InterfaceDescription = currentNic.Description;
                    currentWifiProfile.InterfaceName = currentNic.Name;

                    ret.Add(currentWifiProfile);
                }
            }

            return ret;
        }

        /// <summary>
        /// Gets the current profile.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        internal static WifiProfile GetCurrentProfile(string[] input)
        {
            WifiProfile result = null;
            foreach (string item in input)
            {
                if (item.IndexOf("GUID") >= 0)
                {
                    result = new WifiProfile();
                    string guid = item.Substring(item.IndexOf(":") + 1).Trim();
                    result.InterfaceGuid = "{" + guid.ToUpper() + "}";
                }

                if (item.IndexOf("SSID") >= 0 && item.IndexOf("BSSID") == -1)
                {
                    string ssid = item.Substring(item.IndexOf(":") + 1).Trim();
                    result.SSID = ssid;
                }
            }

            WindowsNetworkCard card = WindowsNetworkCardManager.RefreshStatus(result.InterfaceGuid);

            result.InterfaceMAC = card.MacAddress;
            result.InterfaceDescription = card.Description;
            result.InterfaceName = card.Name;

            return result;
        }

        /// <summary>
        /// Gets the active wifi profile for card.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <returns></returns>
        public static WifiProfile GetActiveWifiProfileForCard(WindowsNetworkCard card)
        {
            WifiProfile wifi = ActiveWifiProfile;

            if (wifi != null && wifi.InterfaceMAC.Equals(card.MacAddress)) return wifi;

            return null;
        }
    }
}

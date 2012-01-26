using System;
using System.Collections.Generic;
using System.Text;

namespace Argon.Network.Wifi.Windows7
{
    public abstract class WifiConfigurationManager
    {
        /// <summary>
        /// Converts a 802.11 SSID to a string.
        /// </summary>
        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

        static string GetStringForMAC(String mac)
        {
            string buffer="";
            string sep="";

            for(int i=0;i<12;i+=2)
            {
                buffer+=sep+mac[i]+mac[i+1];
                sep=":";
            }

            return buffer.ToUpper();
        }

        /// <summary>
        /// Sets the wifi profile.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="profileName">Name of the profile.</param>
        /// <returns></returns>
        public static Boolean SetWifiProfile(string guid, string profileName)
        {
            WlanClient client = new WlanClient();
            string localGuid;

            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                localGuid = "{" + wlanIface.InterfaceGuid.ToString().ToUpper() + "}";

                if (localGuid.Equals(guid))
                {
                    foreach (Wlan.WlanProfileInfo profileInfo in wlanIface.GetProfiles())
                    {
                        if (profileInfo.profileName.Equals(profileName))
                        {
                            wlanIface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, profileName);
                            return true;
                        }
                    }
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the active wifi profile.
        /// </summary>
        /// <returns></returns>
        public static WifiProfile GetActiveWifiProfile()
        {
            WlanClient client = new WlanClient();
            WlanClient.WlanInterface[] interfaces = client.Interfaces;           

            WifiProfile profile=null;
            String currentProfile = null;

            foreach (WlanClient.WlanInterface card in interfaces)
            {
                try
                {
                    currentProfile = null;
                    currentProfile = card.CurrentConnection.profileName;
                    if (String.IsNullOrEmpty(currentProfile)) continue;
                } catch(Exception)
                {
                    continue;
                }
                
                profile = new WifiProfile();

                profile.Name = currentProfile;

                profile.InterfaceName = card.InterfaceName;
                profile.InterfaceGuid = "{" + card.InterfaceGuid.ToString().ToUpper() + "}";
                profile.InterfaceDescription = card.InterfaceDescription;

                profile.InterfaceMAC = GetStringForMAC(card.NetworkInterface.GetPhysicalAddress().ToString());
                
                profile.Connected = true;
                break;
            }

            return profile;
        }

        /// <summary>
        /// Gets the wifi profile list.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public static List<WifiProfile> GetWifiProfileList(string guid)
        {
            WlanClient client = new WlanClient();
            List<WifiProfile> list = new List<WifiProfile>();

            WifiProfile profile;
            WlanClient.WlanInterface[] interfaces=client.Interfaces;
            foreach (WlanClient.WlanInterface card in interfaces)
            {
                string currentProfile = "";
                currentProfile=card.CurrentConnection.profileName;
                
                // Retrieves XML configurations of existing profiles.
                // This can assist you in constructing your own XML configuration
                // (that is, it will give you an example to follow).
                Wlan.WlanProfileInfo[] profiles = card.GetProfiles();
                foreach (Wlan.WlanProfileInfo profileInfo in profiles)
                {
                    profile = new WifiProfile();                  

                    profile.InterfaceName = card.InterfaceName;
                    profile.InterfaceGuid = "{" + card.InterfaceGuid.ToString().ToUpper() + "}";
                    profile.InterfaceDescription = card.InterfaceDescription;

                    profile.InterfaceMAC = GetStringForMAC(card.NetworkInterface.GetPhysicalAddress().ToString());

                    if (guid != null && !profile.InterfaceGuid.Equals(guid)) break; 
                    
                    string name = profileInfo.profileName; // this is typically the network's SSID
                  
                    profile.Name = name;
                  
                    if (profile.Name.Equals(currentProfile))
                    {
                        profile.Connected = true;
                    }

                    list.Add(profile);
                }                
            }
            return list;
        }

        public static List<WifiConfiguration> GetWifiNetworkList(string MacAddress)
        {
            WlanClient client = new WlanClient();
            List<WifiConfiguration> list = new List<WifiConfiguration>();

            WifiConfiguration config;
            // foreach wifiinterface
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {              
                // Lists all networks with WEP security
                Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    config = new WifiConfiguration();

                    config.InterfaceName = wlanIface.InterfaceName;
                    config.InterfaceGuid = "{" + wlanIface.InterfaceGuid.ToString().ToUpper() + "}";
                    config.InterfaceDescription = wlanIface.InterfaceDescription;

                    config.InterfaceMAC=GetStringForMAC(wlanIface.NetworkInterface.GetPhysicalAddress().ToString());
                 
                    if (MacAddress!=null && !config.InterfaceMAC.Equals(MacAddress)) break; 

                    // network information
                    config.NetworkSSID=network.dot11Ssid;
                    config.NetworkID = GetStringForSSID(network.dot11Ssid);
                    config.SignalQuality = network.wlanSignalQuality;
                    config.NetworkAuthAlgorithm = network.dot11DefaultAuthAlgorithm;                    

                    list.Add(config);                   
                }
            }

            return list;
        }
    }
}

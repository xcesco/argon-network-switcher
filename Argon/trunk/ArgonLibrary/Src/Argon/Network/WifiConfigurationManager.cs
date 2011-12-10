using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NativeWifi;

namespace Argon.Network
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

        public static Boolean SetWifiProfile(string MacAddress, string profileName)
        {
            WlanClient client = new WlanClient();
            string mac;

            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                mac=GetStringForMAC(wlanIface.NetworkInterface.GetPhysicalAddress().ToString());

                if (mac.Equals(MacAddress))
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

        public static List<WifiProfile> GetWifiProfileList(string MacAddress)
        {
            WlanClient client = new WlanClient();
            List<WifiProfile> list = new List<WifiProfile>();

            WifiProfile profile;
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                // Retrieves XML configurations of existing profiles.
                // This can assist you in constructing your own XML configuration
                // (that is, it will give you an example to follow).
                foreach (Wlan.WlanProfileInfo profileInfo in wlanIface.GetProfiles())
                {
                    profile = new WifiProfile();

                    profile.InterfaceName = wlanIface.InterfaceName;
                    profile.InterfaceGuid = wlanIface.InterfaceGuid;
                    profile.InterfaceDescription = wlanIface.InterfaceDescription;

                    profile.InterfaceMAC = GetStringForMAC(wlanIface.NetworkInterface.GetPhysicalAddress().ToString());

                    if (MacAddress != null && !profile.InterfaceMAC.Equals(MacAddress)) break; 
                    
                    string name = profileInfo.profileName; // this is typically the network's SSID
                    string xml = wlanIface.GetProfileXml(profileInfo.profileName);

                    profile.Name = name;
                    profile.Xml = xml;

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
                    config.InterfaceGuid = wlanIface.InterfaceGuid;
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

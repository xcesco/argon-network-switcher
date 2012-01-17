using System;
using System.Collections.Generic;
using System.Text;
using Argon.FileSystem;

namespace Argon.Network
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class FirexfoxProxyConfigurationAdapter
    {
        /// <summary>
        /// Applies the config.
        /// </summary>
        /// <param name="config">The config.</param>
        public static void ApplyConfig(ProxyConfiguration config)
        {
            Dictionary<String, String> dictionary=new Dictionary<string,string>();

            dictionary.Add("user_pref(\"network.proxy.http\"", "user_pref(\"network.proxy.http\", \"" + config.ServerAddress + "\");");
            dictionary.Add("user_pref(\"network.proxy.http_port\""  , "user_pref(\"network.proxy.http_port\", " + config.Port + ");");

            dictionary.Add("user_pref(\"network.proxy.ftp\"", "user_pref(\"network.proxy.ftp\", \"" + config.ServerAddress + "\");");
            dictionary.Add("user_pref(\"network.proxy.ftp_port\""   , "user_pref(\"network.proxy.ftp_port\", " + config.Port + ");");

            dictionary.Add("user_pref(\"network.proxy.gopher\"", "user_pref(\"network.proxy.gopher\", \"" + config.ServerAddress + "\");");
            dictionary.Add("user_pref(\"network.proxy.gopher_port\"", "user_pref(\"network.proxy.gopher_port\", " + config.Port + ");");

            dictionary.Add("user_pref(\"network.proxy.socks\"", "user_pref(\"network.proxy.socks\", \"" + config.ServerAddress + "\");");
            dictionary.Add("user_pref(\"network.proxy.socks_port\"" , "user_pref(\"network.proxy.socks_port\", " + config.Port + ");");

            dictionary.Add("user_pref(\"network.proxy.ssl\"", "user_pref(\"network.proxy.ssl\", \"" + config.ServerAddress + "\");");
            dictionary.Add("user_pref(\"network.proxy.ssl_port\""   , "user_pref(\"network.proxy.ssl_port\", " + config.Port + ");");

            dictionary.Add("user_pref(\"network.proxy.no_proxies_on\"", "user_pref(\"network.proxy.no_proxies_on\", \"" + (config.ProxyOverrideEnabled ? config.ProxyOverride :"") + "\");");
            dictionary.Add("user_pref(\"network.proxy.share_proxy_settings\"", "user_pref(\"network.proxy.share_proxy_settings\", true);");

            // see http://kb.mozillazine.org/Network.proxy.type
            dictionary.Add("user_pref(\"network.proxy.type\"", "user_pref(\"network.proxy.type\", " + (config.Enabled ? "1" : "0") + ");");            
            
            String path = Environment.GetEnvironmentVariable("APPDATA") + @"\Mozilla\Firefox\";
            IniFile iFile = new IniFile(path + "profiles.ini");

            path += iFile.ReadString("Profile0", "Path") + @"\";

            bool esito = false;
            String[] oldLines = FileUtility.GetFileTextLines(path + "prefs.js", out esito);

            List<String> newLines = new List<String>();            

            foreach(String item in oldLines)
            {
                esito = false;
                
                foreach (String itemKey in dictionary.Keys)
                {
                    if (item.Contains(itemKey))
                    {
                        newLines.Add(dictionary[itemKey]);
                        dictionary[itemKey] = "";
                        esito = true;
                        break;
                    }
                }


                if (!esito)
                {
                    newLines.Add(item);
                }
            }

            foreach (String item in dictionary.Values)
            {
                newLines.Add(item);
            }      
            
            FileUtility.SetFileTextLines(path + "prefs.js", newLines.ToArray());
        }
    }
}

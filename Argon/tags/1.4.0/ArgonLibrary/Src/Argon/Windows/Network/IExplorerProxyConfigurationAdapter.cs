using System;
using System.Collections.Generic;
using System.Text;
using Argon.Windows;
using System.Runtime.InteropServices;

/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
namespace Argon.Windows.Network
{
    /// <summary>
    /// Adapter for the Internet Explorer
    /// </summary>
    public abstract class IExplorerProxyConfigurationAdapter
    {

        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;

        public const int INTERNET_OPTION_REFRESH = 37;        


        /// <summary>
        /// Reads the config.
        /// </summary>
        /// <returns></returns>
        public static ProxyConfiguration ReadConfig()
        {
            ProxyConfiguration ret = new ProxyConfiguration();

            long tmp1 = RegistryUtility.ReadIntValue(RegistryKeyType.CurrentUser, RK_INTERNET_SETTINGS, "ProxyEnable", 0);
            if (tmp1.Equals(1))
            {
                ret.Enabled = true;
            }
            else
            {
                ret.Enabled = false;
            }

            string tmp2 = RegistryUtility.ReadStringValue(RegistryKeyType.CurrentUser, RK_INTERNET_SETTINGS, "ProxyServer");
            string[] aTmp2 = tmp2.Split(':');
            ret.ServerAddress = aTmp2[0];
            if (aTmp2.Length > 1)
            {
                ret.Port = Int32.Parse(aTmp2[1]);
            }


            string tmp3 = RegistryUtility.ReadStringValue(RegistryKeyType.CurrentUser, RK_INTERNET_SETTINGS, "ProxyOverride");
            if (tmp3.EndsWith(";<local>"))
            {
                ret.ProxyOverrideEnabled = true;
                tmp3 = tmp3.Substring(0, tmp3.IndexOf(";<local>") - 1);
                ret.ProxyOverride = tmp3;
            }
            else
            {
                ret.ProxyOverrideEnabled = false;
                ret.ProxyOverride = tmp3;
            }


            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static readonly string RK_INTERNET_SETTINGS = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings\";


        /// <summary>
        /// Applies the config.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <returns></returns>
        public static bool ApplyConfig(ProxyConfiguration config)
        {
            string szValue = string.Empty;

            if (config == null) return false;

            if (config.Enabled)
            {
                string tmpServerAddress = config.ServerAddress;
                if (config.Port != 0)
                {
                    tmpServerAddress += ":" + config.Port;
                }

                string tmpOverride = config.ProxyOverride;
                if (tmpOverride == null)
                {
                    tmpOverride = "";
                }

                if (config.ProxyOverrideEnabled)
                {
                    if (!tmpOverride.Contains("<local>"))
                    {
                        tmpOverride += ";<local>";
                    }
                }
                else
                {
                    tmpOverride = tmpOverride.Replace("<local>", "");

                    if (tmpOverride.EndsWith(";"))
                    {
                        tmpOverride = tmpOverride.Substring(0, tmpOverride.Length - 1);
                    }

                    tmpOverride = tmpOverride.Replace(";;", ";");

                }
                RegistryUtility.WriteIntValue(RegistryKeyType.CurrentUser, RK_INTERNET_SETTINGS, "ProxyEnable", 1);
                RegistryUtility.WriteStringValue(RegistryKeyType.CurrentUser, RK_INTERNET_SETTINGS, "ProxyServer", tmpServerAddress);
                RegistryUtility.WriteStringValue(RegistryKeyType.CurrentUser, RK_INTERNET_SETTINGS, "ProxyOverride", tmpOverride);
            }
            else
            {
                RegistryUtility.WriteIntValue(RegistryKeyType.CurrentUser, RK_INTERNET_SETTINGS, "ProxyEnable", 0);
            }

            // set Immediate proxy settings changing (Chrome bug)
            // http://stackoverflow.com/questions/2020363/how-to-change-global-windows-proxy-using-c-sharp-net-with-immediate-effect
            bool settingsReturn, refreshReturn;
            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);

            return true;
        }
    }
}

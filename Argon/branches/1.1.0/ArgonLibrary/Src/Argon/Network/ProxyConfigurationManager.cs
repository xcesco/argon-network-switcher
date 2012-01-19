using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using Argon.FileSystem;
using System.Diagnostics;

namespace Argon.Network
{
    /// <summary>
    /// This class contains the logic to manage the proxy configurations present in the system.
    /// </summary>
    public abstract class ProxyConfigurationManager
    {
        /// <summary>
        /// Reads the config.
        /// </summary>
        /// <returns></returns>
        public static ProxyConfiguration ReadConfig()
        {
            return IExplorerProxyConfigurationAdapter.ReadConfig();
        }

        /// <summary>
        /// Applies the specified config.
        /// </summary>
        /// <param name="config">The config.</param>
        public static void Apply(ProxyConfiguration config)
        {
            IExplorerProxyConfigurationAdapter.ApplyConfig(config);
            FirexfoxProxyConfigurationAdapter.ApplyConfig(config);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using Argon.FileSystem;
using System.Diagnostics;

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

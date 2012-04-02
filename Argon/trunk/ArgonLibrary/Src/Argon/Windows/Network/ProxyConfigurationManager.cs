using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using Argon.FileSystem;
using System.Diagnostics;
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

            RunningWindowsExecutable firefox=FindFirefoxAndShutdown();
            FirexfoxProxyConfigurationAdapter.ApplyConfig(config);
            RestartFirefox(firefox);
        }

        /// <summary>
        /// Finds the firefox.
        /// </summary>
        /// <returns>if firefox is open, returns program's instance</returns>
        public static RunningWindowsExecutable FindFirefoxAndShutdown()
        {
            RunningWindowsExecutable app=null;
            List<RunningWindowsExecutable> actual;
            actual = WindowsExecutableManager.RunningProcesses;

            foreach (RunningWindowsExecutable item in actual)
            {

                if ("firefox.exe".Equals(item.Name))
                {
                    item.Kill = true;                    
                    WindowsExecutor.Execute(item);

                    return item;
                }
            }

            return null;
        }

        /// <summary>
        /// wait time for restart firefox after settings are changed.
        /// </summary>
        private const int WAIT_FOR_PROXY = 500; 
        

        /// <summary>
        /// Restarts the firefox.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void RestartFirefox(RunningWindowsExecutable item)
        {
            if (item != null)
            {
                System.Threading.Thread.Sleep(WAIT_FOR_PROXY);
                item.Kill = false;
                WindowsExecutor.Execute(item);
            }
        }
    }
}

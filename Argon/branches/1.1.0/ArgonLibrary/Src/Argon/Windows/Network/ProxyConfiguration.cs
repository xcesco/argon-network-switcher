using System;
using System.Collections.Generic;
using System.Text;

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
    /// 
    /// </summary>
    [Serializable]    
    public class ProxyConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        protected bool _enabled;

        /// <summary>
        /// 
        /// </summary>
        protected bool _proxyOverrideEnabled;



        /// <summary>
        /// Gets or sets a value indicating whether [proxy override enabled].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [proxy override enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool ProxyOverrideEnabled
        {
            get { return _proxyOverrideEnabled; }
            set { _proxyOverrideEnabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable proxy].
        /// </summary>
        /// <value><c>true</c> if [enable proxy]; otherwise, <c>false</c>.</value>
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _serverAddress;

        /// <summary>
        /// 
        /// </summary>
        protected int _port;

        /// <summary>
        /// 
        /// </summary>
        protected string _proxyOverride;

        /// <summary>
        /// Gets or sets the proxy server address.
        /// </summary>
        /// <value>The proxy server address.</value>
        public string ServerAddress
        {
            get { return _serverAddress; }
            set { _serverAddress = value; }
        }

        /// <summary>
        /// Gets or sets the proxy port.
        /// </summary>
        /// <value>The proxy port.</value>
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        /// <summary>
        /// Gets or sets the proxy override.
        /// </summary>
        /// <value>The proxy override.</value>
        public string ProxyOverride
        {
            get { return _proxyOverride; }
            set { _proxyOverride = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyConfiguration"/> class.
        /// </summary>
        public ProxyConfiguration()
        {
            _enabled = false;
            _port = 80;
            _proxyOverride = "";
            _proxyOverrideEnabled = false;
            _serverAddress = "";                        
        }

        /// <summary>
        /// Copies the specified obj.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static ProxyConfiguration Copy(ProxyConfiguration obj)
        {
            return (ProxyConfiguration)obj.MemberwiseClone();
        }

    }
}

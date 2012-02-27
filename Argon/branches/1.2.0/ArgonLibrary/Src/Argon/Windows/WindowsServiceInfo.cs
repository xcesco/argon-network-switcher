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
namespace Argon.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public class WindowsServiceInfoImpl : IWindowsServiceInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsServiceInfoImpl"/> class.
        /// </summary>
        public WindowsServiceInfoImpl()
        {
            _serviceName = "";
            _forcedStatus = ServiceForcedStatus.NONE;
        }

        public static WindowsServiceInfoImpl Copy(WindowsServiceInfoImpl obj)
        {
            return (WindowsServiceInfoImpl)obj.MemberwiseClone();
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _serviceName;

        /// <summary>
        /// 
        /// </summary>
        protected ServiceForcedStatus _forcedStatus;

        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        /// <summary>
        /// Gets or sets the forced status.
        /// </summary>
        /// <value>The forced status.</value>
        public ServiceForcedStatus ForcedStatus
        {
            get { return _forcedStatus; }
            set { _forcedStatus = value; }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IWindowsServiceInfo
    {
        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        string ServiceName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the forced status.
        /// </summary>
        /// <value>The forced status.</value>
        ServiceForcedStatus ForcedStatus
        {
            get;
            set;
        }

    }
}

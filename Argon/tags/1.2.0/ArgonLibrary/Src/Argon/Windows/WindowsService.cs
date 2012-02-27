using System.ServiceProcess;
using System;

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
    /// Rappresenta un servizio windows. La differenza rispetto a ServiceController
    /// e' la possibilita' di gestire anche il campo descrizione. Se ad un WindowsSerice
    /// e' associato ad un service allora è mounted.
    /// Se non di tipo mounted, allora le uniche proprietà valide sono:
    /// </summary>
    [Serializable]
    public class WindowsService : WindowsComponent, IWindowsServiceInfo
    {
        /// <summary>
        /// 
        /// </summary>
        protected ServiceForcedStatus _forcedStatus;

        /// <summary>
        /// 
        /// </summary>
        protected string _serviceName;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsService"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="description">The description.</param>
        public WindowsService(ServiceController service, string description)
        {
            _service = service;
            _description = description;
            _forcedStatus = ServiceForcedStatus.NONE;
            _serviceName=service.ServiceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsService"/> class.
        /// </summary>
        public WindowsService()
        {            
            _service = null;            
            _forcedStatus = ServiceForcedStatus.NONE;
        }

        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        /// <value>The service.</value>
        public ServiceController Service
        {
            get { return _service; }
            set {
                _service = value;
                if (_service != null)
                {
                    _serviceName = value.ServiceName;
                }
            }
        }

        /// <summary>
        /// Determines whether this instance is mounted.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if this instance is mounted; otherwise, <c>false</c>.
        /// </returns>
        public bool IsMounted()
        {
            return _service==null ? false: true;
        }

        /// <summary>
        /// contiene il servizio che questa classe rappresenta
        /// </summary>
        protected ServiceController _service;                 


        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public ServiceControllerStatus Status
        {
            get { return _service.Status; }            
        }


        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName
        {
            get { return _service.DisplayName; }
            set { _service.DisplayName = value; }
        }

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
}

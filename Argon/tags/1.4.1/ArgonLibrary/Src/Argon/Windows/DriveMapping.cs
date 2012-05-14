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
    public enum DriveMapType : int
    {
        /// <summary>
        /// 
        /// </summary>
        MOUNT=0,
        /// <summary>
        /// 
        /// </summary>
        UNMOUNT=1
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]  
    public class DriveMap : WindowsComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DriveMap"/> class.
        /// </summary>
        public DriveMap()
        {
            _drive = "A:";
            _username = "";
            _password = "";
            _realPath = "";
            _type = DriveMapType.MOUNT;
        }

        /// <summary>
        /// 
        /// </summary>
        protected DriveMapType _type;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public DriveMapType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _drive;

        /// <summary>
        /// 
        /// </summary>
        private string _realPath;

        /// <summary>
        /// 
        /// </summary>
        private string _username;

        /// <summary>
        /// 
        /// </summary>
        private string _password;

        /// <summary>
        /// Gets or sets the drive.
        /// </summary>
        /// <value>The drive.</value>
        public string Drive
        {
            get { return _drive; }
            set { _drive = value; }
        }

        /// <summary>
        /// Gets or sets the real path.
        /// </summary>
        /// <value>The real path.</value>
        public string RealPath
        {
            get { return _realPath; }
            set { _realPath = value; }
        }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public static DriveMap Copy(DriveMap obj)
        {
            return (DriveMap)obj.MemberwiseClone();
        }
    }
}

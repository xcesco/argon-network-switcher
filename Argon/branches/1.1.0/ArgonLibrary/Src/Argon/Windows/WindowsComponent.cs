using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

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
    /// Base class for component defined in library
    /// </summary>
    [Serializable]
    public abstract class WindowsComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsComponent"/> class.
        /// </summary>
        public WindowsComponent()
        {
            _name = "";
            _description = "";
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _name;

        /// <summary>
        /// 
        /// </summary>
        protected string _description;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

    }
}

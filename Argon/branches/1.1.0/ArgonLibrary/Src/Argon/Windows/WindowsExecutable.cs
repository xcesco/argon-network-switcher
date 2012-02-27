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
    [Serializable]
    public class WindowsExecutable : WindowsComponent
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsExecutable"/> class.
        /// </summary>
        public WindowsExecutable()
        {
            _file = "";
            _directory = "";
            _arguments = "";
            _waitForExit = true;
            _kill = false;
        }

        /// <summary>
        /// 
        /// </summary>
        protected bool _waitForExit;

        protected string _file;

        protected string _directory;

        protected string _arguments;

        private bool _kill;

        public bool Kill
        {
            get { return _kill; }
            set { _kill = value; }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [wait for exit].
        /// </summary>
        /// <value><c>true</c> if [wait for exit]; otherwise, <c>false</c>.</value>
        public bool WaitForExit
        {
            get { return _waitForExit; }
            set { _waitForExit = value; }
        }

       
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        public string Directory
        {
            get { return _directory; }
            set { _directory = value; }
        }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        /// <value>The file.</value>
        public string File
        {
            get { return _file; }
            set { _file = value; }
        }

        /// <summary>
        /// Gets or sets the arguments.
        /// </summary>
        /// <value>The arguments.</value>
        public string Arguments
        {
            get { return _arguments; }
            set { _arguments = value; }

        }

        /// <summary>
        /// Copies the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static WindowsExecutable Copy(WindowsExecutable item)
        {
            return (WindowsExecutable)item.MemberwiseClone();
        }
    }
}

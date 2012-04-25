using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
    /// Rapresents an running program
    /// </summary>
    [Serializable]
    public class RunningWindowsExecutable : WindowsExecutable
    {
        protected int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }        

        public String CommandLine
        {
            get {
                string temp="";

                temp += File;
                temp += " " + Arguments;

                return temp;

            }            
        }


        public RunningWindowsExecutable()
        {
            
        }
    }
}

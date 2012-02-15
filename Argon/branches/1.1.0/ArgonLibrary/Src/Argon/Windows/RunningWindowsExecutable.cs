using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Argon.Windows
{
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

                temp += _file;
                temp += " " + _arguments;

                return temp;

            }            
        }


        public RunningWindowsExecutable()
        {
            
        }
    }
}

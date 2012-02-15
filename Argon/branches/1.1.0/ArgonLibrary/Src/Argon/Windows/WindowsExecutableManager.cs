using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Management;
using System.IO;

namespace Argon.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class WindowsExecutableManager
    {
        /// <summary>
        /// Applies the specified exec list.
        /// </summary>
        /// <param name="execList">The exec list.</param>
        public static void Apply(List<WindowsExecutable> execList)
        {
            foreach (WindowsExecutable item in execList)
            {
                WindowsExecutor.Execute(item);
            }
        }

        /// <summary>
        /// Gets the running processes.
        /// </summary>
        /// <value>The running processes.</value>
        public static List<RunningWindowsExecutable> RunningProcesses
        {
            get
            {
                List<RunningWindowsExecutable> lista = new List<RunningWindowsExecutable>();

                Process[] processlist = Process.GetProcesses();
                RunningWindowsExecutable temp;

                SelectQuery selectQuery = new SelectQuery("select * from Win32_Process where executablePath is not null");
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery))
                {
                    foreach (ManagementObject process in searcher.Get())
                    {
                        int id = Convert.ToInt32(process.Properties["ProcessId"].Value);
                        string name = process.Properties["Name"].Value as string;
                        string commandLine = process.Properties["CommandLine"].Value as string;
                        int i = commandLine.IndexOf('"', 2);
                        if (i != commandLine.Length - 1 && i != -1)
                        {
                            commandLine = commandLine.Substring(i + 1);
                        }
                        else
                        {
                            commandLine = "";
                        }
                        string path = process.Properties["ExecutablePath"].Value as string;                        

                        temp = new RunningWindowsExecutable();
                        temp.File = Path.GetFileName(path);
                        temp.Arguments = commandLine;
                        temp.Directory = Path.GetDirectoryName(path);
                        temp.Name = name;
                        temp.Kill = true;
                        temp.WaitForExit = false;
                        temp.Id = id;

                        lista.Add(temp);
                    }
                }

                return lista;
            }
        }
    }
}

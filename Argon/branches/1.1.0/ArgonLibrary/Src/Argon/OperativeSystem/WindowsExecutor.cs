using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Argon.OperatingSystem
{
    /// <summary>
    /// Consente di eseguire sotto processi
    /// </summary>
    public abstract class WindowsExecutor
    {
        /// <summary>
        /// Executes the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public static bool Execute(string filename, string args)
        {
            WindowsExecutable exe = new WindowsExecutable();
            exe.File = filename;
            exe.Arguments = args;

            return Execute(exe);
        }


        /// <summary>
        /// Executes the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="filename">The filename.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public static bool Execute(string path, string filename, string args)
        {
            WindowsExecutable exe = new WindowsExecutable();
            exe.Directory = path;
            exe.File = filename;
            exe.Arguments = args;

            return Execute(exe);
        }

        /// <summary>
        /// Executes the specified executable.
        /// </summary>
        /// <param name="executable">The executable.</param>
        /// <returns></returns>
        public static bool Execute(WindowsExecutable executable)
        {
            bool ret = false;
            if (executable.Kill)
            {
                List<RunningWindowsExecutable> lista = WindowsExecutableManager.RunningProcesses;


                foreach (RunningWindowsExecutable item in lista)
                {
                    try
                    {
                        if (item.Name.Equals(executable.Name) &&
                            item.Directory.Equals(executable.Directory))
                        {
                            Process.GetProcessById(item.Id).Kill();
                            Debug.WriteLine("Kill process " + item.Name);
                        }
                    }
                    catch(Exception e)
                    {
                        Debug.WriteLine("Impossible to kill process " + executable.Name + " " + e.Message);
                    }
                }
            }
            else
            {

                string temp = "";
                Process exe = new Process();

                try
                {
                    string dir = executable.Directory;

                    dir = (dir == null) ? "" : dir;
                    dir = dir.Trim();

                    if (dir.Length > 0)
                    {
                        if (!dir.EndsWith(Path.DirectorySeparatorChar.ToString()))
                        {
                            dir += Path.DirectorySeparatorChar;
                        }
                    }
                    dir += executable.File.Trim();
                    exe.StartInfo.FileName = dir;
                    temp = dir;

                    exe.StartInfo.UseShellExecute = false;
                    exe.StartInfo.CreateNoWindow = true;
                    //exe.StartInfo.WorkingDirectory = executable.Directory;
                    //exe.StartInfo.RedirectStandardOutput = false;
                    //exe.StartInfo.RedirectStandardError = true;


                    exe.StartInfo.Arguments = " " + executable.Arguments;

                    exe.Start();

                    if (executable.WaitForExit)
                    {
                        exe.WaitForExit();

                        if (exe.ExitCode == 0)
                        {
                            Debug.WriteLine("Eseguo: " + dir + " " + executable.Arguments);
                            ret = true;
                        }
                        else
                        {
                            Debug.WriteLine("Exit code not 0 for " + dir + " " + executable.Arguments);
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Eseguo no wait: " + dir + " " + executable.Arguments);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Error on exe: " + temp + " " + executable.Arguments);
                    Debug.WriteLine(e.Message);
                }
                finally
                {
                    exe.Dispose();
                }
            }
            return ret;
        }

    }
}

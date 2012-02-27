using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
namespace Argon.FileSystem
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void FoundFileHandler(FileFinder sender, string filename);

    /// <summary>
    /// 
    /// </summary>
    public delegate void ErrorHandler(Exception e);

    /// <summary>
    /// Utility class for file search.  
    /// <list type="bullet">
    /// <item>   
    /// <description>Directory di base (si possono definire più cartelle di base dalle quali 
    /// effettuare le ricerche.</description>
    /// </item>
    /// <item>
    /// <description>Nome dei file da ricercare (completi o parziali)</description>
    /// </item>
    /// <item>
    /// <description>Contenuto dei file</description>
    /// </item>
    /// </list>
    /// </summary>
    public sealed class FileFinder
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public FileFinder()
        {
        }

        /// <summary>
        /// event file found
        /// </summary>
        public event FoundFileHandler OnFileFound;

        /// <summary>
        /// event error
        /// </summary>
        public event ErrorHandler OnError;


        // Make sure that this static member is thread safe.
        private Regex regularExpression;

        /// <summary>
        /// Executes the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        /// <param name="searchPattern">The search pattern.</param>
        /// <param name="maxFileSize">Size of the max file.</param>
        public void Execute(string folder, string searchPattern, int maxFileSize)
        {
            string[] type=new string[] { string.Empty };
            Execute(folder, searchPattern, false, false, -1);
            //Execute(folder, searchPattern, type, null, false, false, maxFileSize);
        }


        /// <summary>
        /// Given a root directory, find all files which name satisfated searchPattern and
        /// which contains defined string in parameter text.
        /// </summary>
        /// <param name="folder">root directory for search</param>
        /// <param name="searchPattern">file name pattern. If searchWithRegEx is true, then it will be considerede a regular expression.</param>
        /// <param name="searchWithRegExp">If true, then it will be considerede a regular expression.
        /// <param name="caseSensitive">se <code>true</code> indica che alla regular expression contenuta
        /// in text non bisogna applicare controlli caseSensitive</param>
        /// <param name="maxFileSize">massima dimensione dei file da analizzare (in Megabyte)</param>
        public void Execute(string folder, string searchPattern, bool searchWithRegExp, bool caseSensitive, int maxFileSize)
        {
            // Add all files in the specified
            // directory and its subdirectories.

            if (searchWithRegExp)
            {
                RegexOptions regexOptions = RegexOptions.Compiled;

                if (!caseSensitive)
                {
                    regexOptions |= RegexOptions.IgnoreCase;
                }
                regexOptions |= RegexOptions.Singleline;


                regularExpression = new Regex(searchPattern, regexOptions);
            }
            else
            {
                regularExpression = null;
            }

            Regex fileTypesDelim = new Regex(",");
            string[] fileTypes = fileTypesDelim.Split(searchPattern);

            if (fileTypes.Length == 0)
            {
                fileTypes = new string[] { string.Empty };
            }

            for (int i = 0; i < fileTypes.Length; i++)
            {
                fileTypes[i] = fileTypes[i].Trim();
            }

            Execute(folder, folder, fileTypes, searchWithRegExp, caseSensitive, maxFileSize);
        }

        /// <summary>
        /// Executes the specified root folder.
        /// </summary>
        /// <param name="rootFolder">The root folder.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="fileTypes">The file types.</param>
        /// <param name="regularExpression">if set to <c>true</c> [regular expression].</param>
        /// <param name="caseSensitive">if set to <c>true</c> [case sensitive].</param>
        /// <param name="maxFileSize">Size of the max file.</param>
        private void Execute(string rootFolder, string folder, string[] fileTypes, bool regularExpression, bool caseSensitive, int maxFileSize)
        {
            try
            {
                // Add all the files in the current directory
                // to the StringDictionary.
                try
                {
                    foreach (string fileType in fileTypes)
                    {
                        try
                        {
                            foreach (string file in Directory.GetFiles(folder, fileType))
                            {
                                bool fileTooLarge = false;

                                if (maxFileSize != -1)
                                {
                                    FileInfo fileInfo = new FileInfo(file);

                                    const int megabyte = 1024 * 1024;

                                    fileTooLarge = fileInfo.Length > maxFileSize * megabyte;
                                }
                                
                                if (!fileTooLarge)
                                {
                                    OnFileFound(this,file);
                                }
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {

                        }
                    }
                }
                // CDs with errors can trigger an IOException
                // when Directory.GetFiles is called.
                catch (IOException)
                {
                }

                // Recursively add all the files in the
                // current directory's subdirectories.
                try
                {
                    foreach (string currentFolder in Directory.GetDirectories(folder))
                    {                        
                        // Nel caso di cartella .svn, andiamo semplicemente avanti
                        
                        if (currentFolder.EndsWith(".svn",StringComparison.InvariantCultureIgnoreCase))
                        {
                            continue;
                        }
                        /*
                        if (SearchInfo.Cancelled)
                        {
                            return;
                        }*/

                        Execute(rootFolder, currentFolder, fileTypes, regularExpression, caseSensitive, maxFileSize);
                    }
                }
                // CDs with errors can trigger an IOException
                // when Directory.GetDirectories is called.
                catch (IOException)
                {
                }
                catch (UnauthorizedAccessException)
                {
                }
            }
            // It's extremely important to catch *all* exceptions
            // that might happen during an asynchronous method
            // call. Otherwise the call may not complete, and you
            // won't even realize it.
            catch (Exception ex)
            {
                if (OnError != null)
                {
                    OnError(ex);
                }
            }
        }        

    }
}

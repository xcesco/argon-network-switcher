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
namespace Argon.FileSystem
{
    /// <summary>
    /// File utility
    /// </summary>
    public class FileUtility
    {
        private FileUtility()
        {            
        }

        /// <summary>
        /// Dato un nome di file completo di path, estrae solo il path.
        /// </summary>
        /// <param name="fullFileName">nome del file più estensione</param>
        /// <returns>path senza il nome del file</returns>
        public static string GetPath(string fullFileName)
        {
            if (fullFileName == null) return null;

            string path = fullFileName;
            int index = fullFileName.LastIndexOf('\\');

            if (index > -1)
            {
                path = fullFileName.Substring(0,index + 1);
            }            

            return path;
        }

        /// <summary>
        /// Dato un nome di file completo di path, estrae solo il nome del file.
        /// Se il parametro <code>extension</code> è <code>true</code>, allora
        /// viene estratta anche l'estensione.
        /// </summary>
        /// <param name="fullFileName">nome del file più estensione</param>
        /// <param name="extension">indica se estrarre o meno l'estensione</param>
        /// <returns>nome del file</returns>
        public static string GetFileName(string fullFileName, bool extension)
        {
            if (fullFileName == null) return null;

            string fileName = fullFileName;
            int index = fullFileName.LastIndexOf('\\');

            if (index>-1) {
                fileName=fullFileName.Substring(index + 1);
            }

            if (!extension)
            {
                int index2 = fileName.LastIndexOf(".");
                if (index2 > -1)
                {
                    fileName = fileName.Substring(0, index2);
                }
            }

            return fileName;
        }

        /// <summary>
        /// Dato un nome di file completo di path, estrae solo il nome del file.        
        /// Viene estratta anche l'estensione.
        /// </summary>
        /// <param name="fullFileName">nome del file completo di path</param>
        /// <returns>nome del file senza</returns>
        public static string GetFileName(string fullFileName)
        {
            return GetFileName(fullFileName, true);
        }

        /// <summary>
        /// Dato un nome di file completo di path, estrae solo il nome del file.        
        /// L'estensione viene tolta dal nome del file.
        /// </summary>
        /// <param name="fullFileName">nome del file completo di path</param>
        /// <returns>nome del file senza</returns>
        public static string GetSimpleFileName(string fullFileName)
        {
            return GetFileName(fullFileName, false);
        }

        /// <summary>
        /// Dato un file completo di path, questo metodo restituisce il contenuto del
        /// file sottoforma di testo.
        /// </summary>
        /// <param name="fileName">nome del file</param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static string GetFileText(string fileName, out bool error)
        {
            string text = string.Empty;
            error = false;

            try
            {
                //text = "";
                text = File.ReadAllText(fileName);
            }
            catch
            {
                error = true;
            }

            return text;
        }

        /// <summary>
        /// Gets the file text line.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="error">if set to <c>true</c> [error].</param>
        /// <returns></returns>
        public static string[] GetFileTextLines(string fileName, out bool error)
        {
            String[] text = new String[0];
            error = false;

            try
            {
                //text = "";
                text = File.ReadAllLines(fileName);                

            }
            catch
            {
                error = true;
            }

            return text;
        }

        /// <summary>
        /// Sets the file text.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="contents">The contents.</param>
        public static void SetFileText(string fileName, string contents)
        {
            File.WriteAllText(fileName,contents);
        }

        /// <summary>
        /// Sets the file text.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="contents">The contents.</param>
        public static void SetFileTextLines(string fileName, string[] contents)
        {
            File.WriteAllLines(fileName, contents);
        }


        /// <summary>
        /// Data cartella di base ed una sua sottocartella, questa procedura restituisce
        /// il percorso relativo.
        /// </summary>
        /// <param name="absolutePath">Cartella di base</param>
        /// <param name="fullPath">Cartella di cui si vuole sapere il percorso relativo
        /// rispetto al primo parametro</param>
        /// <returns>percorso relativo che separa il primo path dal secondo</returns>
        public static string GetRelativePath(string absolutePath, string fullPath)
        {
            if (absolutePath == null || fullPath == null) return "";

            if (fullPath.StartsWith(absolutePath))
            {
                int nSize = absolutePath.Length;

                return fullPath.Substring(nSize);
            }

            return fullPath;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Argon.FileSystem
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void FoundPattern(Object current, string pattern, MatchCollection match);

    /// <summary>
    /// 
    /// </summary>
    public class FileInspector
    {
        private Regex regularExpression;
        private string pattern;

        private Object currentObject;

        /// <summary>
        /// Oggetto corrent
        /// </summary>
        public Object CurrentObject
        {
            get { return currentObject; }
            set { currentObject = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInspector"/> class.
        /// </summary>
        public FileInspector()
        {            
        }

        /// <summary>
        /// Gets or sets the pattern.
        /// </summary>
        /// <value>The pattern.</value>
        public string Pattern
        {
            set
            {
                pattern = value;
                RegexOptions regexOptions = RegexOptions.Compiled;
                regexOptions |= RegexOptions.IgnoreCase;
                regexOptions |= RegexOptions.Singleline;
                regularExpression = new Regex(pattern, regexOptions);
            }
            get
            {
                return pattern;
            }
        }

        /// <summary>
        /// evento associato all'aver trovato un file che soddisfa le condizioni
        /// di ricerca.
        /// </summary>
        public event FoundPattern PatternFound;

        /// <summary>
        /// Executes the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void Execute(string fileName)
        {
            bool error = false;
            bool result = false;

            if (regularExpression == null) return;

            string allText = FileUtility.GetFileText(fileName, out error);

            if (error)
            {
                return;
            }
            
            result = regularExpression.IsMatch(allText);
            if (result)
            {
                MatchCollection coll = regularExpression.Matches(allText);
                PatternFound(currentObject,pattern, coll);
            }            
        }
    }
}

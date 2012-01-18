using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Argon.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class NewVersion
    {
        private string _since;

        public string Since
        {
            get { return _since; }
            set { _since = value; }
        }

        private Version _avaiableVersion;

        public Version AvaiableVersion
        {
            get { return _avaiableVersion; }
            set { _avaiableVersion = value; }
        }

        private String _url;

        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }

    public abstract class CheckForUpdate
    {

        public static void Verify(string url)
        {
            Verify(url, "New version detected.", "Download the new version?");
        }

        /// <summary>
        /// Verifies the specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="title">The title.</param>
        /// <param name="question">The question.</param>
        public static void Verify(string url, string title, string question)
        {
            // get the running version of executable
            Version curVersion = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;                

            NewVersion newVersion = GetLastPublishedVersion(url);

            if (newVersion == null) return;
                        

            // compare the versions
            if (curVersion.CompareTo(newVersion.AvaiableVersion) < 0)
            {
                // ask the user if he would like
                // to download the new version                
                if (DialogResult.Yes ==
                 MessageBox.Show("Current version "+curVersion+"\n\n"+question + "\n\nNew version " + newVersion.AvaiableVersion + "\nDate " + newVersion.Since, title,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question))
                {
                    // navigate the default web
                    // browser to our app
                    // homepage (the url
                    // comes from the xml content)
                    System.Diagnostics.Process.Start(newVersion.Url);
                }
            }
            else
            {
                MessageBox.Show("The software is updated!","Updated",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Gets the last published version.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        internal static NewVersion GetLastPublishedVersion(string url)
        {
            // in newVersion variable we will store the
            // version info from xml file
            NewVersion newVersion = null;
            // and in this variable we will put the url we
            // would like to open so that the user can
            // download the new version
            // it can be a homepage or a direct
            // link to zip/exe file
            url = (url == null) ? "" : url;


            if (url.Trim().Length == 0) return newVersion;

            string date;

            try
            {
                // provide the XmlTextReader with the URL of
                // our xml document
                string xmlURL = url;
                XmlTextReader reader =
                  new XmlTextReader(xmlURL);
                // simply (and easily) skip the junk at the beginning
                reader.MoveToContent();
                // internal - as the XmlTextReader moves only
                // forward, we save current xml element name
                // in elementName variable. When we parse a
                // text node, we refer to elementName to check
                // what was the node name
                string elementName = "";
                // we check if the xml starts with a proper
                // "ourfancyapp" element node
                if ((reader.NodeType == XmlNodeType.Element) &&
                    (reader.Name == "application"))
                {
                    while (reader.Read())
                    {
                        // when we find an element node,
                        // we remember its name
                        if (reader.NodeType == XmlNodeType.Element)
                            elementName = reader.Name;
                        else
                        {
                            // for text nodes...
                            if ((reader.NodeType == XmlNodeType.Text) &&
                                (reader.HasValue))
                            {
                                // we check what the name of the node was
                                switch (elementName)
                                {
                                    case "version":
                                        // thats why we keep the version info
                                        // in xxx.xxx.xxx.xxx format
                                        // the Version class does the
                                        // parsing for us
                                        newVersion = new NewVersion();
                                        newVersion.AvaiableVersion = new Version(reader.Value + ".0");                                        
                                        break;
                                    case "url":                                        
                                        url = reader.Value;
                                        newVersion.Url = url;
                                        break;
                                    case "date":
                                        date = reader.Value;
                                        newVersion.Since = date;
                                        break;

                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }

            return newVersion;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Network.Profile;
using System.Windows.Forms;
using Argon.Models;
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
namespace Argon.UseCase
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class UseCaseConfig
    {
        /// <summary>
        /// 
        /// </summary>
        protected const string DEFAULT_FILENAME = "Profiles.xml";

        /// <summary>
        /// Loads the specified file name. If operation is ok, DataModel.NetworkProfileList is filled.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="showDialog">if set to <c>true</c> [show dialog].</param>
        /// <returns></returns>
        public static void Load(string fileName = DEFAULT_FILENAME, bool showDialog = false)
        {
            if (showDialog)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to load default config?", "Load config", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.No:
                        OpenFileDialog dialog = new OpenFileDialog();

                        dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                        //dialog.InitialDirectory = initialDirectory;
                        dialog.Title = "Select a config file to load";

                        result = dialog.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            fileName = dialog.FileName;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case DialogResult.Yes:
                        break;
                };
            }

            // execute config default
            List<NetworkProfile> list = NetworkProfileHelper.Load(fileName);

            UseCaseLogger.ShowInfo("Load file '" + Path.GetFullPath(fileName) + "'");

            if (!File.Exists(Path.GetFullPath(fileName)))
            {
                UseCaseLogger.ShowError("Ehi! No file '" + Path.GetFullPath(fileName) + "' found!");
            } else if (list.Count==0)
            {
                UseCaseLogger.ShowError("Ehi! 0 profiles found!");
            } else{
                DataModel.NetworkProfileList = list;
                UseCaseProfile.Refresh();                
            }        
            
        }

        /// <summary>
        /// Rearranges the profiles.
        /// </summary>
        /// <param name="listProfile">The list profile.</param>
        public static void RearrangeProfiles(List<NetworkProfile> listProfile)
        {
            DataModel.NetworkProfileList = listProfile;
            UseCaseProfile.Refresh();
        }


        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="showDialog">if set to <c>true</c> [show dialog].</param>
        /// <returns></returns>
        public static bool Save(string fileName = DEFAULT_FILENAME, bool showDialog = false)
        {
            if (showDialog)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save default config?", "Save config", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Cancel:
                        return false;
                    case DialogResult.No:
                        SaveFileDialog dialog = new SaveFileDialog();

                        dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                        //dialog.InitialDirectory = initialDirectory;
                        dialog.Title = "Select a config file to save";

                        result = dialog.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            fileName = dialog.FileName;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case DialogResult.Yes:
                        break;
                }
            }

            bool ret = NetworkProfileHelper.Save(DataModel.NetworkProfileList, fileName);

            UseCaseLogger.ShowInfo("Saved file '" + Path.GetFullPath(fileName) + "'");

            return ret;

        }
    }
}

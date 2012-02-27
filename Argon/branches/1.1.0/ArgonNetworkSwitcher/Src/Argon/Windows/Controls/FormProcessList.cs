using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Argon.Windows;
using System.IO;
using System.Management;
using Argon.Windows.Forms;

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
namespace Argon.Windows.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormProcessList : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormProcessList"/> class.
        /// </summary>
        public FormProcessList()
        {
            InitializeComponent();
           
        }

        private void Setup()
        {
            _selectedWindowsExecutable = null;
            listView.ClearObjects();
            List<RunningWindowsExecutable> lista = WindowsExecutableManager.RunningProcesses;

            listView.AddObjects(lista);
            listView.Sort(1);
        }

        private void FormProcessList_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _selectedWindowsExecutable = listView.SelectedObject as WindowsExecutable;

            if (_selectedWindowsExecutable == null)
            {
                MessageBox.Show(this, "No program is selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }                        
        }

        /// <summary>
        /// 
        /// </summary>
        protected WindowsExecutable _selectedWindowsExecutable;

        /// <summary>
        /// Gets or sets the selected windows executable.
        /// </summary>
        /// <value>The selected windows executable.</value>
        public WindowsExecutable SelectedWindowsExecutable
        {
            get
            {
                return _selectedWindowsExecutable;
            }

            set
            {
                _selectedWindowsExecutable = value;
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            btnSelect_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Setup();
        }

    }
}

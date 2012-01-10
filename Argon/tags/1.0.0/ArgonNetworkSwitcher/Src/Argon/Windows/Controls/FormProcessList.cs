using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Argon.OperatingSystem;
using System.IO;
using System.Management;
using Argon.Windows.Forms;

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

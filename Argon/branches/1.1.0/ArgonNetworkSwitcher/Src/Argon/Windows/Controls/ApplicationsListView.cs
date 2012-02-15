using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Argon.Windows;
using Argon.Windows.Controls;

namespace Argon.Windows.Controls
{
    /// <summary>
    /// type of selection
    /// </summary>
    internal enum SelectionType { NEW, SELECTED, NONE };


    /// <summary>
    /// 
    /// </summary>
    [DesignTimeVisible(true), ToolboxItem(true),
     ToolboxBitmap(typeof(Button))]
    public partial class ApplicationsListView : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        internal SelectionType status;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsListView"/> class.
        /// </summary>
        public ApplicationsListView()
        {
            InitializeComponent();

            status = SelectionType.NONE;
        }

        private WindowsExecutable currentItem;

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = txtDirectory.Text;
            openFileDialog.FileName = txtFile.Text;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string temp = openFileDialog.FileName;
                txtFile.Text = Path.GetFileName(temp);
                txtDirectory.Text = Path.GetDirectoryName(temp);
                if (txtName.Text.Length == 0)
                {
                    txtName.Text = Path.GetFileNameWithoutExtension(temp);
                }
            }


        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            status = SelectionType.NEW;
            currentItem = new WindowsExecutable();
            DisplayCurrentApplication();
        }

        /// <summary>
        /// Reads the current application.
        /// </summary>
        protected void DisplayCurrentApplication()
        {
            if (currentItem != null)
            {
                txtName.Text = currentItem.Name;
                txtFile.Text = currentItem.File;
                txtDirectory.Text = currentItem.Directory;
                txtArguments.Text = currentItem.Arguments;
                txtDescription.Text = currentItem.Description;
                cbWaitForExit.Checked=currentItem.WaitForExit;
                cbKill.Checked = currentItem.Kill;
            }
            else
            {
                txtName.Text = "";
                txtFile.Text = "";
                txtDirectory.Text = "";
                txtArguments.Text = "";
                txtDescription.Text = "";
                cbWaitForExit.Checked = true;
                cbKill.Checked = false;
            }
        }

        /// <summary>
        /// Writes the current application.
        /// </summary>
        protected void WriteCurrentApplication()
        {
            if (currentItem == null) return;

            currentItem.Name = txtName.Text;
            currentItem.File = txtFile.Text;
            currentItem.Directory = txtDirectory.Text;
            currentItem.Arguments = txtArguments.Text;
            currentItem.Description = txtDescription.Text;
            currentItem.WaitForExit = cbWaitForExit.Checked;
            currentItem.Kill = cbKill.Checked;
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (currentItem != null)
            {
                listView.RemoveObject(currentItem);
            }
            //listView.Refresh();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (status == SelectionType.NONE)
            {
                currentItem = new WindowsExecutable();
            }

            WriteCurrentApplication();

            if (status == SelectionType.SELECTED)
            {
                listView.RefreshObject(currentItem);
            }
            else
            {
                listView.AddObject(currentItem);
                status = SelectionType.SELECTED;
                listView.SelectObject(currentItem);
                listView.RefreshSelectedObjects();
            }

        }

        /// <summary>
        /// Handles the SelectionChanged event of the listView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listView_SelectionChanged(object sender, EventArgs e)
        {
            status = SelectionType.SELECTED;
            currentItem = (WindowsExecutable)listView.SelectedObject;
            DisplayCurrentApplication();
        }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        public List<WindowsExecutable> Items
        {
            get
            {
                List<WindowsExecutable> temp = new List<WindowsExecutable>();

                if (listView.Items.Count != 0)
                {
                    foreach (WindowsExecutable item in listView.Objects)
                    {
                        temp.Add(item);
                    }
                }

                return temp;
            }
        }

        /// <summary>
        /// Sets the items.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetItems(List<WindowsExecutable> value)
        {
            if (value == null) return;
            List<WindowsExecutable> temp = value;

            listView.SetObjects(temp);
            listView.Refresh();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormProcessList form = new FormProcessList();
            if (form.ShowDialog() == DialogResult.OK)
            {
                listView.AddObject(form.SelectedWindowsExecutable);
             
            }            
        }

      

    }
}

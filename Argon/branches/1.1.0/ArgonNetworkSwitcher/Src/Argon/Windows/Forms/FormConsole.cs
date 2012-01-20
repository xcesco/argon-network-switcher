using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Controllers;

namespace Argon.Windows.Forms
{
    public partial class FormConsole : ArgonDockContent
    {
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);


        public FormConsole()
        {
            InitializeComponent();
        }

        private void FormConsole_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                Controller.Instance.View.ViewMain.rbtnViewConsole.Checked = false;
            }
            else
            {
                Controller.Instance.View.ViewMain.rbtnViewConsole.Checked = true;
            }
        }

        private void FormConsole_Load(object sender, EventArgs e)
        {

        }

        // This method demonstrates a pattern for making thread-safe
        // calls on a Windows Forms control. 
        //
        // If the calling thread is different from the thread that
        // created the TextBox control, this method creates a
        // SetTextCallback and calls itself asynchronously using the
        // Invoke method.
        //
        // If the calling thread is the same as the thread that created
        // the TextBox control, the Text property is set directly. 

        public void AddText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lstBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lstBox.Items.Add(text);
                lstBox.SelectedIndex = lstBox.Items.Count - 1;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }
    }
}

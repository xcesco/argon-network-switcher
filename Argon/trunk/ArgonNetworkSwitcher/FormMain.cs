using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Argon
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // load form position
            _DeserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
        }

        private DeserializeDockContent _DeserializeDockContent;

        private IDockContent GetContentFromPersistString(string persistString)
        {
           /*if (persistString == typeof(FormAdapters).ToString())
            {
                Controller.Instance.ViewAdapters.Show(dockPanel);
                return Controller.Instance.ViewAdapters;
            }

            if (persistString == typeof(FormProfiles).ToString())
            {
                Controller.Instance.ViewProfiles.Show(dockPanel);
                return Controller.Instance.ViewProfiles;
            }           */
            return null;
        }
    }
}

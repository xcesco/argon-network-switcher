using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using Argon.Windows.Forms;
using System.Diagnostics;

namespace Argon.Windows.Forms
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

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            String path=Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)+"\\ArgonNetworkSwitcher";
            Directory.CreateDirectory(path);

            Debug.WriteLine(path);
            string configFile = Path.Combine(path, "DockPanel.config");
            Debug.WriteLine(configFile);

           dockPanel.SaveAsXml(configFile);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\ArgonNetworkSwitcher";
            Directory.CreateDirectory(path);

            Debug.WriteLine(path);
            string configFile = Path.Combine(path, "DockPanel.config");
            Debug.WriteLine(configFile);

            FormAdapters formAdapters = new FormAdapters();
            formAdapters.Show(dockPanel);
            formAdapters.DockState = DockState.DockLeft;

            /*
            if (File.Exists(configFile))
            {
                dockPanel.LoadFromXml(configFile, _DeserializeDockContent);
            }
            else*/
          /*  {
                Controller.Instance.ViewProfiles.Show(dockPanel);
                Controller.Instance.ViewProfiles.DockState = DockState.DockLeft;
                Controller.Instance.ViewAdapters.Show(dockPanel);
                Controller.Instance.ViewAdapters.DockState = DockState.DockLeft;

                mnuViewNetworkAdapters.Checked = true;
                mnuViewProfiles.Checked = true;
            }

            Controller.Instance.Init();*/

        }
    }
}

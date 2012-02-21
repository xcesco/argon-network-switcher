using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Collections;
using Argon.Windows;
using BrightIdeasSoftware;
using System.Diagnostics;

namespace Argon.Windows.Controls
{
    /// <summary>
    /// User Control for the management of the windows service.
    /// </summary>
    [DesignTimeVisible(true), ToolboxItem(true),
    ToolboxBitmap(typeof(Button))]
    public partial class ServiceListView : UserControl
    {
        public ServiceListView()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                       ControlStyles.UserPaint |
                       ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
            // impostiamo il modo trasparente prima di inizializzare
            BackColor = Color.Transparent;

             colStatus.ImageGetter = delegate(object rowObject)
            {
                WindowsService service = (WindowsService)rowObject;

                if (service.Status == System.ServiceProcess.ServiceControllerStatus.Running)
                {
                    return IMG_RUN;
                }

                return IMG_STOP;
            };            
            colStatus.Renderer = new BaseRenderer();

            colForcedStatus.ImageGetter = delegate(object rowObject)
            {
                WindowsService service = (WindowsService)rowObject;
                int ret;

                switch (service.ForcedStatus)
                {
                    case ServiceForcedStatus.RUNNING:
                        ret = IMG_FORCE_RUN;
                        break;
                    case ServiceForcedStatus.STOPPED:
                        ret = IMG_FORCE_STOP;
                        break;
                    default:
                        ret = -1;
                        break;
                }
                return ret;
            };
            colForcedStatus.AspectGetter = delegate(object rowObject)
            {
                WindowsService service = (WindowsService)rowObject;
                string ret;

                switch (service.ForcedStatus)
                {
                    case ServiceForcedStatus.RUNNING:
                        ret = "Force run";
                        break;
                    case ServiceForcedStatus.STOPPED:
                        ret = "Force stop";
                        break;
                    default:
                        ret = "";
                        break;
                }
                return ret;
            };
            colForcedStatus.Renderer = new BaseRenderer();

            LoadServices();
        }

        private void mnuForceRun_Click(object sender, EventArgs e)
        {
            IList<WindowsService> selezionati = (IList<WindowsService>)listView.SelectedObjects;

            foreach (WindowsService item in selezionati)
            {
                item.ForcedStatus = ServiceForcedStatus.RUNNING;
            }

            listView.RefreshSelectedObjects();
        }

         /// <summary>
        /// Image index of a running service
        /// </summary>
        protected static int IMG_RUN = 0;
        /// <summary>
        /// Image index of a stopped service
        /// </summary>
        protected static int IMG_STOP = 1;
        /// <summary>
        /// Image index of a force to run image
        /// </summary>
        protected static int IMG_FORCE_RUN = 2;
        /// <summary>
        /// Image index of a force to stop service
        /// </summary>
        protected static int IMG_FORCE_STOP = 3;

                /// <summary>
        /// Loads the services.
        /// </summary>
        public void LoadServices()
        {
            List<WindowsService> listaServizi = WindowsServiceManager.GetWindowsServicesList();
            listView.SetObjects(listaServizi);
        }

        private void tsbReload_Click(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void tsbForceService_Click(object sender, EventArgs e)
        {
            List<IWindowsServiceInfo> services = Items;

            WindowsServiceManager.Apply(services);
        }

        /// <summary>
        /// Refreshes the view.
        /// </summary>
        public void RefreshView()
        {
            List<IWindowsServiceInfo> forcedService = ForcedServicesInfo;

            LoadServices();

            Items = forcedService;

        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>The items.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<IWindowsServiceInfo> Items
        {
            get
            {
                List<IWindowsServiceInfo> ret = new List<IWindowsServiceInfo>();

                foreach (WindowsService item in listView.Objects)
                {
                    if (item.ForcedStatus == ServiceForcedStatus.STOPPED ||
                        item.ForcedStatus == ServiceForcedStatus.RUNNING)
                    {
                        ret.Add(item);
                    }
                }

                return ret;
            }
            set
            {
                if (value == null) return;
                List<IWindowsServiceInfo> listaInput = value;

                foreach (IWindowsServiceInfo item in listaInput)
                {
                    if (item.ServiceName == null) continue;
                    foreach (WindowsService item2 in listView.Objects)
                    {
                        if (item.ServiceName.Equals(item2.ServiceName))
                        {
                            item2.ForcedStatus = item.ForcedStatus;
                            listView.RefreshObject(item2);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets the forced services info.
        /// </summary>
        /// <value>The forced services info.</value>
        public List<IWindowsServiceInfo> ForcedServicesInfo
        {
            get
            {
                List<IWindowsServiceInfo> ret = new List<IWindowsServiceInfo>();
                IWindowsServiceInfo info;
                foreach (WindowsService item in listView.Objects)
                {
                    if (item.ForcedStatus != ServiceForcedStatus.NONE)
                    {
                        info = new WindowsServiceInfoImpl();
                        info.ServiceName = item.ServiceName;
                        info.ForcedStatus = item.ForcedStatus;
                        ret.Add(item);
                    }
                }

                return ret;
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (listView.SelectedObjects.Count == 0)
            {
                mnuForceNone.Enabled = false;
                mnuForceRun.Enabled = false;
                mnuForceStop.Enabled = false;

                mnuStartService.Enabled = false;
                mnuStopService.Enabled = false;
            }
            else
            {
                mnuForceNone.Enabled = true;
                mnuForceRun.Enabled = true;
                mnuForceStop.Enabled = true;

                mnuStartService.Enabled = true;
                mnuStopService.Enabled = true;
            }
        }

        private void listView_SelectionChanged(object sender, EventArgs e)
        {
            tslInfo.Text = "Selected service(s): " + listView.SelectedObjects.Count;
        }

        private void mnuForceStop_Click(object sender, EventArgs e)
        {
            IList selezionati = listView.SelectedObjects;

            foreach (WindowsService item in selezionati)
            {
                item.ForcedStatus = ServiceForcedStatus.STOPPED;
            }

            listView.RefreshSelectedObjects();
        }

        private void mnuForceNone_Click(object sender, EventArgs e)
        {
             IList selezionati = listView.SelectedObjects;

            foreach (WindowsService item in selezionati)
            {
                item.ForcedStatus = ServiceForcedStatus.NONE;
            }

            listView.RefreshSelectedObjects();        
        }

        private void mnuStartService_Click(object sender, EventArgs e)
        {
            foreach (WindowsService item in listView.SelectedObjects)
            {
                try
                {
                    item.Service.Start();
                }
                catch (Exception e1)
                {
                    Debug.WriteLine(e1.Message);
                }
            }

            listView.RefreshSelectedObjects();
        }

        private void mnuStopService_Click(object sender, EventArgs e)
        {
            foreach (WindowsService item in listView.SelectedObjects)
            {
                try
                {
                    item.Service.Stop();
                }
                catch (Exception e1)
                {
                    Debug.WriteLine(e1.Message);
                }
            }

            listView.RefreshSelectedObjects();
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}

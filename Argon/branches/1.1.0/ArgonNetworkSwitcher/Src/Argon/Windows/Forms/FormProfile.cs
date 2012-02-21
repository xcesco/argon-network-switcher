using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Drawing.Printing;
using Argon.Windows;
using Argon.Windows.Network.Profile;
using Argon.Controllers;
using Argon.Windows.Network;
using Argon.UseCase;
using Argon.Models;
using System.Diagnostics;

namespace Argon.Windows.Forms
{
    public partial class FormProfile : ArgonDockContent
    {
        public FormProfile()
        {
            InitializeComponent();
            currentNetworkCardIndex = -1;
            // to avoid flicker problem
            // see http://stackoverflow.com/questions/64272/how-to-eliminate-flicker-in-windows-forms-custom-control-when-scrolling
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);


        }

        /// <summary>
        /// Gets or sets the profile.
        /// </summary>
        /// <value>
        /// The profile.
        /// </value>
        public NetworkProfile Profile
        {
            get { return (NetworkProfile)Tag; }
            set { Tag = value; }
        }

        /// <summary>
        /// Handles the Load event of the FormProfile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FormProfile_Load(object sender, EventArgs e)
        {
            this.Activated += new System.EventHandler(this.ArgonDockContent_Activated);
            String[] imageNameList = ViewModel.ImageNames;

            ContextMenuStrip menuStrip = this.contextMenuStrip;

            menuStrip.Items.Clear();

            ToolStripMenuItem menuItem;
            int counter = 0;

            // fill imageList in formProfiles
            foreach (String item in imageNameList)
            {
                menuItem = new ToolStripMenuItem();
                menuItem.Image = UseCaseApplication.GetImage(item);
                menuItem.Tag = item;
                menuItem.Text = "Profile image " + counter;
                menuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);

                menuStrip.Items.Add(menuItem);
                counter++;
            }

        }

        public void ShowTab(TabPage tabPage)
        {
            TabPage[] array = { tp1NIC, tp2Proxy, tp3DriveMap, tp4Printers, tp5Services, tp6Applications, tp7Adapters };

            tabControl.SuspendLayout();
            tabControl.TabPages.Clear();

            foreach (TabPage item in array)
            {
                // if (item != tabPage)
                //{
                tabControl.TabPages.Add(item);
                //}
            }

            tabControl.ResumeLayout();
        }

        public void HideTab(TabPage tabPage)
        {
            TabPage[] array = { tp1NIC, tp2Proxy, tp3DriveMap, tp4Printers, tp5Services, tp6Applications, tp7Adapters };

            tabControl.SuspendLayout();
            tabControl.TabPages.Clear();

            foreach (TabPage item in array)
            {
                if (item != tabPage)
                {
                    tabControl.TabPages.Add(item);
                }
            }

            tabControl.ResumeLayout();
        }

        protected List<WindowsNetworkCard> networkList;


        private void DisplayCurrentNIC()
        {
            NetworkProfile profile = (NetworkProfile)Tag;
            string temp;
            if (profile.NetworkCardInfo != null)
            {
                temp = profile.NetworkCardInfo.ViewId + " " + profile.NetworkCardInfo.Name;
            }
            else
            {
                temp = "";
            }
            txtSelectedCard.Text = temp;

            RefreshView();
        }


        private void btnCurrentConfig_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        public void RefreshView()
        {
            LoadConfiguration();

        }


        private bool LoadConfiguration()
        {
            NetworkProfile profile = (NetworkProfile)Tag;

            if (profile.NetworkCardInfo.Id.Length > 0)
            {
                ipControl.Configuration = WindowsNetworkCardManager.WindowsNetworkCardTable[profile.NetworkCardInfo.Id];
            }
            proxyPanel.Configuration = ProxyConfigurationManager.ReadConfig();

            return true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.TabText = "Profile: " + txtName.Text;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            NetworkProfile profile = Profile;
            // cerchiamo viewId
            string work = lstNetworkCard.Text;
            currentNetworkCardIndex = lstNetworkCard.SelectedIndex;

            if (work.Equals(UseCaseProfile.NEW_NIC_NAME))
            {
            }
            else
            {
                int i1 = work.IndexOf("[");

                if (i1 >= 0)
                {
                    int i2 = work.IndexOf("]", i1);

                    work = i2 > 0 ? work.Substring(i1, i2 + 1) : work;
                }
                if (work.Length > 0)
                {
                    List<WindowsNetworkCard> lista = WindowsNetworkCardManager.WindowsNetworkCardList;

                    // lo facciamo solo se la card è diversa
                    if (profile.NetworkCardInfo == null || !profile.NetworkCardInfo.ViewId.Equals(work))
                    {
                        foreach (WindowsNetworkCard item in lista)
                        {
                            if (item.ViewId.Equals(work))
                            {
                                profile.NetworkCardInfo = item;
                                break;
                            }
                        }
                    }

                    /* List<WifiProfile> list = WifiConfigurationManager.GetWifiProfileList(profile.NetworkCardInfo.Id);
                     olvWirelessProfiles.ClearObjects();
                     olvWirelessProfiles.AddObjects(list);*/
                }
                else
                {
                    profile.NetworkCardInfo = null;
                }
            }
            DisplayCurrentNIC();
        }

        protected int currentNetworkCardIndex;

        private void btnCurrentConfig_Click_1(object sender, EventArgs e)
        {
            if (currentNetworkCardIndex != -1)
            {
                lstNetworkCard.SelectedIndex = currentNetworkCardIndex;
                btnSelect_Click(sender, e);
            }
        }

        public void btnRun_Click(object sender, EventArgs e)
        {
            UseCaseProfile.SaveProfile();
            Controller.Instance.Profile_Click(this, e);
        }


        private void btnSelectPrinter_Click(object sender, EventArgs e)
        {
            lblSelectedPrinter.Text = cbPrinterList.Text;
        }

        private void btnRemovePrinter_Click(object sender, EventArgs e)
        {
            lblSelectedPrinter.Text = "";
        }

        /// <summary>
        /// Handles the FormClosed event of the FormProfile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosedEventArgs"/> instance containing the event data.</param>
        private void FormProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            UseCaseProfile.Hide(this);            
        }

        /// <summary>
        /// Handles the Click event of the toolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = ((ToolStripMenuItem)sender).Image;

            // set the image
            NetworkProfile profile = (NetworkProfile)Tag;
            profile.ImageName = (string)((ToolStripMenuItem)sender).Tag;
        }

        /// <summary>
        /// Stores the form on data.
        /// </summary>
        public override void StoreFormOnData()
        {
            NetworkProfile profile = Profile;
            profile.Name = txtName.Text;            

            if (ipControl.Configuration == null)
            {
                profile.NetworkCardInfo = new NetworkCardInfoImpl();
            }
            else
            {
                profile.NetworkCardInfo = ipControl.Configuration;
            }

            profile.ProxyConfig = proxyPanel.Configuration;
            profile.DriveMapList = driveMapListView.Items;
            profile.ExecList = applicationsListView.Items;
            profile.ServiceList = serviceListView.Items;
            profile.DefaultPrinter = cbPrinterList.Text;

            // disabled nic
            profile.DisabledNetworkCards = networkCardListView.SelectedItems;

        }

        /// <summary>
        /// Views the data on form.
        /// </summary>
        public override void ViewDataOnForm()
        {
            NetworkProfile profile = Profile;

            networkList = Controller.Instance.ActionRefreshNetworkAdapters(lstNetworkCard);
            txtName.Text = profile.Name;
            TabText = "Profile: " + profile.Name;

            // load the image profile
            this.pictureBox.Image = UseCaseApplication.GetImage(profile.ImageName);

            // abbiamo una scheda di rete
            if (profile.NetworkCardInfo.Id.Length > 0)
            {
                WindowsNetworkCard nic = null;
                bool bTrovata = false;
                // selezioniamo dalla lista
                int i = 1;
                foreach (WindowsNetworkCard item in networkList)
                {
                    if (item.Id.Equals(profile.NetworkCardInfo.Id))
                    {
                        // l'abbiamo trovata
                        bTrovata = true;
                        nic = item;
                        txtSelectedCard.Text = item.ViewId + " " + item.Name;
                        currentNetworkCardIndex = i;
                        lstNetworkCard.SelectedIndex = i;
                        break;
                    }
                    i++;
                }

                if (!bTrovata)
                {
                    // se non l'abbiamo trovata, mettiamo il nome della scheda in rosso                
                    txtSelectedCard.Text = profile.NetworkCardInfo.ViewId + " " + profile.NetworkCardInfo.Name;
                    txtSelectedCard.ForeColor = Color.Red;

                    nic = new WindowsNetworkCard();
                    ipControl.Enabled = false;
                }
                // visualizziamo i dati della configurazione
                nic.Dhcp = profile.NetworkCardInfo.Dhcp;
                nic.IpAddress = profile.NetworkCardInfo.IpAddress;
                nic.SubnetMask = profile.NetworkCardInfo.SubnetMask;
                nic.GatewayAddress = profile.NetworkCardInfo.GatewayAddress;
                nic.DynamicDNS = profile.NetworkCardInfo.DynamicDNS;
                nic.Dns = profile.NetworkCardInfo.Dns;
                nic.Dns2 = profile.NetworkCardInfo.Dns2;
                nic.MacAddress = profile.NetworkCardInfo.MacAddress;
                nic.HardwareName = profile.NetworkCardInfo.HardwareName;


                ipControl.Configuration = nic;
            }

            proxyPanel.Configuration = profile.ProxyConfig;

            serviceListView.Items = profile.ServiceList;

            applicationsListView.SetItems(profile.ExecList);

            driveMapListView.SetItems(profile.DriveMapList);

            lblSelectedPrinter.Text = profile.DefaultPrinter;

            cbPrinterList.Items.Clear();
            int indexPrinter = 0;
            int i1 = 0;
            cbPrinterList.Items.Add("");
            foreach (String item in PrinterSettings.InstalledPrinters)
            {
                i1++;
                cbPrinterList.Items.Add(item);

                if (item.ToLower().Equals(profile.DefaultPrinter.ToLower()))
                {
                    indexPrinter = i1;
                }
            }
            cbPrinterList.SelectedIndex = indexPrinter;

            // disabled nic
            networkCardListView.SelectedItems = profile.DisabledNetworkCards;
            
        }


        /// <summary>
        /// Handles the Activated event of the ArgonDockContent control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected override void ArgonDockContent_Activated(object sender, EventArgs e)
        {
            base.ArgonDockContent_Activated(sender, e);
            UseCaseProfile.SelectProfile(Profile);            
        }
    }
}
using Argon.Windows;
using Argon.Windows.Controls;


namespace Argon.Windows.Forms
{
    partial class FormProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.imageList48x48 = new System.Windows.Forms.ImageList(this.components);
            this.imageList24x24 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNetworkCard = new System.Windows.Forms.ComboBox();
            this.lblSelectedCard = new System.Windows.Forms.Label();
            this.txtSelectedCard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new Argon.Windows.Controls.DoubleBufferedTabControl();
            this.tp1TcpIp4 = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.ipControl = new Argon.Windows.Controls.IpControl();
            this.wifiProfileControl = new Argon.Windows.Controls.WifiProfileControl();
            this.macAddressControl = new Argon.Windows.Controls.MACAddressControl();
            this.dnsConfiguration = new Argon.Windows.Controls.DNSConfiguration();
            this.winsControl = new Argon.Windows.Controls.WinsControl();
            this.tp3Proxy = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.proxyPanel = new Argon.Windows.Controls.ProxyControl();
            this.tp4DriveMap = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.driveMapListView = new Argon.Windows.Controls.DriveMapListView();
            this.tp5Printers = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.lblSelectedPrinter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemovePrinter = new System.Windows.Forms.Button();
            this.lblPrinter2 = new System.Windows.Forms.Label();
            this.cbPrinterList = new System.Windows.Forms.ComboBox();
            this.tp6Services = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.serviceListView = new Argon.Windows.Controls.ServiceListView();
            this.tp7Applications = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.applicationsListView = new Argon.Windows.Controls.ApplicationsListView();
            this.tp8Adapters = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.networkCardListView = new Argon.Windows.Controls.NetworkCardListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tp1TcpIp4.SuspendLayout();
            this.tp3Proxy.SuspendLayout();
            this.tp4DriveMap.SuspendLayout();
            this.tp5Printers.SuspendLayout();
            this.tp6Services.SuspendLayout();
            this.tp7Applications.SuspendLayout();
            this.tp8Adapters.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList48x48
            // 
            this.imageList48x48.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList48x48.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList48x48.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList24x24
            // 
            this.imageList24x24.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList24x24.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList24x24.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Network Card";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // pictureBox
            // 
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = global::Argon.Windows.Forms.Properties.Resources.profile_0_48x48;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(9, 7);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(48, 48);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(218, 490);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Argon.Windows.Forms.Properties.Resources.profile_0_48x48;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem1.Tag = "profile_0_48x48";
            this.toolStripMenuItem1.Text = "Default profile image";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Argon.Windows.Forms.Properties.Resources.profile_1_48x48;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem2.Tag = "profile_1_48x48";
            this.toolStripMenuItem2.Text = "Profile image 1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Argon.Windows.Forms.Properties.Resources.profile_2_48x48;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem3.Tag = "profile_2_48x48";
            this.toolStripMenuItem3.Text = "Profile image 2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Argon.Windows.Forms.Properties.Resources.profile_3_48x48;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem4.Tag = "profile_3_48x48";
            this.toolStripMenuItem4.Text = "Profile image 3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::Argon.Windows.Forms.Properties.Resources.profile_4_48x48;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem5.Tag = "profile_4_48x48";
            this.toolStripMenuItem5.Text = "Profile image 4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::Argon.Windows.Forms.Properties.Resources.profile_5_48x48;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem6.Tag = "profile_5_48x48";
            this.toolStripMenuItem6.Text = "Profile image 5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::Argon.Windows.Forms.Properties.Resources.profile_6_48x48;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem7.Tag = "profile_6_48x48";
            this.toolStripMenuItem7.Text = "Profile image 6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = global::Argon.Windows.Forms.Properties.Resources.profile_7_48x48;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem8.Tag = "profile_7_48x48";
            this.toolStripMenuItem8.Text = "Profile image 7";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = global::Argon.Windows.Forms.Properties.Resources.profile_8_48x48;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(217, 54);
            this.toolStripMenuItem9.Tag = "profile_8_48x48";
            this.toolStripMenuItem9.Text = "Profile image 8";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // lstNetworkCard
            // 
            this.lstNetworkCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNetworkCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNetworkCard.FormattingEnabled = true;
            this.lstNetworkCard.Location = new System.Drawing.Point(179, 33);
            this.lstNetworkCard.Margin = new System.Windows.Forms.Padding(2);
            this.lstNetworkCard.Name = "lstNetworkCard";
            this.lstNetworkCard.Size = new System.Drawing.Size(581, 21);
            this.lstNetworkCard.TabIndex = 18;
            this.lstNetworkCard.SelectedIndexChanged += new System.EventHandler(this.LstNetworkCardSelectedIndexChanged);
            // 
            // lblSelectedCard
            // 
            this.lblSelectedCard.AutoSize = true;
            this.lblSelectedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCard.Location = new System.Drawing.Point(78, 63);
            this.lblSelectedCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedCard.Name = "lblSelectedCard";
            this.lblSelectedCard.Size = new System.Drawing.Size(87, 13);
            this.lblSelectedCard.TabIndex = 19;
            this.lblSelectedCard.Text = "Selected Card";
            // 
            // txtSelectedCard
            // 
            this.txtSelectedCard.AutoSize = true;
            this.txtSelectedCard.Location = new System.Drawing.Point(179, 63);
            this.txtSelectedCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSelectedCard.Name = "txtSelectedCard";
            this.txtSelectedCard.Size = new System.Drawing.Size(63, 13);
            this.txtSelectedCard.TabIndex = 20;
            this.txtSelectedCard.Text = "[NO NAME]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Network Card";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tp1TcpIp4);
            this.tabControl.Controls.Add(this.tp3Proxy);
            this.tabControl.Controls.Add(this.tp4DriveMap);
            this.tabControl.Controls.Add(this.tp5Printers);
            this.tabControl.Controls.Add(this.tp6Services);
            this.tabControl.Controls.Add(this.tp7Applications);
            this.tabControl.Controls.Add(this.tp8Adapters);
            this.tabControl.Location = new System.Drawing.Point(2, 86);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(883, 383);
            this.tabControl.TabIndex = 22;
            // 
            // tp1TcpIp4
            // 
            this.tp1TcpIp4.Controls.Add(this.ipControl);
            this.tp1TcpIp4.Controls.Add(this.wifiProfileControl);
            this.tp1TcpIp4.Controls.Add(this.macAddressControl);
            this.tp1TcpIp4.Controls.Add(this.dnsConfiguration);
            this.tp1TcpIp4.Controls.Add(this.winsControl);
            this.tp1TcpIp4.ImageIndex = 0;
            this.tp1TcpIp4.Location = new System.Drawing.Point(4, 22);
            this.tp1TcpIp4.Margin = new System.Windows.Forms.Padding(2);
            this.tp1TcpIp4.Name = "tp1TcpIp4";
            this.tp1TcpIp4.Padding = new System.Windows.Forms.Padding(2);
            this.tp1TcpIp4.Size = new System.Drawing.Size(875, 357);
            this.tp1TcpIp4.TabIndex = 0;
            this.tp1TcpIp4.Text = "Network";
            this.tp1TcpIp4.UseVisualStyleBackColor = true;
            // 
            // ipControl
            // 
            this.ipControl.BackColor = System.Drawing.Color.Transparent;
            this.ipControl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ipControl.Location = new System.Drawing.Point(5, 5);
            this.ipControl.MinimumSize = new System.Drawing.Size(264, 138);
            this.ipControl.Name = "ipControl";
            this.ipControl.Size = new System.Drawing.Size(264, 138);
            this.ipControl.TabIndex = 10;
            // 
            // wifiProfileControl
            // 
            this.wifiProfileControl.BackColor = System.Drawing.Color.Transparent;
            this.wifiProfileControl.Location = new System.Drawing.Point(274, 124);
            this.wifiProfileControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wifiProfileControl.MinimumSize = new System.Drawing.Size(248, 70);
            this.wifiProfileControl.Name = "wifiProfileControl";
            this.wifiProfileControl.Size = new System.Drawing.Size(277, 70);
            this.wifiProfileControl.TabIndex = 8;
            this.wifiProfileControl.WifiProfileSelected = false;
            this.wifiProfileControl.WifiProfileSSID = null;
            // 
            // macAddressControl
            // 
            this.macAddressControl.Location = new System.Drawing.Point(5, 148);
            this.macAddressControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.macAddressControl.Name = "macAddressControl";
            this.macAddressControl.Size = new System.Drawing.Size(265, 46);
            this.macAddressControl.TabIndex = 9;
            // 
            // dnsConfiguration
            // 
            this.dnsConfiguration.BackColor = System.Drawing.Color.Transparent;
            this.dnsConfiguration.Location = new System.Drawing.Point(274, 5);
            this.dnsConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.dnsConfiguration.Name = "dnsConfiguration";
            this.dnsConfiguration.Size = new System.Drawing.Size(277, 107);
            this.dnsConfiguration.TabIndex = 6;
            // 
            // winsControl
            // 
            this.winsControl.Location = new System.Drawing.Point(582, 176);
            this.winsControl.Name = "winsControl";
            this.winsControl.Size = new System.Drawing.Size(254, 209);
            this.winsControl.TabIndex = 5;
            this.winsControl.Visible = false;
            // 
            // tp3Proxy
            // 
            this.tp3Proxy.Controls.Add(this.proxyPanel);
            this.tp3Proxy.ImageIndex = 1;
            this.tp3Proxy.Location = new System.Drawing.Point(4, 22);
            this.tp3Proxy.Margin = new System.Windows.Forms.Padding(2);
            this.tp3Proxy.Name = "tp3Proxy";
            this.tp3Proxy.Padding = new System.Windows.Forms.Padding(2);
            this.tp3Proxy.Size = new System.Drawing.Size(875, 357);
            this.tp3Proxy.TabIndex = 1;
            this.tp3Proxy.Text = "Proxy";
            this.tp3Proxy.UseVisualStyleBackColor = true;
            // 
            // proxyPanel
            // 
            this.proxyPanel.BackColor = System.Drawing.Color.Transparent;
            this.proxyPanel.Configuration = null;
            this.proxyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyPanel.Location = new System.Drawing.Point(2, 2);
            this.proxyPanel.LogoImage = global::Argon.Windows.Forms.Properties.Resources.proxy_124x40;
            this.proxyPanel.MinimumSize = new System.Drawing.Size(288, 113);
            this.proxyPanel.Name = "proxyPanel";
            this.proxyPanel.Size = new System.Drawing.Size(288, 113);
            this.proxyPanel.TabIndex = 2;
            // 
            // tp4DriveMap
            // 
            this.tp4DriveMap.Controls.Add(this.driveMapListView);
            this.tp4DriveMap.ImageIndex = 2;
            this.tp4DriveMap.Location = new System.Drawing.Point(4, 22);
            this.tp4DriveMap.Margin = new System.Windows.Forms.Padding(2);
            this.tp4DriveMap.Name = "tp4DriveMap";
            this.tp4DriveMap.Size = new System.Drawing.Size(875, 357);
            this.tp4DriveMap.TabIndex = 2;
            this.tp4DriveMap.Text = "Drive Map";
            this.tp4DriveMap.UseVisualStyleBackColor = true;
            // 
            // driveMapListView
            // 
            this.driveMapListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveMapListView.Location = new System.Drawing.Point(0, 0);
            this.driveMapListView.MinimumSize = new System.Drawing.Size(420, 239);
            this.driveMapListView.Name = "driveMapListView";
            this.driveMapListView.Size = new System.Drawing.Size(420, 239);
            this.driveMapListView.TabIndex = 1;
            // 
            // tp5Printers
            // 
            this.tp5Printers.Controls.Add(this.lblSelectedPrinter);
            this.tp5Printers.Controls.Add(this.label5);
            this.tp5Printers.Controls.Add(this.btnRemovePrinter);
            this.tp5Printers.Controls.Add(this.lblPrinter2);
            this.tp5Printers.Controls.Add(this.cbPrinterList);
            this.tp5Printers.ImageIndex = 3;
            this.tp5Printers.Location = new System.Drawing.Point(4, 22);
            this.tp5Printers.Margin = new System.Windows.Forms.Padding(2);
            this.tp5Printers.Name = "tp5Printers";
            this.tp5Printers.Size = new System.Drawing.Size(875, 357);
            this.tp5Printers.TabIndex = 5;
            this.tp5Printers.Text = "Printers";
            this.tp5Printers.UseVisualStyleBackColor = true;
            this.tp5Printers.Click += new System.EventHandler(this.tp5Printers_Click);
            // 
            // lblSelectedPrinter
            // 
            this.lblSelectedPrinter.AutoSize = true;
            this.lblSelectedPrinter.Location = new System.Drawing.Point(125, 55);
            this.lblSelectedPrinter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedPrinter.Name = "lblSelectedPrinter";
            this.lblSelectedPrinter.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPrinter.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Select the default printer";
            // 
            // btnRemovePrinter
            // 
            this.btnRemovePrinter.Image = global::Argon.Windows.Forms.Properties.Resources.delete2;
            this.btnRemovePrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovePrinter.Location = new System.Drawing.Point(424, 51);
            this.btnRemovePrinter.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePrinter.Name = "btnRemovePrinter";
            this.btnRemovePrinter.Size = new System.Drawing.Size(86, 38);
            this.btnRemovePrinter.TabIndex = 25;
            this.btnRemovePrinter.Text = "Remove";
            this.btnRemovePrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovePrinter.UseVisualStyleBackColor = true;
            this.btnRemovePrinter.Click += new System.EventHandler(this.btnRemovePrinter_Click);
            // 
            // lblPrinter2
            // 
            this.lblPrinter2.AutoSize = true;
            this.lblPrinter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter2.Location = new System.Drawing.Point(9, 55);
            this.lblPrinter2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrinter2.Name = "lblPrinter2";
            this.lblPrinter2.Size = new System.Drawing.Size(98, 13);
            this.lblPrinter2.TabIndex = 24;
            this.lblPrinter2.Text = "Selected Printer";
            // 
            // cbPrinterList
            // 
            this.cbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinterList.FormattingEnabled = true;
            this.cbPrinterList.Location = new System.Drawing.Point(160, 11);
            this.cbPrinterList.Margin = new System.Windows.Forms.Padding(2);
            this.cbPrinterList.Name = "cbPrinterList";
            this.cbPrinterList.Size = new System.Drawing.Size(245, 21);
            this.cbPrinterList.TabIndex = 22;
            this.cbPrinterList.SelectedIndexChanged += new System.EventHandler(this.CbPrinterListSelectedIndexChanged);
            // 
            // tp6Services
            // 
            this.tp6Services.Controls.Add(this.serviceListView);
            this.tp6Services.ImageIndex = 4;
            this.tp6Services.Location = new System.Drawing.Point(4, 22);
            this.tp6Services.Margin = new System.Windows.Forms.Padding(2);
            this.tp6Services.Name = "tp6Services";
            this.tp6Services.Size = new System.Drawing.Size(875, 357);
            this.tp6Services.TabIndex = 3;
            this.tp6Services.Text = "Services";
            this.tp6Services.UseVisualStyleBackColor = true;
            // 
            // serviceListView
            // 
            this.serviceListView.BackColor = System.Drawing.Color.Transparent;
            this.serviceListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceListView.Location = new System.Drawing.Point(0, 0);
            this.serviceListView.MinimumSize = new System.Drawing.Size(420, 153);
            this.serviceListView.Name = "serviceListView";
            this.serviceListView.Size = new System.Drawing.Size(420, 153);
            this.serviceListView.TabIndex = 2;
            // 
            // tp7Applications
            // 
            this.tp7Applications.Controls.Add(this.applicationsListView);
            this.tp7Applications.ImageIndex = 5;
            this.tp7Applications.Location = new System.Drawing.Point(4, 22);
            this.tp7Applications.Margin = new System.Windows.Forms.Padding(2);
            this.tp7Applications.Name = "tp7Applications";
            this.tp7Applications.Size = new System.Drawing.Size(875, 357);
            this.tp7Applications.TabIndex = 4;
            this.tp7Applications.Text = "Appplications";
            this.tp7Applications.UseVisualStyleBackColor = true;
            // 
            // applicationsListView
            // 
            this.applicationsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsListView.Location = new System.Drawing.Point(0, 0);
            this.applicationsListView.MinimumSize = new System.Drawing.Size(420, 239);
            this.applicationsListView.Name = "applicationsListView";
            this.applicationsListView.Size = new System.Drawing.Size(420, 239);
            this.applicationsListView.TabIndex = 2;
            // 
            // tp8Adapters
            // 
            this.tp8Adapters.Controls.Add(this.networkCardListView);
            this.tp8Adapters.ImageIndex = 7;
            this.tp8Adapters.Location = new System.Drawing.Point(4, 22);
            this.tp8Adapters.Margin = new System.Windows.Forms.Padding(2);
            this.tp8Adapters.Name = "tp8Adapters";
            this.tp8Adapters.Size = new System.Drawing.Size(875, 357);
            this.tp8Adapters.TabIndex = 6;
            this.tp8Adapters.Text = "Disabled Adapters";
            this.tp8Adapters.UseVisualStyleBackColor = true;
            // 
            // networkCardListView
            // 
            this.networkCardListView.BackColor = System.Drawing.Color.Transparent;
            this.networkCardListView.CheckBoxes = true;
            this.networkCardListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkCardListView.Location = new System.Drawing.Point(0, 0);
            this.networkCardListView.Name = "networkCardListView";
            this.networkCardListView.SelectedItems = ((System.Collections.Generic.List<Argon.Windows.Network.WindowsNetworkCard>)(resources.GetObject("networkCardListView.SelectedItems")));
            this.networkCardListView.Size = new System.Drawing.Size(192, 74);
            this.networkCardListView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(142, 4);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 20);
            this.txtName.TabIndex = 25;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelectedCard);
            this.Controls.Add(this.txtSelectedCard);
            this.Controls.Add(this.lstNetworkCard);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProfile";
            this.TabText = "Profile";
            this.Text = "Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfile_FormClosed);
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tp1TcpIp4.ResumeLayout(false);
            this.tp3Proxy.ResumeLayout(false);
            this.tp4DriveMap.ResumeLayout(false);
            this.tp5Printers.ResumeLayout(false);
            this.tp5Printers.PerformLayout();
            this.tp6Services.ResumeLayout(false);
            this.tp7Applications.ResumeLayout(false);
            this.tp8Adapters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList48x48;
        private System.Windows.Forms.ImageList imageList24x24;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label label8;       
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox lstNetworkCard;
        private System.Windows.Forms.Label lblSelectedCard;
        private System.Windows.Forms.Label txtSelectedCard;
        private System.Windows.Forms.Label label2;
        private Controls.ProxyControl proxyPanel;
        private Controls.DriveMapListView driveMapListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemovePrinter;
        private System.Windows.Forms.Label lblPrinter2;
        private System.Windows.Forms.ComboBox cbPrinterList;
        private Controls.ServiceListView serviceListView;
        private Controls.ApplicationsListView applicationsListView;
        private System.Windows.Forms.Label lblSelectedPrinter;
        private Controls.NetworkCardListView networkCardListView;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtName;
        public DoubleBufferedTabPage tp1TcpIp4;
        public DoubleBufferedTabPage tp3Proxy;
        public DoubleBufferedTabPage tp4DriveMap;
        public DoubleBufferedTabPage tp5Printers;
        public DoubleBufferedTabPage tp6Services;
        public DoubleBufferedTabPage tp7Applications;
        public DoubleBufferedTabPage tp8Adapters;
        public DoubleBufferedTabControl tabControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private WinsControl winsControl;
        private DNSConfiguration dnsConfiguration;
        private MACAddressControl macAddressControl;
        private WifiProfileControl wifiProfileControl;
        private IpControl ipControl;
    }
}
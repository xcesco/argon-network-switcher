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
            this.btnSelect = new System.Windows.Forms.Button();
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
            this.tp1NIC = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.ipControl = new Argon.Windows.Controls.IpControl();
            this.tp2Proxy = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.proxyPanel = new Argon.Windows.Controls.ProxyControl();
            this.tp3DriveMap = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.driveMapListView = new Argon.Windows.Controls.DriveMapListView();
            this.tp4Printers = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.lblSelectedPrinter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemovePrinter = new System.Windows.Forms.Button();
            this.lblPrinter2 = new System.Windows.Forms.Label();
            this.btnSelectPrinter = new System.Windows.Forms.Button();
            this.cbPrinterList = new System.Windows.Forms.ComboBox();
            this.tp5Services = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.serviceListView = new Argon.Windows.Controls.ServiceListView();
            this.tp6Applications = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.applicationsListView = new Argon.Windows.Controls.ApplicationsListView();
            this.tp7Adapters = new Argon.Windows.Controls.DoubleBufferedTabPage();
            this.networkCardListView = new Argon.Windows.Controls.NetworkCardListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tp1NIC.SuspendLayout();
            this.tp2Proxy.SuspendLayout();
            this.tp3DriveMap.SuspendLayout();
            this.tp4Printers.SuspendLayout();
            this.tp5Services.SuspendLayout();
            this.tp6Applications.SuspendLayout();
            this.tp7Adapters.SuspendLayout();
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
            // btnSelect
            // 
            this.btnSelect.Image = global::Argon.Windows.Forms.Properties.Resources.arrow_down_green;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(156, 39);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(83, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip;
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Image = global::Argon.Windows.Forms.Properties.Resources.profile_0_48x48;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(12, 9);
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
            this.lstNetworkCard.Location = new System.Drawing.Point(255, 41);
            this.lstNetworkCard.Name = "lstNetworkCard";
            this.lstNetworkCard.Size = new System.Drawing.Size(892, 21);
            this.lstNetworkCard.TabIndex = 18;
            // 
            // lblSelectedCard
            // 
            this.lblSelectedCard.AutoSize = true;
            this.lblSelectedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCard.Location = new System.Drawing.Point(66, 69);
            this.lblSelectedCard.Name = "lblSelectedCard";
            this.lblSelectedCard.Size = new System.Drawing.Size(87, 13);
            this.lblSelectedCard.TabIndex = 19;
            this.lblSelectedCard.Text = "Selected Card";
            // 
            // txtSelectedCard
            // 
            this.txtSelectedCard.AutoSize = true;
            this.txtSelectedCard.Location = new System.Drawing.Point(153, 69);
            this.txtSelectedCard.Name = "txtSelectedCard";
            this.txtSelectedCard.Size = new System.Drawing.Size(63, 13);
            this.txtSelectedCard.TabIndex = 20;
            this.txtSelectedCard.Text = "[NO NAME]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 44);
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
            this.tabControl.Controls.Add(this.tp1NIC);
            this.tabControl.Controls.Add(this.tp2Proxy);
            this.tabControl.Controls.Add(this.tp3DriveMap);
            this.tabControl.Controls.Add(this.tp4Printers);
            this.tabControl.Controls.Add(this.tp5Services);
            this.tabControl.Controls.Add(this.tp6Applications);
            this.tabControl.Controls.Add(this.tp7Adapters);
            this.tabControl.Location = new System.Drawing.Point(3, 113);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1177, 487);
            this.tabControl.TabIndex = 22;
            // 
            // tp1NIC
            // 
            this.tp1NIC.Controls.Add(this.ipControl);
            this.tp1NIC.ImageIndex = 0;
            this.tp1NIC.Location = new System.Drawing.Point(4, 22);
            this.tp1NIC.Name = "tp1NIC";
            this.tp1NIC.Padding = new System.Windows.Forms.Padding(3);
            this.tp1NIC.Size = new System.Drawing.Size(1169, 461);
            this.tp1NIC.TabIndex = 0;
            this.tp1NIC.Text = "Network";
            this.tp1NIC.UseVisualStyleBackColor = true;
            // 
            // ipControl
            // 
            this.ipControl.BackColor = System.Drawing.Color.Transparent;
            this.ipControl.Configuration = null;
            this.ipControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipControl.Location = new System.Drawing.Point(3, 3);
            this.ipControl.MinimumSize = new System.Drawing.Size(584, 240);
            this.ipControl.Name = "ipControl";
            this.ipControl.Size = new System.Drawing.Size(1163, 455);
            this.ipControl.TabIndex = 2;
            // 
            // tp2Proxy
            // 
            this.tp2Proxy.Controls.Add(this.proxyPanel);
            this.tp2Proxy.ImageIndex = 1;
            this.tp2Proxy.Location = new System.Drawing.Point(4, 22);
            this.tp2Proxy.Name = "tp2Proxy";
            this.tp2Proxy.Padding = new System.Windows.Forms.Padding(3);
            this.tp2Proxy.Size = new System.Drawing.Size(1169, 461);
            this.tp2Proxy.TabIndex = 1;
            this.tp2Proxy.Text = "Proxy";
            this.tp2Proxy.UseVisualStyleBackColor = true;
            // 
            // proxyPanel
            // 
            this.proxyPanel.BackColor = System.Drawing.Color.Transparent;
            this.proxyPanel.Configuration = null;
            this.proxyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyPanel.Location = new System.Drawing.Point(3, 3);
            this.proxyPanel.LogoImage = global::Argon.Windows.Forms.Properties.Resources.proxy_300x100;
            this.proxyPanel.MinimumSize = new System.Drawing.Size(384, 148);
            this.proxyPanel.Name = "proxyPanel";
            this.proxyPanel.Size = new System.Drawing.Size(1163, 452);
            this.proxyPanel.TabIndex = 2;
            // 
            // tp3DriveMap
            // 
            this.tp3DriveMap.Controls.Add(this.driveMapListView);
            this.tp3DriveMap.ImageIndex = 2;
            this.tp3DriveMap.Location = new System.Drawing.Point(4, 22);
            this.tp3DriveMap.Name = "tp3DriveMap";
            this.tp3DriveMap.Size = new System.Drawing.Size(1169, 461);
            this.tp3DriveMap.TabIndex = 2;
            this.tp3DriveMap.Text = "Drive Map";
            this.tp3DriveMap.UseVisualStyleBackColor = true;
            // 
            // driveMapListView
            // 
            this.driveMapListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveMapListView.Location = new System.Drawing.Point(0, 0);
            this.driveMapListView.MinimumSize = new System.Drawing.Size(560, 312);
            this.driveMapListView.Name = "driveMapListView";
            this.driveMapListView.Size = new System.Drawing.Size(1169, 458);
            this.driveMapListView.TabIndex = 1;
            // 
            // tp4Printers
            // 
            this.tp4Printers.Controls.Add(this.lblSelectedPrinter);
            this.tp4Printers.Controls.Add(this.label5);
            this.tp4Printers.Controls.Add(this.btnRemovePrinter);
            this.tp4Printers.Controls.Add(this.lblPrinter2);
            this.tp4Printers.Controls.Add(this.btnSelectPrinter);
            this.tp4Printers.Controls.Add(this.cbPrinterList);
            this.tp4Printers.ImageIndex = 3;
            this.tp4Printers.Location = new System.Drawing.Point(4, 22);
            this.tp4Printers.Name = "tp4Printers";
            this.tp4Printers.Size = new System.Drawing.Size(1169, 461);
            this.tp4Printers.TabIndex = 5;
            this.tp4Printers.Text = "Printers";
            this.tp4Printers.UseVisualStyleBackColor = true;
            // 
            // lblSelectedPrinter
            // 
            this.lblSelectedPrinter.AutoSize = true;
            this.lblSelectedPrinter.Location = new System.Drawing.Point(167, 50);
            this.lblSelectedPrinter.Name = "lblSelectedPrinter";
            this.lblSelectedPrinter.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPrinter.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Select the default printer";
            // 
            // btnRemovePrinter
            // 
            this.btnRemovePrinter.Image = global::Argon.Windows.Forms.Properties.Resources.delete2;
            this.btnRemovePrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovePrinter.Location = new System.Drawing.Point(501, 45);
            this.btnRemovePrinter.Name = "btnRemovePrinter";
            this.btnRemovePrinter.Size = new System.Drawing.Size(83, 23);
            this.btnRemovePrinter.TabIndex = 25;
            this.btnRemovePrinter.Text = "Remove";
            this.btnRemovePrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovePrinter.UseVisualStyleBackColor = true;
            this.btnRemovePrinter.Click += new System.EventHandler(this.btnRemovePrinter_Click);
            // 
            // lblPrinter2
            // 
            this.lblPrinter2.AutoSize = true;
            this.lblPrinter2.Location = new System.Drawing.Point(12, 50);
            this.lblPrinter2.Name = "lblPrinter2";
            this.lblPrinter2.Size = new System.Drawing.Size(82, 13);
            this.lblPrinter2.TabIndex = 24;
            this.lblPrinter2.Text = "Selected Printer";
            // 
            // btnSelectPrinter
            // 
            this.btnSelectPrinter.Image = global::Argon.Windows.Forms.Properties.Resources.arrow_down_green;
            this.btnSelectPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPrinter.Location = new System.Drawing.Point(501, 12);
            this.btnSelectPrinter.Name = "btnSelectPrinter";
            this.btnSelectPrinter.Size = new System.Drawing.Size(83, 23);
            this.btnSelectPrinter.TabIndex = 23;
            this.btnSelectPrinter.Text = "Select";
            this.btnSelectPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectPrinter.UseVisualStyleBackColor = true;
            this.btnSelectPrinter.Click += new System.EventHandler(this.btnSelectPrinter_Click);
            // 
            // cbPrinterList
            // 
            this.cbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinterList.FormattingEnabled = true;
            this.cbPrinterList.Location = new System.Drawing.Point(170, 14);
            this.cbPrinterList.Name = "cbPrinterList";
            this.cbPrinterList.Size = new System.Drawing.Size(325, 21);
            this.cbPrinterList.TabIndex = 22;
            // 
            // tp5Services
            // 
            this.tp5Services.Controls.Add(this.serviceListView);
            this.tp5Services.ImageIndex = 4;
            this.tp5Services.Location = new System.Drawing.Point(4, 22);
            this.tp5Services.Name = "tp5Services";
            this.tp5Services.Size = new System.Drawing.Size(1169, 461);
            this.tp5Services.TabIndex = 3;
            this.tp5Services.Text = "Services";
            this.tp5Services.UseVisualStyleBackColor = true;
            // 
            // serviceListView
            // 
            this.serviceListView.BackColor = System.Drawing.Color.Transparent;
            this.serviceListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceListView.Location = new System.Drawing.Point(0, 0);
            this.serviceListView.MinimumSize = new System.Drawing.Size(560, 200);
            this.serviceListView.Name = "serviceListView";
            this.serviceListView.Size = new System.Drawing.Size(1169, 458);
            this.serviceListView.TabIndex = 2;
            // 
            // tp6Applications
            // 
            this.tp6Applications.Controls.Add(this.applicationsListView);
            this.tp6Applications.ImageIndex = 5;
            this.tp6Applications.Location = new System.Drawing.Point(4, 22);
            this.tp6Applications.Name = "tp6Applications";
            this.tp6Applications.Size = new System.Drawing.Size(1169, 461);
            this.tp6Applications.TabIndex = 4;
            this.tp6Applications.Text = "Appplications";
            this.tp6Applications.UseVisualStyleBackColor = true;
            // 
            // applicationsListView
            // 
            this.applicationsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsListView.Location = new System.Drawing.Point(0, 0);
            this.applicationsListView.MinimumSize = new System.Drawing.Size(560, 312);
            this.applicationsListView.Name = "applicationsListView";
            this.applicationsListView.Size = new System.Drawing.Size(1169, 458);
            this.applicationsListView.TabIndex = 2;
            // 
            // tp7Adapters
            // 
            this.tp7Adapters.Controls.Add(this.networkCardListView);
            this.tp7Adapters.ImageIndex = 7;
            this.tp7Adapters.Location = new System.Drawing.Point(4, 22);
            this.tp7Adapters.Name = "tp7Adapters";
            this.tp7Adapters.Size = new System.Drawing.Size(1169, 461);
            this.tp7Adapters.TabIndex = 6;
            this.tp7Adapters.Text = "Disabled Adapters";
            this.tp7Adapters.UseVisualStyleBackColor = true;
            // 
            // networkCardListView
            // 
            this.networkCardListView.BackColor = System.Drawing.Color.Transparent;
            this.networkCardListView.CheckBoxes = true;
            this.networkCardListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkCardListView.Location = new System.Drawing.Point(0, 0);
            this.networkCardListView.Name = "networkCardListView";
            this.networkCardListView.Size = new System.Drawing.Size(1169, 458);
            this.networkCardListView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(107, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(414, 20);
            this.txtName.TabIndex = 25;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 612);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelectedCard);
            this.Controls.Add(this.lblSelectedCard);
            this.Controls.Add(this.lstNetworkCard);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSelect);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfile";
            this.TabText = "Profile";
            this.Text = "Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfile_FormClosed);
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tp1NIC.ResumeLayout(false);
            this.tp2Proxy.ResumeLayout(false);
            this.tp3DriveMap.ResumeLayout(false);
            this.tp4Printers.ResumeLayout(false);
            this.tp4Printers.PerformLayout();
            this.tp5Services.ResumeLayout(false);
            this.tp6Applications.ResumeLayout(false);
            this.tp7Adapters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList48x48;
        private System.Windows.Forms.ImageList imageList24x24;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label label8;       
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox lstNetworkCard;
        private System.Windows.Forms.Label lblSelectedCard;
        private System.Windows.Forms.Label txtSelectedCard;
        private System.Windows.Forms.Label label2;
        private Controls.IpControl ipControl;
        private Controls.ProxyControl proxyPanel;
        private Controls.DriveMapListView driveMapListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemovePrinter;
        private System.Windows.Forms.Label lblPrinter2;
        private System.Windows.Forms.Button btnSelectPrinter;
        private System.Windows.Forms.ComboBox cbPrinterList;
        private Controls.ServiceListView serviceListView;
        private Controls.ApplicationsListView applicationsListView;
        private System.Windows.Forms.Label lblSelectedPrinter;
        private Controls.NetworkCardListView networkCardListView;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtName;
        public DoubleBufferedTabPage tp1NIC;
        public DoubleBufferedTabPage tp2Proxy;
        public DoubleBufferedTabPage tp3DriveMap;
        public DoubleBufferedTabPage tp4Printers;
        public DoubleBufferedTabPage tp5Services;
        public DoubleBufferedTabPage tp6Applications;
        public DoubleBufferedTabPage tp7Adapters;
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
    }
}
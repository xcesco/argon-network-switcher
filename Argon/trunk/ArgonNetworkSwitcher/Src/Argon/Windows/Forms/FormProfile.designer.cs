using Argon.Windows;
using Argon.Network;


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
            ProxyConfiguration proxyConfiguration1 = new ProxyConfiguration();
            this.imageList48x48 = new System.Windows.Forms.ImageList(this.components);
            this.imageList24x24 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1 = new Ascend.Windows.Forms.GradientPanel();
            this.txtSelectedCard = new System.Windows.Forms.Label();
            this.lblSelectedCard = new System.Windows.Forms.Label();
            this.lstNetworkCard = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientLine1 = new Ascend.Windows.Forms.GradientLine();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel = new Ascend.Windows.Forms.NavigationPane();
            this.panelPrinter = new Ascend.Windows.Forms.NavigationPanePage();
            this.lblSelectedPrinter = new System.Windows.Forms.Label();
            this.cbPrinterList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDriveMap = new Ascend.Windows.Forms.NavigationPanePage();
            this.driveMappingListView1 = new Argon.Windows.Controls.DriveMapListView();
            this.panelPrograms = new Ascend.Windows.Forms.NavigationPanePage();
            this.applicationsListView = new Argon.Windows.Controls.ApplicationsListView();
            this.panelServices = new Ascend.Windows.Forms.NavigationPanePage();
            this.serviceListView1 = new Argon.Windows.Controls.ServiceListView();
            this.panelProxy = new Ascend.Windows.Forms.NavigationPanePage();
            this.proxyPanel = new Argon.Windows.Controls.ProxyControl();
            this.panelIpConfiguration = new Ascend.Windows.Forms.NavigationPanePage();
            this.ipControl1 = new Argon.Windows.Controls.IpControl();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemovePrinter = new System.Windows.Forms.Button();
            this.btnSelectPrinter = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelPrinter.SuspendLayout();
            this.panelDriveMap.SuspendLayout();
            this.panelPrograms.SuspendLayout();
            this.panelServices.SuspendLayout();
            this.panelProxy.SuspendLayout();
            this.panelIpConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList48x48
            // 
            this.imageList48x48.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList48x48.ImageStream")));
            this.imageList48x48.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList48x48.Images.SetKeyName(0, "PCI-card_network.png");
            this.imageList48x48.Images.SetKeyName(1, "PCI-card_preferences.png");
            this.imageList48x48.Images.SetKeyName(2, "PCI-card_delete.png");
            // 
            // imageList24x24
            // 
            this.imageList24x24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList24x24.ImageStream")));
            this.imageList24x24.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList24x24.Images.SetKeyName(0, "PCI-card.png");
            this.imageList24x24.Images.SetKeyName(1, "client_network.png");
            this.imageList24x24.Images.SetKeyName(2, "gears.png");
            this.imageList24x24.Images.SetKeyName(3, "application_server_run.png");
            this.imageList24x24.Images.SetKeyName(4, "earth_network.png");
            this.imageList24x24.Images.SetKeyName(5, "printer.png");
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.txtSelectedCard);
            this.gradientPanel1.Controls.Add(this.btnSelect);
            this.gradientPanel1.Controls.Add(this.lblSelectedCard);
            this.gradientPanel1.Controls.Add(this.lstNetworkCard);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.txtName);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.pictureBox);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(876, 98);
            this.gradientPanel1.TabIndex = 11;
            // 
            // txtSelectedCard
            // 
            this.txtSelectedCard.AutoSize = true;
            this.txtSelectedCard.Location = new System.Drawing.Point(187, 67);
            this.txtSelectedCard.Name = "txtSelectedCard";
            this.txtSelectedCard.Size = new System.Drawing.Size(0, 13);
            this.txtSelectedCard.TabIndex = 8;
            // 
            // lblSelectedCard
            // 
            this.lblSelectedCard.AutoSize = true;
            this.lblSelectedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCard.Location = new System.Drawing.Point(82, 67);
            this.lblSelectedCard.Name = "lblSelectedCard";
            this.lblSelectedCard.Size = new System.Drawing.Size(74, 13);
            this.lblSelectedCard.TabIndex = 5;
            this.lblSelectedCard.Text = "Selected Card";
            // 
            // lstNetworkCard
            // 
            this.lstNetworkCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNetworkCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNetworkCard.FormattingEnabled = true;
            this.lstNetworkCard.Location = new System.Drawing.Point(190, 36);
            this.lstNetworkCard.Name = "lstNetworkCard";
            this.lstNetworkCard.Size = new System.Drawing.Size(325, 21);
            this.lstNetworkCard.TabIndex = 4;
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
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(190, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(414, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
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
            // gradientLine1
            // 
            this.gradientLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLine1.GradientHighColor = System.Drawing.Color.LightSteelBlue;
            this.gradientLine1.GradientLowColor = System.Drawing.Color.MidnightBlue;
            this.gradientLine1.Location = new System.Drawing.Point(0, 98);
            this.gradientLine1.Name = "gradientLine1";
            this.gradientLine1.Size = new System.Drawing.Size(876, 2);
            this.gradientLine1.TabIndex = 12;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(876, 487);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 100);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(876, 512);
            this.toolStripContainer1.TabIndex = 15;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // panel
            // 
            this.panel.AllowAddOrRemove = false;
            this.panel.AntiAlias = true;
            this.panel.ButtonActiveGradientHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(155)))));
            this.panel.ButtonActiveGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panel.ButtonBorderColor = System.Drawing.Color.DarkGray;
            this.panel.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.panel.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.ButtonGradientHighColor = System.Drawing.Color.WhiteSmoke;
            this.panel.ButtonGradientLowColor = System.Drawing.Color.Gainsboro;
            this.panel.ButtonHighlightGradientHighColor = System.Drawing.Color.White;
            this.panel.ButtonHighlightGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panel.CaptionBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.panel.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.CaptionGradientHighColor = System.Drawing.Color.Silver;
            this.panel.CaptionGradientLowColor = System.Drawing.Color.Gainsboro;
            this.panel.CaptionImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel.Controls.Add(this.panelPrinter);
            this.panel.Controls.Add(this.panelPrograms);
            this.panel.Controls.Add(this.panelDriveMap);
            this.panel.Controls.Add(this.panelIpConfiguration);
            this.panel.Controls.Add(this.panelProxy);
            this.panel.Controls.Add(this.panelServices);
            this.panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FooterGradientHighColor = System.Drawing.Color.LightGray;
            this.panel.FooterGradientLowColor = System.Drawing.SystemColors.GrayText;
            this.panel.FooterHeight = 30;
            this.panel.FooterHighlightGradientHighColor = System.Drawing.Color.White;
            this.panel.FooterHighlightGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panel.ImageInCaption = true;
            this.panel.ImageList = this.imageList24x24;
            this.panel.ImageListFooter = this.imageList24x24;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.NavigationPages.AddRange(new Ascend.Windows.Forms.NavigationPanePage[] {
            this.panelIpConfiguration,
            this.panelProxy,
            this.panelServices,
            this.panelPrograms,
            this.panelDriveMap,
            this.panelPrinter});
            this.panel.Size = new System.Drawing.Size(876, 487);
            this.panel.TabIndex = 11;
            this.panel.VisibleButtonCount = 0;
            // 
            // panelPrinter
            // 
            this.panelPrinter.ActiveGradientHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(155)))));
            this.panelPrinter.ActiveGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelPrinter.AutoScroll = true;
            this.panelPrinter.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.panelPrinter.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPrinter.Controls.Add(this.btnRemovePrinter);
            this.panelPrinter.Controls.Add(this.label3);
            this.panelPrinter.Controls.Add(this.btnSelectPrinter);
            this.panelPrinter.Controls.Add(this.lblSelectedPrinter);
            this.panelPrinter.Controls.Add(this.cbPrinterList);
            this.panelPrinter.Controls.Add(this.label2);
            this.panelPrinter.GradientHighColor = System.Drawing.Color.WhiteSmoke;
            this.panelPrinter.GradientLowColor = System.Drawing.Color.Gainsboro;
            this.panelPrinter.HighlightGradientHighColor = System.Drawing.Color.White;
            this.panelPrinter.HighlightGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelPrinter.Image = null;
            this.panelPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelPrinter.ImageFooter = null;
            this.panelPrinter.ImageIndex = -1;
            this.panelPrinter.ImageIndexFooter = -1;
            this.panelPrinter.ImageKey = "";
            this.panelPrinter.ImageKeyFooter = "";
            this.panelPrinter.ImageList = this.imageList24x24;
            this.panelPrinter.ImageListFooter = this.imageList24x24;
            this.panelPrinter.Key = "panelPrinter";
            this.panelPrinter.Location = new System.Drawing.Point(1, 27);
            this.panelPrinter.Name = "panelPrinter";
            this.panelPrinter.Size = new System.Drawing.Size(874, 422);
            this.panelPrinter.TabIndex = 6;
            this.panelPrinter.Text = "navigationPanePage1";
            this.panelPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelPrinter.ToolTipText = null;
            // 
            // lblSelectedPrinter
            // 
            this.lblSelectedPrinter.AutoSize = true;
            this.lblSelectedPrinter.Location = new System.Drawing.Point(186, 48);
            this.lblSelectedPrinter.Name = "lblSelectedPrinter";
            this.lblSelectedPrinter.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPrinter.TabIndex = 2;
            // 
            // cbPrinterList
            // 
            this.cbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinterList.FormattingEnabled = true;
            this.cbPrinterList.Location = new System.Drawing.Point(189, 12);
            this.cbPrinterList.Name = "cbPrinterList";
            this.cbPrinterList.Size = new System.Drawing.Size(325, 21);
            this.cbPrinterList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select the default printer";
            // 
            // panelDriveMap
            // 
            this.panelDriveMap.ActiveGradientHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(155)))));
            this.panelDriveMap.ActiveGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelDriveMap.AutoScroll = true;
            this.panelDriveMap.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.panelDriveMap.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.panelDriveMap.Controls.Add(this.driveMappingListView1);
            this.panelDriveMap.GradientHighColor = System.Drawing.Color.WhiteSmoke;
            this.panelDriveMap.GradientLowColor = System.Drawing.Color.Gainsboro;
            this.panelDriveMap.HighlightGradientHighColor = System.Drawing.Color.White;
            this.panelDriveMap.HighlightGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelDriveMap.Image = null;
            this.panelDriveMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelDriveMap.ImageFooter = null;
            this.panelDriveMap.ImageIndex = -1;
            this.panelDriveMap.ImageIndexFooter = -1;
            this.panelDriveMap.ImageKey = "";
            this.panelDriveMap.ImageKeyFooter = "";
            this.panelDriveMap.ImageList = this.imageList24x24;
            this.panelDriveMap.ImageListFooter = this.imageList24x24;
            this.panelDriveMap.Key = "panelDriveMap";
            this.panelDriveMap.Location = new System.Drawing.Point(1, 27);
            this.panelDriveMap.Name = "panelDriveMap";
            this.panelDriveMap.Size = new System.Drawing.Size(874, 422);
            this.panelDriveMap.TabIndex = 5;
            this.panelDriveMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelDriveMap.ToolTipText = null;
            // 
            // driveMappingListView1
            // 
            this.driveMappingListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveMappingListView1.Location = new System.Drawing.Point(0, 0);
            this.driveMappingListView1.MinimumSize = new System.Drawing.Size(560, 312);
            this.driveMappingListView1.Name = "driveMappingListView1";
            this.driveMappingListView1.Size = new System.Drawing.Size(874, 422);
            this.driveMappingListView1.TabIndex = 0;
            // 
            // panelPrograms
            // 
            this.panelPrograms.ActiveGradientHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(155)))));
            this.panelPrograms.ActiveGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelPrograms.AutoScroll = true;
            this.panelPrograms.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.panelPrograms.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPrograms.Controls.Add(this.applicationsListView);
            this.panelPrograms.GradientHighColor = System.Drawing.Color.WhiteSmoke;
            this.panelPrograms.GradientLowColor = System.Drawing.Color.Gainsboro;
            this.panelPrograms.HighlightGradientHighColor = System.Drawing.Color.White;
            this.panelPrograms.HighlightGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelPrograms.Image = null;
            this.panelPrograms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelPrograms.ImageFooter = null;
            this.panelPrograms.ImageIndex = -1;
            this.panelPrograms.ImageIndexFooter = -1;
            this.panelPrograms.ImageKey = "";
            this.panelPrograms.ImageKeyFooter = "";
            this.panelPrograms.ImageList = this.imageList24x24;
            this.panelPrograms.ImageListFooter = this.imageList24x24;
            this.panelPrograms.Key = "panelPrograms";
            this.panelPrograms.Location = new System.Drawing.Point(1, 27);
            this.panelPrograms.Name = "panelPrograms";
            this.panelPrograms.Size = new System.Drawing.Size(874, 422);
            this.panelPrograms.TabIndex = 4;
            this.panelPrograms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelPrograms.ToolTipText = null;
            // 
            // applicationsListView
            // 
            this.applicationsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsListView.Location = new System.Drawing.Point(0, 0);
            this.applicationsListView.MinimumSize = new System.Drawing.Size(560, 312);
            this.applicationsListView.Name = "applicationsListView";
            this.applicationsListView.Size = new System.Drawing.Size(874, 422);
            this.applicationsListView.TabIndex = 0;
            // 
            // panelServices
            // 
            this.panelServices.ActiveGradientHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(155)))));
            this.panelServices.ActiveGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelServices.AutoScroll = true;
            this.panelServices.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.panelServices.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.panelServices.Controls.Add(this.serviceListView1);
            this.panelServices.GradientHighColor = System.Drawing.Color.WhiteSmoke;
            this.panelServices.GradientLowColor = System.Drawing.Color.Gainsboro;
            this.panelServices.HighlightGradientHighColor = System.Drawing.Color.White;
            this.panelServices.HighlightGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelServices.Image = null;
            this.panelServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelServices.ImageFooter = null;
            this.panelServices.ImageIndex = -1;
            this.panelServices.ImageIndexFooter = -1;
            this.panelServices.ImageKey = "";
            this.panelServices.ImageKeyFooter = "";
            this.panelServices.ImageList = this.imageList24x24;
            this.panelServices.ImageListFooter = this.imageList24x24;
            this.panelServices.Key = "panelServices";
            this.panelServices.Location = new System.Drawing.Point(1, 27);
            this.panelServices.Name = "panelServices";
            this.panelServices.Size = new System.Drawing.Size(874, 422);
            this.panelServices.TabIndex = 3;
            this.panelServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelServices.ToolTipText = null;
            // 
            // serviceListView1
            // 
            this.serviceListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceListView1.Items = ((System.Collections.Generic.List<Argon.OperatingSystem.IWindowsServiceInfo>)(resources.GetObject("serviceListView1.Items")));
            this.serviceListView1.Location = new System.Drawing.Point(0, 0);
            this.serviceListView1.MinimumSize = new System.Drawing.Size(560, 200);
            this.serviceListView1.Name = "serviceListView1";
            this.serviceListView1.Size = new System.Drawing.Size(874, 422);
            this.serviceListView1.TabIndex = 0;
            // 
            // panelProxy
            // 
            this.panelProxy.ActiveGradientHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(155)))));
            this.panelProxy.ActiveGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelProxy.AutoScroll = true;
            this.panelProxy.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.panelProxy.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.panelProxy.Controls.Add(this.proxyPanel);
            this.panelProxy.GradientHighColor = System.Drawing.Color.WhiteSmoke;
            this.panelProxy.GradientLowColor = System.Drawing.Color.Gainsboro;
            this.panelProxy.HighlightGradientHighColor = System.Drawing.Color.White;
            this.panelProxy.HighlightGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelProxy.Image = null;
            this.panelProxy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelProxy.ImageFooter = null;
            this.panelProxy.ImageIndex = -1;
            this.panelProxy.ImageIndexFooter = -1;
            this.panelProxy.ImageKey = "";
            this.panelProxy.ImageKeyFooter = "";
            this.panelProxy.ImageList = this.imageList24x24;
            this.panelProxy.ImageListFooter = this.imageList24x24;
            this.panelProxy.Key = "panelProxy";
            this.panelProxy.Location = new System.Drawing.Point(1, 27);
            this.panelProxy.Name = "panelProxy";
            this.panelProxy.Size = new System.Drawing.Size(874, 422);
            this.panelProxy.TabIndex = 2;
            this.panelProxy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelProxy.ToolTipText = null;
            // 
            // proxyPanel
            // 
            this.proxyPanel.BackColor = System.Drawing.Color.Transparent;
            proxyConfiguration1.Enabled = false;
            proxyConfiguration1.Port = 80;
            proxyConfiguration1.ProxyOverride = "";
            proxyConfiguration1.ProxyOverrideEnabled = false;
            proxyConfiguration1.ServerAddress = "";
            this.proxyPanel.Configuration = proxyConfiguration1;
            this.proxyPanel.Location = new System.Drawing.Point(11, 12);
            this.proxyPanel.MinimumSize = new System.Drawing.Size(384, 148);
            this.proxyPanel.Name = "proxyPanel";
            this.proxyPanel.Size = new System.Drawing.Size(384, 155);
            this.proxyPanel.TabIndex = 0;
            // 
            // panelIpConfiguration
            // 
            this.panelIpConfiguration.ActiveGradientHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(155)))));
            this.panelIpConfiguration.ActiveGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelIpConfiguration.AutoScroll = true;
            this.panelIpConfiguration.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.panelIpConfiguration.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.panelIpConfiguration.Controls.Add(this.ipControl1);
            this.panelIpConfiguration.GradientHighColor = System.Drawing.Color.WhiteSmoke;
            this.panelIpConfiguration.GradientLowColor = System.Drawing.Color.Gainsboro;
            this.panelIpConfiguration.HighlightGradientHighColor = System.Drawing.Color.White;
            this.panelIpConfiguration.HighlightGradientLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(78)))));
            this.panelIpConfiguration.Image = null;
            this.panelIpConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelIpConfiguration.ImageFooter = null;
            this.panelIpConfiguration.ImageIndex = -1;
            this.panelIpConfiguration.ImageIndexFooter = -1;
            this.panelIpConfiguration.ImageKey = "";
            this.panelIpConfiguration.ImageKeyFooter = "";
            this.panelIpConfiguration.ImageList = this.imageList24x24;
            this.panelIpConfiguration.ImageListFooter = this.imageList24x24;
            this.panelIpConfiguration.Key = "panelIpConfiguration";
            this.panelIpConfiguration.Location = new System.Drawing.Point(1, 27);
            this.panelIpConfiguration.Name = "panelIpConfiguration";
            this.panelIpConfiguration.Size = new System.Drawing.Size(874, 422);
            this.panelIpConfiguration.TabIndex = 1;
            this.panelIpConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelIpConfiguration.ToolTipText = null;
            // 
            // ipControl1
            // 
            this.ipControl1.BackColor = System.Drawing.Color.Transparent;
            this.ipControl1.Configuration = null;
            this.ipControl1.Location = new System.Drawing.Point(3, 3);
            this.ipControl1.MinimumSize = new System.Drawing.Size(584, 240);
            this.ipControl1.Name = "ipControl1";
            this.ipControl1.Size = new System.Drawing.Size(584, 240);
            this.ipControl1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Printer";
            // 
            // btnRemovePrinter
            // 
            this.btnRemovePrinter.Image = global::Argon.Windows.Forms.Properties.Resources.delete2;
            this.btnRemovePrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovePrinter.Location = new System.Drawing.Point(520, 43);
            this.btnRemovePrinter.Name = "btnRemovePrinter";
            this.btnRemovePrinter.Size = new System.Drawing.Size(83, 23);
            this.btnRemovePrinter.TabIndex = 10;
            this.btnRemovePrinter.Text = "Remove";
            this.btnRemovePrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovePrinter.UseVisualStyleBackColor = true;
            this.btnRemovePrinter.Click += new System.EventHandler(this.btnRemovePrinter_Click);
            // 
            // btnSelectPrinter
            // 
            this.btnSelectPrinter.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPrinter.Image")));
            this.btnSelectPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPrinter.Location = new System.Drawing.Point(520, 10);
            this.btnSelectPrinter.Name = "btnSelectPrinter";
            this.btnSelectPrinter.Size = new System.Drawing.Size(83, 23);
            this.btnSelectPrinter.TabIndex = 8;
            this.btnSelectPrinter.Text = "Select";
            this.btnSelectPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectPrinter.UseVisualStyleBackColor = true;
            this.btnSelectPrinter.Click += new System.EventHandler(this.btnSelectPrinter_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(521, 36);
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
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(48, 48);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 612);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.gradientLine1);
            this.Controls.Add(this.gradientPanel1);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfile";
            this.TabText = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.Activated += new System.EventHandler(this.FormProfile_Activated);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panelPrinter.ResumeLayout(false);
            this.panelPrinter.PerformLayout();
            this.panelDriveMap.ResumeLayout(false);
            this.panelPrograms.ResumeLayout(false);
            this.panelServices.ResumeLayout(false);
            this.panelProxy.ResumeLayout(false);
            this.panelIpConfiguration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList48x48;
        private System.Windows.Forms.ImageList imageList24x24;
        private Ascend.Windows.Forms.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private Ascend.Windows.Forms.GradientLine gradientLine1;
        private System.Windows.Forms.ComboBox lstNetworkCard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Ascend.Windows.Forms.NavigationPane panel;
        private Ascend.Windows.Forms.NavigationPanePage panelIpConfiguration;
        private Ascend.Windows.Forms.NavigationPanePage panelProxy;
        private Ascend.Windows.Forms.NavigationPanePage panelServices;
        private Argon.Windows.Controls.ServiceListView serviceListView1;
        private Ascend.Windows.Forms.NavigationPanePage panelPrograms;
        private Argon.Windows.Controls.ApplicationsListView applicationsListView;
        private Ascend.Windows.Forms.NavigationPanePage panelDriveMap;
        private Argon.Windows.Controls.DriveMapListView driveMappingListView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblSelectedCard;
        private Argon.Windows.Controls.ProxyControl proxyPanel;
        private Argon.Windows.Controls.IpControl ipControl1;
        private System.Windows.Forms.Label txtSelectedCard;
        private Ascend.Windows.Forms.NavigationPanePage panelPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPrinterList;
        private System.Windows.Forms.Label lblSelectedPrinter;
        private System.Windows.Forms.Button btnSelectPrinter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemovePrinter;
    }
}
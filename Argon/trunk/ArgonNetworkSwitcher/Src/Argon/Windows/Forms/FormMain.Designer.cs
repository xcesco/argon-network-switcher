using WeifenLuo.WinFormsUI.Docking;

namespace Argon.Windows.Forms
{
    partial class FormMain
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
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewNetworkAdapters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.makeADonationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnProfileNew = new System.Windows.Forms.ToolStripButton();
            this.btnProfileView = new System.Windows.Forms.ToolStripButton();
            this.btnProfileDelete = new System.Windows.Forms.ToolStripButton();
            this.btnProfileSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProfileRun = new System.Windows.Forms.ToolStripButton();
            this.btnProfileRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProfilesLoad = new System.Windows.Forms.ToolStripButton();
            this.btnProfilesSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCardsRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCardView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 586);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 17);
            this.lblStatus.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuView,
            this.helpToolStripMenuItem,
            this.mnuDonate});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewNetworkAdapters,
            this.mnuViewProfiles,
            this.mnuViewConsole});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(41, 20);
            this.mnuView.Text = "&View";
            // 
            // mnuViewNetworkAdapters
            // 
            this.mnuViewNetworkAdapters.Name = "mnuViewNetworkAdapters";
            this.mnuViewNetworkAdapters.Size = new System.Drawing.Size(171, 22);
            this.mnuViewNetworkAdapters.Text = "Network adapters";
            this.mnuViewNetworkAdapters.Click += new System.EventHandler(this.mnuViewNetworkAdapters_Click);
            // 
            // mnuViewProfiles
            // 
            this.mnuViewProfiles.Name = "mnuViewProfiles";
            this.mnuViewProfiles.Size = new System.Drawing.Size(171, 22);
            this.mnuViewProfiles.Text = "Profiles";
            this.mnuViewProfiles.Click += new System.EventHandler(this.profilesToolStripMenuItem_Click);
            // 
            // mnuViewConsole
            // 
            this.mnuViewConsole.Name = "mnuViewConsole";
            this.mnuViewConsole.Size = new System.Drawing.Size(171, 22);
            this.mnuViewConsole.Text = "Console";
            this.mnuViewConsole.Click += new System.EventHandler(this.mnuViewConsole_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCheckForUpdates,
            this.toolStripMenuItem2,
            this.mnuHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuCheckForUpdates
            // 
            this.mnuCheckForUpdates.Name = "mnuCheckForUpdates";
            this.mnuCheckForUpdates.Size = new System.Drawing.Size(176, 22);
            this.mnuCheckForUpdates.Text = "Check For Updates";
            this.mnuCheckForUpdates.Click += new System.EventHandler(this.mnuCheckForUpdates_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(176, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // mnuDonate
            // 
            this.mnuDonate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeADonationToolStripMenuItem});
            this.mnuDonate.Name = "mnuDonate";
            this.mnuDonate.Size = new System.Drawing.Size(54, 20);
            this.mnuDonate.Text = "Donate";
            // 
            // makeADonationToolStripMenuItem
            // 
            this.makeADonationToolStripMenuItem.Name = "makeADonationToolStripMenuItem";
            this.makeADonationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.makeADonationToolStripMenuItem.Text = "Make a donation";
            this.makeADonationToolStripMenuItem.Click += new System.EventHandler(this.makeADonationToolStripMenuItem_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.ControlDark;
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1016, 608);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.dockPanel.Skin = dockPanelSkin1;
            this.dockPanel.TabIndex = 6;
            this.dockPanel.SizeChanged += new System.EventHandler(this.dockPanel_SizeChanged);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProfileNew,
            this.btnProfileView,
            this.btnProfileDelete,
            this.btnProfileSave,
            this.toolStripSeparator3,
            this.btnProfileRun,
            this.btnProfileRefresh,
            this.toolStripSeparator6,
            this.btnProfilesLoad,
            this.btnProfilesSave,
            this.toolStripSeparator4,
            this.btnCardsRefresh,
            this.btnCardView,
            this.toolStripSeparator5});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1016, 55);
            this.toolStrip.TabIndex = 9;
            this.toolStrip.Text = "Command menù";
            // 
            // btnProfileNew
            // 
            this.btnProfileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfileNew.Image = global::Argon.Windows.Forms.Properties.Resources.index_add;
            this.btnProfileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfileNew.Name = "btnProfileNew";
            this.btnProfileNew.Size = new System.Drawing.Size(52, 52);
            this.btnProfileNew.Text = "New profile";
            this.btnProfileNew.Click += new System.EventHandler(this.btnProfileNew_Click);
            // 
            // btnProfileView
            // 
            this.btnProfileView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfileView.Image = global::Argon.Windows.Forms.Properties.Resources.index_view;
            this.btnProfileView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfileView.Name = "btnProfileView";
            this.btnProfileView.Size = new System.Drawing.Size(52, 52);
            this.btnProfileView.Text = "View profile";
            this.btnProfileView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnProfileDelete
            // 
            this.btnProfileDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfileDelete.Image = global::Argon.Windows.Forms.Properties.Resources.index_delete;
            this.btnProfileDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfileDelete.Name = "btnProfileDelete";
            this.btnProfileDelete.Size = new System.Drawing.Size(52, 52);
            this.btnProfileDelete.Text = "Delete profile";
            this.btnProfileDelete.Click += new System.EventHandler(this.btnProfileDelete_Click);
            // 
            // btnProfileSave
            // 
            this.btnProfileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfileSave.Image = global::Argon.Windows.Forms.Properties.Resources.index_preferences;
            this.btnProfileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfileSave.Name = "btnProfileSave";
            this.btnProfileSave.Size = new System.Drawing.Size(52, 52);
            this.btnProfileSave.Text = "Save Profile";
            this.btnProfileSave.Click += new System.EventHandler(this.btnProfileSave_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // btnProfileRun
            // 
            this.btnProfileRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfileRun.Image = global::Argon.Windows.Forms.Properties.Resources.gear_run1;
            this.btnProfileRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfileRun.Name = "btnProfileRun";
            this.btnProfileRun.Size = new System.Drawing.Size(52, 52);
            this.btnProfileRun.Text = "Run profile";
            this.btnProfileRun.Click += new System.EventHandler(this.btnProfileRun_Click);
            // 
            // btnProfileRefresh
            // 
            this.btnProfileRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfileRefresh.Image = global::Argon.Windows.Forms.Properties.Resources.refresh2;
            this.btnProfileRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfileRefresh.Name = "btnProfileRefresh";
            this.btnProfileRefresh.Size = new System.Drawing.Size(52, 52);
            this.btnProfileRefresh.Text = "Refresh network card";
            this.btnProfileRefresh.Click += new System.EventHandler(this.btnProfileRefresh_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 55);
            // 
            // btnProfilesLoad
            // 
            this.btnProfilesLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfilesLoad.Image = global::Argon.Windows.Forms.Properties.Resources.data_out;
            this.btnProfilesLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfilesLoad.Name = "btnProfilesLoad";
            this.btnProfilesLoad.Size = new System.Drawing.Size(52, 52);
            this.btnProfilesLoad.Text = "Load profiles";
            this.btnProfilesLoad.Click += new System.EventHandler(this.btnAllProfileLoad_Click);
            // 
            // btnProfilesSave
            // 
            this.btnProfilesSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfilesSave.Image = global::Argon.Windows.Forms.Properties.Resources.data_disk1;
            this.btnProfilesSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfilesSave.Name = "btnProfilesSave";
            this.btnProfilesSave.Size = new System.Drawing.Size(52, 52);
            this.btnProfilesSave.Text = "Save profiles";
            this.btnProfilesSave.Click += new System.EventHandler(this.btnProfileSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // btnCardsRefresh
            // 
            this.btnCardsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCardsRefresh.Image = global::Argon.Windows.Forms.Properties.Resources.PCI_card_network;
            this.btnCardsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCardsRefresh.Name = "btnCardsRefresh";
            this.btnCardsRefresh.Size = new System.Drawing.Size(52, 52);
            this.btnCardsRefresh.Text = "Refresh network cards";
            this.btnCardsRefresh.Click += new System.EventHandler(this.btnAllCardsRefresh_Click);
            // 
            // btnCardView
            // 
            this.btnCardView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCardView.Image = global::Argon.Windows.Forms.Properties.Resources.PCI_card_view1;
            this.btnCardView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCardView.Name = "btnCardView";
            this.btnCardView.Size = new System.Drawing.Size(52, 52);
            this.btnCardView.Text = "Network card view";
            this.btnCardView.Click += new System.EventHandler(this.btnCardView_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // imageList16x16
            // 
            this.imageList16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16x16.ImageStream")));
            this.imageList16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16x16.Images.SetKeyName(0, "package_delete.png");
            this.imageList16x16.Images.SetKeyName(1, "package_add.png");
            this.imageList16x16.Images.SetKeyName(2, "data_up.png");
            this.imageList16x16.Images.SetKeyName(3, "data_down.png");
            this.imageList16x16.Images.SetKeyName(4, "Graphite-Smooth-Folder-Applications-icon.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 608);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dockPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Argon - Network Switcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem mnuViewNetworkAdapters;
        public System.Windows.Forms.ToolStripMenuItem mnuViewProfiles;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        public DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList imageList16x16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripButton btnProfileNew;
        public System.Windows.Forms.ToolStripButton btnProfilesLoad;
        public System.Windows.Forms.ToolStripButton btnProfilesSave;
        public System.Windows.Forms.ToolStripButton btnProfileDelete;
        public System.Windows.Forms.ToolStripButton btnProfileView;
        public System.Windows.Forms.ToolStripButton btnProfileSave;
        public System.Windows.Forms.ToolStripButton btnCardsRefresh;
        public System.Windows.Forms.ToolStripButton btnCardView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton btnProfileRun;
        public System.Windows.Forms.ToolStripButton btnProfileRefresh;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        public System.Windows.Forms.ToolStripMenuItem mnuViewConsole;
        public System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckForUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDonate;
        private System.Windows.Forms.ToolStripMenuItem makeADonationToolStripMenuItem;

        public DockPanel Pannello
        {
            get
            {
                return dockPanel;
            }
        }
    }
}
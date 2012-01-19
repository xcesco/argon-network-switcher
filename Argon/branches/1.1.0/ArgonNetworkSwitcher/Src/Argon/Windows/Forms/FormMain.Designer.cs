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
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin2 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin2 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient4 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient8 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient9 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient5 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient10 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient11 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient12 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient6 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient13 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient14 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.rbtnProfilesSave = new System.Windows.Forms.RibbonButton();
            this.rbtnProfilesLoad = new System.Windows.Forms.RibbonButton();
            this.rtProfiles = new System.Windows.Forms.RibbonTab();
            this.rpOperations = new System.Windows.Forms.RibbonPanel();
            this.rbtnProfilesNew = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileView = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileDelete = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileSave = new System.Windows.Forms.RibbonButton();
            this.rsProfileSeparator = new System.Windows.Forms.RibbonSeparator();
            this.rbtnProfileRun = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileRefresh = new System.Windows.Forms.RibbonButton();
            this.rpProfilesCollection = new System.Windows.Forms.RibbonPanel();
            this.rtViews = new System.Windows.Forms.RibbonTab();
            this.rpViews = new System.Windows.Forms.RibbonPanel();
            this.rbtnViewConsole = new System.Windows.Forms.RibbonButton();
            this.rbtnViewProfiles = new System.Windows.Forms.RibbonButton();
            this.rbtnViewNICs = new System.Windows.Forms.RibbonButton();
            this.rtOptions = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rtHelp = new System.Windows.Forms.RibbonTab();
            this.rpHelp = new System.Windows.Forms.RibbonPanel();
            this.rbtnCheckUpdate = new System.Windows.Forms.RibbonButton();
            this.rbtnHelpAbout = new System.Windows.Forms.RibbonButton();
            this.rbtnHelpDonate = new System.Windows.Forms.RibbonButton();
            this.statusStrip.SuspendLayout();
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
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.ControlDark;
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1016, 608);
            dockPanelGradient4.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient4.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin2.DockStripGradient = dockPanelGradient4;
            tabGradient8.EndColor = System.Drawing.SystemColors.Control;
            tabGradient8.StartColor = System.Drawing.SystemColors.Control;
            tabGradient8.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin2.TabGradient = tabGradient8;
            dockPanelSkin2.AutoHideStripSkin = autoHideStripSkin2;
            tabGradient9.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient9.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient9.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient2.ActiveTabGradient = tabGradient9;
            dockPanelGradient5.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient5.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient2.DockStripGradient = dockPanelGradient5;
            tabGradient10.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient10.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient10.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient2.InactiveTabGradient = tabGradient10;
            dockPaneStripSkin2.DocumentGradient = dockPaneStripGradient2;
            tabGradient11.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient11.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient11.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient11.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient2.ActiveCaptionGradient = tabGradient11;
            tabGradient12.EndColor = System.Drawing.SystemColors.Control;
            tabGradient12.StartColor = System.Drawing.SystemColors.Control;
            tabGradient12.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient2.ActiveTabGradient = tabGradient12;
            dockPanelGradient6.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient6.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient2.DockStripGradient = dockPanelGradient6;
            tabGradient13.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient13.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient13.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient13.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient2.InactiveCaptionGradient = tabGradient13;
            tabGradient14.EndColor = System.Drawing.Color.Transparent;
            tabGradient14.StartColor = System.Drawing.Color.Transparent;
            tabGradient14.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient2.InactiveTabGradient = tabGradient14;
            dockPaneStripSkin2.ToolWindowGradient = dockPaneStripToolWindowGradient2;
            dockPanelSkin2.DockPaneStripSkin = dockPaneStripSkin2;
            this.dockPanel.Skin = dockPanelSkin2;
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
            // ribbon
            // 
            this.ribbon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Minimized = false;
            this.ribbon.Name = "ribbon";
            // 
            // 
            // 
            this.ribbon.OrbDropDown.BorderRoundness = 8;
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbImage = global::Argon.Windows.Forms.Properties.Resources.PCI_card_view;
            // 
            // 
            // 
            this.ribbon.QuickAcessToolbar.AltKey = null;
            this.ribbon.QuickAcessToolbar.Image = null;
            this.ribbon.QuickAcessToolbar.Items.Add(this.rbtnProfilesSave);
            this.ribbon.QuickAcessToolbar.Items.Add(this.rbtnProfilesLoad);
            this.ribbon.QuickAcessToolbar.Tag = null;
            this.ribbon.QuickAcessToolbar.Text = null;
            this.ribbon.QuickAcessToolbar.ToolTip = null;
            this.ribbon.QuickAcessToolbar.ToolTipImage = null;
            this.ribbon.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon.Size = new System.Drawing.Size(1016, 138);
            this.ribbon.TabIndex = 12;
            this.ribbon.Tabs.Add(this.rtProfiles);
            this.ribbon.Tabs.Add(this.rtViews);
            this.ribbon.Tabs.Add(this.rtOptions);
            this.ribbon.Tabs.Add(this.rtHelp);
            this.ribbon.TabSpacing = 6;
            this.ribbon.Text = "ribbon";
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // rbtnProfilesSave
            // 
            this.rbtnProfilesSave.AltKey = null;
            this.rbtnProfilesSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfilesSave.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfilesSave.Image = ((System.Drawing.Image)(resources.GetObject("rbtnProfilesSave.Image")));
            this.rbtnProfilesSave.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.rbtnProfilesSave.SmallImage = global::Argon.Windows.Forms.Properties.Resources.disk_blue;
            this.rbtnProfilesSave.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfilesSave.Tag = null;
            this.rbtnProfilesSave.Text = "Save";
            this.rbtnProfilesSave.ToolTip = null;
            this.rbtnProfilesSave.ToolTipImage = null;
            this.rbtnProfilesSave.ToolTipTitle = "Save profiles";
            this.rbtnProfilesSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // rbtnProfilesLoad
            // 
            this.rbtnProfilesLoad.AltKey = null;
            this.rbtnProfilesLoad.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfilesLoad.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfilesLoad.Image = ((System.Drawing.Image)(resources.GetObject("rbtnProfilesLoad.Image")));
            this.rbtnProfilesLoad.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.rbtnProfilesLoad.SmallImage = global::Argon.Windows.Forms.Properties.Resources.document;
            this.rbtnProfilesLoad.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfilesLoad.Tag = null;
            this.rbtnProfilesLoad.Text = "Load profiles";
            this.rbtnProfilesLoad.ToolTip = null;
            this.rbtnProfilesLoad.ToolTipImage = null;
            this.rbtnProfilesLoad.ToolTipTitle = "Load profiles";
            this.rbtnProfilesLoad.Click += new System.EventHandler(this.btnAllProfileLoad_Click);
            // 
            // rtProfiles
            // 
            this.rtProfiles.Panels.Add(this.rpOperations);
            this.rtProfiles.Panels.Add(this.rpProfilesCollection);
            this.rtProfiles.Tag = null;
            this.rtProfiles.Text = "Profiles";
            // 
            // rpOperations
            // 
            this.rpOperations.ButtonMoreEnabled = false;
            this.rpOperations.ButtonMoreVisible = false;
            this.rpOperations.Items.Add(this.rbtnProfilesNew);
            this.rpOperations.Items.Add(this.rbtnProfileView);
            this.rpOperations.Items.Add(this.rbtnProfileDelete);
            this.rpOperations.Items.Add(this.rbtnProfileSave);
            this.rpOperations.Items.Add(this.rsProfileSeparator);
            this.rpOperations.Items.Add(this.rbtnProfileRun);
            this.rpOperations.Items.Add(this.rbtnProfileRefresh);
            this.rpOperations.Tag = null;
            this.rpOperations.Text = "Operations";
            // 
            // rbtnProfilesNew
            // 
            this.rbtnProfilesNew.AltKey = null;
            this.rbtnProfilesNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfilesNew.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfilesNew.Image = global::Argon.Windows.Forms.Properties.Resources.index_add;
            this.rbtnProfilesNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfilesNew.SmallImage")));
            this.rbtnProfilesNew.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfilesNew.Tag = null;
            this.rbtnProfilesNew.Text = "New";
            this.rbtnProfilesNew.ToolTip = "New profile";
            this.rbtnProfilesNew.ToolTipImage = null;
            this.rbtnProfilesNew.ToolTipTitle = null;
            // 
            // rbtnProfileView
            // 
            this.rbtnProfileView.AltKey = null;
            this.rbtnProfileView.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileView.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileView.Image = global::Argon.Windows.Forms.Properties.Resources.index_view;
            this.rbtnProfileView.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileView.SmallImage")));
            this.rbtnProfileView.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileView.Tag = null;
            this.rbtnProfileView.Text = "View";
            this.rbtnProfileView.ToolTip = "View selected profile";
            this.rbtnProfileView.ToolTipImage = null;
            this.rbtnProfileView.ToolTipTitle = null;
            // 
            // rbtnProfileDelete
            // 
            this.rbtnProfileDelete.AltKey = null;
            this.rbtnProfileDelete.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileDelete.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileDelete.Image = global::Argon.Windows.Forms.Properties.Resources.index_delete;
            this.rbtnProfileDelete.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileDelete.SmallImage")));
            this.rbtnProfileDelete.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileDelete.Tag = null;
            this.rbtnProfileDelete.Text = "Delete";
            this.rbtnProfileDelete.ToolTip = "Delete selected profile";
            this.rbtnProfileDelete.ToolTipImage = null;
            this.rbtnProfileDelete.ToolTipTitle = null;
            // 
            // rbtnProfileSave
            // 
            this.rbtnProfileSave.AltKey = null;
            this.rbtnProfileSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileSave.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileSave.Image = global::Argon.Windows.Forms.Properties.Resources.index_preferences;
            this.rbtnProfileSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileSave.SmallImage")));
            this.rbtnProfileSave.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileSave.Tag = null;
            this.rbtnProfileSave.Text = "Save";
            this.rbtnProfileSave.ToolTip = null;
            this.rbtnProfileSave.ToolTipImage = null;
            this.rbtnProfileSave.ToolTipTitle = null;
            this.rbtnProfileSave.Click += new System.EventHandler(this.btnProfileSave_Click_1);
            // 
            // rsProfileSeparator
            // 
            this.rsProfileSeparator.AltKey = null;
            this.rsProfileSeparator.Image = null;
            this.rsProfileSeparator.Tag = null;
            this.rsProfileSeparator.Text = null;
            this.rsProfileSeparator.ToolTip = null;
            this.rsProfileSeparator.ToolTipImage = null;
            this.rsProfileSeparator.ToolTipTitle = null;
            // 
            // rbtnProfileRun
            // 
            this.rbtnProfileRun.AltKey = null;
            this.rbtnProfileRun.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileRun.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileRun.Image = global::Argon.Windows.Forms.Properties.Resources.gear_run1;
            this.rbtnProfileRun.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileRun.SmallImage")));
            this.rbtnProfileRun.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileRun.Tag = null;
            this.rbtnProfileRun.Text = "Run";
            this.rbtnProfileRun.ToolTip = null;
            this.rbtnProfileRun.ToolTipImage = null;
            this.rbtnProfileRun.ToolTipTitle = null;
            // 
            // rbtnProfileRefresh
            // 
            this.rbtnProfileRefresh.AltKey = null;
            this.rbtnProfileRefresh.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileRefresh.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileRefresh.Image = global::Argon.Windows.Forms.Properties.Resources.refresh2;
            this.rbtnProfileRefresh.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileRefresh.SmallImage")));
            this.rbtnProfileRefresh.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileRefresh.Tag = null;
            this.rbtnProfileRefresh.Text = "Refresh";
            this.rbtnProfileRefresh.ToolTip = null;
            this.rbtnProfileRefresh.ToolTipImage = null;
            this.rbtnProfileRefresh.ToolTipTitle = null;
            // 
            // rpProfilesCollection
            // 
            this.rpProfilesCollection.Tag = null;
            this.rpProfilesCollection.Text = "Profiles";
            // 
            // rtViews
            // 
            this.rtViews.Panels.Add(this.rpViews);
            this.rtViews.Tag = null;
            this.rtViews.Text = "Views";
            // 
            // rpViews
            // 
            this.rpViews.Items.Add(this.rbtnViewConsole);
            this.rpViews.Items.Add(this.rbtnViewProfiles);
            this.rpViews.Items.Add(this.rbtnViewNICs);
            this.rpViews.Tag = null;
            this.rpViews.Text = "views";
            // 
            // rbtnViewConsole
            // 
            this.rbtnViewConsole.AltKey = null;
            this.rbtnViewConsole.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnViewConsole.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnViewConsole.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnViewConsole.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnViewConsole.SmallImage")));
            this.rbtnViewConsole.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnViewConsole.Tag = null;
            this.rbtnViewConsole.Text = "Console";
            this.rbtnViewConsole.ToolTip = null;
            this.rbtnViewConsole.ToolTipImage = null;
            this.rbtnViewConsole.ToolTipTitle = null;
            this.rbtnViewConsole.Click += new System.EventHandler(this.mnuViewConsole_Click);
            // 
            // rbtnViewProfiles
            // 
            this.rbtnViewProfiles.AltKey = null;
            this.rbtnViewProfiles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnViewProfiles.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnViewProfiles.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnViewProfiles.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnViewProfiles.SmallImage")));
            this.rbtnViewProfiles.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnViewProfiles.Tag = null;
            this.rbtnViewProfiles.Text = "Profiles";
            this.rbtnViewProfiles.ToolTip = null;
            this.rbtnViewProfiles.ToolTipImage = null;
            this.rbtnViewProfiles.ToolTipTitle = null;
            this.rbtnViewProfiles.Click += new System.EventHandler(this.profilesToolStripMenuItem_Click);
            // 
            // rbtnViewNICs
            // 
            this.rbtnViewNICs.AltKey = null;
            this.rbtnViewNICs.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnViewNICs.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnViewNICs.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnViewNICs.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnViewNICs.SmallImage")));
            this.rbtnViewNICs.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnViewNICs.Tag = null;
            this.rbtnViewNICs.Text = "Networks Card";
            this.rbtnViewNICs.ToolTip = null;
            this.rbtnViewNICs.ToolTipImage = null;
            this.rbtnViewNICs.ToolTipTitle = null;
            this.rbtnViewNICs.Click += new System.EventHandler(this.mnuViewNetworkAdapters_Click);
            // 
            // rtOptions
            // 
            this.rtOptions.Panels.Add(this.ribbonPanel1);
            this.rtOptions.Tag = null;
            this.rtOptions.Text = "Options";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "options";
            // 
            // rtHelp
            // 
            this.rtHelp.Panels.Add(this.rpHelp);
            this.rtHelp.Tag = null;
            this.rtHelp.Text = "Help";
            // 
            // rpHelp
            // 
            this.rpHelp.Items.Add(this.rbtnCheckUpdate);
            this.rpHelp.Items.Add(this.rbtnHelpAbout);
            this.rpHelp.Items.Add(this.rbtnHelpDonate);
            this.rpHelp.Tag = null;
            this.rpHelp.Text = "Info";
            // 
            // rbtnCheckUpdate
            // 
            this.rbtnCheckUpdate.AltKey = null;
            this.rbtnCheckUpdate.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnCheckUpdate.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnCheckUpdate.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnCheckUpdate.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCheckUpdate.SmallImage")));
            this.rbtnCheckUpdate.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnCheckUpdate.Tag = null;
            this.rbtnCheckUpdate.Text = "Check update";
            this.rbtnCheckUpdate.ToolTip = null;
            this.rbtnCheckUpdate.ToolTipImage = null;
            this.rbtnCheckUpdate.ToolTipTitle = "Check for update";
            // 
            // rbtnHelpAbout
            // 
            this.rbtnHelpAbout.AltKey = null;
            this.rbtnHelpAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnHelpAbout.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnHelpAbout.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnHelpAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnHelpAbout.SmallImage")));
            this.rbtnHelpAbout.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnHelpAbout.Tag = null;
            this.rbtnHelpAbout.Text = "About";
            this.rbtnHelpAbout.ToolTip = null;
            this.rbtnHelpAbout.ToolTipImage = null;
            this.rbtnHelpAbout.ToolTipTitle = null;
            // 
            // rbtnHelpDonate
            // 
            this.rbtnHelpDonate.AltKey = null;
            this.rbtnHelpDonate.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnHelpDonate.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnHelpDonate.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnHelpDonate.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnHelpDonate.SmallImage")));
            this.rbtnHelpDonate.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnHelpDonate.Tag = null;
            this.rbtnHelpDonate.Text = "Donate";
            this.rbtnHelpDonate.ToolTip = null;
            this.rbtnHelpDonate.ToolTipImage = null;
            this.rbtnHelpDonate.ToolTipTitle = "Donate";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 608);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dockPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Argon - Network Switcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        public DockPanel dockPanel;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ImageList imageList16x16;
        private System.Windows.Forms.Ribbon ribbon;
        private System.Windows.Forms.RibbonButton rbtnProfilesSave;
        private System.Windows.Forms.RibbonTab rtProfiles;
        private System.Windows.Forms.RibbonPanel rpOperations;
        private System.Windows.Forms.RibbonTab rtViews;
        private System.Windows.Forms.RibbonPanel rpViews;
        private System.Windows.Forms.RibbonPanel rpProfilesCollection;
        private System.Windows.Forms.RibbonTab rtOptions;
        private System.Windows.Forms.RibbonButton rbtnProfilesLoad;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab rtHelp;
        private System.Windows.Forms.RibbonSeparator rsProfileSeparator;
        private System.Windows.Forms.RibbonPanel rpHelp;
        private System.Windows.Forms.RibbonButton rbtnCheckUpdate;
        private System.Windows.Forms.RibbonButton rbtnHelpAbout;
        private System.Windows.Forms.RibbonButton rbtnHelpDonate;
        public System.Windows.Forms.RibbonButton rbtnProfilesNew;
        public System.Windows.Forms.RibbonButton rbtnProfileView;
        public System.Windows.Forms.RibbonButton rbtnProfileDelete;
        public System.Windows.Forms.RibbonButton rbtnViewConsole;
        public System.Windows.Forms.RibbonButton rbtnProfileSave;
        public System.Windows.Forms.RibbonButton rbtnProfileRun;
        public System.Windows.Forms.RibbonButton rbtnProfileRefresh;
        public System.Windows.Forms.RibbonButton rbtnViewProfiles;
        public System.Windows.Forms.RibbonButton rbtnViewNICs;

        public DockPanel Pannello
        {
            get
            {
                return dockPanel;
            }
        }
    }
}
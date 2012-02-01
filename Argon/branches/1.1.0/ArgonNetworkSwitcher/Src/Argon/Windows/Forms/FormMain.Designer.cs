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
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin4 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin4 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient10 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient22 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin4 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient4 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient23 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient11 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient24 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient4 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient25 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient26 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient12 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient27 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient28 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.rbtnSmartView = new System.Windows.Forms.RibbonButton();
            this.rbtnConfigLoad = new System.Windows.Forms.RibbonButton();
            this.rbtnConfigSave = new System.Windows.Forms.RibbonButton();
            this.rtProfiles = new System.Windows.Forms.RibbonTab();
            this.rpProfilesCollection = new System.Windows.Forms.RibbonPanel();
            this.rtOperations = new System.Windows.Forms.RibbonTab();
            this.rpProfile = new System.Windows.Forms.RibbonPanel();
            this.rbtnProfileNew = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileView = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileDelete = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileSave = new System.Windows.Forms.RibbonButton();
            this.rsProfileSeparator = new System.Windows.Forms.RibbonSeparator();
            this.rbtnProfileRun = new System.Windows.Forms.RibbonButton();
            this.rpCards = new System.Windows.Forms.RibbonPanel();
            this.rbtnCardsRefresh = new System.Windows.Forms.RibbonButton();
            this.rbtnCardView = new System.Windows.Forms.RibbonButton();
            this.rpNetworkCard = new System.Windows.Forms.RibbonPanel();
            this.rpConsole = new System.Windows.Forms.RibbonPanel();
            this.rtViews = new System.Windows.Forms.RibbonTab();
            this.rpViews = new System.Windows.Forms.RibbonPanel();
            this.rbtnViewConsole = new System.Windows.Forms.RibbonButton();
            this.rbtnViewProfiles = new System.Windows.Forms.RibbonButton();
            this.rbtnViewNetworkCards = new System.Windows.Forms.RibbonButton();
            this.rpHelp = new System.Windows.Forms.RibbonPanel();
            this.rbtnHelpAbout = new System.Windows.Forms.RibbonButton();
            this.rbtnHelpUpdate = new System.Windows.Forms.RibbonButton();
            this.rbtnHelpDonate = new System.Windows.Forms.RibbonButton();
            this.pnlRibbonContainer = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.pnlRibbonContainer.SuspendLayout();
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
            this.dockPanel.Location = new System.Drawing.Point(0, 140);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1016, 446);
            dockPanelGradient10.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient10.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin4.DockStripGradient = dockPanelGradient10;
            tabGradient22.EndColor = System.Drawing.SystemColors.Control;
            tabGradient22.StartColor = System.Drawing.SystemColors.Control;
            tabGradient22.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin4.TabGradient = tabGradient22;
            dockPanelSkin4.AutoHideStripSkin = autoHideStripSkin4;
            tabGradient23.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient23.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient23.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient4.ActiveTabGradient = tabGradient23;
            dockPanelGradient11.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient11.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient4.DockStripGradient = dockPanelGradient11;
            tabGradient24.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient24.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient24.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient4.InactiveTabGradient = tabGradient24;
            dockPaneStripSkin4.DocumentGradient = dockPaneStripGradient4;
            tabGradient25.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient25.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient25.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient25.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient4.ActiveCaptionGradient = tabGradient25;
            tabGradient26.EndColor = System.Drawing.SystemColors.Control;
            tabGradient26.StartColor = System.Drawing.SystemColors.Control;
            tabGradient26.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient4.ActiveTabGradient = tabGradient26;
            dockPanelGradient12.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient12.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient4.DockStripGradient = dockPanelGradient12;
            tabGradient27.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient27.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient27.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient27.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient4.InactiveCaptionGradient = tabGradient27;
            tabGradient28.EndColor = System.Drawing.Color.Transparent;
            tabGradient28.StartColor = System.Drawing.Color.Transparent;
            tabGradient28.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient4.InactiveTabGradient = tabGradient28;
            dockPaneStripSkin4.ToolWindowGradient = dockPaneStripToolWindowGradient4;
            dockPanelSkin4.DockPaneStripSkin = dockPaneStripSkin4;
            this.dockPanel.Skin = dockPanelSkin4;
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
            this.ribbon.OrbImage = null;
            this.ribbon.OrbVisible = false;
            this.ribbon.QuickAccessVisible = false;
            // 
            // 
            // 
            this.ribbon.QuickAcessToolbar.AltKey = null;
            this.ribbon.QuickAcessToolbar.Image = null;
            this.ribbon.QuickAcessToolbar.Items.Add(this.rbtnSmartView);
            this.ribbon.QuickAcessToolbar.Items.Add(this.rbtnConfigLoad);
            this.ribbon.QuickAcessToolbar.Items.Add(this.rbtnConfigSave);
            this.ribbon.QuickAcessToolbar.Tag = null;
            this.ribbon.QuickAcessToolbar.Text = null;
            this.ribbon.QuickAcessToolbar.ToolTip = null;
            this.ribbon.QuickAcessToolbar.ToolTipImage = null;
            this.ribbon.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon.Size = new System.Drawing.Size(1016, 138);
            this.ribbon.TabIndex = 12;
            this.ribbon.Tabs.Add(this.rtProfiles);
            this.ribbon.Tabs.Add(this.rtOperations);
            this.ribbon.Tabs.Add(this.rtViews);
            this.ribbon.TabSpacing = 6;
            this.ribbon.Text = "ribbon";
            // 
            // rbtnSmartView
            // 
            this.rbtnSmartView.AltKey = null;
            this.rbtnSmartView.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnSmartView.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnSmartView.Image = ((System.Drawing.Image)(resources.GetObject("rbtnSmartView.Image")));
            this.rbtnSmartView.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.rbtnSmartView.SmallImage = global::Argon.Windows.Forms.Properties.Resources.lightbulb_16x16;
            this.rbtnSmartView.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnSmartView.Tag = null;
            this.rbtnSmartView.Text = "Smart view";
            this.rbtnSmartView.ToolTip = null;
            this.rbtnSmartView.ToolTipImage = null;
            this.rbtnSmartView.ToolTipTitle = null;
            this.rbtnSmartView.Click += new System.EventHandler(this.rbtnSmartView_Click);
            // 
            // rbtnConfigLoad
            // 
            this.rbtnConfigLoad.AltKey = null;
            this.rbtnConfigLoad.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnConfigLoad.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnConfigLoad.Image = ((System.Drawing.Image)(resources.GetObject("rbtnConfigLoad.Image")));
            this.rbtnConfigLoad.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.rbtnConfigLoad.SmallImage = global::Argon.Windows.Forms.Properties.Resources.document;
            this.rbtnConfigLoad.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnConfigLoad.Tag = null;
            this.rbtnConfigLoad.Text = "Load config";
            this.rbtnConfigLoad.ToolTip = null;
            this.rbtnConfigLoad.ToolTipImage = null;
            this.rbtnConfigLoad.ToolTipTitle = "Load config";
            this.rbtnConfigLoad.Click += new System.EventHandler(this.btnConfigLoad_Click);
            // 
            // rbtnConfigSave
            // 
            this.rbtnConfigSave.AltKey = null;
            this.rbtnConfigSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnConfigSave.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnConfigSave.Image = ((System.Drawing.Image)(resources.GetObject("rbtnConfigSave.Image")));
            this.rbtnConfigSave.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.rbtnConfigSave.SmallImage = global::Argon.Windows.Forms.Properties.Resources.disk_blue;
            this.rbtnConfigSave.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnConfigSave.Tag = null;
            this.rbtnConfigSave.Text = "Save";
            this.rbtnConfigSave.ToolTip = null;
            this.rbtnConfigSave.ToolTipImage = null;
            this.rbtnConfigSave.ToolTipTitle = "Save config";
            this.rbtnConfigSave.Click += new System.EventHandler(this.rbtnConfigSave_Click);
            // 
            // rtProfiles
            // 
            this.rtProfiles.Panels.Add(this.rpProfilesCollection);
            this.rtProfiles.Tag = null;
            this.rtProfiles.Text = "Profiles";
            // 
            // rpProfilesCollection
            // 
            this.rpProfilesCollection.Tag = null;
            this.rpProfilesCollection.Text = "Run";
            // 
            // rtOperations
            // 
            this.rtOperations.Panels.Add(this.rpProfile);
            this.rtOperations.Panels.Add(this.rpCards);
            this.rtOperations.Panels.Add(this.rpNetworkCard);
            this.rtOperations.Panels.Add(this.rpConsole);
            this.rtOperations.Tag = null;
            this.rtOperations.Text = "Operations";
            // 
            // rpProfile
            // 
            this.rpProfile.ButtonMoreEnabled = false;
            this.rpProfile.ButtonMoreVisible = false;
            this.rpProfile.Items.Add(this.rbtnProfileNew);
            this.rpProfile.Items.Add(this.rbtnProfileView);
            this.rpProfile.Items.Add(this.rbtnProfileDelete);
            this.rpProfile.Items.Add(this.rbtnProfileSave);
            this.rpProfile.Items.Add(this.rsProfileSeparator);
            this.rpProfile.Items.Add(this.rbtnProfileRun);
            this.rpProfile.Tag = null;
            this.rpProfile.Text = "profile";
            // 
            // rbtnProfileNew
            // 
            this.rbtnProfileNew.AltKey = null;
            this.rbtnProfileNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileNew.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileNew.Image = global::Argon.Windows.Forms.Properties.Resources.document_new48x48;
            this.rbtnProfileNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileNew.SmallImage")));
            this.rbtnProfileNew.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileNew.Tag = null;
            this.rbtnProfileNew.Text = "New";
            this.rbtnProfileNew.ToolTip = "New profile";
            this.rbtnProfileNew.ToolTipImage = null;
            this.rbtnProfileNew.ToolTipTitle = null;
            this.rbtnProfileNew.Click += new System.EventHandler(this.btnProfileNew_Click);
            // 
            // rbtnProfileView
            // 
            this.rbtnProfileView.AltKey = null;
            this.rbtnProfileView.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileView.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileView.Image = global::Argon.Windows.Forms.Properties.Resources.document_edit48x48;
            this.rbtnProfileView.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileView.SmallImage")));
            this.rbtnProfileView.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileView.Tag = null;
            this.rbtnProfileView.Text = "View";
            this.rbtnProfileView.ToolTip = "View selected profile";
            this.rbtnProfileView.ToolTipImage = null;
            this.rbtnProfileView.ToolTipTitle = null;
            this.rbtnProfileView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // rbtnProfileDelete
            // 
            this.rbtnProfileDelete.AltKey = null;
            this.rbtnProfileDelete.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileDelete.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileDelete.Image = global::Argon.Windows.Forms.Properties.Resources.document_delete48x48;
            this.rbtnProfileDelete.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileDelete.SmallImage")));
            this.rbtnProfileDelete.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileDelete.Tag = null;
            this.rbtnProfileDelete.Text = "Delete";
            this.rbtnProfileDelete.ToolTip = "Delete selected profile";
            this.rbtnProfileDelete.ToolTipImage = null;
            this.rbtnProfileDelete.ToolTipTitle = null;
            this.rbtnProfileDelete.Click += new System.EventHandler(this.btnProfileDelete_Click);
            // 
            // rbtnProfileSave
            // 
            this.rbtnProfileSave.AltKey = null;
            this.rbtnProfileSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfileSave.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfileSave.Image = global::Argon.Windows.Forms.Properties.Resources.document_check48x48;
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
            this.rbtnProfileRun.Image = global::Argon.Windows.Forms.Properties.Resources.document_connection48x48;
            this.rbtnProfileRun.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfileRun.SmallImage")));
            this.rbtnProfileRun.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfileRun.Tag = null;
            this.rbtnProfileRun.Text = "Run";
            this.rbtnProfileRun.ToolTip = null;
            this.rbtnProfileRun.ToolTipImage = null;
            this.rbtnProfileRun.ToolTipTitle = null;
            // 
            // rpCards
            // 
            this.rpCards.Items.Add(this.rbtnCardsRefresh);
            this.rpCards.Items.Add(this.rbtnCardView);
            this.rpCards.Tag = null;
            this.rpCards.Text = "network cards";
            // 
            // rbtnCardsRefresh
            // 
            this.rbtnCardsRefresh.AltKey = null;
            this.rbtnCardsRefresh.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnCardsRefresh.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnCardsRefresh.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnCardsRefresh.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCardsRefresh.SmallImage")));
            this.rbtnCardsRefresh.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnCardsRefresh.Tag = null;
            this.rbtnCardsRefresh.Text = "Refresh";
            this.rbtnCardsRefresh.ToolTip = null;
            this.rbtnCardsRefresh.ToolTipImage = null;
            this.rbtnCardsRefresh.ToolTipTitle = null;
            // 
            // rbtnCardView
            // 
            this.rbtnCardView.AltKey = null;
            this.rbtnCardView.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnCardView.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnCardView.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnCardView.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCardView.SmallImage")));
            this.rbtnCardView.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnCardView.Tag = null;
            this.rbtnCardView.Text = "View";
            this.rbtnCardView.ToolTip = null;
            this.rbtnCardView.ToolTipImage = null;
            this.rbtnCardView.ToolTipTitle = null;
            // 
            // rpNetworkCard
            // 
            this.rpNetworkCard.Tag = null;
            this.rpNetworkCard.Text = "network card";
            // 
            // rpConsole
            // 
            this.rpConsole.Tag = null;
            this.rpConsole.Text = "console";
            // 
            // rtViews
            // 
            this.rtViews.Panels.Add(this.rpViews);
            this.rtViews.Panels.Add(this.rpHelp);
            this.rtViews.Tag = null;
            this.rtViews.Text = "Views";
            // 
            // rpViews
            // 
            this.rpViews.Items.Add(this.rbtnViewConsole);
            this.rpViews.Items.Add(this.rbtnViewProfiles);
            this.rpViews.Items.Add(this.rbtnViewNetworkCards);
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
            this.rbtnViewProfiles.Click += new System.EventHandler(this.rbtnViewProfiles_Click);
            // 
            // rbtnViewNetworkCards
            // 
            this.rbtnViewNetworkCards.AltKey = null;
            this.rbtnViewNetworkCards.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnViewNetworkCards.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnViewNetworkCards.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnViewNetworkCards.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnViewNetworkCards.SmallImage")));
            this.rbtnViewNetworkCards.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnViewNetworkCards.Tag = null;
            this.rbtnViewNetworkCards.Text = "Networks Card";
            this.rbtnViewNetworkCards.ToolTip = null;
            this.rbtnViewNetworkCards.ToolTipImage = null;
            this.rbtnViewNetworkCards.ToolTipTitle = null;
            this.rbtnViewNetworkCards.Click += new System.EventHandler(this.mnuViewNetworkAdapters_Click);
            // 
            // rpHelp
            // 
            this.rpHelp.Items.Add(this.rbtnHelpAbout);
            this.rpHelp.Items.Add(this.rbtnHelpUpdate);
            this.rpHelp.Items.Add(this.rbtnHelpDonate);
            this.rpHelp.Tag = null;
            this.rpHelp.Text = "help";
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
            this.rbtnHelpAbout.Click += new System.EventHandler(this.rbtnHelpAbout_Click);
            // 
            // rbtnHelpUpdate
            // 
            this.rbtnHelpUpdate.AltKey = null;
            this.rbtnHelpUpdate.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnHelpUpdate.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnHelpUpdate.Image = global::Argon.Windows.Forms.Properties.Resources.package_view1;
            this.rbtnHelpUpdate.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnHelpUpdate.SmallImage")));
            this.rbtnHelpUpdate.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnHelpUpdate.Tag = null;
            this.rbtnHelpUpdate.Text = "Update";
            this.rbtnHelpUpdate.ToolTip = null;
            this.rbtnHelpUpdate.ToolTipImage = null;
            this.rbtnHelpUpdate.ToolTipTitle = null;
            this.rbtnHelpUpdate.Click += new System.EventHandler(this.rbtnHelpUpdate_Click);
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
            this.rbtnHelpDonate.ToolTipTitle = null;
            this.rbtnHelpDonate.Click += new System.EventHandler(this.rbtnHelpDonate_Click);
            // 
            // pnlRibbonContainer
            // 
            this.pnlRibbonContainer.Controls.Add(this.ribbon);
            this.pnlRibbonContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRibbonContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlRibbonContainer.Name = "pnlRibbonContainer";
            this.pnlRibbonContainer.Size = new System.Drawing.Size(1016, 140);
            this.pnlRibbonContainer.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 608);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.pnlRibbonContainer);
            this.Controls.Add(this.statusStrip);
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
            this.pnlRibbonContainer.ResumeLayout(false);
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
        private System.Windows.Forms.RibbonTab rtProfiles;
        private System.Windows.Forms.RibbonPanel rpProfile;
        private System.Windows.Forms.RibbonTab rtOperations;
        private System.Windows.Forms.RibbonPanel rpViews;
        private System.Windows.Forms.RibbonTab rtViews;
        private System.Windows.Forms.RibbonSeparator rsProfileSeparator;
        public System.Windows.Forms.RibbonButton rbtnProfileNew;
        public System.Windows.Forms.RibbonButton rbtnProfileView;
        public System.Windows.Forms.RibbonButton rbtnProfileDelete;
        public System.Windows.Forms.RibbonButton rbtnViewConsole;
        public System.Windows.Forms.RibbonButton rbtnProfileSave;
        public System.Windows.Forms.RibbonButton rbtnViewProfiles;
        public System.Windows.Forms.RibbonButton rbtnViewNetworkCards;
        public System.Windows.Forms.RibbonButton rbtnConfigSave;
        public System.Windows.Forms.RibbonButton rbtnConfigLoad;
        private System.Windows.Forms.RibbonPanel rpCards;
        public System.Windows.Forms.RibbonButton rbtnCardsRefresh;
        public System.Windows.Forms.RibbonButton rbtnCardView;
        public System.Windows.Forms.RibbonPanel rpProfilesCollection;
        private System.Windows.Forms.RibbonPanel rpNetworkCard;
        private System.Windows.Forms.RibbonPanel rpConsole;
        private System.Windows.Forms.RibbonPanel rpHelp;
        private System.Windows.Forms.RibbonButton rbtnHelpAbout;
        private System.Windows.Forms.RibbonButton rbtnHelpUpdate;
        private System.Windows.Forms.RibbonButton rbtnHelpDonate;
        public System.Windows.Forms.RibbonButton rbtnProfileRun;
        public System.Windows.Forms.RibbonButton rbtnSmartView;
        public System.Windows.Forms.Panel pnlRibbonContainer;
        
        public DockPanel Pannello
        {
            get
            {
                return dockPanel;
            }
        }
    }
}
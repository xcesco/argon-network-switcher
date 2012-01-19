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
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.rtProfiles = new System.Windows.Forms.RibbonTab();
            this.rpOperations = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rtViews = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.rbtnProfilesSave = new System.Windows.Forms.RibbonButton();
            this.rbtnProfilesLoad = new System.Windows.Forms.RibbonButton();
            this.rbtnProfilesAdd = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileView = new System.Windows.Forms.RibbonButton();
            this.rbtnProfileDelete = new System.Windows.Forms.RibbonButton();
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
            this.lblStatus.Size = new System.Drawing.Size(38, 17);
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
            this.ribbon.Tabs.Add(this.ribbonTab1);
            this.ribbon.TabSpacing = 6;
            this.ribbon.Text = "ribbon";
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // rtProfiles
            // 
            this.rtProfiles.Panels.Add(this.rpOperations);
            this.rtProfiles.Panels.Add(this.ribbonPanel3);
            this.rtProfiles.Tag = null;
            this.rtProfiles.Text = "Profiles";
            // 
            // rpOperations
            // 
            this.rpOperations.Items.Add(this.rbtnProfilesAdd);
            this.rpOperations.Items.Add(this.rbtnProfileView);
            this.rpOperations.Items.Add(this.rbtnProfileDelete);
            this.rpOperations.Tag = null;
            this.rpOperations.Text = "Operations";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Tag = null;
            this.ribbonPanel3.Text = "Profiles";
            // 
            // rtViews
            // 
            this.rtViews.Panels.Add(this.ribbonPanel2);
            this.rtViews.Tag = null;
            this.rtViews.Text = "Views";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Tag = null;
            this.ribbonPanel2.Text = "views";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Tag = null;
            this.ribbonTab1.Text = "ribbonTab1";
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
            // 
            // rbtnProfilesAdd
            // 
            this.rbtnProfilesAdd.AltKey = null;
            this.rbtnProfilesAdd.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnProfilesAdd.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnProfilesAdd.Image = global::Argon.Windows.Forms.Properties.Resources.index_add;
            this.rbtnProfilesAdd.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnProfilesAdd.SmallImage")));
            this.rbtnProfilesAdd.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnProfilesAdd.Tag = null;
            this.rbtnProfilesAdd.Text = null;
            this.rbtnProfilesAdd.ToolTip = "Add profile";
            this.rbtnProfilesAdd.ToolTipImage = null;
            this.rbtnProfilesAdd.ToolTipTitle = null;
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
            this.rbtnProfileView.Text = null;
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
            this.rbtnProfileDelete.Text = null;
            this.rbtnProfileDelete.ToolTip = "Delete selected profile";
            this.rbtnProfileDelete.ToolTipImage = null;
            this.rbtnProfileDelete.ToolTipTitle = null;
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
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonButton rbtnProfilesAdd;
        private System.Windows.Forms.RibbonButton rbtnProfileView;
        private System.Windows.Forms.RibbonButton rbtnProfileDelete;
        private System.Windows.Forms.RibbonButton rbtnProfilesLoad;

        public DockPanel Pannello
        {
            get
            {
                return dockPanel;
            }
        }
    }
}
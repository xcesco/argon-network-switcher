namespace Argon.Windows.Forms.Src.Argon.Windows.Controls
{
    partial class ServiceListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceListView));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbForceService = new System.Windows.Forms.ToolStripButton();
            this.tslInfo = new System.Windows.Forms.ToolStripLabel();
            this.listView = new BrightIdeasSoftware.ObjectListView();
            this.colDisplayName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colForcedStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuForceRun = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuForceStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuForceNone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStartService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStopService = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReload,
            this.tsbRefresh,
            this.tsbForceService,
            this.tslInfo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(560, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.Image = global::Argon.Windows.Forms.Properties.Resources.replace2;
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(23, 22);
            this.tsbReload.Text = "Reload";
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::Argon.Windows.Forms.Properties.Resources.refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "Refresh services";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbForceService
            // 
            this.tsbForceService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbForceService.Image = global::Argon.Windows.Forms.Properties.Resources.gears;
            this.tsbForceService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForceService.Name = "tsbForceService";
            this.tsbForceService.Size = new System.Drawing.Size(23, 22);
            this.tsbForceService.Text = "Force services";
            this.tsbForceService.Click += new System.EventHandler(this.tsbForceService_Click);
            // 
            // tslInfo
            // 
            this.tslInfo.Name = "tslInfo";
            this.tslInfo.Size = new System.Drawing.Size(115, 22);
            this.tslInfo.Text = "Selected service(s): 0";
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.colDisplayName);
            this.listView.AllColumns.Add(this.colStatus);
            this.listView.AllColumns.Add(this.colForcedStatus);
            this.listView.AllColumns.Add(this.colDescription);
            this.listView.AllowColumnReorder = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDisplayName,
            this.colStatus,
            this.colForcedStatus,
            this.colDescription});
            this.listView.ContextMenuStrip = this.contextMenuStrip;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 25);
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(560, 281);
            this.listView.SmallImageList = this.imageList16x16;
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectionChanged += new System.EventHandler(this.listView_SelectionChanged);
            // 
            // colDisplayName
            // 
            this.colDisplayName.AspectName = "DisplayName";
            this.colDisplayName.Text = "Name";
            this.colDisplayName.Width = 165;
            // 
            // colStatus
            // 
            this.colStatus.AspectName = "Status";
            this.colStatus.Text = "Status";
            // 
            // colForcedStatus
            // 
            this.colForcedStatus.AspectName = "ForcedStatus";
            this.colForcedStatus.Text = "Forced";
            this.colForcedStatus.Width = 80;
            // 
            // colDescription
            // 
            this.colDescription.AspectName = "Description";
            this.colDescription.Text = "Description";
            this.colDescription.Width = 144;
            // 
            // imageList16x16
            // 
            this.imageList16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16x16.ImageStream")));
            this.imageList16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16x16.Images.SetKeyName(0, "gear_run.png");
            this.imageList16x16.Images.SetKeyName(1, "gear_stop.png");
            this.imageList16x16.Images.SetKeyName(2, "gear_ok.png");
            this.imageList16x16.Images.SetKeyName(3, "gear_forbidden.png");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuForceRun,
            this.mnuForceStop,
            this.mnuForceNone,
            this.toolStripMenuItem1,
            this.mnuStartService,
            this.mnuStopService,
            this.toolStripMenuItem2,
            this.mnuRefresh});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(179, 170);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // mnuForceRun
            // 
            this.mnuForceRun.Image = global::Argon.Windows.Forms.Properties.Resources.gear_ok;
            this.mnuForceRun.Name = "mnuForceRun";
            this.mnuForceRun.Size = new System.Drawing.Size(178, 22);
            this.mnuForceRun.Text = "Force running";
            this.mnuForceRun.Click += new System.EventHandler(this.mnuForceRun_Click);
            // 
            // mnuForceStop
            // 
            this.mnuForceStop.Image = global::Argon.Windows.Forms.Properties.Resources.gear_forbidden;
            this.mnuForceStop.Name = "mnuForceStop";
            this.mnuForceStop.Size = new System.Drawing.Size(178, 22);
            this.mnuForceStop.Text = "Force stopping";
            this.mnuForceStop.Click += new System.EventHandler(this.mnuForceStop_Click);
            // 
            // mnuForceNone
            // 
            this.mnuForceNone.Name = "mnuForceNone";
            this.mnuForceNone.Size = new System.Drawing.Size(178, 22);
            this.mnuForceNone.Text = "Delete forced status";
            this.mnuForceNone.Click += new System.EventHandler(this.mnuForceNone_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // mnuStartService
            // 
            this.mnuStartService.Image = global::Argon.Windows.Forms.Properties.Resources.gear_run;
            this.mnuStartService.Name = "mnuStartService";
            this.mnuStartService.Size = new System.Drawing.Size(178, 22);
            this.mnuStartService.Text = "Start service(s)";
            this.mnuStartService.Click += new System.EventHandler(this.mnuStartService_Click);
            // 
            // mnuStopService
            // 
            this.mnuStopService.Image = global::Argon.Windows.Forms.Properties.Resources.gear_stop;
            this.mnuStopService.Name = "mnuStopService";
            this.mnuStopService.Size = new System.Drawing.Size(178, 22);
            this.mnuStopService.Text = "Stop service(s)";
            this.mnuStopService.Click += new System.EventHandler(this.mnuStopService_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Image = global::Argon.Windows.Forms.Properties.Resources.refresh;
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(178, 22);
            this.mnuRefresh.Text = "Refresh";
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // ServiceListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.toolStrip);
            this.MinimumSize = new System.Drawing.Size(560, 200);
            this.Name = "ServiceListView";
            this.Size = new System.Drawing.Size(560, 306);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private BrightIdeasSoftware.ObjectListView listView;
        private BrightIdeasSoftware.OLVColumn colDisplayName;
        private System.Windows.Forms.ImageList imageList16x16;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private BrightIdeasSoftware.OLVColumn colStatus;
        private BrightIdeasSoftware.OLVColumn colForcedStatus;
        private BrightIdeasSoftware.OLVColumn colDescription;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbForceService;
        private System.Windows.Forms.ToolStripLabel tslInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuForceRun;
        private System.Windows.Forms.ToolStripMenuItem mnuForceStop;
        private System.Windows.Forms.ToolStripMenuItem mnuForceNone;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuStartService;
        private System.Windows.Forms.ToolStripMenuItem mnuStopService;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
    }
}

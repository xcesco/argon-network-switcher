using BrightIdeasSoftware;
namespace Argon.Windows.Forms
{
    partial class FormNetworkCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNetworkCards));
            this.images32x32 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShowInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.images24x24 = new System.Windows.Forms.ImageList(this.components);
            this.listView = new BrightIdeasSoftware.ObjectListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // images32x32
            // 
            this.images32x32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images32x32.ImageStream")));
            this.images32x32.TransparentColor = System.Drawing.Color.Transparent;
            this.images32x32.Images.SetKeyName(0, "PCI-card.png");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowInfo,
            this.mnuEnable,
            this.mnuDisable});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            this.contextMenuStrip.Text = "View";
            // 
            // mnuShowInfo
            // 
            this.mnuShowInfo.Name = "mnuShowInfo";
            this.mnuShowInfo.Size = new System.Drawing.Size(152, 22);
            this.mnuShowInfo.Text = "Show info";
            this.mnuShowInfo.Click += new System.EventHandler(this.mnuShowInfo_Click);
            // 
            // mnuEnable
            // 
            this.mnuEnable.Name = "mnuEnable";
            this.mnuEnable.Size = new System.Drawing.Size(152, 22);
            this.mnuEnable.Text = "Enable";
            this.mnuEnable.Click += new System.EventHandler(this.mnuEnable_Click);
            // 
            // mnuDisable
            // 
            this.mnuDisable.Name = "mnuDisable";
            this.mnuDisable.Size = new System.Drawing.Size(152, 22);
            this.mnuDisable.Text = "Disable";
            this.mnuDisable.Click += new System.EventHandler(this.mnuDisable_Click);
            // 
            // images24x24
            // 
            this.images24x24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images24x24.ImageStream")));
            this.images24x24.TransparentColor = System.Drawing.Color.Transparent;
            this.images24x24.Images.SetKeyName(0, "PCI-card_network.png");
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.colName);
            this.listView.AllColumns.Add(this.colDescription);
            this.listView.AllColumns.Add(this.colStatus);
            this.listView.AllColumns.Add(this.colType);
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription,
            this.colStatus,
            this.colType});
            this.listView.ContextMenuStrip = this.contextMenuStrip;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(778, 468);
            this.listView.SmallImageList = this.images32x32;
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 180;
            // 
            // colDescription
            // 
            this.colDescription.AspectName = "Description";
            this.colDescription.Text = "Description";
            this.colDescription.Width = 260;
            // 
            // colStatus
            // 
            this.colStatus.AspectName = "Status";
            this.colStatus.Text = "Status";
            this.colStatus.Width = 120;
            // 
            // colType
            // 
            this.colType.AspectName = "CardType";
            this.colType.Text = "Type";
            this.colType.Width = 80;
            // 
            // FormNetworkCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 468);
            this.Controls.Add(this.listView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNetworkCards";
            this.TabText = "Network Adapters ";
            this.Text = "Network Adapters ";
            this.Load += new System.EventHandler(this.FormAdapters_Load);
            this.VisibleChanged += new System.EventHandler(this.FormAdapters_VisibleChanged);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList images32x32;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuShowInfo;
        private System.Windows.Forms.ImageList images24x24;
        private OLVColumn colName;
        private OLVColumn colDescription;
        public ObjectListView listView;
        private System.Windows.Forms.ToolStripMenuItem mnuEnable;
        private System.Windows.Forms.ToolStripMenuItem mnuDisable;
        private OLVColumn colStatus;
        private OLVColumn colType;
    }
}
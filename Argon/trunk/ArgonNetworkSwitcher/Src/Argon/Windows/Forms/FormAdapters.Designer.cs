using BrightIdeasSoftware;
namespace Argon.Windows.Forms
{
    partial class FormAdapters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdapters));
            this.images48x48 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.images24x24 = new System.Windows.Forms.ImageList(this.components);
            this.listView = new ObjectListView();
            this.colName = new OLVColumn();
            this.colDescription = new OLVColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // images48x48
            // 
            this.images48x48.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images48x48.ImageStream")));
            this.images48x48.TransparentColor = System.Drawing.Color.Transparent;
            this.images48x48.Images.SetKeyName(0, "PCI-card_network.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 26);
            this.contextMenuStrip1.Text = "View";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem1.Text = "Show info";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.actionDisplayCardInfo_Click);
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
            this.listView.AlternateRowBackColor = System.Drawing.Color.Empty;
            this.listView.AlwaysGroupByColumn = null;
            this.listView.AlwaysGroupBySortOrder = System.Windows.Forms.SortOrder.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription});
            this.listView.ContextMenuStrip = this.contextMenuStrip1;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.listView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.listView.LastSortColumn = null;
            this.listView.LastSortOrder = System.Windows.Forms.SortOrder.None;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(778, 468);
            this.listView.SmallImageList = this.images24x24;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 280;
            // 
            // colDescription
            // 
            this.colDescription.AspectName = "Description";
            this.colDescription.Text = "Description";
            this.colDescription.Width = 460;
            // 
            // FormAdapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 468);
            this.Controls.Add(this.listView);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdapters";
            this.TabText = "Network Adapters";
            this.Text = "Network Adapters";
            this.Load += new System.EventHandler(this.FormAdapters_Load);
            this.Activated += new System.EventHandler(this.FormAdapters_Activated);
            this.VisibleChanged += new System.EventHandler(this.FormAdapters_VisibleChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList images48x48;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ImageList images24x24;
        private OLVColumn colName;
        private OLVColumn colDescription;
        public ObjectListView listView;
    }
}
using BrightIdeasSoftware;
namespace Argon.Windows.Forms
{
    partial class FormProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfiles));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.listView = new BrightIdeasSoftware.ObjectListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colNetwork = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApply = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDuplicateProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList48x48 = new System.Windows.Forms.ImageList(this.components);
            this.imageList24x24 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(521, 243);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(521, 268);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.colName);
            this.listView.AllColumns.Add(this.colNetwork);
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colNetwork});
            this.listView.ContextMenuStrip = this.contextMenu;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.LargeImageList = this.imageList48x48;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(521, 243);
            this.listView.SmallImageList = this.imageList48x48;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.ImageAspectName = "";
            this.colName.Text = "Name";
            this.colName.Width = 160;
            // 
            // colNetwork
            // 
            this.colNetwork.AspectName = "NetworkCardInfo.Name";
            this.colNetwork.Text = "Network interface card selected";
            this.colNetwork.Width = 260;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.toolStripMenuItem1,
            this.mnuOpen,
            this.mnuApply,
            this.toolStripSeparator1,
            this.mnuDuplicateProfile,
            this.toolStripMenuItem2,
            this.mnuDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(162, 154);
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(161, 22);
            this.mnuNew.Text = "New profile";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(161, 22);
            this.mnuOpen.Text = "Open profile";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuApply
            // 
            this.mnuApply.Name = "mnuApply";
            this.mnuApply.Size = new System.Drawing.Size(161, 22);
            this.mnuApply.Text = "Run profile";
            this.mnuApply.Click += new System.EventHandler(this.mnuRun_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuDuplicateProfile
            // 
            this.mnuDuplicateProfile.Name = "mnuDuplicateProfile";
            this.mnuDuplicateProfile.Size = new System.Drawing.Size(161, 22);
            this.mnuDuplicateProfile.Text = "Duplicate profile";
            this.mnuDuplicateProfile.Click += new System.EventHandler(this.mnuDuplicateProfile_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(161, 22);
            this.mnuDelete.Text = "Remove profile";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // imageList48x48
            // 
            this.imageList48x48.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList48x48.ImageSize = new System.Drawing.Size(48, 46);
            this.imageList48x48.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList24x24
            // 
            this.imageList24x24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList24x24.ImageStream")));
            this.imageList24x24.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList24x24.Images.SetKeyName(0, "index.png");
            this.imageList24x24.Images.SetKeyName(1, "package.png");
            this.imageList24x24.Images.SetKeyName(2, "save_as.png");
            // 
            // FormProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 268);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfiles";
            this.TabText = "Profiles ";
            this.Text = "Profiles ";
            this.Load += new System.EventHandler(this.FormProfiles_Load);
            this.VisibleChanged += new System.EventHandler(this.FormProfiles_VisibleChanged);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ImageList imageList24x24;
        private OLVColumn colNetwork;
        public ObjectListView listView;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuApply;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDuplicateProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ImageList imageList48x48;
        public OLVColumn colName;
    }
}
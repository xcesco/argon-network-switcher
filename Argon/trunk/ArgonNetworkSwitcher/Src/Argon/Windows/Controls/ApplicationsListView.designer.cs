using BrightIdeasSoftware;
namespace Argon.Windows.Controls
{
    partial class ApplicationsListView
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDelete = new System.Windows.Forms.ToolStripButton();
            this.mnuSelect = new System.Windows.Forms.ToolStripButton();
           // this.gradientPanel1 = new Ascend.Windows.Forms.GradientPanel();
            this.cbKill = new System.Windows.Forms.CheckBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbWaitForExit = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.listView = new ObjectListView();
            this.colName = new OLVColumn();
            this.colDescription = new OLVColumn();
            this.colFile = new OLVColumn();
            this.colArguments = new OLVColumn();
            this.colDirectory = new OLVColumn();
            this.colWaitForExit = new OLVColumn();
            this.colKill = new OLVColumn();
            this.toolStrip1.SuspendLayout();
           // this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "exe";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "executable (*.exe)|*.exe|batch file (*.cmd;*.bat)|*.cmd;*.bat|All files (*.*)|*.*" +
                "";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Select an application";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.toolStripSeparator1,
            this.mnuSave,
            this.toolStripSeparator2,
            this.mnuDelete,
            this.mnuSelect});
            this.toolStrip1.Location = new System.Drawing.Point(3, 103);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(116, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuNew
            // 
            this.mnuNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuNew.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_add;
            this.mnuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(23, 22);
            this.mnuNew.Text = "Add";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuSave
            // 
            this.mnuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuSave.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_check;
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(23, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuDelete
            // 
            this.mnuDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuDelete.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_delete;
            this.mnuDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(23, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuSelect
            // 
            this.mnuSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuSelect.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_select;
            this.mnuSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(23, 22);
            this.mnuSelect.Text = "Select a running process";
            this.mnuSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gradientPanel1
            //           
            // 
            // cbKill
            // 
            this.cbKill.AutoSize = true;
            this.cbKill.Location = new System.Drawing.Point(126, 146);
            this.cbKill.Name = "cbKill";
            this.cbKill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbKill.Size = new System.Drawing.Size(79, 17);
            this.cbKill.TabIndex = 23;
            this.cbKill.Text = "Kill process";
            this.cbKill.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_select;
            this.btnSelect.Location = new System.Drawing.Point(254, 196);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbWaitForExit
            // 
            this.cbWaitForExit.AutoSize = true;
            this.cbWaitForExit.Location = new System.Drawing.Point(11, 146);
            this.cbWaitForExit.Name = "cbWaitForExit";
            this.cbWaitForExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbWaitForExit.Size = new System.Drawing.Size(90, 17);
            this.cbWaitForExit.TabIndex = 21;
            this.cbWaitForExit.Text = "Wait for finish";
            this.cbWaitForExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_delete;
            this.btnDelete.Location = new System.Drawing.Point(173, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_check;
            this.btnSave.Location = new System.Drawing.Point(92, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_add;
            this.btnNew.Location = new System.Drawing.Point(11, 196);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Arguments";
            // 
            // txtArguments
            // 
            this.txtArguments.Location = new System.Drawing.Point(75, 120);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(472, 20);
            this.txtArguments.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 44);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(352, 20);
            this.txtDescription.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Application";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(75, 94);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(415, 20);
            this.txtDirectory.TabIndex = 10;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(75, 68);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(352, 20);
            this.txtFile.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(352, 20);
            this.txtName.TabIndex = 8;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(498, 92);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(49, 23);
            this.btnBrowser.TabIndex = 7;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.colName);
            this.listView.AllColumns.Add(this.colDescription);
            this.listView.AllColumns.Add(this.colFile);
            this.listView.AllColumns.Add(this.colArguments);
            this.listView.AllColumns.Add(this.colDirectory);
            this.listView.AllColumns.Add(this.colWaitForExit);
            this.listView.AllColumns.Add(this.colKill);
            this.listView.AllowColumnReorder = true;
            this.listView.AlternateRowBackColor = System.Drawing.Color.Empty;
            this.listView.AlwaysGroupByColumn = null;
            this.listView.AlwaysGroupBySortOrder = System.Windows.Forms.SortOrder.None;
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription,
            this.colFile,
            this.colArguments,
            this.colDirectory,
            this.colWaitForExit,
            this.colKill});
            this.listView.FullRowSelect = true;
            this.listView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.listView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.listView.LastSortColumn = null;
            this.listView.LastSortOrder = System.Windows.Forms.SortOrder.None;
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(589, 99);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectionChanged += new System.EventHandler(this.listView_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.AspectName = null;
            this.colDescription.Text = "Description";
            this.colDescription.Width = 80;
            // 
            // colFile
            // 
            this.colFile.AspectName = "File";
            this.colFile.Text = "File";
            this.colFile.Width = 100;
            // 
            // colArguments
            // 
            this.colArguments.AspectName = "Arguments";
            this.colArguments.Text = "Args";
            this.colArguments.Width = 80;
            // 
            // colDirectory
            // 
            this.colDirectory.AspectName = "Directory";
            this.colDirectory.Text = "Directory";
            this.colDirectory.Width = 160;
            // 
            // colWaitForExit
            // 
            this.colWaitForExit.AspectName = "WaitForExit";
            this.colWaitForExit.Text = "Wait";
            // 
            // colKill
            // 
            this.colKill.AspectName = "Kill";
            this.colKill.Text = "Kill";
            // 
            // ApplicationsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView);
            this.MinimumSize = new System.Drawing.Size(560, 312);
            this.Name = "ApplicationsListView";
            this.Size = new System.Drawing.Size(595, 364);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
           // this.gradientPanel1.ResumeLayout(false);
           // this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private ObjectListView listView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuNew;
        //private Ascend.Windows.Forms.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.ToolStripButton mnuSave;
        private System.Windows.Forms.ToolStripButton mnuDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckBox cbWaitForExit;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ToolStripButton mnuSelect;
        private System.Windows.Forms.CheckBox cbKill;
        private OLVColumn colKill;
        private OLVColumn colName;
        private OLVColumn colDirectory;
        private OLVColumn colDescription;
        private OLVColumn colFile;
        private OLVColumn colArguments;
        private OLVColumn colWaitForExit;
    }
}

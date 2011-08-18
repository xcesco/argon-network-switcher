using BrightIdeasSoftware;
namespace Argon.Windows.Controls
{
    partial class DriveMapListView
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
            this.gradientPanel1 = new Ascend.Windows.Forms.GradientPanel();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUnmount = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnMount = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbDrive = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRealPath = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMount = new System.Windows.Forms.ToolStripButton();
            this.mnuTest = new System.Windows.Forms.ToolStripButton();
            this.mnuUnmount = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listView = new ObjectListView();
            this.colName = new OLVColumn();
            this.colDescription = new OLVColumn();
            this.colDrive = new OLVColumn();
            this.colRealPath = new OLVColumn();
            this.colUsername = new OLVColumn();
            this.colPassword = new OLVColumn();
            this.colOperation = new OLVColumn();
//            this.gradientPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.Controls.Add(this.cbOperation);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.btnNew);
            this.gradientPanel1.Controls.Add(this.btnUnmount);
            this.gradientPanel1.Controls.Add(this.btnTest);
            this.gradientPanel1.Controls.Add(this.btnMount);
            this.gradientPanel1.Controls.Add(this.btnDelete);
            this.gradientPanel1.Controls.Add(this.btnSave);
            this.gradientPanel1.Controls.Add(this.cbDrive);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.txtPassword);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.txtUsername);
            this.gradientPanel1.Controls.Add(this.txtDescription);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.txtRealPath);
            this.gradientPanel1.Controls.Add(this.txtName);
            this.gradientPanel1.Location = new System.Drawing.Point(3, 147);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(643, 160);
            this.gradientPanel1.TabIndex = 19;
            // 
            // cbOperation
            // 
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "Mount",
            "Unmount"});
            this.cbOperation.Location = new System.Drawing.Point(508, 97);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(119, 21);
            this.cbOperation.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Operation";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_add;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(13, 130);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "Add";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // btnUnmount
            // 
            this.btnUnmount.Image = global::Argon.Windows.Forms.Properties.Resources.server_delete;
            this.btnUnmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnmount.Location = new System.Drawing.Point(418, 130);
            this.btnUnmount.Name = "btnUnmount";
            this.btnUnmount.Size = new System.Drawing.Size(75, 23);
            this.btnUnmount.TabIndex = 26;
            this.btnUnmount.Text = "Unmount";
            this.btnUnmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnmount.UseVisualStyleBackColor = true;
            this.btnUnmount.Click += new System.EventHandler(this.mnu_Destroy);
            // 
            // btnTest
            // 
            this.btnTest.Image = global::Argon.Windows.Forms.Properties.Resources.server_unknown;
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(337, 130);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 25;
            this.btnTest.Text = "Test";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.mnu_Test);
            // 
            // btnMount
            // 
            this.btnMount.Image = global::Argon.Windows.Forms.Properties.Resources.server_client;
            this.btnMount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMount.Location = new System.Drawing.Point(256, 130);
            this.btnMount.Name = "btnMount";
            this.btnMount.Size = new System.Drawing.Size(75, 23);
            this.btnMount.TabIndex = 24;
            this.btnMount.Text = "Mount";
            this.btnMount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMount.UseVisualStyleBackColor = true;
            this.btnMount.Click += new System.EventHandler(this.mnu_Create);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(175, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Argon.Windows.Forms.Properties.Resources.table_sql_check;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(94, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // cbDrive
            // 
            this.cbDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrive.FormattingEnabled = true;
            this.cbDrive.Items.AddRange(new object[] {
            "",
            "A:",
            "B:",
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "J:",
            "K:",
            "I:",
            "L:",
            "M:",
            "N:",
            "O:",
            "P:",
            "Q:",
            "R:",
            "S:",
            "T:",
            "U:",
            "V:",
            "W:",
            "Y:",
            "Z:"});
            this.cbDrive.Location = new System.Drawing.Point(75, 71);
            this.cbDrive.Name = "cbDrive";
            this.cbDrive.Size = new System.Drawing.Size(50, 21);
            this.cbDrive.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(312, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 18;
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
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(75, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 20);
            this.txtUsername.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 44);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(552, 20);
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
            this.label2.Location = new System.Drawing.Point(143, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Real path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Drive";
            // 
            // txtRealPath
            // 
            this.txtRealPath.Location = new System.Drawing.Point(202, 71);
            this.txtRealPath.Name = "txtRealPath";
            this.txtRealPath.Size = new System.Drawing.Size(425, 20);
            this.txtRealPath.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(552, 20);
            this.txtName.TabIndex = 8;
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
            this.toolStripSeparator3,
            this.mnuMount,
            this.mnuTest,
            this.mnuUnmount});
            this.toolStrip1.Location = new System.Drawing.Point(3, 122);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(168, 25);
            this.toolStrip1.TabIndex = 18;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuMount
            // 
            this.mnuMount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuMount.Image = global::Argon.Windows.Forms.Properties.Resources.server_client;
            this.mnuMount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMount.Name = "mnuMount";
            this.mnuMount.Size = new System.Drawing.Size(23, 22);
            this.mnuMount.Text = "Mount";
            this.mnuMount.Click += new System.EventHandler(this.mnu_Create);
            // 
            // mnuTest
            // 
            this.mnuTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuTest.Image = global::Argon.Windows.Forms.Properties.Resources.server_unknown;
            this.mnuTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuTest.Name = "mnuTest";
            this.mnuTest.Size = new System.Drawing.Size(23, 22);
            this.mnuTest.Text = "Test";
            this.mnuTest.Click += new System.EventHandler(this.mnu_Test);
            // 
            // mnuUnmount
            // 
            this.mnuUnmount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuUnmount.Image = global::Argon.Windows.Forms.Properties.Resources.server_delete;
            this.mnuUnmount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuUnmount.Name = "mnuUnmount";
            this.mnuUnmount.Size = new System.Drawing.Size(23, 22);
            this.mnuUnmount.Text = "Unmount disk";
            this.mnuUnmount.Click += new System.EventHandler(this.mnu_Destroy);
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
            // listView
            // 
            this.listView.AllColumns.Add(this.colName);
            this.listView.AllColumns.Add(this.colDescription);
            this.listView.AllColumns.Add(this.colDrive);
            this.listView.AllColumns.Add(this.colRealPath);
            this.listView.AllColumns.Add(this.colUsername);
            this.listView.AllColumns.Add(this.colPassword);
            this.listView.AllColumns.Add(this.colOperation);
            this.listView.AlternateRowBackColor = System.Drawing.Color.Empty;
            this.listView.AlwaysGroupByColumn = null;
            this.listView.AlwaysGroupBySortOrder = System.Windows.Forms.SortOrder.None;
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription,
            this.colDrive,
            this.colRealPath,
            this.colUsername,
            this.colPassword,
            this.colOperation});
            this.listView.FullRowSelect = true;
            this.listView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.listView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.listView.LastSortColumn = null;
            this.listView.LastSortOrder = System.Windows.Forms.SortOrder.None;
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(642, 116);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 20;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectionChanged += new System.EventHandler(this.listView_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 76;
            // 
            // colDescription
            // 
            this.colDescription.AspectName = "Description";
            this.colDescription.Text = "Description";
            this.colDescription.Width = 86;
            // 
            // colDrive
            // 
            this.colDrive.AspectName = "Drive";
            this.colDrive.Text = "Letter";
            // 
            // colRealPath
            // 
            this.colRealPath.AspectName = "RealPath";
            this.colRealPath.Text = "Path";
            this.colRealPath.Width = 207;
            // 
            // colUsername
            // 
            this.colUsername.AspectName = "Username";
            this.colUsername.Text = "Username";
            // 
            // colPassword
            // 
            this.colPassword.AspectName = "Password";
            this.colPassword.Text = "Password";
            // 
            // colOperation
            // 
            this.colOperation.AspectName = "Type";
            this.colOperation.Text = "Operation";
            this.colOperation.Width = 80;
            // 
            // DriveMapListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(560, 312);
            this.Name = "DriveMapListView";
            this.Size = new System.Drawing.Size(649, 312);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ascend.Windows.Forms.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRealPath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnuDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbDrive;
        private System.Windows.Forms.ToolStripButton mnuMount;
        private System.Windows.Forms.ToolStripButton mnuUnmount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mnuTest;
        private ObjectListView listView;
        private OLVColumn colName;
        private OLVColumn colDescription;
        private OLVColumn colDrive;
        private OLVColumn colRealPath;
        private OLVColumn colUsername;
        private OLVColumn colPassword;
        private System.Windows.Forms.Button btnUnmount;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnMount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Label label7;
        private OLVColumn colOperation;
    }
}

using Argon.Windows;
using Argon.Network;


namespace Argon.Windows.Forms
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.imageList48x48 = new System.Windows.Forms.ImageList(this.components);
            this.imageList24x24 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lstNetworkCard = new System.Windows.Forms.ComboBox();
            this.lblSelectedCard = new System.Windows.Forms.Label();
            this.txtSelectedCard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp1NIC = new System.Windows.Forms.TabPage();
            this.ipControl = new Argon.Windows.Controls.IpControl();
            this.tp2Proxy = new System.Windows.Forms.TabPage();
            this.proxyPanel = new Argon.Windows.Controls.ProxyControl();
            this.tpDriveMap = new System.Windows.Forms.TabPage();
            this.driveMapListView = new Argon.Windows.Controls.DriveMapListView();
            this.tp3Printers = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemovePrinter = new System.Windows.Forms.Button();
            this.lblPrinter2 = new System.Windows.Forms.Label();
            this.btnSelectPrinter = new System.Windows.Forms.Button();
            this.cbPrinterList = new System.Windows.Forms.ComboBox();
            this.tp5Services = new System.Windows.Forms.TabPage();
            this.serviceListView = new Argon.Windows.Controls.ServiceListView();
            this.tp6Applications = new System.Windows.Forms.TabPage();
            this.applicationsListView = new Argon.Windows.Controls.ApplicationsListView();
            this.lblSelectedPrinter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tp1NIC.SuspendLayout();
            this.tp2Proxy.SuspendLayout();
            this.tpDriveMap.SuspendLayout();
            this.tp3Printers.SuspendLayout();
            this.tp5Services.SuspendLayout();
            this.tp6Applications.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList48x48
            // 
            this.imageList48x48.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList48x48.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList48x48.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList24x24
            // 
            this.imageList24x24.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList24x24.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList24x24.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Network Card";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(10, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(414, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::Argon.Windows.Forms.Properties.Resources.arrow_down_green;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(394, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(83, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(24, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(48, 48);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // lstNetworkCard
            // 
            this.lstNetworkCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNetworkCard.FormattingEnabled = true;
            this.lstNetworkCard.Location = new System.Drawing.Point(175, 6);
            this.lstNetworkCard.Name = "lstNetworkCard";
            this.lstNetworkCard.Size = new System.Drawing.Size(213, 21);
            this.lstNetworkCard.TabIndex = 18;
            // 
            // lblSelectedCard
            // 
            this.lblSelectedCard.AutoSize = true;
            this.lblSelectedCard.Location = new System.Drawing.Point(89, 34);
            this.lblSelectedCard.Name = "lblSelectedCard";
            this.lblSelectedCard.Size = new System.Drawing.Size(74, 13);
            this.lblSelectedCard.TabIndex = 19;
            this.lblSelectedCard.Text = "Selected Card";
            // 
            // txtSelectedCard
            // 
            this.txtSelectedCard.AutoSize = true;
            this.txtSelectedCard.Location = new System.Drawing.Point(172, 34);
            this.txtSelectedCard.Name = "txtSelectedCard";
            this.txtSelectedCard.Size = new System.Drawing.Size(63, 13);
            this.txtSelectedCard.TabIndex = 20;
            this.txtSelectedCard.Text = "[NO NAME]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Selected Card";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tp1NIC);
            this.tabControl.Controls.Add(this.tp2Proxy);
            this.tabControl.Controls.Add(this.tpDriveMap);
            this.tabControl.Controls.Add(this.tp3Printers);
            this.tabControl.Controls.Add(this.tp5Services);
            this.tabControl.Controls.Add(this.tp6Applications);
            this.tabControl.Location = new System.Drawing.Point(3, 76);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1177, 524);
            this.tabControl.TabIndex = 22;
            // 
            // tp1NIC
            // 
            this.tp1NIC.Controls.Add(this.ipControl);
            this.tp1NIC.Location = new System.Drawing.Point(4, 22);
            this.tp1NIC.Name = "tp1NIC";
            this.tp1NIC.Padding = new System.Windows.Forms.Padding(3);
            this.tp1NIC.Size = new System.Drawing.Size(1169, 498);
            this.tp1NIC.TabIndex = 0;
            this.tp1NIC.Text = "Network";
            this.tp1NIC.UseVisualStyleBackColor = true;
            // 
            // ipControl
            // 
            this.ipControl.BackColor = System.Drawing.Color.Transparent;
            this.ipControl.Configuration = null;
            this.ipControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipControl.Location = new System.Drawing.Point(3, 3);
            this.ipControl.MinimumSize = new System.Drawing.Size(584, 240);
            this.ipControl.Name = "ipControl";
            this.ipControl.Size = new System.Drawing.Size(1163, 492);
            this.ipControl.TabIndex = 2;
            // 
            // tp2Proxy
            // 
            this.tp2Proxy.Controls.Add(this.proxyPanel);
            this.tp2Proxy.Location = new System.Drawing.Point(4, 22);
            this.tp2Proxy.Name = "tp2Proxy";
            this.tp2Proxy.Padding = new System.Windows.Forms.Padding(3);
            this.tp2Proxy.Size = new System.Drawing.Size(1169, 498);
            this.tp2Proxy.TabIndex = 1;
            this.tp2Proxy.Text = "Proxy";
            this.tp2Proxy.UseVisualStyleBackColor = true;
            // 
            // proxyPanel
            // 
            this.proxyPanel.BackColor = System.Drawing.Color.Transparent;
            this.proxyPanel.Configuration = null;
            this.proxyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyPanel.Location = new System.Drawing.Point(3, 3);
            this.proxyPanel.MinimumSize = new System.Drawing.Size(384, 148);
            this.proxyPanel.Name = "proxyPanel";
            this.proxyPanel.Size = new System.Drawing.Size(1163, 492);
            this.proxyPanel.TabIndex = 2;
            // 
            // tpDriveMap
            // 
            this.tpDriveMap.Controls.Add(this.driveMapListView);
            this.tpDriveMap.Location = new System.Drawing.Point(4, 22);
            this.tpDriveMap.Name = "tpDriveMap";
            this.tpDriveMap.Size = new System.Drawing.Size(1169, 498);
            this.tpDriveMap.TabIndex = 2;
            this.tpDriveMap.Text = "Drive Map";
            this.tpDriveMap.UseVisualStyleBackColor = true;
            // 
            // driveMapListView
            // 
            this.driveMapListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveMapListView.Location = new System.Drawing.Point(0, 0);
            this.driveMapListView.MinimumSize = new System.Drawing.Size(560, 312);
            this.driveMapListView.Name = "driveMapListView";
            this.driveMapListView.Size = new System.Drawing.Size(1169, 498);
            this.driveMapListView.TabIndex = 1;
            // 
            // tp3Printers
            // 
            this.tp3Printers.Controls.Add(this.lblSelectedPrinter);
            this.tp3Printers.Controls.Add(this.label5);
            this.tp3Printers.Controls.Add(this.btnRemovePrinter);
            this.tp3Printers.Controls.Add(this.lblPrinter2);
            this.tp3Printers.Controls.Add(this.btnSelectPrinter);
            this.tp3Printers.Controls.Add(this.cbPrinterList);
            this.tp3Printers.Location = new System.Drawing.Point(4, 22);
            this.tp3Printers.Name = "tp3Printers";
            this.tp3Printers.Size = new System.Drawing.Size(1169, 498);
            this.tp3Printers.TabIndex = 5;
            this.tp3Printers.Text = "Printers";
            this.tp3Printers.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Select the default printer";
            // 
            // btnRemovePrinter
            // 
            this.btnRemovePrinter.Image = global::Argon.Windows.Forms.Properties.Resources.delete2;
            this.btnRemovePrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovePrinter.Location = new System.Drawing.Point(501, 45);
            this.btnRemovePrinter.Name = "btnRemovePrinter";
            this.btnRemovePrinter.Size = new System.Drawing.Size(83, 23);
            this.btnRemovePrinter.TabIndex = 25;
            this.btnRemovePrinter.Text = "Remove";
            this.btnRemovePrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovePrinter.UseVisualStyleBackColor = true;
            this.btnRemovePrinter.Click += new System.EventHandler(this.btnRemovePrinter_Click);
            // 
            // lblPrinter2
            // 
            this.lblPrinter2.AutoSize = true;
            this.lblPrinter2.Location = new System.Drawing.Point(12, 50);
            this.lblPrinter2.Name = "lblPrinter2";
            this.lblPrinter2.Size = new System.Drawing.Size(82, 13);
            this.lblPrinter2.TabIndex = 24;
            this.lblPrinter2.Text = "Selected Printer";
            // 
            // btnSelectPrinter
            // 
            this.btnSelectPrinter.Image = global::Argon.Windows.Forms.Properties.Resources.arrow_down_green;
            this.btnSelectPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPrinter.Location = new System.Drawing.Point(501, 12);
            this.btnSelectPrinter.Name = "btnSelectPrinter";
            this.btnSelectPrinter.Size = new System.Drawing.Size(83, 23);
            this.btnSelectPrinter.TabIndex = 23;
            this.btnSelectPrinter.Text = "Select";
            this.btnSelectPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectPrinter.UseVisualStyleBackColor = true;
            this.btnSelectPrinter.Click += new System.EventHandler(this.btnSelectPrinter_Click);
            // 
            // cbPrinterList
            // 
            this.cbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinterList.FormattingEnabled = true;
            this.cbPrinterList.Location = new System.Drawing.Point(170, 14);
            this.cbPrinterList.Name = "cbPrinterList";
            this.cbPrinterList.Size = new System.Drawing.Size(325, 21);
            this.cbPrinterList.TabIndex = 22;
            // 
            // tp5Services
            // 
            this.tp5Services.Controls.Add(this.serviceListView);
            this.tp5Services.Location = new System.Drawing.Point(4, 22);
            this.tp5Services.Name = "tp5Services";
            this.tp5Services.Size = new System.Drawing.Size(1169, 498);
            this.tp5Services.TabIndex = 3;
            this.tp5Services.Text = "Services";
            this.tp5Services.UseVisualStyleBackColor = true;
            // 
            // serviceListView
            // 
            this.serviceListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceListView.Location = new System.Drawing.Point(0, 0);
            this.serviceListView.MinimumSize = new System.Drawing.Size(560, 200);
            this.serviceListView.Name = "serviceListView";
            this.serviceListView.Size = new System.Drawing.Size(1169, 498);
            this.serviceListView.TabIndex = 2;
            // 
            // tp6Applications
            // 
            this.tp6Applications.Controls.Add(this.applicationsListView);
            this.tp6Applications.Location = new System.Drawing.Point(4, 22);
            this.tp6Applications.Name = "tp6Applications";
            this.tp6Applications.Size = new System.Drawing.Size(1169, 498);
            this.tp6Applications.TabIndex = 4;
            this.tp6Applications.Text = "Appplications";
            this.tp6Applications.UseVisualStyleBackColor = true;
            // 
            // applicationsListView
            // 
            this.applicationsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsListView.Location = new System.Drawing.Point(0, 0);
            this.applicationsListView.MinimumSize = new System.Drawing.Size(560, 312);
            this.applicationsListView.Name = "applicationsListView";
            this.applicationsListView.Size = new System.Drawing.Size(1169, 498);
            this.applicationsListView.TabIndex = 2;
            // 
            // lblSelectedPrinter
            // 
            this.lblSelectedPrinter.AutoSize = true;
            this.lblSelectedPrinter.Location = new System.Drawing.Point(167, 50);
            this.lblSelectedPrinter.Name = "lblSelectedPrinter";
            this.lblSelectedPrinter.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPrinter.TabIndex = 27;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 612);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelectedCard);
            this.Controls.Add(this.lblSelectedCard);
            this.Controls.Add(this.lstNetworkCard);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProfile";
            this.TabText = "Profile";
            this.Text = "Profile";
            this.Activated += new System.EventHandler(this.FormProfile_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfile_FormClosed);
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tp1NIC.ResumeLayout(false);
            this.tp2Proxy.ResumeLayout(false);
            this.tpDriveMap.ResumeLayout(false);
            this.tp3Printers.ResumeLayout(false);
            this.tp3Printers.PerformLayout();
            this.tp5Services.ResumeLayout(false);
            this.tp6Applications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList48x48;
        private System.Windows.Forms.ImageList imageList24x24;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label label8;       
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox lstNetworkCard;
        private System.Windows.Forms.Label lblSelectedCard;
        private System.Windows.Forms.Label txtSelectedCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tp1NIC;
        private Controls.IpControl ipControl;
        private System.Windows.Forms.TabPage tp2Proxy;
        private Controls.ProxyControl proxyPanel;
        private System.Windows.Forms.TabPage tpDriveMap;
        private Controls.DriveMapListView driveMapListView;
        private System.Windows.Forms.TabPage tp3Printers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemovePrinter;
        private System.Windows.Forms.Label lblPrinter2;
        private System.Windows.Forms.Button btnSelectPrinter;
        private System.Windows.Forms.ComboBox cbPrinterList;
        private System.Windows.Forms.TabPage tp5Services;
        private Controls.ServiceListView serviceListView;
        private System.Windows.Forms.TabPage tp6Applications;
        private Controls.ApplicationsListView applicationsListView;
        private System.Windows.Forms.Label lblSelectedPrinter;
    }
}
namespace Argon.Windows.Controls
{
    partial class IpControl
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbDynamicDNS = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDHCPEnabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlternativeDNS = new IpTextBox();
            this.txtPrimaryDNS = new IpTextBox();
            this.txtDefaultGateway = new IpTextBox();
            this.txtSubnetMask = new IpTextBox();
            this.txtIP = new IpTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMacAddress = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbDynamicDNS);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtAlternativeDNS);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtPrimaryDNS);
            this.groupBox4.Location = new System.Drawing.Point(288, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 166);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DNS Configuration";
            // 
            // cbDynamicDNS
            // 
            this.cbDynamicDNS.AutoSize = true;
            this.cbDynamicDNS.Location = new System.Drawing.Point(15, 26);
            this.cbDynamicDNS.Name = "cbDynamicDNS";
            this.cbDynamicDNS.Size = new System.Drawing.Size(119, 17);
            this.cbDynamicDNS.TabIndex = 20;
            this.cbDynamicDNS.Text = "Use DHCP for DNS";
            this.cbDynamicDNS.UseVisualStyleBackColor = true;
            this.cbDynamicDNS.CheckedChanged += new System.EventHandler(this.cbDynamicDNS_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Primary DNS Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alternative DNS Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDHCPEnabled);
            this.groupBox2.Controls.Add(this.txtDefaultGateway);
            this.groupBox2.Controls.Add(this.txtSubnetMask);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 166);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP Configuration";
            // 
            // cbDHCPEnabled
            // 
            this.cbDHCPEnabled.AutoSize = true;
            this.cbDHCPEnabled.Location = new System.Drawing.Point(19, 26);
            this.cbDHCPEnabled.Name = "cbDHCPEnabled";
            this.cbDHCPEnabled.Size = new System.Drawing.Size(92, 17);
            this.cbDHCPEnabled.TabIndex = 14;
            this.cbDHCPEnabled.Text = "Enable DHCP";
            this.cbDHCPEnabled.UseVisualStyleBackColor = true;
            this.cbDHCPEnabled.CheckedChanged += new System.EventHandler(this.cbDHCPEnabled_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Default gateway";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subnet mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP";
            // 
            // txtAlternativeDNS
            // 
            this.txtAlternativeDNS.BackColor = System.Drawing.Color.Transparent;
            this.txtAlternativeDNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAlternativeDNS.IpAddress = "0.0.0.0";
            this.txtAlternativeDNS.Location = new System.Drawing.Point(135, 79);
            this.txtAlternativeDNS.MinimumSize = new System.Drawing.Size(128, 20);
            this.txtAlternativeDNS.Name = "txtAlternativeDNS";
            this.txtAlternativeDNS.RangeAValue = 0;
            this.txtAlternativeDNS.RangeBValue = 0;
            this.txtAlternativeDNS.RangeCValue = 0;
            this.txtAlternativeDNS.RangeDValue = 0;
            this.txtAlternativeDNS.Size = new System.Drawing.Size(128, 20);
            this.txtAlternativeDNS.TabIndex = 19;
            // 
            // txtPrimaryDNS
            // 
            this.txtPrimaryDNS.BackColor = System.Drawing.Color.Transparent;
            this.txtPrimaryDNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPrimaryDNS.IpAddress = "0.0.0.0";
            this.txtPrimaryDNS.Location = new System.Drawing.Point(135, 53);
            this.txtPrimaryDNS.MinimumSize = new System.Drawing.Size(128, 20);
            this.txtPrimaryDNS.Name = "txtPrimaryDNS";
            this.txtPrimaryDNS.RangeAValue = 0;
            this.txtPrimaryDNS.RangeBValue = 0;
            this.txtPrimaryDNS.RangeCValue = 0;
            this.txtPrimaryDNS.RangeDValue = 0;
            this.txtPrimaryDNS.Size = new System.Drawing.Size(128, 20);
            this.txtPrimaryDNS.TabIndex = 18;
            // 
            // txtDefaultGateway
            // 
            this.txtDefaultGateway.BackColor = System.Drawing.Color.Transparent;
            this.txtDefaultGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDefaultGateway.IpAddress = "0.0.0.0";
            this.txtDefaultGateway.Location = new System.Drawing.Point(126, 105);
            this.txtDefaultGateway.MinimumSize = new System.Drawing.Size(128, 20);
            this.txtDefaultGateway.Name = "txtDefaultGateway";
            this.txtDefaultGateway.RangeAValue = 0;
            this.txtDefaultGateway.RangeBValue = 0;
            this.txtDefaultGateway.RangeCValue = 0;
            this.txtDefaultGateway.RangeDValue = 0;
            this.txtDefaultGateway.Size = new System.Drawing.Size(128, 20);
            this.txtDefaultGateway.TabIndex = 13;
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.BackColor = System.Drawing.Color.Transparent;
            this.txtSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSubnetMask.IpAddress = "0.0.0.0";
            this.txtSubnetMask.Location = new System.Drawing.Point(126, 79);
            this.txtSubnetMask.MinimumSize = new System.Drawing.Size(128, 20);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.RangeAValue = 0;
            this.txtSubnetMask.RangeBValue = 0;
            this.txtSubnetMask.RangeCValue = 0;
            this.txtSubnetMask.RangeDValue = 0;
            this.txtSubnetMask.Size = new System.Drawing.Size(128, 20);
            this.txtSubnetMask.TabIndex = 12;
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Transparent;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtIP.IpAddress = "0.0.0.0";
            this.txtIP.Location = new System.Drawing.Point(126, 53);
            this.txtIP.MinimumSize = new System.Drawing.Size(128, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.RangeAValue = 0;
            this.txtIP.RangeBValue = 0;
            this.txtIP.RangeCValue = 0;
            this.txtIP.RangeDValue = 0;
            this.txtIP.Size = new System.Drawing.Size(128, 20);
            this.txtIP.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMacAddress);
            this.groupBox1.Location = new System.Drawing.Point(4, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 59);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mac Address";
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.Location = new System.Drawing.Point(19, 19);
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.ReadOnly = true;
            this.txtMacAddress.Size = new System.Drawing.Size(235, 20);
            this.txtMacAddress.TabIndex = 0;
            this.txtMacAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(584, 240);
            this.Name = "IpControl";
            this.Size = new System.Drawing.Size(584, 240);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private IpTextBox txtAlternativeDNS;
        private System.Windows.Forms.Label label6;
        private IpTextBox txtPrimaryDNS;
        private System.Windows.Forms.GroupBox groupBox2;
        private IpTextBox txtDefaultGateway;
        private IpTextBox txtSubnetMask;
        private IpTextBox txtIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDHCPEnabled;
        private System.Windows.Forms.CheckBox cbDynamicDNS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMacAddress;
    }
}

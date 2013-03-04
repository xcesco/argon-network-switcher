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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDHCPEnabled = new System.Windows.Forms.CheckBox();
            this.txtDefaultGateway = new Argon.Windows.Controls.IpTextBox();
            this.txtSubnetMask = new Argon.Windows.Controls.IpTextBox();
            this.txtIP = new Argon.Windows.Controls.IpTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 138);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP Configuration";
            // 
            // cbDHCPEnabled
            // 
            this.cbDHCPEnabled.AutoSize = true;
            this.cbDHCPEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDHCPEnabled.ForeColor = System.Drawing.Color.Black;
            this.cbDHCPEnabled.Location = new System.Drawing.Point(11, 26);
            this.cbDHCPEnabled.Name = "cbDHCPEnabled";
            this.cbDHCPEnabled.Size = new System.Drawing.Size(103, 17);
            this.cbDHCPEnabled.TabIndex = 14;
            this.cbDHCPEnabled.Text = "Enable DHCP";
            this.cbDHCPEnabled.UseVisualStyleBackColor = true;
            this.cbDHCPEnabled.CheckedChanged += new System.EventHandler(this.cbDHCPEnabled_CheckedChanged);
            // 
            // txtDefaultGateway
            // 
            this.txtDefaultGateway.BackColor = System.Drawing.Color.Transparent;
            this.txtDefaultGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDefaultGateway.ForeColor = System.Drawing.Color.Black;
            this.txtDefaultGateway.IpAddress = "0.0.0.0";
            this.txtDefaultGateway.Location = new System.Drawing.Point(120, 105);
            this.txtDefaultGateway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtSubnetMask.ForeColor = System.Drawing.Color.Black;
            this.txtSubnetMask.IpAddress = "0.0.0.0";
            this.txtSubnetMask.Location = new System.Drawing.Point(120, 79);
            this.txtSubnetMask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtIP.ForeColor = System.Drawing.Color.Black;
            this.txtIP.IpAddress = "0.0.0.0";
            this.txtIP.Location = new System.Drawing.Point(120, 53);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.MinimumSize = new System.Drawing.Size(128, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.RangeAValue = 0;
            this.txtIP.RangeBValue = 0;
            this.txtIP.RangeCValue = 0;
            this.txtIP.RangeDValue = 0;
            this.txtIP.Size = new System.Drawing.Size(128, 20);
            this.txtIP.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Default gateway";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subnet mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP";
            // 
            // IpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MinimumSize = new System.Drawing.Size(264, 138);
            this.Name = "IpControl";
            this.Size = new System.Drawing.Size(264, 138);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private IpTextBox txtDefaultGateway;
        private IpTextBox txtSubnetMask;
        private IpTextBox txtIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDHCPEnabled;
    }
}

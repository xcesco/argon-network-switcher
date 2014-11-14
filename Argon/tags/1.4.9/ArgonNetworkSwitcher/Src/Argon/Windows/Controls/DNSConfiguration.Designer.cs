namespace Argon.Windows.Controls
{
    partial class DNSConfiguration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDynamicDNS = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlternativeDNS = new Argon.Windows.Controls.IpTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrimaryDNS = new Argon.Windows.Controls.IpTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDynamicDNS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAlternativeDNS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrimaryDNS);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(277, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DNS Configuration ";
            // 
            // cbDynamicDNS
            // 
            this.cbDynamicDNS.AutoSize = true;
            this.cbDynamicDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDynamicDNS.ForeColor = System.Drawing.Color.Black;
            this.cbDynamicDNS.Location = new System.Drawing.Point(14, 23);
            this.cbDynamicDNS.Name = "cbDynamicDNS";
            this.cbDynamicDNS.Size = new System.Drawing.Size(135, 17);
            this.cbDynamicDNS.TabIndex = 25;
            this.cbDynamicDNS.Text = "Use DHCP for DNS";
            this.cbDynamicDNS.UseVisualStyleBackColor = true;
            this.cbDynamicDNS.CheckedChanged += new System.EventHandler(this.cbDynamicDNS_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Primary DNS Server";
            // 
            // txtAlternativeDNS
            // 
            this.txtAlternativeDNS.BackColor = System.Drawing.Color.Transparent;
            this.txtAlternativeDNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAlternativeDNS.ForeColor = System.Drawing.Color.Black;
            this.txtAlternativeDNS.IpAddress = "0.0.0.0";
            this.txtAlternativeDNS.Location = new System.Drawing.Point(134, 76);
            this.txtAlternativeDNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlternativeDNS.MinimumSize = new System.Drawing.Size(128, 20);
            this.txtAlternativeDNS.Name = "txtAlternativeDNS";
            this.txtAlternativeDNS.RangeAValue = 0;
            this.txtAlternativeDNS.RangeBValue = 0;
            this.txtAlternativeDNS.RangeCValue = 0;
            this.txtAlternativeDNS.RangeDValue = 0;
            this.txtAlternativeDNS.Size = new System.Drawing.Size(128, 20);
            this.txtAlternativeDNS.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Alternative DNS Server";
            // 
            // txtPrimaryDNS
            // 
            this.txtPrimaryDNS.BackColor = System.Drawing.Color.Transparent;
            this.txtPrimaryDNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPrimaryDNS.ForeColor = System.Drawing.Color.Black;
            this.txtPrimaryDNS.IpAddress = "0.0.0.0";
            this.txtPrimaryDNS.Location = new System.Drawing.Point(134, 50);
            this.txtPrimaryDNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrimaryDNS.MinimumSize = new System.Drawing.Size(128, 20);
            this.txtPrimaryDNS.Name = "txtPrimaryDNS";
            this.txtPrimaryDNS.RangeAValue = 0;
            this.txtPrimaryDNS.RangeBValue = 0;
            this.txtPrimaryDNS.RangeCValue = 0;
            this.txtPrimaryDNS.RangeDValue = 0;
            this.txtPrimaryDNS.Size = new System.Drawing.Size(128, 20);
            this.txtPrimaryDNS.TabIndex = 23;
            // 
            // DNSConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DNSConfiguration";
            this.Size = new System.Drawing.Size(277, 114);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDynamicDNS;
        private System.Windows.Forms.Label label5;
        private global::Argon.Windows.Controls.IpTextBox txtAlternativeDNS;
        private System.Windows.Forms.Label label6;
        private global::Argon.Windows.Controls.IpTextBox txtPrimaryDNS;
    }
}

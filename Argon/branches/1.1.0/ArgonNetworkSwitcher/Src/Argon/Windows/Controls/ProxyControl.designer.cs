namespace Argon.Windows.Controls
{
    partial class ProxyControl
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbProxyOverrideEnabled = new System.Windows.Forms.CheckBox();
            this.txtProxyOverride = new System.Windows.Forms.TextBox();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEnabledProxy = new System.Windows.Forms.CheckBox();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pictureBox);
            this.groupBox3.Controls.Add(this.cbProxyOverrideEnabled);
            this.groupBox3.Controls.Add(this.txtProxyOverride);
            this.groupBox3.Controls.Add(this.txtProxyPort);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbEnabledProxy);
            this.groupBox3.Controls.Add(this.txtProxyAddress);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 305);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proxy settings";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 100);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // cbProxyOverrideEnabled
            // 
            this.cbProxyOverrideEnabled.AutoSize = true;
            this.cbProxyOverrideEnabled.Location = new System.Drawing.Point(12, 189);
            this.cbProxyOverrideEnabled.Name = "cbProxyOverrideEnabled";
            this.cbProxyOverrideEnabled.Size = new System.Drawing.Size(95, 17);
            this.cbProxyOverrideEnabled.TabIndex = 14;
            this.cbProxyOverrideEnabled.Text = "Proxy Override";
            this.cbProxyOverrideEnabled.UseVisualStyleBackColor = true;
            this.cbProxyOverrideEnabled.CheckedChanged += new System.EventHandler(this.cbProxyOverrideEnabled_CheckedChanged);
            // 
            // txtProxyOverride
            // 
            this.txtProxyOverride.Location = new System.Drawing.Point(12, 209);
            this.txtProxyOverride.Multiline = true;
            this.txtProxyOverride.Name = "txtProxyOverride";
            this.txtProxyOverride.Size = new System.Drawing.Size(355, 83);
            this.txtProxyOverride.TabIndex = 13;
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.Location = new System.Drawing.Point(257, 154);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.Size = new System.Drawing.Size(55, 20);
            this.txtProxyPort.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Port";
            // 
            // cbEnabledProxy
            // 
            this.cbEnabledProxy.AutoSize = true;
            this.cbEnabledProxy.Location = new System.Drawing.Point(12, 131);
            this.cbEnabledProxy.Name = "cbEnabledProxy";
            this.cbEnabledProxy.Size = new System.Drawing.Size(93, 17);
            this.cbEnabledProxy.TabIndex = 9;
            this.cbEnabledProxy.Text = "Enabled proxy";
            this.cbEnabledProxy.UseVisualStyleBackColor = true;
            this.cbEnabledProxy.CheckedChanged += new System.EventHandler(this.cbEnabledProxy_CheckedChanged);
            // 
            // txtProxyAddress
            // 
            this.txtProxyAddress.Location = new System.Drawing.Point(43, 154);
            this.txtProxyAddress.Name = "txtProxyAddress";
            this.txtProxyAddress.Size = new System.Drawing.Size(172, 20);
            this.txtProxyAddress.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Proxy";
            // 
            // ProxyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(364, 148);
            this.Name = "ProxyControl";
            this.Size = new System.Drawing.Size(381, 324);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbProxyOverrideEnabled;
        private System.Windows.Forms.TextBox txtProxyOverride;
        private System.Windows.Forms.TextBox txtProxyPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbEnabledProxy;
        private System.Windows.Forms.TextBox txtProxyAddress;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}

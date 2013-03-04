namespace Argon.Windows.Controls
{
    partial class WifiProfileControl
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
            this.cbWifiProfile = new System.Windows.Forms.ComboBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.gbWifiProfile = new System.Windows.Forms.GroupBox();
            this.gbWifiProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbWifiProfile
            // 
            this.cbWifiProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWifiProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWifiProfile.FormattingEnabled = true;
            this.cbWifiProfile.Location = new System.Drawing.Point(14, 55);
            this.cbWifiProfile.Margin = new System.Windows.Forms.Padding(4);
            this.cbWifiProfile.Name = "cbWifiProfile";
            this.cbWifiProfile.Size = new System.Drawing.Size(300, 24);
            this.cbWifiProfile.TabIndex = 1;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWifi.ForeColor = System.Drawing.Color.Black;
            this.cbWifi.Location = new System.Drawing.Point(14, 26);
            this.cbWifi.Margin = new System.Windows.Forms.Padding(4);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(118, 21);
            this.cbWifi.TabIndex = 0;
            this.cbWifi.Text = "associate to";
            this.cbWifi.UseVisualStyleBackColor = true;
            this.cbWifi.CheckedChanged += new System.EventHandler(this.cbWifi_CheckedChanged);
            // 
            // gbWifiProfile
            // 
            this.gbWifiProfile.Controls.Add(this.cbWifiProfile);
            this.gbWifiProfile.Controls.Add(this.cbWifi);
            this.gbWifiProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWifiProfile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbWifiProfile.Location = new System.Drawing.Point(0, 0);
            this.gbWifiProfile.Margin = new System.Windows.Forms.Padding(4);
            this.gbWifiProfile.Name = "gbWifiProfile";
            this.gbWifiProfile.Padding = new System.Windows.Forms.Padding(4);
            this.gbWifiProfile.Size = new System.Drawing.Size(330, 92);
            this.gbWifiProfile.TabIndex = 26;
            this.gbWifiProfile.TabStop = false;
            this.gbWifiProfile.Text = "Wifi profile";
            // 
            // WifiProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbWifiProfile);
            this.MinimumSize = new System.Drawing.Size(330, 92);
            this.Name = "WifiProfileControl";
            this.Size = new System.Drawing.Size(330, 92);
            this.gbWifiProfile.ResumeLayout(false);
            this.gbWifiProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWifiProfile;
        private System.Windows.Forms.CheckBox cbWifi;
        private System.Windows.Forms.GroupBox gbWifiProfile;
    }
}

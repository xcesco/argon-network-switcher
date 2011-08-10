namespace Argon.Windows.Forms
{

    /// <summary>
    /// TextBox per la gestione degli indirizzi IP4
    /// </summary>      
    partial class IpTextBox
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
            this.txtBackground = new System.Windows.Forms.TextBox();
            this.txtRD = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtRC = new System.Windows.Forms.TextBox();
            this.txtRB = new System.Windows.Forms.TextBox();
            this.txtLabel1 = new System.Windows.Forms.TextBox();
            this.txtLabel2 = new System.Windows.Forms.TextBox();
            this.txtLabel3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBackground
            // 
            this.txtBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBackground.Location = new System.Drawing.Point(0, 0);
            this.txtBackground.Multiline = true;
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.Size = new System.Drawing.Size(128, 20);
            this.txtBackground.TabIndex = 8;
            this.txtBackground.TabStop = false;
            // 
            // txtRD
            // 
            this.txtRD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRD.Location = new System.Drawing.Point(104, 3);
            this.txtRD.MaxLength = 3;
            this.txtRD.Name = "txtRD";
            this.txtRD.Size = new System.Drawing.Size(18, 13);
            this.txtRD.TabIndex = 15;
            this.txtRD.Text = "0";
            this.txtRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRD.TextChanged += new System.EventHandler(this.txtRD_TextChanged);
            this.txtRD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            this.txtRD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // txtRA
            // 
            this.txtRA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRA.Location = new System.Drawing.Point(5, 3);
            this.txtRA.MaxLength = 3;
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(18, 13);
            this.txtRA.TabIndex = 12;
            this.txtRA.Text = "0";
            this.txtRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRA.TextChanged += new System.EventHandler(this.txtRA_TextChanged);
            this.txtRA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            this.txtRA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // txtRC
            // 
            this.txtRC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRC.Location = new System.Drawing.Point(71, 3);
            this.txtRC.MaxLength = 3;
            this.txtRC.Name = "txtRC";
            this.txtRC.Size = new System.Drawing.Size(18, 13);
            this.txtRC.TabIndex = 14;
            this.txtRC.Text = "0";
            this.txtRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRC.TextChanged += new System.EventHandler(this.txtRC_TextChanged);
            this.txtRC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            this.txtRC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // txtRB
            // 
            this.txtRB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRB.Location = new System.Drawing.Point(38, 3);
            this.txtRB.MaxLength = 3;
            this.txtRB.Name = "txtRB";
            this.txtRB.Size = new System.Drawing.Size(18, 13);
            this.txtRB.TabIndex = 13;
            this.txtRB.Text = "0";
            this.txtRB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRB.TextChanged += new System.EventHandler(this.txtRB_TextChanged);
            this.txtRB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Event_KeyDown);
            this.txtRB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // txtLabel1
            // 
            this.txtLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabel1.Location = new System.Drawing.Point(29, 3);
            this.txtLabel1.Name = "txtLabel1";
            this.txtLabel1.Size = new System.Drawing.Size(3, 13);
            this.txtLabel1.TabIndex = 16;
            this.txtLabel1.TabStop = false;
            this.txtLabel1.Text = ".";
            this.txtLabel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLabel2
            // 
            this.txtLabel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabel2.Location = new System.Drawing.Point(62, 4);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.Size = new System.Drawing.Size(3, 13);
            this.txtLabel2.TabIndex = 17;
            this.txtLabel2.TabStop = false;
            this.txtLabel2.Text = ".";
            this.txtLabel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLabel3
            // 
            this.txtLabel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabel3.Location = new System.Drawing.Point(95, 3);
            this.txtLabel3.Name = "txtLabel3";
            this.txtLabel3.Size = new System.Drawing.Size(3, 13);
            this.txtLabel3.TabIndex = 18;
            this.txtLabel3.TabStop = false;
            this.txtLabel3.Text = ".";
            this.txtLabel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IpTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLabel3);
            this.Controls.Add(this.txtLabel2);
            this.Controls.Add(this.txtLabel1);
            this.Controls.Add(this.txtRD);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtRC);
            this.Controls.Add(this.txtRB);
            this.Controls.Add(this.txtBackground);
            this.MinimumSize = new System.Drawing.Size(128, 20);
            this.Name = "IpTextBox";
            this.Size = new System.Drawing.Size(128, 20);
            this.Load += new System.EventHandler(this.IpTextBox_Load);
            this.BackColorChanged += new System.EventHandler(this.IpTextBox_BackColorChanged);
            this.FontChanged += new System.EventHandler(this.IpTextBox_FontChanged);
            this.Resize += new System.EventHandler(this.IpTextBox_Resize);
            this.ForeColorChanged += new System.EventHandler(this.IpTextBox_ForeColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackground;
        private System.Windows.Forms.TextBox txtRD;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtRC;
        private System.Windows.Forms.TextBox txtRB;
        private System.Windows.Forms.TextBox txtLabel1;
        private System.Windows.Forms.TextBox txtLabel2;
        private System.Windows.Forms.TextBox txtLabel3;

    }
}

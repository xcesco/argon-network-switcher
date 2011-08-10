namespace Argon.Windows.Forms
{
    partial class FormAdapters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdapters));
            this.button1 = new System.Windows.Forms.Button();
            this.ipTextBox1 = new Argon.Windows.Forms.IpTextBox();
            this.ipTextBox2 = new Argon.Windows.Forms.IpTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ipTextBox1
            // 
            this.ipTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.ipTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipTextBox1.IpAddress = "0.0.0.0";
            this.ipTextBox1.Location = new System.Drawing.Point(12, 41);
            this.ipTextBox1.MinimumSize = new System.Drawing.Size(128, 20);
            this.ipTextBox1.Name = "ipTextBox1";
            this.ipTextBox1.RangeAValue = 0;
            this.ipTextBox1.RangeBValue = 0;
            this.ipTextBox1.RangeCValue = 0;
            this.ipTextBox1.RangeDValue = 0;
            this.ipTextBox1.Size = new System.Drawing.Size(128, 20);
            this.ipTextBox1.TabIndex = 1;
            // 
            // ipTextBox2
            // 
            this.ipTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.ipTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipTextBox2.IpAddress = "0.0.0.0";
            this.ipTextBox2.Location = new System.Drawing.Point(12, 67);
            this.ipTextBox2.MinimumSize = new System.Drawing.Size(128, 20);
            this.ipTextBox2.Name = "ipTextBox2";
            this.ipTextBox2.RangeAValue = 0;
            this.ipTextBox2.RangeBValue = 0;
            this.ipTextBox2.RangeCValue = 0;
            this.ipTextBox2.RangeDValue = 0;
            this.ipTextBox2.Size = new System.Drawing.Size(128, 20);
            this.ipTextBox2.TabIndex = 2;
            // 
            // FormAdapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ipTextBox2);
            this.Controls.Add(this.ipTextBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdapters";
            this.TabText = "Network Adapters";
            this.Text = "Network Adapters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Windows.Forms.IpTextBox ipTextBox1;
        private Windows.Forms.IpTextBox ipTextBox2;
    }
}
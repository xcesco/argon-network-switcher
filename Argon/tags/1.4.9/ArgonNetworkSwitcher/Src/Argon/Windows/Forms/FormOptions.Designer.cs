namespace Argon.Windows.Forms
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStartWithAutodetect = new System.Windows.Forms.CheckBox();
            this.cbStartAndCheckForUpdate = new System.Windows.Forms.CheckBox();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbStartNormal = new System.Windows.Forms.RadioButton();
            this.rbStartTrayArea = new System.Windows.Forms.RadioButton();
            this.rbStartSmartView = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbConfirmOnClose = new System.Windows.Forms.CheckBox();
            this.cbDisplaySplahScreen = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbDisplaySplahScreen);
            this.groupBox1.Controls.Add(this.cbStartWithAutodetect);
            this.groupBox1.Controls.Add(this.cbStartAndCheckForUpdate);
            this.groupBox1.Controls.Add(this.cbStartWithWindows);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(13, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Startup";
            // 
            // cbStartWithAutodetect
            // 
            this.cbStartWithAutodetect.AutoSize = true;
            this.cbStartWithAutodetect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbStartWithAutodetect.Location = new System.Drawing.Point(7, 46);
            this.cbStartWithAutodetect.Name = "cbStartWithAutodetect";
            this.cbStartWithAutodetect.Size = new System.Drawing.Size(294, 20);
            this.cbStartWithAutodetect.TabIndex = 1;
            this.cbStartWithAutodetect.Text = "Autodetect profile when application run";
            this.cbStartWithAutodetect.UseVisualStyleBackColor = true;
            // 
            // cbStartAndCheckForUpdate
            // 
            this.cbStartAndCheckForUpdate.AutoSize = true;
            this.cbStartAndCheckForUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbStartAndCheckForUpdate.Location = new System.Drawing.Point(303, 20);
            this.cbStartAndCheckForUpdate.Name = "cbStartAndCheckForUpdate";
            this.cbStartAndCheckForUpdate.Size = new System.Drawing.Size(216, 20);
            this.cbStartAndCheckForUpdate.TabIndex = 3;
            this.cbStartAndCheckForUpdate.Text = "Check for update on startup";
            this.cbStartAndCheckForUpdate.UseVisualStyleBackColor = true;
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbStartWithWindows.Location = new System.Drawing.Point(7, 20);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(201, 20);
            this.cbStartWithWindows.TabIndex = 0;
            this.cbStartWithWindows.Text = "Run when Windows starts";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbStartNormal);
            this.groupBox2.Controls.Add(this.rbStartTrayArea);
            this.groupBox2.Controls.Add(this.rbStartSmartView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Location = new System.Drawing.Point(13, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initial status";
            // 
            // rbStartNormal
            // 
            this.rbStartNormal.AutoSize = true;
            this.rbStartNormal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbStartNormal.Location = new System.Drawing.Point(335, 21);
            this.rbStartNormal.Name = "rbStartNormal";
            this.rbStartNormal.Size = new System.Drawing.Size(114, 20);
            this.rbStartNormal.TabIndex = 7;
            this.rbStartNormal.TabStop = true;
            this.rbStartNormal.Text = "Show normal";
            this.rbStartNormal.UseVisualStyleBackColor = true;
            // 
            // rbStartTrayArea
            // 
            this.rbStartTrayArea.AutoSize = true;
            this.rbStartTrayArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbStartTrayArea.Location = new System.Drawing.Point(175, 21);
            this.rbStartTrayArea.Name = "rbStartTrayArea";
            this.rbStartTrayArea.Size = new System.Drawing.Size(145, 20);
            this.rbStartTrayArea.TabIndex = 6;
            this.rbStartTrayArea.TabStop = true;
            this.rbStartTrayArea.Text = "Show in tray area";
            this.rbStartTrayArea.UseVisualStyleBackColor = true;
            // 
            // rbStartSmartView
            // 
            this.rbStartSmartView.AutoSize = true;
            this.rbStartSmartView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbStartSmartView.Location = new System.Drawing.Point(7, 21);
            this.rbStartSmartView.Name = "rbStartSmartView";
            this.rbStartSmartView.Size = new System.Drawing.Size(151, 20);
            this.rbStartSmartView.TabIndex = 5;
            this.rbStartSmartView.TabStop = true;
            this.rbStartSmartView.Text = "Start in smart view";
            this.rbStartSmartView.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(115, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 48);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbConfirmOnClose);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Location = new System.Drawing.Point(13, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 51);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shutdown";
            // 
            // cbConfirmOnClose
            // 
            this.cbConfirmOnClose.AutoSize = true;
            this.cbConfirmOnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbConfirmOnClose.Location = new System.Drawing.Point(7, 20);
            this.cbConfirmOnClose.Name = "cbConfirmOnClose";
            this.cbConfirmOnClose.Size = new System.Drawing.Size(313, 20);
            this.cbConfirmOnClose.TabIndex = 0;
            this.cbConfirmOnClose.Text = "Ask confirmation before close application";
            this.cbConfirmOnClose.UseVisualStyleBackColor = true;
            // 
            // cbDisplaySplahScreen
            // 
            this.cbDisplaySplahScreen.AutoSize = true;
            this.cbDisplaySplahScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDisplaySplahScreen.Location = new System.Drawing.Point(303, 46);
            this.cbDisplaySplahScreen.Name = "cbDisplaySplahScreen";
            this.cbDisplaySplahScreen.Size = new System.Drawing.Size(249, 20);
            this.cbDisplaySplahScreen.TabIndex = 5;
            this.cbDisplaySplahScreen.Text = "Display splash screen at startup";
            this.cbDisplaySplahScreen.UseVisualStyleBackColor = true;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 391);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOptions";
            this.TabText = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.VisibleChanged += new System.EventHandler(this.FormOptions_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbStartWithAutodetect;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbStartAndCheckForUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbStartTrayArea;
        private System.Windows.Forms.RadioButton rbStartSmartView;
        private System.Windows.Forms.RadioButton rbStartNormal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbConfirmOnClose;
        private System.Windows.Forms.CheckBox cbDisplaySplahScreen;
    }
}
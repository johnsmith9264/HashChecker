﻿namespace HashCheckerProj
{
    partial class HashChecker
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
            this.bStop = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bChFile = new System.Windows.Forms.Button();
            this.tbChSumFile = new System.Windows.Forms.TextBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.bQCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bBrowseFile = new System.Windows.Forms.Button();
            this.bBrowseDir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLogShow = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bOptions = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.bHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStop
            // 
            this.bStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(344, 460);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(425, 460);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bChFile
            // 
            this.bChFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bChFile.Location = new System.Drawing.Point(431, 32);
            this.bChFile.Name = "bChFile";
            this.bChFile.Size = new System.Drawing.Size(69, 49);
            this.bChFile.TabIndex = 3;
            this.bChFile.Text = "Check File";
            this.bChFile.UseVisualStyleBackColor = true;
            this.bChFile.Click += new System.EventHandler(this.bChFile_Click);
            // 
            // tbChSumFile
            // 
            this.tbChSumFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbChSumFile.Location = new System.Drawing.Point(35, 34);
            this.tbChSumFile.Name = "tbChSumFile";
            this.tbChSumFile.Size = new System.Drawing.Size(357, 20);
            this.tbChSumFile.TabIndex = 4;
            // 
            // tbDir
            // 
            this.tbDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDir.Location = new System.Drawing.Point(35, 60);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(357, 20);
            this.tbDir.TabIndex = 5;
            // 
            // bQCheck
            // 
            this.bQCheck.Location = new System.Drawing.Point(173, 3);
            this.bQCheck.Name = "bQCheck";
            this.bQCheck.Size = new System.Drawing.Size(143, 22);
            this.bQCheck.TabIndex = 6;
            this.bQCheck.Text = "Quick Check...";
            this.bQCheck.UseVisualStyleBackColor = true;
            this.bQCheck.Click += new System.EventHandler(this.bQCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dir:";
            // 
            // bBrowseFile
            // 
            this.bBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseFile.Image = global::HashCheckerProj.Properties.Resources.openfolderHS;
            this.bBrowseFile.Location = new System.Drawing.Point(398, 32);
            this.bBrowseFile.Name = "bBrowseFile";
            this.bBrowseFile.Size = new System.Drawing.Size(27, 23);
            this.bBrowseFile.TabIndex = 9;
            this.bBrowseFile.UseVisualStyleBackColor = true;
            this.bBrowseFile.Click += new System.EventHandler(this.bBrowseFile_Click);
            // 
            // bBrowseDir
            // 
            this.bBrowseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseDir.Image = global::HashCheckerProj.Properties.Resources.openfolderHS;
            this.bBrowseDir.Location = new System.Drawing.Point(398, 58);
            this.bBrowseDir.Name = "bBrowseDir";
            this.bBrowseDir.Size = new System.Drawing.Size(27, 23);
            this.bBrowseDir.TabIndex = 10;
            this.bBrowseDir.UseVisualStyleBackColor = true;
            this.bBrowseDir.Click += new System.EventHandler(this.bBrowseDir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbLogShow);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbPriority);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bQCheck);
            this.panel1.Controls.Add(this.bChFile);
            this.panel1.Controls.Add(this.bBrowseDir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bBrowseFile);
            this.panel1.Controls.Add(this.tbChSumFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbDir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 128);
            this.panel1.TabIndex = 11;
            // 
            // cbLogShow
            // 
            this.cbLogShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogShow.FormattingEnabled = true;
            this.cbLogShow.Items.AddRange(new object[] {
            "Checksum file entries",
            "Full names",
            "Filenames only"});
            this.cbLogShow.Location = new System.Drawing.Point(83, 96);
            this.cbLogShow.Name = "cbLogShow";
            this.cbLogShow.Size = new System.Drawing.Size(129, 21);
            this.cbLogShow.TabIndex = 18;
            this.cbLogShow.SelectedIndexChanged += new System.EventHandler(this.cbLogShow_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Show in log:";
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Highest",
            "Above Normal",
            "Normal",
            "Below Normal",
            "Lowest"});
            this.cbPriority.Location = new System.Drawing.Point(368, 96);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(121, 21);
            this.cbPriority.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thread priority:";
            // 
            // bOptions
            // 
            this.bOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bOptions.Location = new System.Drawing.Point(12, 460);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(75, 23);
            this.bOptions.TabIndex = 12;
            this.bOptions.Text = "Options...";
            this.bOptions.UseVisualStyleBackColor = true;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(0, 134);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(505, 320);
            this.rtbLog.TabIndex = 13;
            this.rtbLog.Text = "";
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(94, 460);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(75, 23);
            this.bHelp.TabIndex = 14;
            this.bHelp.Text = "Help";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // HashChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 495);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.bOptions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bStop);
            this.Name = "HashChecker";
            this.Text = "Hash Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HashChecker_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HashChecker_FormClosed);
            this.Load += new System.EventHandler(this.HashChecker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bChFile;
        private System.Windows.Forms.TextBox tbChSumFile;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Button bQCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBrowseFile;
        private System.Windows.Forms.Button bBrowseDir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbLogShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button bHelp;
    }
}
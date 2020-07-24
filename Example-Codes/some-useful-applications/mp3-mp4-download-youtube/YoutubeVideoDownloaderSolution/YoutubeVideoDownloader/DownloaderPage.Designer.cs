namespace YoutubeVideoDownloader
{
    partial class downloaderPage
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
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.btnMp4 = new System.Windows.Forms.Button();
            this.btnMp3 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.btnSetCurrentDirectory = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCopyPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxUrl
            // 
            this.tbxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrl.Location = new System.Drawing.Point(12, 12);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(510, 26);
            this.tbxUrl.TabIndex = 0;
            this.tbxUrl.Text = "video link here.";
            // 
            // btnMp4
            // 
            this.btnMp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMp4.Location = new System.Drawing.Point(16, 168);
            this.btnMp4.Name = "btnMp4";
            this.btnMp4.Size = new System.Drawing.Size(98, 49);
            this.btnMp4.TabIndex = 2;
            this.btnMp4.Text = "Download As Mp4";
            this.btnMp4.UseVisualStyleBackColor = true;
            this.btnMp4.Click += new System.EventHandler(this.btnMp4_Click);
            // 
            // btnMp3
            // 
            this.btnMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMp3.Location = new System.Drawing.Point(131, 168);
            this.btnMp3.Name = "btnMp3";
            this.btnMp3.Size = new System.Drawing.Size(98, 49);
            this.btnMp3.TabIndex = 3;
            this.btnMp3.Text = "Download As Mp3";
            this.btnMp3.UseVisualStyleBackColor = true;
            this.btnMp3.Click += new System.EventHandler(this.btnMp3_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(12, 235);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(255, 24);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status of process shows here";
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(12, 56);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.ReadOnly = true;
            this.tbxPath.Size = new System.Drawing.Size(253, 20);
            this.tbxPath.TabIndex = 5;
            this.tbxPath.Text = "selected path shows here";
            // 
            // btnSetCurrentDirectory
            // 
            this.btnSetCurrentDirectory.Location = new System.Drawing.Point(271, 56);
            this.btnSetCurrentDirectory.Name = "btnSetCurrentDirectory";
            this.btnSetCurrentDirectory.Size = new System.Drawing.Size(163, 20);
            this.btnSetCurrentDirectory.TabIndex = 6;
            this.btnSetCurrentDirectory.Text = "set as current directory";
            this.btnSetCurrentDirectory.UseVisualStyleBackColor = true;
            this.btnSetCurrentDirectory.Click += new System.EventHandler(this.btnSetCurrentDirectory_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(440, 56);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCopyPath
            // 
            this.btnCopyPath.Location = new System.Drawing.Point(12, 82);
            this.btnCopyPath.Name = "btnCopyPath";
            this.btnCopyPath.Size = new System.Drawing.Size(75, 23);
            this.btnCopyPath.TabIndex = 8;
            this.btnCopyPath.Text = "copy path";
            this.btnCopyPath.UseVisualStyleBackColor = true;
            this.btnCopyPath.Click += new System.EventHandler(this.btnCopyPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "downloading as mp3 takes same time as mp4";
            // 
            // downloaderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopyPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSetCurrentDirectory);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnMp3);
            this.Controls.Add(this.btnMp4);
            this.Controls.Add(this.tbxUrl);
            this.Name = "downloaderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Button btnMp4;
        private System.Windows.Forms.Button btnMp3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.Button btnSetCurrentDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCopyPath;
        private System.Windows.Forms.Label label1;
    }
}


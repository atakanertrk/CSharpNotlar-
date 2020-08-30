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
            this.components = new System.ComponentModel.Container();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.btnMp4 = new System.Windows.Forms.Button();
            this.btnMp3 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCopyPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxQuality = new System.Windows.Forms.ComboBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteLastItemOfList = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.lbxQueue = new System.Windows.Forms.ListBox();
            this.lblQueue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxUrl
            // 
            this.tbxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrl.Location = new System.Drawing.Point(10, 35);
            this.tbxUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(451, 30);
            this.tbxUrl.TabIndex = 0;
            this.tbxUrl.Text = "video link here.";
            // 
            // btnMp4
            // 
            this.btnMp4.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMp4.Location = new System.Drawing.Point(47, 172);
            this.btnMp4.Margin = new System.Windows.Forms.Padding(4);
            this.btnMp4.Name = "btnMp4";
            this.btnMp4.Size = new System.Drawing.Size(131, 60);
            this.btnMp4.TabIndex = 2;
            this.btnMp4.Text = "Download As Mp4";
            this.btnMp4.UseVisualStyleBackColor = false;
            this.btnMp4.Click += new System.EventHandler(this.btnMp4_Click);
            // 
            // btnMp3
            // 
            this.btnMp3.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMp3.Location = new System.Drawing.Point(195, 172);
            this.btnMp3.Margin = new System.Windows.Forms.Padding(4);
            this.btnMp3.Name = "btnMp3";
            this.btnMp3.Size = new System.Drawing.Size(131, 60);
            this.btnMp3.TabIndex = 3;
            this.btnMp3.Text = "Download As Mp3";
            this.btnMp3.UseVisualStyleBackColor = false;
            this.btnMp3.Click += new System.EventHandler(this.btnMp3_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(42, 109);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(327, 29);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status of process shows here";
            // 
            // tbxPath
            // 
            this.tbxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPath.Location = new System.Drawing.Point(4, 10);
            this.tbxPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.ReadOnly = true;
            this.tbxPath.Size = new System.Drawing.Size(418, 24);
            this.tbxPath.TabIndex = 5;
            this.tbxPath.Text = "selected path shows here";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrowse.Location = new System.Drawing.Point(4, 42);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 45);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCopyPath
            // 
            this.btnCopyPath.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCopyPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopyPath.Location = new System.Drawing.Point(117, 44);
            this.btnCopyPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyPath.Name = "btnCopyPath";
            this.btnCopyPath.Size = new System.Drawing.Size(112, 43);
            this.btnCopyPath.TabIndex = 8;
            this.btnCopyPath.Text = "copy path";
            this.btnCopyPath.UseVisualStyleBackColor = false;
            this.btnCopyPath.Click += new System.EventHandler(this.btnCopyPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "downloading as mp3 takes same amount of time as mp4";
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnAddUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUrl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddUrl.Location = new System.Drawing.Point(10, 72);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(163, 52);
            this.btnAddUrl.TabIndex = 10;
            this.btnAddUrl.Text = "Add to queue";
            this.btnAddUrl.UseVisualStyleBackColor = false;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Some videos can be downloaded low quality";
            // 
            // cbxQuality
            // 
            this.cbxQuality.FormattingEnabled = true;
            this.cbxQuality.Location = new System.Drawing.Point(47, 141);
            this.cbxQuality.Name = "cbxQuality";
            this.cbxQuality.Size = new System.Drawing.Size(121, 24);
            this.cbxQuality.TabIndex = 18;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber.ForeColor = System.Drawing.Color.Green;
            this.lblNumber.Location = new System.Drawing.Point(270, 19);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(27, 29);
            this.lblNumber.TabIndex = 19;
            this.lblNumber.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl.Location = new System.Drawing.Point(23, 19);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(232, 24);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Video Number In Process:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.43974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.56026F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 1055);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblQueue);
            this.panel1.Controls.Add(this.lbxQueue);
            this.panel1.Controls.Add(this.btnDeleteLastItemOfList);
            this.panel1.Controls.Add(this.btnClearList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 570);
            this.panel1.TabIndex = 20;
            // 
            // btnDeleteLastItemOfList
            // 
            this.btnDeleteLastItemOfList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteLastItemOfList.Location = new System.Drawing.Point(159, 217);
            this.btnDeleteLastItemOfList.Name = "btnDeleteLastItemOfList";
            this.btnDeleteLastItemOfList.Size = new System.Drawing.Size(203, 33);
            this.btnDeleteLastItemOfList.TabIndex = 15;
            this.btnDeleteLastItemOfList.Text = "Delete Last Added Link";
            this.btnDeleteLastItemOfList.UseVisualStyleBackColor = true;
            this.btnDeleteLastItemOfList.Click += new System.EventHandler(this.btnDeleteLastItemOfList_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearList.Location = new System.Drawing.Point(30, 217);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(123, 44);
            this.btnClearList.TabIndex = 16;
            this.btnClearList.Text = "Clear Queue";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // lbxQueue
            // 
            this.lbxQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxQueue.FormattingEnabled = true;
            this.lbxQueue.ItemHeight = 18;
            this.lbxQueue.Location = new System.Drawing.Point(30, 45);
            this.lbxQueue.Name = "lbxQueue";
            this.lbxQueue.Size = new System.Drawing.Size(418, 166);
            this.lbxQueue.TabIndex = 13;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQueue.Location = new System.Drawing.Point(25, 17);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(82, 25);
            this.lblQueue.TabIndex = 12;
            this.lblQueue.Text = "QUEUE";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbxQuality);
            this.panel2.Controls.Add(this.btnMp4);
            this.panel2.Controls.Add(this.lblNumber);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.btnMp3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(634, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 570);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbxUrl);
            this.panel3.Controls.Add(this.btnAddUrl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 473);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.tbxPath);
            this.panel4.Controls.Add(this.btnCopyPath);
            this.panel4.Controls.Add(this.btnBrowse);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(634, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(625, 473);
            this.panel4.TabIndex = 23;
            // 
            // downloaderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "downloaderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Button btnMp4;
        private System.Windows.Forms.Button btnMp3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCopyPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cbxQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.ListBox lbxQueue;
        private System.Windows.Forms.Button btnDeleteLastItemOfList;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace YoutubeVideoDownloader
{
    public partial class downloaderPage : Form
    {
        bool isPathSelectedControl=false;
        ProcessOfDownloads processOfDownloads = new ProcessOfDownloads();
        BindingList<string> UrlQueue;
        public downloaderPage()
        {
            InitializeComponent();
            UrlQueue = new BindingList<string>();
            Settings();
        }
        public void Settings()
        {
            lbxQueue.ScrollAlwaysVisible = true;
            lbxQueue.HorizontalScrollbar = true;
            cbxQuality.Items.Add(360); cbxQuality.Items.Add(480); cbxQuality.Items.Add(720); cbxQuality.Items.Add(1080);
        }
        
        //private void btnSetCurrentDirectory_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        tbxPath.Text = Directory.GetCurrentDirectory();
        //        isPathSelectedControl = true;
        //    }
        //    catch (Exception)
        //    {
        //        lblStatus.Text = "cannot get current directory";
        //    }
        //}

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedPath = fbd.SelectedPath;
                tbxPath.Text = selectedPath;
                isPathSelectedControl = true;
            }
        }

        private async void btnMp3_Click(object sender, EventArgs e)
        {
            int count = 0;
            lblNumber.Text = count.ToString();
            if (isPathSelectedControl == true)
            {
                foreach (var link in UrlQueue)
                {
                    count += 1;
                    lblNumber.Text = count.ToString();
                    lblStatus.Text = "Downloading as MP3...";
                    bool isDownloadSuccess = await processOfDownloads.DownloadAsMp3(tbxPath.Text, link);
                    if (isDownloadSuccess == false)
                    {
                        lblStatus.Text = "Check url then try again";
                    }
                    else
                    {
                        lblStatus.Text = "Downloaded";
                    }
                }
            }
            else
            {
                lblStatus.Text = "Check download path then try again";
            }
        }
        private async void btnMp4_Click(object sender, EventArgs e)
        {
            if (cbxQuality.SelectedItem != null || Convert.ToInt32(cbxQuality.SelectedItem) != 0)
            {
                int count = 0;
                lblNumber.Text = count.ToString();
                if (isPathSelectedControl == true)
                {
                    foreach (var link in UrlQueue)
                    {
                        count += 1;
                        lblNumber.Text = count.ToString();
                        lblStatus.Text = "Downloading as MP4...";
                        bool isDownloadSuccess = await processOfDownloads.DownloadAsMp4(link, tbxPath.Text, Convert.ToInt32(cbxQuality.SelectedItem));
                        if (isDownloadSuccess == false)
                        {
                            lblStatus.Text = "Check video url then try again";
                        }
                        else
                        {
                            lblStatus.Text = $"Downloaded";
                        }
                    }
                }
                else
                {
                    lblStatus.Text = "Check download path then try again";
                }
            }
            else
            {
                lblStatus.Text = "Please select video resolution";
            }
        }

        private void btnCopyPath_Click(object sender, EventArgs e)
        {
            if (isPathSelectedControl == true)
            {
                System.Windows.Forms.Clipboard.SetText(tbxPath.Text);
            }
            else
            {
                MessageBox.Show("select download path");
            }
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            lbxQueue.DataSource = UrlQueue;
            if (tbxUrl.Text != "" && UrlQueue.Contains(tbxUrl.Text)==false)
            {
                UrlQueue.Add(tbxUrl.Text);
            }
            else
            {
                MessageBox.Show("You have already added same URL in queue or you havent enter URL");
            }
            tbxUrl.Text = "";
        }


        private void btnDeleteLastItemOfList_Click(object sender, EventArgs e)
        {
            if (UrlQueue.Any()) //prevent IndexOutOfRangeException for empty list
            {
                UrlQueue.RemoveAt(UrlQueue.Count - 1);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            UrlQueue.Clear();
        }

    }
}

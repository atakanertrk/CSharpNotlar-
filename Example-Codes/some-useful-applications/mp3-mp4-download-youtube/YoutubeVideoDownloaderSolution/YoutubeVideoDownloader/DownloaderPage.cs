using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public downloaderPage()
        {
            InitializeComponent();
        }

        private void btnSetCurrentDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                tbxPath.Text = Directory.GetCurrentDirectory();
                isPathSelectedControl = true;
            }
            catch (Exception)
            {
                lblStatus.Text = "cannot get current directory";
            }
        }

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
            if (isPathSelectedControl == true)
            {
                lblStatus.Text = "Downloading as MP3...";
                bool isDownloadSuccess = await processOfDownloads.DownloadAsMp3(tbxPath.Text,tbxUrl.Text);
                if (isDownloadSuccess == false)
                {
                    lblStatus.Text = "Check url then try again";
                }
                else
                {
                    lblStatus.Text = "Downloaded";
                }
            }
            else
            {
                lblStatus.Text = "Check download path then try again";
            }
        }
        private async void btnMp4_Click(object sender, EventArgs e)
        {
            if (isPathSelectedControl==true)
            {
                lblStatus.Text = "Downloading as MP4...";
                bool isDownloadSuccess = await processOfDownloads.DownloadAsMp4(tbxUrl.Text,tbxPath.Text);
                if (isDownloadSuccess==false)
                {
                    lblStatus.Text = "Check video url then try again";
                }
                else
                {
                    lblStatus.Text = $"Downloaded";
                }
            }
            else
            {
                lblStatus.Text = "Check download path then try again";
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
    }
}

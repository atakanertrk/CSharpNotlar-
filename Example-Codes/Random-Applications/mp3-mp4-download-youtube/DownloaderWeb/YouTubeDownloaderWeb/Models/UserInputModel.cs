using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeDownloaderWeb.Models
{
    public class UserInputModel
    {
        public string VideoUrl { get; set; }
        public  int VideoQuality { get; set; }
        public string VideoFormat { get; set; }
        public List<string> QualityOptions { get; set; } 
        public List<string> FormatOptions { get; set; } 
    }
}

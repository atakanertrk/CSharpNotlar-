using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VideoLibrary;
using YouTubeDownloaderWeb.Models;

namespace YouTubeDownloaderWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public UserInputModel LoadModel()
        {
            UserInputModel input = new UserInputModel();
            input.QualityOptions = new List<string>();
            input.FormatOptions = new List<string>();
            input.FormatOptions.Add("mp3"); input.FormatOptions.Add("mp4"); input.FormatOptions.Add("Aac (original/better than mp3)");
            input.QualityOptions.Add("1080"); input.QualityOptions.Add("720"); input.QualityOptions.Add("480"); input.QualityOptions.Add("360");
             
            return input;
        }
        [DisableRequestSizeLimit]
        public IActionResult Index()
        {
            var model = LoadModel();
            model.VideoUrl = "";
            return View(model);
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public IActionResult Download(UserInputModel input)
        {
            if (input.VideoFormat == "mp3")
            {
                return File(DownloadAsMp3(input.VideoUrl), $"application/mp3", $"music.mp3",true);
            }
            else if (input.VideoFormat == "Aac (original/better than mp3)")
            {
                return File(DownloadAsMp3(input.VideoUrl), $"application/aac", $"music.aac", true);
            }
            else if (input.VideoFormat == "mp4")
            {
                return File(DownloadAsMp4(input.VideoUrl,input.VideoQuality), $"application/mp4", $"video.mp4", true);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public byte[] DownloadAsMp4(string url, int quality)
        {
            List<YouTubeVideo> videos = YouTube.Default
                .GetAllVideos(url)
                .ToList();
            videos = videos
           .Where(v => v.Resolution <= quality && v.AudioFormat.ToString().ToLower() != "unknown")
           .OrderByDescending(v => v.Resolution)
           .ToList();
            var vid = videos.FirstOrDefault();
            return vid.GetBytes();
        }
        public byte[] DownloadAsMp3(string url)
        {
            //var youtube = YouTube.Default;
            //var vid = youtube.GetVideo(url);
            //string audioFormat = vid.AudioFormat.ToString();
            List<YouTubeVideo> videos = YouTube.Default
               .GetAllVideos(url)
               .ToList();
            videos = videos
           .Where(v => v.AudioFormat.ToString().ToLower() != "unknown")
           .OrderBy(v => v.AudioBitrate) // taking lowest quality for download issues
           .ToList();
            var vid = videos.FirstOrDefault();
            return (vid.GetBytes());
        }

        public async Task<(byte[], string)> AsyncDownloadAsMp3(string url)
        {
            var youtube = YouTube.Default;
            var vid = await youtube.GetVideoAsync(url);
            string audioFormat = vid.AudioFormat.ToString();
            byte[] bytes = await vid.GetBytesAsync();
            return (bytes, audioFormat);
        }
        public async Task<byte[]> AsyncDownloadAsMp4(string url, int quality)
        {
            byte[] bytes;
            List<YouTubeVideo> videos;
            videos = YouTube.Default
           .GetAllVideos(url)
           .ToList();
            videos = videos
             .Where(v => v.Resolution <= quality && v.AudioFormat.ToString().ToLower() != "unknown")
             .OrderByDescending(v => v.Resolution)
             .OrderByDescending(v => v.ContentLength)
             .ToList();

            var vid = videos.FirstOrDefault();
            bytes = await vid.GetBytesAsync();
            return bytes;
        }
        public IActionResult Data(InfoModel info)
        {
            return View(info);
        }
        public IActionResult DependenciesOwners()
        {
            return View();
        }

    }
}



/* 
 * 
 * 
 try
            {
                if (input.VideoFormat == "mp4")
                {
                    var output = DownloadAsMp4(input.VideoUrl, input.VideoQuality);
                    return File(output, "application/mp4", "video.mp4");
                }
                else if (input.VideoFormat == "mp3")
                {
                    var download = DownloadAsMp3(input.VideoUrl);
                    var byteArray = download.Item1;
                    var mediaType = download.Item2;
                    return File(byteArray, $"application/mp3", $"music.mp3");
                }
                else if (input.VideoFormat == "Aac (original/better than mp3)")
                {
                    var download = DownloadAsMp3(input.VideoUrl);
                    var byteArray = download.Item1;
                    var mediaType = download.Item2;
                    return File(byteArray, $"application/{mediaType}", $"music.{mediaType}");
                }
                InfoModel info = new InfoModel();
                info.info = $"Inputs: vidFormat:{input.VideoFormat}  +  vidUrl:{input.VideoUrl}  +  vidQuality:{input.VideoQuality}";
                return RedirectToAction("Data", info);
            }
            catch (Exception ex)
            {
                InfoModel info = new InfoModel();
                info.info = $"{ex.Message} + {ex.Source}";
                return RedirectToAction("Data", info);
            }
 * 
 * 
 */

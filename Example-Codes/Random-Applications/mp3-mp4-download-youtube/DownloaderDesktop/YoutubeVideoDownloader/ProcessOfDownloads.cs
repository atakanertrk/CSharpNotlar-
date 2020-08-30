using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeVideoDownloader
{
    public class ProcessOfDownloads
    {
        public async Task<bool> DownloadAsMp3(string destination, string videoUrl)
        {
            try
            {
                //var youtube = YouTube.Default;
                //var vid = await youtube.GetVideoAsync(videoUrl);
                List<YouTubeVideo> videos = YouTube.Default
               .GetAllVideos(videoUrl)
               .ToList();
                videos = videos
               .Where(v => v.AudioFormat.ToString().ToLower() != "unknown")
               .OrderBy(v => v.AudioBitrate) 
               .ToList();
                var vid = videos.FirstOrDefault();
                File.WriteAllBytes(destination + @"\" + vid.FullName, await vid.GetBytesAsync());
                var inputFile = new MediaFile { Filename = destination + @"\" + vid.FullName };
                var outputFile = new MediaFile { Filename = destination + @"\" + vid.FullName.Remove(vid.FullName.Length - 4) + @".mp3" };
                await Task.Run(() =>
                {
                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                        engine.Convert(inputFile, outputFile);
                    }
                });
                File.Delete(destination + @"\" + vid.FullName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public async Task<bool> DownloadAsMp4(string url, string path,int quality)
        {
            try
            {
                List<YouTubeVideo> videos = YouTube.Default
                    .GetAllVideos(url)
                    .ToList();
                videos = videos
               .Where(v => v.Resolution <= quality && v.AudioFormat.ToString().ToLower()!="unknown")
               .OrderByDescending(v => v.Resolution)
               .ToList();
                var vid = videos.FirstOrDefault();
                File.WriteAllBytes(path + @"\" + vid.FullName, await vid.GetBytesAsync());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

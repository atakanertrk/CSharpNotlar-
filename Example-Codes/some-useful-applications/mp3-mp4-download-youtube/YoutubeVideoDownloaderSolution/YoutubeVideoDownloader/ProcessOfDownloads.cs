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
                var youtube = YouTube.Default;
                var vid = await youtube.GetVideoAsync(videoUrl);
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
                File.Delete(destination + @"\" + vid.FullName); // deleting mp4 file
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public async Task<bool> DownloadAsMp4(string url, string path)
        {
            var youtube = YouTube.Default;
            try
            {
                var video = await youtube.GetVideoAsync(url);
                File.WriteAllBytes(path + @"\" + video.FullName , await video.GetBytesAsync());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

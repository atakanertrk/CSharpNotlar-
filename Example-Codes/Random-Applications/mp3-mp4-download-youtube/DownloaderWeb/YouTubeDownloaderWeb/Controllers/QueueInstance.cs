using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeDownloaderWeb.Controllers
{
    // First in first out
    public class QueueInstance
    {
        private static readonly QueueInstance _instance = new QueueInstance();
        private static List<string> queue = new List<string>();
        private QueueInstance() //constructor
        {
            
        }
        public static QueueInstance GetInstance()
        {
            return _instance;
        }
        public static List<string> GetQueue()
        {
            return queue;
        }
        public static void AddToQueue(string item)
        {
            queue.Add(item);
        }
        public static void DeleteFromQueue()
        {
            queue.RemoveAt(0);
        }
    }
}

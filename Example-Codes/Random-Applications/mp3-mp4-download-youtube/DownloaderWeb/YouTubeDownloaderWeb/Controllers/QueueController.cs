using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YouTubeDownloaderWeb.Models;

namespace YouTubeDownloaderWeb.Controllers
{
    public class QueueController : Controller
    {
        public IActionResult Index()
        {
            QueueModel queueModel = new QueueModel();
            queueModel.itemList = QueueInstance.GetQueue();
            return View(queueModel);
        }
        [HttpPost]
        public IActionResult DeleteFromQueue(QueueModel queueModel)
        {
            QueueInstance.DeleteFromQueue();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult AddToQueue(QueueModel queueModel)
        {
            QueueInstance.AddToQueue(queueModel.item);
            return RedirectToAction("Index");
        }

    }
}

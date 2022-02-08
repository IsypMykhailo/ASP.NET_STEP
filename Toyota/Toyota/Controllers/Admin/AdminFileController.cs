using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Toyota.Controllers.Admin
{
    public class AdminFileController : Controller
    {

        public IActionResult Index()
        {
            string rootDir = Helpers.Media.WebRootStoragePath;
            string curDir = "/";
            ViewBag.currentDir = curDir;
            string[] dirs = Directory.GetDirectories(rootDir);

            for(int i = 0; i < dirs.Length; i++)
            {
                dirs[i] = dirs[i].Replace(Helpers.Media.WebRootStoragePath, "");
            }

            ViewBag.Directories = dirs;
            ViewBag.Files = Directory.GetFiles(rootDir);

            return View();
        }

        
    }
}

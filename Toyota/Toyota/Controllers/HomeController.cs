using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Toyota.Data;
using Toyota.Models;

namespace Toyota.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _context = db;
        }

        public IActionResult Index()
        {
            // Helpers.Notification.Email.SendEmailAsync();
            /*var d = new Helpers.DataBase.Dump.Create();
            d.DumpColors(_context);*/
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Jwt()
        {
            return View();
        }
        public IActionResult Ajax()
        {
            return View();
        }

        public IActionResult Cars()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

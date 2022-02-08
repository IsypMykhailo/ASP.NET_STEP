using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toyota.Controllers.Admin
{
    public class AdminFileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

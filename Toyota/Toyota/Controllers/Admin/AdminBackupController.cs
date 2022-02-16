using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toyota.Data;
using Toyota.Helpers.DataBase.DumpBackups;

namespace Toyota.Controllers.Admin
{
    public class AdminBackupController : Controller
    {
        private readonly ApplicationDbContext _context;
        public readonly DumpDatabase dumpDatabase;

        public AdminBackupController(ApplicationDbContext context)
        {
            _context = context;
            dumpDatabase = new DumpDatabase(_context);
            dumpDatabase.OnBackupCreated += (string message) => Helpers.Notification.Email.SendEmailAsync(message, "backup database", "amazonkanameforme@gmail.com");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Реализация DI
        /// Получение в конструктор контекста на базу данных
        /// </summary>
        /// <param name="context"></param>

        public PortfolioController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Items.Include(p => p.Category);
            return View(await applicationDbContext.ToListAsync());
        }
    }
}

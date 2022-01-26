using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toyota.Data;
using Toyota.Data.Entities;

namespace Toyota.Controllers.Admin
{
    public class AdminCarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminCarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.OpenColors = _context.Colors;
            return View(await _context.Models.ToListAsync());
        }

        public async Task<IActionResult> ModelsModifications(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.OpenModel = _context.Models.First(model => model.Id == id);
            return View(await _context.Modifications
                .Include(modification => modification.ModificationColors)
                .ThenInclude(modificationColor=>modificationColor.Color)
                .Where(mod => mod.ModelId == id).ToListAsync());
        }

        /*
            SELECT * FROM Modification
            JOIN ModificationColors ON Modification.Id = ModificationColors.ModificationId
            JOIN Colors ON ModificationColors.ColorId = Colors.Id
            WHERE Modification.ModelId = [Model.Id]
         */

        public IActionResult CreateModifications()
        {
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Name");
            return View();
        }

        // POST: StandartModifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateModifications([Bind("Id,Slug,Name,ModelId")] Modification modification, IFormFile fileToStorage)
        {
            if (ModelState.IsValid)
            {
                modification.Id = Guid.NewGuid();
                modification.ImgUrl = await Helpers.Media.UploadImage(fileToStorage, "modifications_thumbs");
                _context.Add(modification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Name", modification.ModelId);
            return View(modification);
        }

        // GET: StandartModels/Create
        public IActionResult CreateModels()
        {
            return View();
        }

        // POST: StandartModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateModels([Bind("Id,Slug,Name")] Model model, IFormFile fileToStorage)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _context.Add(model);
                model.ImgUrl = await Helpers.Media.UploadImage(fileToStorage, "models_thumbs");
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: StandartModificationColors/Create
        public IActionResult CreateModificationColors()
        {
            ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Name");
            ViewData["ModificationId"] = new SelectList(_context.Modifications, "Id", "Name");
            return View();
        }

        // POST: StandartModificationColors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateModificationColors([Bind("Id,Slug,ModificationId,ColorId")] ModificationColors modificationColors, IFormFile fileToStorage)
        {
            if (ModelState.IsValid)
            {
                modificationColors.Id = Guid.NewGuid();
                modificationColors.ImgUrl = await Helpers.Media.UploadImage(fileToStorage, "modification_colors_thumbs");
                _context.Add(modificationColors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ColorId"] = new SelectList(_context.Colors, "Id", "Name", modificationColors.ColorId);
            ViewData["ModificationId"] = new SelectList(_context.Modifications, "Id", "Name", modificationColors.ModificationId);
            return View(modificationColors);
        }

        // GET: StandartColors/Create
        public IActionResult CreateColors()
        {
            return View();
        }

        // POST: StandartColors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateColors([Bind("Id,Slug,Name")] Color color, IFormFile fileToStorage)
        {
            if (ModelState.IsValid)
            {
                color.Id = Guid.NewGuid();
                color.ImgUrl = await Helpers.Media.UploadImage(fileToStorage, "colors_thumbs");
                _context.Add(color);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(color);
        }
    }
}

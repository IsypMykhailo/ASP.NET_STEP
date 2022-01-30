using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toyota.Data;
using Toyota.Data.Entities;

namespace Toyota.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetModificationColorsImgController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GetModificationColorsImgController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ModificationColors>>> Get(Guid id)
        {
            /*return await _context.ModificationColors
                .Where(m => m.ModificationId == id)
                .Include(m=>m.Color)
                .Where(m=>m.Color.Id == m.ColorId)
                .ToListAsync();*/
            /*return await _context.ModificationColors
                .Include(m => m.Color)
                .Include(m => m.Modification)
                .FirstOrDefaultAsync(m => m.Id == id);*/
            /*return await _context.Colors
                    .SelectMany(
                        color => color.ModificationColors,
                        (c, mc) => new { Color = c, ModColor = mc })
                    .Where(a => a.ModColor.ModificationId == id)
                    .Select(a => a.Color).ToListAsync();*/
            return await _context.ModificationColors
                    .Where(a => a.ModificationId == id).ToListAsync();
        }
    }
}

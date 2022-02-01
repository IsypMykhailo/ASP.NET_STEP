using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Toyota.Data;
using Toyota.Data.Entities;

namespace Toyota.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreCallBackController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StoreCallBackController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/StoreCallBack
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CallBack>> PostCallBack(CallBack callBack)
        {
            _context.CallBacks.Add(callBack);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCallBack", new { id = callBack.Id }, callBack);
        }

        // DELETE: api/StoreCallBack/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCallBack(Guid id)
        {
            var callBack = await _context.CallBacks.FindAsync(id);
            if (callBack == null)
            {
                return NotFound();
            }

            _context.CallBacks.Remove(callBack);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CallBackExists(Guid id)
        {
            return _context.CallBacks.Any(e => e.Id == id);
        }
    }
}

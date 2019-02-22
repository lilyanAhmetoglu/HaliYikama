using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Haliyikama.Data;
using Haliyikama.Data.Models;

namespace HaliYikamaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IletisimsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IletisimsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Iletisims
        [HttpGet]
        public IEnumerable<Iletisim> GetIletisim()
        {
            return _context.Iletisim;
        }

        // GET: api/Iletisims/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIletisim([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var iletisim = await _context.Iletisim.FindAsync(id);

            if (iletisim == null)
            {
                return NotFound();
            }

            return Ok(iletisim);
        }

        // PUT: api/Iletisims/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIletisim([FromRoute] int id, [FromBody] Iletisim iletisim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != iletisim.IletisimId)
            {
                return BadRequest();
            }

            _context.Entry(iletisim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IletisimExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Iletisims
        [HttpPost]
        public async Task<IActionResult> PostIletisim([FromBody] Iletisim iletisim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Iletisim.Add(iletisim);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIletisim", new { id = iletisim.IletisimId }, iletisim);
        }

        // DELETE: api/Iletisims/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIletisim([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var iletisim = await _context.Iletisim.FindAsync(id);
            if (iletisim == null)
            {
                return NotFound();
            }

            _context.Iletisim.Remove(iletisim);
            await _context.SaveChangesAsync();

            return Ok(iletisim);
        }

        private bool IletisimExists(int id)
        {
            return _context.Iletisim.Any(e => e.IletisimId == id);
        }
    }
}
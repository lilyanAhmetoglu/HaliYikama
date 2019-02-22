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
    public class AyarlarsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AyarlarsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Ayarlars
        [HttpGet]
        public IEnumerable<Ayarlar> GetAyarlar()
        {
            return _context.Ayarlar;
        }

        // GET: api/Ayarlars/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAyarlar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ayarlar = await _context.Ayarlar.FindAsync(id);

            if (ayarlar == null)
            {
                return NotFound();
            }

            return Ok(ayarlar);
        }

        // PUT: api/Ayarlars/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAyarlar([FromRoute] int id, [FromBody] Ayarlar ayarlar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ayarlar.Id)
            {
                return BadRequest();
            }

            _context.Entry(ayarlar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AyarlarExists(id))
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

        // POST: api/Ayarlars
        [HttpPost]
        public async Task<IActionResult> PostAyarlar([FromBody] Ayarlar ayarlar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Ayarlar.Add(ayarlar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAyarlar", new { id = ayarlar.Id }, ayarlar);
        }

        // DELETE: api/Ayarlars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAyarlar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ayarlar = await _context.Ayarlar.FindAsync(id);
            if (ayarlar == null)
            {
                return NotFound();
            }

            _context.Ayarlar.Remove(ayarlar);
            await _context.SaveChangesAsync();

            return Ok(ayarlar);
        }

        private bool AyarlarExists(int id)
        {
            return _context.Ayarlar.Any(e => e.Id == id);
        }
    }
}
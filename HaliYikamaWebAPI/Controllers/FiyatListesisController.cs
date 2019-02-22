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
    public class FiyatListesisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FiyatListesisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/FiyatListesis
        [HttpGet]
        public IEnumerable<FiyatListesi> GetFiyatListesi()
        {
            return _context.FiyatListesi;
        }

        // GET: api/FiyatListesis/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFiyatListesi([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fiyatListesi = await _context.FiyatListesi.FindAsync(id);

            if (fiyatListesi == null)
            {
                return NotFound();
            }

            return Ok(fiyatListesi);
        }

        // PUT: api/FiyatListesis/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFiyatListesi([FromRoute] int id, [FromBody] FiyatListesi fiyatListesi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fiyatListesi.FiyatId)
            {
                return BadRequest();
            }

            _context.Entry(fiyatListesi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FiyatListesiExists(id))
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

        // POST: api/FiyatListesis
        [HttpPost]
        public async Task<IActionResult> PostFiyatListesi([FromBody] FiyatListesi fiyatListesi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FiyatListesi.Add(fiyatListesi);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFiyatListesi", new { id = fiyatListesi.FiyatId }, fiyatListesi);
        }

        // DELETE: api/FiyatListesis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFiyatListesi([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fiyatListesi = await _context.FiyatListesi.FindAsync(id);
            if (fiyatListesi == null)
            {
                return NotFound();
            }

            _context.FiyatListesi.Remove(fiyatListesi);
            await _context.SaveChangesAsync();

            return Ok(fiyatListesi);
        }

        private bool FiyatListesiExists(int id)
        {
            return _context.FiyatListesi.Any(e => e.FiyatId == id);
        }
    }
}
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
    public class AltHizmetsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AltHizmetsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AltHizmets
        [HttpGet]
        public IEnumerable<AltHizmet> GetAltHizmetler()
        {
            return _context.AltHizmetler;
        }

        // GET: api/AltHizmets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAltHizmet([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var altHizmet = await _context.AltHizmetler.FindAsync(id);

            if (altHizmet == null)
            {
                return NotFound();
            }

            return Ok(altHizmet);
        }

        // PUT: api/AltHizmets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAltHizmet([FromRoute] int id, [FromBody] AltHizmet altHizmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != altHizmet.AltHizmetId)
            {
                return BadRequest();
            }

            _context.Entry(altHizmet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AltHizmetExists(id))
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

        // POST: api/AltHizmets
        [HttpPost]
        public async Task<IActionResult> PostAltHizmet([FromBody] AltHizmet altHizmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.AltHizmetler.Add(altHizmet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAltHizmet", new { id = altHizmet.AltHizmetId }, altHizmet);
        }

        // DELETE: api/AltHizmets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAltHizmet([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var altHizmet = await _context.AltHizmetler.FindAsync(id);
            if (altHizmet == null)
            {
                return NotFound();
            }

            _context.AltHizmetler.Remove(altHizmet);
            await _context.SaveChangesAsync();

            return Ok(altHizmet);
        }

        private bool AltHizmetExists(int id)
        {
            return _context.AltHizmetler.Any(e => e.AltHizmetId == id);
        }
    }
}
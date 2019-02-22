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
    public class HizmetsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HizmetsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Hizmets
        [HttpGet]
        public IEnumerable<Hizmet> GetHizmetler()
        {
            return _context.Hizmetler;
        }

        // GET: api/Hizmets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHizmet([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hizmet = await _context.Hizmetler.FindAsync(id);

            if (hizmet == null)
            {
                return NotFound();
            }

            return Ok(hizmet);
        }

        // PUT: api/Hizmets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHizmet([FromRoute] int id, [FromBody] Hizmet hizmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hizmet.HizmetId)
            {
                return BadRequest();
            }

            _context.Entry(hizmet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HizmetExists(id))
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

        // POST: api/Hizmets
        [HttpPost]
        public async Task<IActionResult> PostHizmet([FromBody] Hizmet hizmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Hizmetler.Add(hizmet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHizmet", new { id = hizmet.HizmetId }, hizmet);
        }

        // DELETE: api/Hizmets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHizmet([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hizmet = await _context.Hizmetler.FindAsync(id);
            if (hizmet == null)
            {
                return NotFound();
            }

            _context.Hizmetler.Remove(hizmet);
            await _context.SaveChangesAsync();

            return Ok(hizmet);
        }

        private bool HizmetExists(int id)
        {
            return _context.Hizmetler.Any(e => e.HizmetId == id);
        }
    }
}
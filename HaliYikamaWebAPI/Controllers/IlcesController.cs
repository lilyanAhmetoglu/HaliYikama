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
    public class IlcesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IlcesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Ilces
        [HttpGet]
        public IEnumerable<Ilce> GetIlceler()
        {
            return _context.Ilceler;
        }

        // GET: api/Ilces/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIlce([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ilce = await _context.Ilceler.FindAsync(id);

            if (ilce == null)
            {
                return NotFound();
            }

            return Ok(ilce);
        }

        // PUT: api/Ilces/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIlce([FromRoute] int id, [FromBody] Ilce ilce)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ilce.IlceId)
            {
                return BadRequest();
            }

            _context.Entry(ilce).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IlceExists(id))
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

        // POST: api/Ilces
        [HttpPost]
        public async Task<IActionResult> PostIlce([FromBody] Ilce ilce)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Ilceler.Add(ilce);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIlce", new { id = ilce.IlceId }, ilce);
        }

        // DELETE: api/Ilces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIlce([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ilce = await _context.Ilceler.FindAsync(id);
            if (ilce == null)
            {
                return NotFound();
            }

            _context.Ilceler.Remove(ilce);
            await _context.SaveChangesAsync();

            return Ok(ilce);
        }

        private bool IlceExists(int id)
        {
            return _context.Ilceler.Any(e => e.IlceId == id);
        }
    }
}
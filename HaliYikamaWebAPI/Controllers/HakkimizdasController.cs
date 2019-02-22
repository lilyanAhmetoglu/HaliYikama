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
    public class HakkimizdasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HakkimizdasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Hakkimizdas
        [HttpGet]
        public IEnumerable<Hakkimizda> GetHakkimizda()
        {
            return _context.Hakkimizda;
        }

        // GET: api/Hakkimizdas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHakkimizda([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hakkimizda = await _context.Hakkimizda.FindAsync(id);

            if (hakkimizda == null)
            {
                return NotFound();
            }

            return Ok(hakkimizda);
        }

        // PUT: api/Hakkimizdas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHakkimizda([FromRoute] int id, [FromBody] Hakkimizda hakkimizda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hakkimizda.HakkimizdaId)
            {
                return BadRequest();
            }

            _context.Entry(hakkimizda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HakkimizdaExists(id))
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

        // POST: api/Hakkimizdas
        [HttpPost]
        public async Task<IActionResult> PostHakkimizda([FromBody] Hakkimizda hakkimizda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Hakkimizda.Add(hakkimizda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHakkimizda", new { id = hakkimizda.HakkimizdaId }, hakkimizda);
        }

        // DELETE: api/Hakkimizdas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHakkimizda([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hakkimizda = await _context.Hakkimizda.FindAsync(id);
            if (hakkimizda == null)
            {
                return NotFound();
            }

            _context.Hakkimizda.Remove(hakkimizda);
            await _context.SaveChangesAsync();

            return Ok(hakkimizda);
        }

        private bool HakkimizdaExists(int id)
        {
            return _context.Hakkimizda.Any(e => e.HakkimizdaId == id);
        }
    }
}
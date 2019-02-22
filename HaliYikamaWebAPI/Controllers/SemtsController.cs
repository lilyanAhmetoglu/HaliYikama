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
    public class SemtsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SemtsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Semts
        [HttpGet]
        public IEnumerable<Semt> GetSemtler()
        {
            return _context.Semtler;
        }

        // GET: api/Semts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSemt([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var semt = await _context.Semtler.FindAsync(id);

            if (semt == null)
            {
                return NotFound();
            }

            return Ok(semt);
        }

        // PUT: api/Semts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSemt([FromRoute] int id, [FromBody] Semt semt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != semt.SemtId)
            {
                return BadRequest();
            }

            _context.Entry(semt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SemtExists(id))
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

        // POST: api/Semts
        [HttpPost]
        public async Task<IActionResult> PostSemt([FromBody] Semt semt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Semtler.Add(semt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSemt", new { id = semt.SemtId }, semt);
        }

        // DELETE: api/Semts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSemt([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var semt = await _context.Semtler.FindAsync(id);
            if (semt == null)
            {
                return NotFound();
            }

            _context.Semtler.Remove(semt);
            await _context.SaveChangesAsync();

            return Ok(semt);
        }

        private bool SemtExists(int id)
        {
            return _context.Semtler.Any(e => e.SemtId == id);
        }
    }
}
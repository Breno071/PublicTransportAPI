using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PublicTransportAPI.Data;
using PublicTransportAPI.Models;

namespace PublicTransportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinhaController : ControllerBase
    {
        private readonly PublicTransportAPIContext _context;

        public LinhaController(PublicTransportAPIContext context)
        {
            _context = context;
        }

        // GET: api/Linha
        [HttpGet("{skip:int}/{take:int}")]
        public async Task<ActionResult<IEnumerable<Linha>>> GetLinha(int skip, int take)
        {
          if (_context.Linha == null)
          {
              return NotFound();
          }
            return await _context.Linha
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        // GET: api/Linha/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Linha>> GetLinha(long id)
        {
          if (_context.Linha == null)
          {
              return NotFound();
          }
            var linha = await _context.Linha.FindAsync(id);

            if (linha == null)
            {
                return NotFound();
            }

            return linha;
        }

        // PUT: api/Linha/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLinha(long id, Linha linha)
        {
            if (id != linha.Id)
            {
                return BadRequest();
            }

            _context.Entry(linha).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinhaExists(id))
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

        // POST: api/Linha
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Linha>> PostLinha(Linha linha)
        {
          if (_context.Linha == null)
          {
              return Problem("Entity set 'PublicTransportAPIContext.Linha'  is null.");
          }
            _context.Linha.Add(linha);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLinha", new { id = linha.Id }, linha);
        }

        // DELETE: api/Linha/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLinha(long id)
        {
            if (_context.Linha == null)
            {
                return NotFound();
            }
            var linha = await _context.Linha.FindAsync(id);
            if (linha == null)
            {
                return NotFound();
            }

            _context.Linha.Remove(linha);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LinhaExists(long id)
        {
            return (_context.Linha?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

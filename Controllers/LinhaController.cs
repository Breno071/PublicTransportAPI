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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbLinha>>> GetTbLinhas()
        {
          if (_context.TbLinhas == null)
          {
              return NotFound();
          }
            return await _context.TbLinhas.ToListAsync();
        }

        // GET: api/Linha/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbLinha>> GetTbLinha(long id)
        {
          if (_context.TbLinhas == null)
          {
              return NotFound();
          }
            var tbLinha = await _context.TbLinhas.FindAsync(id);

            if (tbLinha == null)
            {
                return NotFound();
            }

            return tbLinha;
        }

        // PUT: api/Linha/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbLinha(long id, TbLinha tbLinha)
        {
            if (id != tbLinha.LinhaId)
            {
                return BadRequest();
            }

            _context.Entry(tbLinha).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbLinhaExists(id))
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
        public async Task<ActionResult<TbLinha>> PostTbLinha(TbLinha tbLinha)
        {
          if (_context.TbLinhas == null)
          {
              return Problem("Entity set 'PublicTransportAPIContext.TbLinhas'  is null.");
          }
            _context.TbLinhas.Add(tbLinha);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbLinha", new { id = tbLinha.LinhaId }, tbLinha);
        }

        // DELETE: api/Linha/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbLinha(long id)
        {
            if (_context.TbLinhas == null)
            {
                return NotFound();
            }
            var tbLinha = await _context.TbLinhas.FindAsync(id);
            if (tbLinha == null)
            {
                return NotFound();
            }

            _context.TbLinhas.Remove(tbLinha);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbLinhaExists(long id)
        {
            return (_context.TbLinhas?.Any(e => e.LinhaId == id)).GetValueOrDefault();
        }
    }
}

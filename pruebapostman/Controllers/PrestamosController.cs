using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebapostman.Models;

namespace pruebapostman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PrestamosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Prestamos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prestamo>>> GetPrestamo()
        {
            return await _context.Prestamos.ToListAsync();
        }

        // GET: api/Prestamos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prestamo>> GetPrestamo(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);

            if (prestamo == null)
            {
                return NotFound();
            }

            return prestamo;
        }

        // POST: api/Prestamos
        [HttpPost]
        public async Task<ActionResult<Prestamo>> PostPrestamo(Prestamo prestamo)
        {
            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPrestamo), new { id = prestamo.IDPrestamo }, prestamo);
        }

        // PUT: api/Prestamo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrestamo(int id, Prestamo prestamo)
        {
            if (id != prestamo.IDPrestamo)
            {
                return BadRequest();
            }

            _context.Entry(prestamo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrestamoExists(id))
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

        // DELETE: api/Prestamos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrestamo(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null)
            {
                return NotFound();
            }

            _context.Prestamos.Remove(prestamo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrestamoExists(int id)
        {
            return _context.Prestamos.Any(e => e.IDPrestamo == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Valiny.Data;
using Valiny.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Valiny.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EstudiantesController(ApplicationDbContext context)
        {
            this._context = context;
        }

        // GET: api/<EstudiantesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> Get()
        {
            if (_context.Estudiantes == null)
            {
                return NotFound();
            }
            return await _context.Estudiantes.ToListAsync();
        }

        // GET api/<EstudiantesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiante>> Get(int EstudianteId)
        {
            if (_context.Estudiantes == null)
            {
                return NotFound();
            }
            var Estudiante = await _context.Estudiantes.FindAsync(EstudianteId);

            if (Estudiante is null)
            {
                return NotFound();
            }

            return Estudiante;
        }

        // POST api/<EstudiantesController>
        [HttpPost]
        public async Task<ActionResult<Estudiante>> Post([FromBody] Estudiante Estudiante)
        {
            if (_context.Estudiantes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Estudiantes'  is null.");
            }
            _context.Estudiantes.Add(Estudiante);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { EstudianteId = Estudiante.EstudianteId }, Estudiante);
        }

        // PUT api/<EstudiantesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int EstudianteId, [FromBody] Estudiante Estudiante)
        {
            if (EstudianteId != Estudiante.EstudianteId)
            {
                return BadRequest();
            }
            _context.Entry(Estudiante).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!EstudianteExists(EstudianteId))
                {
                    return NotFound();
                }
                else
                {
                    return BadRequest();
                }
            }
            return NoContent();
        }

        private bool EstudianteExists(int estudianteId)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<EstudiantesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int estudianteId)
        {
            if (_context.Estudiantes is null)
            {
                return NotFound();
            }

            var Estudiante = await _context.Estudiantes.FirstOrDefaultAsync(s => s.EstudianteId == estudianteId);
            if (Estudiante == null)
            {
                return NotFound();
            }

            _context.Estudiantes.Remove(Estudiante);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}

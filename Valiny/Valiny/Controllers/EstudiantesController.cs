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
        public async Task<ActionResult<Estudiante>> Get(int ID_Estudiante)
        {
            if (_context.Estudiantes == null)
            {
                return NotFound();
            }
            var supplier = await _context.Estudiantes.FindAsync(ID_Estudiante);

            if (supplier is null)
            {
                return NotFound();
            }

            return supplier;
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
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EstudiantesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

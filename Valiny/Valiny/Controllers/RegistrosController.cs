using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Valiny.Data;
using Valiny.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Valiny.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RegistrosController(ApplicationDbContext context)
        {
            this._context = context;
        }
        // GET: api/<RegistrosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registro>>> Get()
        {
            if (_context.Registros == null)
            {
                return NotFound();
            }
            return await _context.Registros.ToListAsync();
        }

        // GET api/<RegistrosController>/5
        [HttpGet("{RegistroId}")]
        public async Task<ActionResult<Registro>> Get(int RegistroId)
        {
            if (_context.Registros == null)
            {
                return NotFound();
            }
            var Registro = await _context.Registros.FindAsync(RegistroId);

            if (Registro is null)
            {
                return NotFound();
            }

            return Registro;
        }

        // POST api/<RegistrosController>
        [HttpPost]
        public async Task<ActionResult<Registro>> Post([FromBody] Registro Registro)
        {
            if (_context.Registros == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Registro'  is null.");
            }
            _context.Registros.Add(Registro);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { RegistroId = Registro.RegistroId }, Registro);
        }

        // PUT api/<RegistrosController>/5
        [HttpPut("{RegistroId}")]
        public async Task<IActionResult> PutAsync(int RegistroId, [FromBody] Registro Registro)
        {
            if (RegistroId != Registro.RegistroId)
            {
                return BadRequest();
            }
            _context.Entry(Registro).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!RegistroExists(RegistroId))
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

        private bool RegistroExists(int registroId)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<RegistrosController>/5
        [HttpDelete("{RegistroId}")]
        public async Task<IActionResult> Delete(int RegistroId)
        {
            if (_context.Registros is null)
            {
                return NotFound();
            }

            var Registro = await _context.Registros.FirstOrDefaultAsync(s => s.RegistroId == RegistroId);
            if (Registro == null)
            {
                return NotFound();
            }

            _context.Registros.Remove(Registro);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}

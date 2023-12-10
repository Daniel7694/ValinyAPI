using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Valiny.Data;
using Valiny.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Valiny.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrativosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdministrativosController(ApplicationDbContext context)
        {
            this._context = context;
        }
        // GET: api/<AdministrativosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrativo>>> Get()
        {
            if (_context.Administrativos == null)
            {
                return NotFound();
            }
            return await _context.Administrativos.ToListAsync();
        }

        // GET api/<AdministrativosController>/5
        [HttpGet("{AdministrativoId}")]
        public async Task<ActionResult<Administrativo>> Get(int AdministrativoId)
        {
            if (_context.Administrativos == null)
            {
                return NotFound();
            }
            var Administrativo = await _context.Administrativos.FindAsync(AdministrativoId);

            if (Administrativo is null)
            {
                return NotFound();
            }

            return Administrativo;
        }

        // POST api/<AdministrativosController>
        [HttpPost]
        public async Task<ActionResult<Administrativo>> Post([FromBody] Administrativo Administrativo)
        {
            if (_context.Administrativos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Administrativo'  is null.");
            }
            _context.Administrativos.Add(Administrativo);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { AdministrativoId = Administrativo.AdministrativoId}, Administrativo);
        }

        // PUT api/<AdministrativosController>/5
        [HttpPut("{AdministrativoId}")]
        public async Task<IActionResult> PutAsync(int AdministrativoId, [FromBody] Administrativo Administrativo)
        {
            if (AdministrativoId != Administrativo.AdministrativoId)
            {
                return BadRequest();
            }
            _context.Entry(Administrativo).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!AdministrativoExists(AdministrativoId))
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

        private bool AdministrativoExists(int AdministrativoId)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<AdministrativosController>/5
        [HttpDelete("{AdministrativoId}")]
        public async Task<IActionResult> Delete(int AdministrativoId)
        {
            if (_context.Administrativos is null)
            {
                return NotFound();
            }

            var Administrativo = await _context.Administrativos.FirstOrDefaultAsync(s => s.AdministrativoId == AdministrativoId);
            if (Administrativo == null)
            {
                return NotFound();
            }

            _context.Administrativos.Remove(Administrativo);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}

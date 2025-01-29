using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiIosep.Models.Persona.Geo;
using ApiIosep.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaisesController : ControllerBase
    {
        private readonly SqlDBContext _context;

        public PaisesController(SqlDBContext context)
        {
            _context = context;
        }

        // GET: api/Paises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paises>>> GetPais()
        {
            return await _context.Pais.ToListAsync();
        }

        // GET: api/Paises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paises>> GetPaises(int id)
        {
            var paises = await _context.Pais.FindAsync(id);

            if (paises == null)
            {
                return NotFound();
            }

            return paises;
        }

        // GET: api/Paises/Provincias
        [HttpGet("Provincias")]
        public async Task<ActionResult<List<PaisVM>>> GetPaisesConProvincia()
        {
            var paises = await _context.Pais.Where(w => !w.Anulado).OrderBy(o => o.Nombre).ToListAsync();
            var provincias = await _context.Provincia.Where(w => !w.Anulado).OrderBy(o => o.Nombre).ToListAsync();

            if (paises == null)
            {
                return NotFound();
            }

            List<PaisVM> items = new List<PaisVM>();
            foreach (var pais in paises)
            {
                PaisVM item = new PaisVM();
                item.IdPais = pais.IdPais;
                item.Nombre = pais.Nombre.Trim();
                item.Code = pais.Code;
                item.Provincias = provincias.Where(w => w.IdPais == pais.IdPais && !w.Anulado)
                                    .Select(s => new ProvinciaVM { 
                                        IdProvincia = s.IdProvincia,
                                        Nombre = s.Nombre.Trim()
                                    });
                items.Add(item);
            }

            return items;
        }

        // PUT: api/Paises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaises(int id, Paises paises)
        {
            if (id != paises.IdPais)
            {
                return BadRequest();
            }

            _context.Entry(paises).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaisesExists(id))
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

        // POST: api/Paises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Paises>> PostPaises(Paises paises)
        {
            _context.Pais.Add(paises);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaises", new { id = paises.IdPais }, paises);
        }

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaises(int id)
        {
            var paises = await _context.Pais.FindAsync(id);
            if (paises == null)
            {
                return NotFound();
            }

            _context.Pais.Remove(paises);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaisesExists(int id)
        {
            return _context.Pais.Any(e => e.IdPais == id);
        }
    }
}

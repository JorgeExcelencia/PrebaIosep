using Microsoft.AspNetCore.Mvc;
using ApiIosep.Models.Persona;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.Persona.Geo;
using Newtonsoft.Json;
using ApiIosep.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AfiliadosController : ControllerBase
    {
        //private const char DefaultValue = ' ';
        //private readonly IOSEPContext _context;
        //private string? _appName = "";
        private IAfiliadosServices _afiliadosServices;

        public AfiliadosController(IOSEPContext context, IAfiliadosServices afiliadosServices)
        {
            //_context = context;
            //if (!Config.Application.TryGetValue("appName", out _appName))
            //    _appName = "IOSEP";
            _afiliadosServices = afiliadosServices;

        }




        // GET: api/Afiliados/IosepSalud/textoabuscar
        [HttpGet("IosepSalud/{filter}")]
        public async Task<ActionResult<IEnumerable<AfiliadoVM>>> GetAfiliados(string filter)
        {
           var resp = await _afiliadosServices.GetAfiliados(filter);

           return resp;
           
        }

        // GET: api/Afiliados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Afiliado>> GetAfiliados(int id)
        {
            var afiliados = await _afiliadosServices.GetAfiliados(id);
                

            if (afiliados == null)
            {
                return NotFound();
            }

            return afiliados;
        }

        [HttpGet("localidades/{filtro}/{cantidad}/{pagina}")]
        public ActionResult<Localidades?> GetLocalidades(string filtro, int cantidad, int pagina)
        {
            Localidades? item = new();
            using (StreamReader r = new StreamReader("Models/Persona/Geo/Localidades.json"))
            {
                string json = r.ReadToEnd();
                if (json != null)
                    item = JsonConvert.DeserializeObject<Localidades>(json);
            }
            if (item != null && item.localidades != null)
            {
                int pag = pagina - 1;
                filtro = filtro.ToUpper();
                item.localidades = item.localidades.Where(w=>w.nombre.Contains(filtro)).Skip(cantidad * pag).Take(cantidad);
            }
            return item;
        }

        // PUT: api/Afiliados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAfiliados(int id, Afiliado afiliados)
        {
            if (id != afiliados.IdAfiliado)
            {
                return BadRequest();
            }


           var resp = await _afiliadosServices.PutAfiliados(id, afiliados);
            if (resp.Code != 200)
                return NotFound();

            return NoContent();
        }

        // POST: api/Afiliados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Afiliado>> PostAfiliados(Afiliado afiliados)
        //{
        //    _context.Afiliados.Add(afiliados);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAfiliados", new { id = afiliados.IdAfiliado }, afiliados);
        //}

        [HttpGet("IosepSalud/GetGrupoFamiliar/{idAfiliado}")]
        public async Task<ActionResult> GetGrupoFamiliar(int idAfiliado)
        {
            var a = await _afiliadosServices.GetGrupoFamiliar(idAfiliado);
            
            return Ok(a);
        }

        // DELETE: api/Afiliados/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAfiliados(int id)
        //{
        //    var afiliados = await _context.Afiliados.FindAsync(id);
        //    if (afiliados == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Afiliados.Remove(afiliados);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AfiliadosExists(int id)
        //{
        //    return _context.Afiliados.Any(e => e.IdAfiliado == id);
        //}
    }
}

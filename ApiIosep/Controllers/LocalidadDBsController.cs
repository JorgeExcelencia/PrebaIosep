using Microsoft.AspNetCore.Mvc;
using ApiIosep.Models.Persona.Geo;
using Microsoft.AspNetCore.Authorization;
using ApiIosep.Models.IOSEP;
using ApiIosep.Services.Interfaces;

namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LocalidadDBsController : ControllerBase
    {
        private ILocalidadDBServices _localidadDBServices;

        public LocalidadDBsController(ILocalidadDBServices localidadDBServices)
        {
            _localidadDBServices = localidadDBServices;
        }

        // GET: api/LocalidadDBs/5
        [HttpGet("{idProv}")]
        public async Task<ActionResult<IEnumerable<LocalidadVW>>> GetLocalidades(int idProv)
        {
       
          var result = await _localidadDBServices.GetLocalidades(idProv);
            return Ok(result);
        }

        // GET: api/LocalidadDBs/Provincia/5
        [HttpGet("Provincia/{idLocalidad}")]
        public async Task<ActionResult<IEnumerable<LocalidadVW>>> GetLocalidad(int idLocalidad)
        {
          var result = await _localidadDBServices.GetLocalidad(idLocalidad);
 
            return Ok(result);
        }

        // PUT: api/LocalidadDBs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalidadDB(int id, Localidade localidadDB)
        {
            if (id != localidadDB.IdLocalidad)
            {
                return BadRequest();
            }

            var result = await _localidadDBServices.PutLocalidadDB(localidadDB);
            if(result)
                 return NoContent();

            return NotFound();


        }

        // POST: api/LocalidadDBs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LocalidadDB>> PostLocalidadDB(Localidade localidadDB)
        {
            var result = await _localidadDBServices.PostLocalidadDB(localidadDB);
            if (result.IdLocalidad != -1)
                return CreatedAtAction("GetLocalidadDB", new { id = localidadDB.IdLocalidad }, localidadDB);

            return BadRequest();
            

        }

        // DELETE: api/LocalidadDBs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocalidadDB(int id)
        {
            var result = await _localidadDBServices.DeleteLocalidadDB(id);
            if(result)
                return NoContent();

            return BadRequest();
        }

    }
}

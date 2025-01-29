using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ApiIosep.Models.IOSEP;
using ApiIosep.Services.Interfaces;

namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CuotasController : ControllerBase
    {

        private ICuotasServices _cuotasServices;
        public CuotasController(ICuotasServices cuotasServices)
        {
            _cuotasServices = cuotasServices;
        }

        // GET: api/Cuotas
        [HttpGet]
        public async Task<ActionResult<List<IosepSaludHistorialCuota>>> GetCuotas()
        {
            return await _cuotasServices.GetCuotas();
        }

        // GET: api/Cuotas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IosepSaludHistorialCuota>> GetCuotas(int id)
        {
            var cuotas = await _cuotasServices.GetCuota(id);

            if (cuotas == null)
            {
                return NotFound();
            }

            return cuotas;
        }

        // PUT: api/Cuotas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuotas(int id, IosepSaludHistorialCuota cuotas)
        {
            if (id != cuotas.IdIosepSaludHistorialCuotas)
            {
                return BadRequest();
            }

            var resp = await _cuotasServices.PutCuotas(cuotas);
            if(resp)
                return NoContent();
    
            return NotFound();

        }

        // POST: api/Cuotas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IosepSaludHistorialCuota>> PostCuotas(IosepSaludHistorialCuota cuotas)
        {
            var resp = await _cuotasServices.PostCuotas(cuotas);

            if(resp.IdIosepSaludHistorialCuotas != 0)
              return CreatedAtAction("GetCuotas", new { id = cuotas.IdIosepSaludHistorialCuotas }, cuotas);

            return BadRequest();
        }

        // DELETE: api/Cuotas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuotas(int id)
        {
            var cuotas = await _cuotasServices.DeleteCuotas(id);
            if(cuotas)
                return NoContent();
           
            return NotFound();
        }

    }
}

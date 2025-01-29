using ApiIosep.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class IosepSaludController : ControllerBase
    {

        private readonly IIosepSaludServices _iosepSaludServices;

        public IosepSaludController(IIosepSaludServices iosepSaludServices)
        {
            _iosepSaludServices = iosepSaludServices;
        }

        [HttpPut("ActualizarVencimiento")]
        public async Task<IActionResult> SetVencimientoFacturacion(string Periodo, string fecven1, string fecven2, string? obs1, string? obs2, string? obs3, string? lug1, string? lug2)
        {
            var resp = await _iosepSaludServices.SetVencimientoFacturacion(Periodo, fecven1, fecven2, obs1, obs2, obs3, lug1, lug2);
            if (resp.Error)
                return BadRequest(resp.Message);

            return Ok(resp.Message);

        }
        [HttpPut("VerificarVencimientos")]
        public async Task<IActionResult> VerificarVencimientosFacturacion(string Periodo)
        {
            var result = await _iosepSaludServices.VerificarVencimientosFacturacion(Periodo);
            if(result)
                return Ok("OK");

            return BadRequest();
        }

        [HttpGet("GlobalRecibos")]
        public string PrintGlobalRecibos(int Id, string P, string? O1, string? O2, string? O3, string? L1, string? L2, string F1, string F2, string Tipo, byte afecta)
        {

            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                 return _iosepSaludServices.PrintGlobalRecibos(Id, P, O1, O2, O3, L1, L2, F1, F2, Tipo, afecta, identity.Name);
            }
            else
            {
                return "<h3>¡NO SE ENCONTRARON DATOS!</h3>";
            }
        }

    }
}

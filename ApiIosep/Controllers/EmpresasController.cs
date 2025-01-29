using Microsoft.AspNetCore.Mvc;
using ApiIosep.Repositories;
using ApiIosep.Models.CtaCte.Empresa;
using Microsoft.AspNetCore.Authorization;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.StoreProcedures;
using System.Security.Claims;
using ApiIosep.Services.Interfaces;
using Models.Models.DTOs;

namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class EmpresasController : ControllerBase
    {

        private IEmpresasServices _empresasServices;

        public EmpresasController(IEmpresasServices empresasServices)
        {

            _empresasServices = empresasServices;
        }

        // GET: api/Empresas/filter
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<empresa>>> GetEmpresas()
        {
            //return await _context.Empresa.Take(15).OrderBy(o => o.Nombre).ToListAsync();
            return await _empresasServices.GetEmpresas();
        }

        // GET: api/Empresas/filter
        [HttpGet("{filter}")]
        public async Task<ActionResult<IEnumerable<empresa>>> GetEmpresas(string filter)
        {
            try
            {
                filter = filter.ToLower().Trim();
                //var empresas = await _context.Empresa.Where(w => w.Nombre.ToLower().Contains(filter.ToLower())).OrderBy(o => o.Nombre).ToListAsync();
                var empresas = await _empresasServices.GetEmpresas(filter);

                if (empresas == null)
                {
                    return NotFound();
                }
                return empresas;
            }
            catch 
            {
                 return NotFound();
            }

        }



        // GET: api/Empresas/CtaCte
        [HttpGet("CtaCte")]
        public async Task<ActionResult<IEnumerable<EmpresaVW>>> GetEmpCtaCte()
        {

            var empresas = await _empresasServices.GetEmpCtaCte();
            if (empresas == null)
            {
                return NotFound();
            }

            return empresas;
        }

        // DELETE: api/Empresas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpresas(int id)
        {
            var empresas = await _empresasServices.DeleteEmpresas(id);
            if (!empresas)
                 return NotFound();
            
            return NoContent();
        }

        // PUT: api/Empresas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpresas(int id, empresa empre)
        {
            if (id != empre.IdEmpresa)
            {
                return BadRequest();
            }

            empre = await _empresasServices.PutEmpresas(empre);
            if (empre.IdEmpresa != id)
            {
                return BadRequest();
            }

            return CreatedAtAction("GetEmpresas", new { id }, empre);
        }

        // POST: api/Empresas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empresa>> PostEmpresas(empresa empresas)
        {
           empresas = await _empresasServices.PostEmpresas(empresas);
            if(empresas.IdEmpresa == -1)
                return Conflict();

            return CreatedAtAction("GetEmpresas", new { id = empresas.IdEmpresa }, empresas);
        }

        //private bool EmpresasExists(int id)
        //{
        //    return _context.Empresa.Any(e => e.IdEmpresa == id);
        //}


        [HttpGet("validarUsuario")]
        // public async Task<ActionResult<string>> GuardarNotaCredito()

        public async Task<ActionResult<string>> validarUsuario()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity.Name == "20273907646" || identity.Name == "20377368585" || identity.Name == "20443143549" || identity.Name == "20417764888")
            {
                return Ok("ok");
            }
            else
            {
                return NotFound("No autorizado");
            }
        }

        [HttpPut("InformeAfiliados")]
        public async Task<ActionResult<List<ClaseIosepSalud>>> InformePorEmpresasPeriodo([FromBody] InformeAfiliadosRequest request)
        {
           
                if (request.empresaId <= 0 || string.IsNullOrEmpty(request.periodo))
                {
                    return BadRequest(new { message = "Los parámetros no pueden ser nulos o vacíos." });
                }

            var resp = await _empresasServices.InformePorEmpresasPeriodo(request);
            if (!resp.Error)
                return Ok(resp.Data);

            return StatusCode(500, new { message = resp.Message });

        }

        // GET: api/Empresas/empresaId
        [HttpGet("empresaId")]
        public async Task<ActionResult<IEnumerable<empresa>>> GetEmpresasId([FromQuery] int id)
        {
          
           var resp = await _empresasServices.GetEmpresasById(id);
            if (!resp.Error)
                 return NotFound();

            return Ok(resp.Data);

        }

        [HttpPut("imprimirPanel")]
        public async Task<ActionResult> ImprimirPanel([FromBody] ImprimirPanelDTO payload)
        {

            var identity = HttpContext.User.Identity as ClaimsIdentity;
            string UsuarioImprime = identity?.Name ?? "Desconocido";

            var resp = await _empresasServices.ImprimirPanel(payload, UsuarioImprime);

            if (resp.Error)
                return BadRequest(resp.Message);

            return Ok(resp.Data);
        }


        [HttpPut("generarFactura")]
        public async Task<ActionResult> GenerarFacuraIosepSaludEmpresas([FromBody] ImprimirPanelDTO payload)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            string operador = identity?.Name ?? "Sistema";

           var resp = await _empresasServices.GenerarFacuraIosepSaludEmpresas(payload, operador);

            if (resp.Error)
                return BadRequest(resp.Message);

            return Ok(resp.Message);
        }

        [HttpPut("confirmarCambios")]
        public async Task<ActionResult> ConfirmarCambios([FromBody] ImprimirPanelDTO payload)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            string UsuarioImprime = identity?.Name ?? "usuario";

            var resp = await _empresasServices.ConfirmarCambios(payload, UsuarioImprime);

            if (!resp.Error)
            {
                return Ok(resp.Message);
            }
            else
            {
                return NotFound(resp.Message);
            }
        }


        [HttpPut("buscarCuil")]
        public async Task<ActionResult<List<AfiliadoCuil>>> BuscarCuil([FromBody] buscarCuilRequest datos)
        {

          var resp = await _empresasServices.BuscarCuil(datos);

            if (!resp.Error)
            {
                return Ok(resp.Data);
            }
            else
            {
                return NotFound(resp.Message);
            }
        }

    }
}

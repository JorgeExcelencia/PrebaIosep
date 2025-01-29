using Microsoft.AspNetCore.Mvc;
using ApiIosep.Models.CtaCte;
using ApiIosep.Models.CtaCte.MovDet;
using Microsoft.AspNetCore.Authorization;
using ApiIosep.Models.StoreProcedures;
using ApiIosep.Models.IOSEP;
using System.Data;
using System.Security.Claims;
using ApiIosep.Services.Interfaces;
using Models.Models.DTOs;
using Services.Services.Interfaces;


namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ComprobantesController : ControllerBase
    {

        private string? _appName = "";
        private IComprobantesService _comprobantesService;
        private IHubServices _hubServices;
        public ComprobantesController(IComprobantesService comprobantesService, IHubServices hubServices)
        {
            _comprobantesService = comprobantesService;
            _hubServices = hubServices;
        }

        // GET: api/Comprobantes/Afiliado/62608
        [HttpGet("Afiliado/{id}")]
        public async Task<ActionResult<List<ComprobanteVM>>> GetComprobantexAfiliado(int id,[FromQuery] string? desde = "",[FromQuery] string? hasta = "")
        {
            return await _comprobantesService.GetComprobantexAfiliado(id, false, desde, hasta);
        }



        // GET: api/Comprobantes/Viejo/62608
        [HttpGet("Viejo/{id}")]
        public async Task<ActionResult<List<ComprobanteVM>>> GetComprobanteViejoxAfiliado(int id)
        {
            return await _comprobantesService.GetComprobanteViejoxAfiliado(id);
        }

        // GET: api/Comprobantes/DetallesMovimiento
        [HttpGet("DetallesMovimiento/{id}")]
        public async Task<List<DetalleMovimiento>> GetDetallesMovimientos(int id)
        {
            return await _comprobantesService.GetDetallesMovimientos(id);
        }

        // GET: api/Comprobantes/Empresa/62608
        [HttpGet("Empresa/{id}")]
        public async Task<ActionResult<List<ComprobanteVM>>> GetComprobantexEmpresa(int id, [FromQuery] string? desde, [FromQuery] string? hasta)
        {
            return await _comprobantesService.GetComprobantexAfiliado(id, true, desde, hasta);
        }

        // GET: api/Comprobantes/Movimiento
        [HttpGet("Movimiento")]
        public async Task<ActionResult<List<Mov>>> GetMovimientos()
        {
            return await _comprobantesService.GetMovimientos();
        }

        // GET: api/Comprobantes/Movimiento
        [HttpGet("Movimiento/{param}")]
        public async Task<ActionResult<List<Mov>>> GetMovxOpc(string param)
        {
            
            return await _comprobantesService.GetMovxOpc(param);

        }

        // GET: api/Comprobantes/Cuota/262337/202211
        [HttpGet("Cuota/{id}/{periodo}")]
        public async Task<ActionResult<List<CuotaVM>>> GetCuotaxAfiliado(int id, string periodo)
        {

            return await _comprobantesService.GetCuotaxAfiliado(id,periodo);
        }


        [HttpGet("CuotaEmpresa/{id}/{periodo}")]
        public async Task<ActionResult<List<CuotaVM>>> GetCuotaxEmpresa(int id, string periodo)
        {
            return await _comprobantesService.GetCuotaxEmpresa(id,periodo);
        }

        // GET: api/Comprobantes/Imprimir/1
        [HttpGet("Imprimir/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetImprimirxComprobante(int id)
        {


            var comp = await _comprobantesService.GetImprimirxComprobante(id);

            if (comp != "")
            {
                try
                {
                    
                    var resultado = await _hubServices.ImprimirPDF(comp);

                    if (resultado.ContentType == "application/pdf")
                    {
                        Response.Headers.Add("content-disposition",
                            (from x in resultado.ContentHeaders
                             where x.Name == "Content-Disposition"
                             select x.Value!.ToString()).First()
                            );
                        return File(resultado.RawBytes, "application/pdf");
                    }
                }
                catch
                {
                    throw;
                }
            }

            //return null;
            return Ok(null);
        }

        // GET: api/Comprobantes/NotaCredito
        [HttpGet("NotaCredito/{codBarra}")]
        public async Task<ActionResult<List<NotaCredito>>> GetDataInfoReciboAfiliado(string codBarra)
        {

                return await _comprobantesService.GetDataInfoReciboAfiliado(codBarra);

        }

        [HttpGet("NotaCreditoEmpresa/{codBarra}")]
        public async Task<ActionResult<List<NotaCreditoEmpresa>>> GetDataInfoReciboEmpresa(string codBarra)
        {
            return await _comprobantesService.GetDataInfoReciboEmpresa(codBarra);
        }

        [HttpGet("GuardarNotaCredito/{CodigoBarra}/{Json}/{Tipo}/{Observaciones}")]
        public async Task<ActionResult<string>> SetNotadeCredito(string CodigoBarra, string Json, Int16 Tipo, string? Observaciones)
        {
            Observaciones ??= "";

            var cuil = "";
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity.Name != null)
            {
                cuil = identity.Name;
                IEnumerable<Claim> claims = identity.Claims;

                var rol = claims.Where(x => x.Type.Contains("role")).Select(x => x.Value).FirstOrDefault();
            }
            return await _comprobantesService.SetNotadeCredito(CodigoBarra, Json, Tipo, Observaciones, identity.Name);
            
        }


        [HttpGet("AutenticarUsuarioCuota/{usuario}/{contrasena}")]
        public async Task<ActionResult<string>> AutenticarUsuarioCuota(string usuario, string contrasena)
        {
            try
            {
                if (contrasena == "excelencia123")
                    return "Ok";
                else
                    return "No";
            }
            catch
            {
                throw;
            }
        }

        //POST: api/Comprobantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComprobanteP>> PostComprobante(ComprobanteP comprobante)
        {

            var comprobantes = await _comprobantesService.PostComprobante(comprobante);

            return CreatedAtAction("GetComprobantexAfiliado", new { id = comprobante.IdAfiliado }, comprobantes);
        }


        [HttpPost("ComprobanteEmpresa")]
        public async Task<ActionResult<ComprobanteP>> PostComprobanteEmpresa(ComprobanteP comprobante)
        {

            var comprobantes = await _comprobantesService.PostComprobanteEmpresa(comprobante);
            return CreatedAtAction("GetComprobantexEmpresa", new { id = comprobante.IdEmpresa }, comprobantes);
        }
        
        #region Obtener fecha de vencimiento
        [HttpGet("FechasVencimiento/{periodo}")]
        public async Task<ActionResult<DateTime>> FechasVencimiento(string periodo)
        {
            try
            {
                var fechasVencimiento = await _comprobantesService.FechasVencimiento(periodo);

                return Ok(fechasVencimiento);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
        #endregion

        // POST: api/Comprobantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("global/{periodo}/{tipo}")]
        public async Task<ActionResult<List<ComprobanteVM>>> PostGlobal(string periodo, string tipo)
        {
            string sucursal = Config.Application["sucursal"];
            int cantReg = await _comprobantesService.PostGlobal(periodo,tipo, sucursal);

            return Ok($"Se creo: {cantReg.ToString()}");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutComprobantes(int id, comprobante comprobante)
        {
            if (id != comprobante.IdComprobante)
            {
                return BadRequest();
            }

            var resp = await _comprobantesService.PutComprobantes(id, comprobante);
            if(resp.Code != 200)
                return NotFound();

            return NoContent();
        }

        // DELETE: api/Afiliados/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ComprobanteVM>>> DeleteComprobante(int id)
        {
            var resp = await _comprobantesService.DeleteComprobante(id);
            if(resp.Count == 0)
                return NotFound();

            return resp;
        }


        [HttpPut("anularComprobante")]
        public async Task<ActionResult<List<ComprobanteVM>>> AnularComprobanteReporte([FromBody] anularComprobanteRequest request)
        {

            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var resp = await _comprobantesService.AnularComprobanteReporte(request, identity.Name);

            if (resp.Error && resp.Message == "404")
                return NotFound($"Comprobante con ID {request.IdComprobante} no encontrado.");

            if (resp.Error && resp.Message != "404")
                return StatusCode(500, $"Error al anular el comprobante {request.IdComprobante} y el reporte: {resp.Message}");

            return resp.Data;
        }

        [HttpGet("ImprimirPeriodo/{id}/{periodo}")]
        public async Task<ActionResult> GetImprimirPeriodoAfiliado(int id, string periodo)
        {

            var json = await _comprobantesService.GetImprimirPeriodoAfiliado(id, periodo);

            ImprimirPeriodoController hub = new ImprimirPeriodoController();
            var a = await hub.ImprimirPDFPeriodo(json, periodo);
            Response.Headers.Add("Content-disposition", "inline;filename=aplicationempresas.pdf");
            string s = "";
            return File(a.RawBytes, "application/pdf");

        }
    }
}

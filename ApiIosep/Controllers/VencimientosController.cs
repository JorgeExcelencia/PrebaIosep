using Microsoft.AspNetCore.Mvc;
using ApiIosep.Models.CtaCte;
using ApiIosep.Repositories;
using Microsoft.AspNetCore.Authorization;
using ApiIosep.Services.Interfaces;
using ApiIosep.Models.IOSEP;

namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VencimientosController : ControllerBase
    {
        private readonly SqlDBContext _context;
        private readonly IConfiguration _configuration;
        private IVencimientosService _vencimientosService;

        public VencimientosController(SqlDBContext context, IConfiguration con, IVencimientosService vencimientosService)
        {
            _context = context;
            _configuration = con;
            _vencimientosService = vencimientosService;
        }

        // GET: api/Vencimientos
        [HttpGet("{periodo}/{futuros}")]
        public async Task<ActionResult<IEnumerable<VencimientosPeriodosFacturacion>>> GetVencimientos(string periodo, bool futuros)
        {
            return await _vencimientosService.GetVencimientos(periodo, futuros);
        }

        // GET: api/Vencimientos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VencimientosPeriodosFacturacion>> GetVencimientos(int id)
        {
            var vencimientos = await _vencimientosService.GetVencimientos(id);

            if (vencimientos == null)
            {
                return NotFound();
            }

            return vencimientos;
        }

        // GET: api/Vencimientos/Otro/202211
        [HttpGet("Otro/{periodo}")]
        public async Task<ActionResult<VencimientosPeriodosFacturacion>> GetVencxPeriodo(string periodo)
        {
            //using (SqlConnection cx = new SqlConnection(_configuration.GetConnectionString("WebApiDB")))
            //{
            //    SqlCommand cmd = new SqlCommand("select top 1 Vencimiento_1,Vencimiento_2,Renglon_1,Renglon_2,Renglon_3,Lugar_de_pago1,Lugar_de_pago2 from VencimientosPeriodosFacturacion where Anulado = 0 and Periodo =@periodo order by idPeriodo desc", cx);

            //    cmd.Parameters.Add(new SqlParameter("@periodo", SqlDbType.NChar, 6)).Value = periodo;
            //    cx.Open();
            //    var FechaVigencia = await cmd.ExecuteNonQueryAsync();
            //    cx.Close();

            //    // cx.Close();

            //}
            var vencimientos = await _vencimientosService.GetVencxPeriodo(periodo);
            if (vencimientos == null)
            {
                return NotFound();
            }

            return vencimientos;
        }

        // PUT: api/Vencimientos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutVencimientos(VencimientosPeriodosFacturacion vencimientos)
        {

            var resp = await _vencimientosService.PutVencimientos(vencimientos);
            if(resp)
                return NoContent();

            return NotFound();
        
        }

        // POST: api/Vencimientos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vencimientos>> PostVencimientos(VencimientosPeriodosFacturacion vencimientos)
        {
            vencimientos = await _vencimientosService.PostVencimientos(vencimientos);
            if (vencimientos.idPeriodo != 0)
                return BadRequest();

            return CreatedAtAction("GetVencimientos", new { id = vencimientos.idPeriodo }, vencimientos);
        }

        // DELETE: api/Vencimientos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVencimientos(int id)
        {
            var vencimientos = await _vencimientosService.DeleteVencimientos(id);
            if (vencimientos)
                return NotFound();
            
            return NoContent();
        }


        //[HttpPost("Guardar/{periodo}/{vencimiento_1}/{interes_1}/{vencimiento_2}/{interes_2}/{renglon_1}/{renglon_2}/{renglon_3}/{lugar_de_pago1}/{lugar_de_pago2}/{vencimiento_ProntoPago}")]
        //[HttpGet("Guardar/{periodo}/{vencimiento_1}/{interes_1}/{vencimiento_2}/{interes_2}/{renglon_1}/{renglon_2}/{renglon_3}/{lugar_de_pago1}/{lugar_de_pago2}/{vencimiento_ProntoPago}")]
        ////[Route("Grabar")]
        //public async Task<ActionResult> NuevoVencimiento(string periodo, string? vencimiento_1, string? interes_1, string? vencimiento_2, string? interes_2, string? renglon_1, string? renglon_2, string? renglon_3, string? lugar_de_pago1, string? lugar_de_pago2, string? vencimiento_ProntoPago)
        //{
        //    try
        //    {
        //        periodo = periodo.Replace("-", "");
        //        using (SqlConnection cx = new SqlConnection(_configuration.GetConnectionString("WebApiDB")))
        //        {
        //            SqlCommand cmd = new SqlCommand("Insert into VencimientosPeriodosFacturacion (Periodo, Vencimiento_1, interes_1,Vencimiento_2, interes_2, Renglon_1, Renglon_2, Renglon_3, Lugar_de_pago1, Lugar_de_pago2,  Anulado, Vencimiento_ProntoPago, Vencimiento_1_Original, Vencimiento_2_Original) values (@Periodo, @Vencimiento_1, @interes_1,@Vencimiento_2, @interes_2, @Renglon_1, @Renglon_2, @Renglon_3, @Lugar_de_pago1, @Lugar_de_pago2,  @Anulado, @Vencimiento_ProntoPago, @Vencimiento_1_Original, @Vencimiento_2_Original)", cx);
        //            cmd.Parameters.Add(new SqlParameter("@Vencimiento_1", SqlDbType.Date)).Value = vencimiento_1;
        //            cmd.Parameters.Add(new SqlParameter("@Vencimiento_2", SqlDbType.Date)).Value = vencimiento_2;
        //            cmd.Parameters.Add(new SqlParameter("@Vencimiento_ProntoPago", SqlDbType.Date)).Value = vencimiento_ProntoPago;
        //            cmd.Parameters.Add(new SqlParameter("@Interes_1", SqlDbType.NChar, 80)).Value = interes_1;
        //            cmd.Parameters.Add(new SqlParameter("@Interes_2", SqlDbType.NChar, 80)).Value = interes_2;
        //            cmd.Parameters.Add(new SqlParameter("@Renglon_1", SqlDbType.NChar, 80)).Value = renglon_1 != "vacio" ? renglon_1 : "";
        //            cmd.Parameters.Add(new SqlParameter("@Renglon_2", SqlDbType.NChar, 80)).Value = renglon_2 != "vacio" ? renglon_2 : "";
        //            cmd.Parameters.Add(new SqlParameter("@Renglon_3", SqlDbType.NChar, 80)).Value = renglon_3 != "vacio" ? renglon_3 : "";
        //            cmd.Parameters.Add(new SqlParameter("@Lugar_de_pago1", SqlDbType.NChar, 80)).Value = lugar_de_pago1 != "vacio" ? lugar_de_pago1 : "";
        //            cmd.Parameters.Add(new SqlParameter("@Lugar_de_pago2", SqlDbType.NChar, 80)).Value = lugar_de_pago2 != "vacio" ? lugar_de_pago2 : "";
        //            cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.NChar, 6)).Value = periodo;
        //            cmd.Parameters.Add(new SqlParameter("@Anulado", SqlDbType.Bit)).Value = 0;
        //            cmd.Parameters.Add(new SqlParameter("@Vencimiento_1_Original", SqlDbType.Date)).Value = vencimiento_1;
        //            cmd.Parameters.Add(new SqlParameter("@Vencimiento_2_Original", SqlDbType.Date)).Value = vencimiento_2;
        //            cx.Open();
        //            var _a = await cmd.ExecuteNonQueryAsync();
        //            cx.Close();
        //        }
        //        return Ok("OK");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}

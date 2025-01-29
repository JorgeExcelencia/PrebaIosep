using Microsoft.AspNetCore.Mvc;
using ApiIosep.Repositories;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using ApiIosep.Models.IOSEP;
using ApiIosep.Services.Interfaces;
//using System.Data.SqlClient; //los sp daban error en los parametros


namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ImprimirsController : ControllerBase
    {
        private readonly SqlDBContext _context;
        private IImprimirsServices _imprimirsServices;

        public ImprimirsController(SqlDBContext context, IImprimirsServices imprimirsServices)
        {
            _context = context;
            _imprimirsServices = imprimirsServices;
        }

        // GET: api/Imprimirs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Imprimir>>> GetImprimir()
        {
            return await _imprimirsServices.GetImprimir();
        }

        // GET: api/Imprimirs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Imprimir>> GetImprimir(long id)
        {
            var imprimir = await _imprimirsServices.GetImprimir(id);

            if (imprimir == null)
            {
                return NotFound();
            }

            return imprimir;
        }

        // PUT: api/Imprimirs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImprimir(long id, Imprimir imprimir)
        {
            if (id != imprimir.IdImprimir)
            {
                return BadRequest();
            }

            var result = await _imprimirsServices.PutImprimir(imprimir);
            if(result)
             return NoContent();

            return BadRequest();
        }

        // POST: api/Imprimirs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Imprimir>> PostImprimir(Imprimir imprimir)
        {
         
            var result = await _imprimirsServices.PostImprimir(imprimir);

            if(result.Error)
                return BadRequest(result.Message);

            imprimir = result.Data;
            return CreatedAtAction("GetImprimir", new { id = imprimir.IdImprimir }, imprimir);
        }

        // DELETE: api/Imprimirs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImprimir(long id)
        {
            
            var resul = await _imprimirsServices.DeleteImprimir(id);
            if(resul)
                return NoContent();

            return BadRequest();
        }

        [HttpPost ("DetalleCtaCte")]
        public async Task<ActionResult> DetalleCtaCte(int IdAfiliado, string FechaDesde, string FechaHasta, bool Empresa)
        {
            var resultado = await _imprimirsServices.DetalleCtaCte(IdAfiliado, FechaDesde, FechaHasta, Empresa);

            if (resultado.ContentType == "application/pdf")
            {
                Response.Headers.Add("content-disposition",
                    (from x in resultado.ContentHeaders
                     where x.Name == "Content-Disposition"
                     select x.Value!.ToString()).First()
                    );
                return File(resultado.RawBytes, "application/pdf");
            }
            else
            {
                return Ok(resultado.Content);
            }

        }
    }
}

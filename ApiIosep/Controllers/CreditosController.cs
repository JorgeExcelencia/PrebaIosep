using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models.Models.Creditos;
using Models.Models.Creditos.Respuesta;
using Models.Models.DTOs;
using Services.Services.Concrete;
using Models.Models.DTOs.CreditosDTO;
using Services.Services.Interfaces;

namespace ApiIosep.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreditosController : Controller
    {
        private readonly ICreditosService _creditosService;
        private readonly ILogger<CreditosController> _logger;

        public CreditosController(ICreditosService creditosService, ILogger<CreditosController> logger)
        {
            _creditosService = creditosService;
            _logger = logger;
        }

        [HttpGet("buscarLote")]
        public async Task<ActionResult<RespuestaDTO>> BuscarLote(int idLote)
        {
            try
            {
                var resultado = await _creditosService.BuscarCreditoLotePorId(idLote);
                return resultado.Success ? Ok(resultado) : BadRequest(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar lote");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpGet("loteXPeriodo")]
        public async Task<ActionResult<RespuestaDTO>> BuscarLote(string periodo = "012025")
        {
            try
            {
                var resultado = await _creditosService.BuscarCreditoLotePorPeriodo(periodo);
                return resultado.Success ? Ok(resultado) : BadRequest(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar lotes");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpGet("GetDetalleCreditoPorLote")]
        public async Task<ActionResult<RespuestaDTO>> GetDetalleCreditoPorLote(string periodo = "012025", int idConcepto = 630)
        {
            try
            {
                var resultado = await _creditosService.BuscarLotePorPeriodoDetalleCredito(periodo, idConcepto);
                return resultado.Success ? Ok(resultado) : BadRequest(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar lotes");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpPost("crearLote")]
        public async Task<ActionResult<RespuestaIOSEP>> CrearLote([FromBody] CreditosLotesParameter request)
        {
            try
            {
                var resultado = await _creditosService.CrearLote(request);
                return resultado.Error ? BadRequest(resultado) : Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear lote");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpGet("getIDLoteOtorgar")]
        public async Task<IActionResult> getIDLoteOtorgar(string codigoConcepto, string periodo = "012024")
        {
            string estado = "";
            try
            {
                var lote = await _creditosService.GetLoteOtorgamiento(codigoConcepto, periodo);
                if (lote is null)
                {
                    estado = "Lote sin crear";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(lote);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }
        [HttpPost("solicitarCredito")]
        public async Task<ActionResult<RespuestaIOSEP>> SolicitarCredito([FromBody] SolicitudCreditoDto request)
        {
            try
            {
                var credito = await _creditosService.CrearCredito(request);
                return Ok(credito);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("conceptoCredito")]
        public async Task<ActionResult<RespuestaIOSEP>> conceptoCredito()
        {
            try
            {
                var credito = await _creditosService.BuscarConceptoCredito();
                return Ok(credito);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getAfiliado")]
        public async Task<IActionResult> verificarAfiliado(string cuil)
        {
            string estado = "";
            try
            {
                var afiliado = await _creditosService.BuscarAfiliado(cuil);
                if (afiliado.Data.ToString() == "")
                {

                    estado = "El afiliado no se encuentra en el padrón";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(afiliado);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpGet("GetAfiliadoByID")]
        public async Task<IActionResult> GetAfiliadoByID(int idAfiliado = 0)
        {
            try
            {
                var resultado = await _creditosService.GetAfiliadoService(idAfiliado);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al traer datos de afiliado");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpGet("getLugarPago")]
        public async Task<IActionResult> getLugarDePago(string cuil)
        {
            string estado = "";
            try
            {
                var lugarpago = await _creditosService.BuscarLugarDePago(cuil);
                if (lugarpago.Data.ToString() == "")
                {

                    estado = "El afiliado no se encuentra en el padrón";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(lugarpago);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpPost("receive")]
        public async Task<IActionResult> ReceivePayments([FromBody] List<CreditosDetalleParameter> payments)
        {
            try
            {
                var result = await _creditosService.ProcesoPago(payments);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getDetCuota")]
        public async Task<IActionResult> getDetCuota(int IdCredito)
        {
            string estado = "";
            try
            {
                var detCuota = await _creditosService.BuscarDetalleCuotas(IdCredito);

                if (detCuota.Data.ToString() == "")
                {
                    estado = "No se encontraron cuotas pertenecientes al credito";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(detCuota);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpGet("getCreditosAfi")]
        public async Task<IActionResult> getCredito(int IdAfiliado)
        {
            string estado = "";
            try
            {
                var detCuota = await _creditosService.BuscarCreditos(IdAfiliado);

                //if (detCuota.Data.ToString() == "")
                //{
                //    estado = "No se encontraron creditos pertenecientes al afiliado";

                //    return BadRequest(
                //        new
                //        {
                //            activo = false,
                //            estado
                //        });
                //}

                return Ok(detCuota);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpGet("getCredito")]
        public async Task<IActionResult> getCredito(string CodigoCredito)
        {
            string estado = "";
            try
            {
                var detCuota = await _creditosService.BuscarCredito(CodigoCredito);

                if (detCuota.Data.ToString() == "")
                {
                    estado = "No se encontró el credito indicado";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(detCuota);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpPost("getOrdenesCreditoCoseguro")]
        public async Task<IActionResult> getOrdenesCreditoCoseguro([FromBody] CreditosCoseguroOrdenes request)
        {
            string estado = "";
            try
            {
                var detCuota = await _creditosService.GetReportesCoseguroOrdenesAsync(request);

                if (detCuota is null)
                {
                    estado = "No se encontraron creditos pertenecientes al afiliado";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(detCuota);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpPost("grabarOrdenesCreditoCoseguro")]
        public async Task<IActionResult> grabarOrdenesCreditoCoseguro([FromBody] List<CreditosReporteCoseguroOrden> request)
        {
            string estado = "";
            try
            {
                var detCuota = await _creditosService.GrabarCreditosCoseguroOrdenesAsync(request);

                if (detCuota is null)
                {
                    estado = "No se encontraron creditos pertenecientes al afiliado";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(detCuota);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpGet("getSalarioCuil")]
        public async Task<IActionResult> getSalario(string cuil)
        {
            string estado = "";
            try
            {
                var salario = await _creditosService.BuscarSalario(cuil);

                if (salario.Data.ToString() == "")
                {
                    estado = "No se encontró el salario del afiliado indicado";

                    return Ok(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(salario);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpGet("getSalarioID")]
        public async Task<IActionResult> getSalario(int idafiliado)
        {
            string estado = "";
            try
            {
                var salario = await _creditosService.BuscarSalario(idafiliado);

                if (salario.Data.ToString() == "")
                {
                    estado = "No se encontró el salario del afiliado indicado";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }

                return Ok(salario);
            }
            catch (Exception ex)
            {
                return BadRequest(
                 new
                 {
                     activo = false,
                     estado = ex.Message
                 });
            }
        }

        [HttpPost("newSalario")]
        public async Task<ActionResult<RespuestaIOSEP>> CrearSalario(int IdAfiliado, decimal Monto, DateTime Desde)
        {
            try
            {
                var resultado = await _creditosService.NuevoSalario(IdAfiliado, Monto, Desde);
                return resultado.Error ? BadRequest(resultado) : Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al agregar salario");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpPut("editSalario")]
        public async Task<ActionResult<RespuestaIOSEP>> EditarSalario(int IdSalario, decimal Monto, DateTime Hasta)
        {
            try
            {
                var resultado = await _creditosService.EditarSalario(IdSalario, Monto, Hasta);
                return resultado.Error ? BadRequest(resultado) : Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al editar el salario");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpPut("annulSalario")]
        //[Authorize(Roles = "Administrador SC")] 
        public async Task<ActionResult<RespuestaIOSEP>> AnularSalario(int IdSalario)
        {
            try
            {
                var resultado = await _creditosService.AnularSalario(IdSalario);
                return resultado.Error ? BadRequest(resultado) : Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al anular el salario");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpPost("grabarFichacta")]
        public async Task<IActionResult> grabarFichacta([FromQuery] string nombreArchivo, [FromBody] List<string> archivo)
        {
            string estado = "";
            try
            {
                RespuestaIOSEP resp = new RespuestaIOSEP();
                if (archivo == null || !archivo.Any())
                {
                    estado = "No se envió un archivo o el archivo está vacío.";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }
                switch (nombreArchivo)
                {
                    case "FICHACTA":
                        resp = await _creditosService.GrabarFichacta(archivo);
                        break;
                    case "ANEXO":
                        resp = await _creditosService.GrabarAnexo(archivo);
                        break;
                    case "NOEFEC":
                        resp = await _creditosService.GrabarNoefect(archivo);
                        break;
                    default: break;
                }

                if (resp.DescripcionError != string.Empty)
                {
                    estado = "No se envió un archivo o el archivo está vacío.";

                    return BadRequest(
                        new
                        {
                            activo = false,
                            estado
                        });
                }
                else
                    return Ok(resp);
            }
            catch (Exception ex)
            {
                return BadRequest(
                     new
                     {
                         activo = false,
                         estado = ex.Message
                     });
            }

        }
        /// <summary>
        /// estructura para generar archivo de formato TXT.
        /// </summary> 
        /// <param name="formatoArchivo">Formato del archivo, 0 para el formato estándar y 1 para el nuevo formato.</param>
        /// <returns>Devuelve json en formato especificado.</returns> 
        [HttpGet("FormatoArchivo")]
        public async Task<IActionResult> FormatoArchivo(int formatoArchivo = 0, string fechaCrea = "2024-12-30")
        {
            try
            {
                if (formatoArchivo == 0)
                {
                    var resultado = await _creditosService.GenerarCabeceraLote(fechaCrea);
                    if (resultado == null)
                    {
                        return BadRequest(resultado);
                    }
                    return resultado.Any() ? Ok(resultado) : BadRequest(resultado);
                }
                else
                {
                    var resultado = await _creditosService.CabeceraLoteArchivoNuevo();
                    if (resultado == null)
                    {
                        return BadRequest(resultado);
                    }
                    return resultado.Any() ? Ok(resultado) : BadRequest(resultado);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al generar archivo");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpGet("fichaCuentaXPeriodo")]
        public async Task<ActionResult<RespuestaDTO>> fichaCuenta(string periodo = "012024", string nombreArchivo = "FICHACTA", int pageNumber = 1, int pageSize = 20)
        {
            try
            {
                RespuestaDTO resp = new RespuestaDTO();
                switch (nombreArchivo)
                {
                    case "FICHACTA":
                        resp = await _creditosService.BuscarDatosFichaCuenta(periodo, pageNumber, pageSize);
                        break;
                    case "NOEFECT":
                        resp = await _creditosService.BuscarDatosNoEfectuados(periodo, pageNumber, pageSize);
                        break;
                    case "ANEXO":
                        resp = await _creditosService.BuscarDatosAnexo(periodo, pageNumber, pageSize);
                        break;
                    default:
                        break;
                }
                return Ok(resp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("fichaCtaPago")]
        public async Task<IActionResult> fichaCtaPago([FromBody] List<FichactaDto> payments)
        {
            try
            {
                var result = await _creditosService.pagoFichacta(payments);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("migrarDatosSistemaViejo")]
        public async Task<IActionResult> migrarDatosSistemaViejo([FromBody] List<string> payments, bool cabecera = false)
        {
            try
            {
                var result = await _creditosService.GrabarMigracion(payments, cabecera);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("CalcularCuota")]
        public async Task<IActionResult> CalcularCuota(decimal ImporteCredito, decimal ingresoFamiliar)
        {
            try
            {
                var result = await _creditosService.GenerarCuotaPorCredito(ImporteCredito, ingresoFamiliar);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("CalcularCuotaPorImporte")]
        public async Task<IActionResult> CalcularCuotaPorImporte(decimal ImporteCredito = 0, decimal ingresoFamiliar = 0, int cantCuotas = 1)
        {
            try
            {
                var result = await _creditosService.GenerarCuotasPorImporte(ImporteCredito, ingresoFamiliar, cantCuotas);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ConsumirApiDGI")]
        public async Task<IActionResult> ConsumirApiDGI(string cuil)
        {
            try
            {
                var result = await _creditosService.GetConsumoApi(cuil);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Creditos/ImprimirCreditos/1
        [HttpGet("ImprimirCreditos/{id}")]
        public async Task<ActionResult> GetImprimirxCredito(int id)
        {
            var cred = await _creditosService.GetImprimirxCredito(id);

            if (cred != null)
            {
                try
                {
                    if (cred.ContentType == "application/pdf")
                    {
                        Response.Headers.Add("content-disposition",
                            (from x in cred.ContentHeaders
                             where x.Name == "Content-Disposition"
                             select x.Value!.ToString()).First()
                            );
                        return File(cred.RawBytes, "application/pdf");
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

        [HttpGet("GetCreditosNoEfectuadosXFallecimiento")]
        public async Task<IActionResult> GetCreditosXFallecimiento()
        {
            try
            {
                var result = await _creditosService.GetFallecidosNoEfectuados();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
        [HttpPost("CancelarCreditoXFallecimiento")]
        public async Task<IActionResult> CancelarCreditoXFallecimiento(List<CreditosNoEfectuadosDTO> creditosNoEfect)
        {
            try
            {
                var result = await _creditosService.CancelarCreditoFallecido(creditosNoEfect);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpGet("GetCreditosUnificar")]
        public async Task<IActionResult> GetCreditosUnificar(int IdAfiliado = 0)
        {
            try
            {
                var resultado = await _creditosService.GetCreditoUnificar(IdAfiliado);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al unificar créditos");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpPost("CalcularImporteUnificar")]
        public async Task<IActionResult> CalcularImporteUnificar([FromBody] UnificacionCreditosDto request, int cantCuotas)
        {
            try
            {
                var resultado = await _creditosService.CalcularCreditosUnificados(request, cantCuotas);
                return Ok(resultado); 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al unificar créditos");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpPost("UnificarCreditos")]
        public async Task<IActionResult> UnificarCreditos([FromBody] UnificacionCreditosDto credito, decimal importeTotalCredito, int cantCuota, decimal importePorCuota)
        {
            try
            {
                var resultado = await _creditosService.UnificarCreditosService(credito, importeTotalCredito, cantCuota, importePorCuota);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al unificar créditos");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }
        [HttpPost("VincularGarante")]
        public async Task<IActionResult> VincularGarante(int idAfiliadoGarante = 0, int idAfiliadoDeudor = 0)
        {
            try
            {
                var resultado = await _creditosService.VincularGaranteService(idAfiliadoGarante, idAfiliadoDeudor);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al vincular garantes");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpPost("VincularCreditoDeudorGarante")]
        public async Task<IActionResult> VincularCreditoDeudorGarante(int idAfiliadoGarante = 0, int idAfiliadoDeudor = 0, int idCredito = 0)
        {
            try
            {
                var resultado = await _creditosService.VincularCreditoDeudorGaranteService(idAfiliadoGarante, idAfiliadoDeudor, idCredito);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al vincular garantes");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }
        [HttpPost("TransferirCreditoACobranzas")]
        public async Task<IActionResult> TransferirCreditoACobranzas(int idCredito = 0, int idAfiliado = 0)
        {
            try
            {
                var resultado = await _creditosService.TransferirCreditoACobranzasService(idCredito,idAfiliado);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al transferir credito a cobranzas");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        }

        [HttpPost("ActualizarMargenSalarialPorCredito")]
        public async Task<IActionResult> ActualizarMargenSalarialPorCredito(int idCredito = 0, int idAfiliado = 0)
        {
            try
            {
                var resultado = await _creditosService.ActualizarMargenSalarialPorCreditoService(idCredito, idAfiliado);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al transferir credito a cobranzas");
                return StatusCode(500, new RespuestaIOSEP { Error = true, DescripcionError = "Error interno del servidor" });
            }
        } 
    }
}


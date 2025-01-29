using ApiIosep.Models;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.IOSEPweb;
using ApiIosep.Repositorio.Concrete;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Models.Models.Creditos;
using Models.Models.Creditos.Respuesta;
using Models.Models.DTOs;
using Models.Models.DTOs.CreditosDTO;
using Newtonsoft.Json;
using Repository.Repositorio.Interfaces;
using RestSharp;
using Services.Services.Interfaces;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Services.Services.Concrete
{
    public class CreditosService : ICreditosService
    {
        private readonly ICreditosRepository _creditosRepository;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CreditosService> _logger;
        private ILotesRepository _LotesRepository;
        private IAfiliadosRespository _AfiliadosRepository;
        private RestClient client = new RestClient("https://app.iosep.gob.ar/CRWeb/");
        //private RestClient client = new RestClient("http://localhost:62667/");

        public CreditosService(IConfiguration configuration, ICreditosRepository creditosRepository,
            ILogger<CreditosService> logger, ILotesRepository creditosLotesRepository,
            IAfiliadosRespository afiliadosRespository)
        {
            _configuration = configuration;
            _creditosRepository = creditosRepository;
            _logger = logger;
            _LotesRepository = creditosLotesRepository;
            _AfiliadosRepository = afiliadosRespository;
        }

        public async Task<RespuestaDTO> BuscarConceptoCredito()
        {
            var concCredito = await _creditosRepository.GetConceptoCredito();
            return new RespuestaDTO
            {
                Success = true,
                Message = "Concepto creditos",
                Data = concCredito
            };
        }

        public async Task<RespuestaDTO> BuscarCreditoLotePorId(int idCreditoLote)
        {
            try
            {
                var creditoLote = await _creditosRepository.GetCreditosLotesByID(idCreditoLote);

                if (creditoLote is null)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "Datos Lote",
                        Data = "El Lote no fue encontrado"
                    };
                }

                var datos = new
                {
                    creditoLote.Descripcion,
                    creditoLote.PeriodoProcesamiento,
                    creditoLote.OperadorCrea,
                    creditoLote.Anulado
                };

                return new RespuestaDTO
                {
                    Success = true,
                    Message = "Datos Lote",
                    Data = datos
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar crédito lote");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar crédito lote",
                    Data = "Ocurrió un error al buscar el lote"
                };
            }
        }

        public async Task<RespuestaDTO> BuscarCreditoLotePorPeriodo(string periodo)
        {
            try
            {
                var lotes = await _LotesRepository.GetLotesXPeriodoAsync(periodo);
                if (lotes is null)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "Datos Lote",
                        Data = "No se encontraron lotes"
                    };
                }

                return new RespuestaDTO
                {
                    Success = true,
                    Message = "Datos Lotes",
                    Data = lotes
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar crédito lotes");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar crédito lotes",
                    Data = "Ocurrió un error al buscar lotes"
                };
            }
        }

        public async Task<RespuestaDTO> BuscarLotePorPeriodoDetalleCredito(string periodo, int IdConcepto)
        {
            try
            {
                int mes = int.Parse(periodo.Substring(0, 2));
                int anio = int.Parse(periodo.Substring(2, 4));

                DateTime fecha = new DateTime(anio, mes, 1);

                var creditos = await _creditosRepository.GetCreditosPorPeriodo(fecha, IdConcepto);

                if (creditos is null)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "Datos creditos",
                        Data = "No se encontraron creditos"
                    };
                }

                return new RespuestaDTO
                {
                    Success = true,
                    Message = "Datos creditos",
                    Data = creditos
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar creditos");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar crédito ",
                    Data = "Ocurrió un error al buscar"
                };
            }
        }

        public async Task<RespuestaIOSEP> CrearLote(CreditosLotesParameter request)
        {

            string periodoLote = request.PeriodoProcesamiento.ToString("MMyyyy");

            try
            {
                // Si la descripción es válida, crea un único lote
                if (!string.IsNullOrEmpty(request.Descripcion) && request.Descripcion != "0")
                {
                    await CrearLoteYDetalles(request.Descripcion, periodoLote, request.OperadorCrea).ConfigureAwait(false);
                }
                else
                {
                    // Si no hay descripción, crea lotes para cada descripción activa en la tabla
                    var descripcionesCodigos = await _creditosRepository.GetConceptoCredito();

                    foreach (var descripcion in descripcionesCodigos)
                    {
                        var existeLote = await _LotesRepository.GetLotesXPeriodoByCodigo(periodoLote, descripcion.IdConcCred.ToString());
                        if (existeLote.Count == 0)
                        {
                            await CrearLoteYDetalles(descripcion.IdConcCred.ToString(), periodoLote, request.OperadorCrea).ConfigureAwait(false);
                        }
                    }
                }

                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear lote y sus detalles");
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error al crear el lote y sus detalles"
                };
            }
        }

        private async Task CrearLoteYDetalles(string descripcion, string periodoLote, string operadorCrea)
        {
            var creditoLote = new CreditosLotesDTO
            {
                Descripcion = descripcion,
                PeriodoProcesamiento = periodoLote,
                OperadorCrea = operadorCrea,
                Anulado = false
            };
            _LotesRepository.CrearLote(creditoLote);

            var loteCreado = _LotesRepository.GetCreditosLoteByConcepto(creditoLote.PeriodoProcesamiento, creditoLote.Descripcion);
            var creditosLoteDetalles = new CreditosLoteDetallesDTO
            {
                ImporteTotal = 0,
                CantDocumentos = 0,
                IdLote = loteCreado.IdLote,
                Anulado = false
            };
            _LotesRepository.CrearDetalleLote(creditosLoteDetalles);
        }

        public async Task<bool> ValidarInformeSocioEconomico(int IdAfiliado)
        {
            // Implementar lógica para validar el informe socio-económico
            // Retorna true si el afiliado pasa la validación, false en caso contrario
            return true;
        }

        public async Task<RespuestaIOSEP> CrearCredito(SolicitudCreditoDto request)
        {
            int idAfiliado = request.IdAfiliado;
            DateTime fechaActual = DateTime.Now;
            string periodoLote = fechaActual.ToString("MMyyyy");

            // Calcular el importe total
            decimal importeTotal = request.creditoDetalle.Sum(item => item.ImporteCuota);

            // Validar afiliado y su ingreso familiar
            var afiliado = await _AfiliadosRepository.GetAfiliadoById(idAfiliado);
            if (afiliado == null)
                throw new Exception("Afiliado no encontrado");

            var ingresoFamiliar = await _creditosRepository.GetIngresoFamiliarById(idAfiliado);
            if (ingresoFamiliar == null)
                throw new Exception("No posee ingreso familiar disponible");

            if (!await ValidarInformeSocioEconomico(idAfiliado))
                throw new Exception("El afiliado no cumple con los requisitos del informe socioeconómico");

            // Calcular cuotas y costo administrativo
            int cantidadCuotas = CalcularCantidadCuotas(importeTotal, ingresoFamiliar.Monto);
            string formaPago = ""; // Esto no está definido en el código original
            decimal costoAdministrativo = CalcularCostoAdministrativo(importeTotal, formaPago);

            try
            {
                // Obtener el lote de créditos
                var creditoLote = _LotesRepository.GetCreditosLoteByConcepto(periodoLote, request.ConceptoCodigo.ToString());

                CreditosLoteDetalles creditoLoteDetalle = new CreditosLoteDetalles();
                if (creditoLote != null)
                {
                    creditoLoteDetalle = _LotesRepository.GetUltimoLoteDetalleByID(creditoLote.IdLote);
                }

                // Crear el crédito
                CreditosCreditoDTO nuevoCredito = new CreditosCreditoDTO
                {
                    Cuotas = request.creditoDetalle.Length,
                    Denomina = request.Denomina,
                    CodigoCredito = request.ConceptoCodigo.ToString(),
                    IdAfiliado = request.IdAfiliado,
                    ImporteTotal = importeTotal,
                    IdLote = creditoLoteDetalle?.IdLoteDetalle ?? 0,
                    Anulado = false,
                    FechaCrea = fechaActual
                };

                var nuevoid = await _creditosRepository.CrearCredito(nuevoCredito);

                // Crear detalles del crédito
                string periodo = "";
                foreach (var item in request.creditoDetalle)
                {
                    periodo = CalcularPeriodo(nuevoCredito.FechaCrea, int.Parse(item.NroCredito ?? "0"));
                    var detalle = new CreditosDetalleDTO
                    {
                        ImporteCuota = item.ImporteCuota,
                        IdCredito = nuevoid.IdCredito,
                        NroCredito = item.NroCredito ?? "0",
                        Subcodigo = item.Subcodigo,
                        CodMovimiento = item.CodMovimiento ?? "",
                        Anulado = false,
                        Periodo = periodo
                    };
                    _creditosRepository.CrearCreditoDetalle(detalle);
                }
                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear el crédito");
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error al crear el crédito"
                };
            }
        }

        private string CalcularPeriodo(DateTime fechaBase, int incrementoMes)
        {
            int nuevoAño = fechaBase.Year;
            int nuevoMes = fechaBase.Month + incrementoMes;

            // Ajustar el año y el mes si el mes excede 12
            while (nuevoMes > 12)
            {
                nuevoMes -= 12;
                nuevoAño++;
            }
            // Formatear el mes para que siempre tenga dos dígitos
            string nuevoMesFormateado = nuevoMes.ToString("D2");

            // Devolver el período en formato YYYYMM
            return $"{nuevoMesFormateado}{nuevoAño}";
        }



        public async Task<RespuestaDTO> BuscarAfiliado(string cuil)
        {
            try
            {
                var afiliado = await _AfiliadosRepository.GetAfiliadoCreditos(cuil);
              
                if (afiliado == null)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "No se encontró al afiliado",
                        Data = ""
                    };
                }

                var x = new
                {
                    IdAfiliado = afiliado.IdAfiliado,
                    ANumero = afiliado.A_Numero.Trim(),
                    Nombre = afiliado.Nombre.Trim(),
                    Cuil = afiliado.Cuil.Trim(),
                    Documento = afiliado.Documento.Trim(),
                    IdSexo = afiliado.IdSexo,
                    FechadeNacimiento = afiliado.FechadeNacimiento,
                    IdTipoFamiliar = afiliado.IdTipoFamiliar,
                    IdMotivoBaja = afiliado.IdMotivoBaja
                };

                return new RespuestaDTO
                {
                    Success = true,
                    Message = "Datos Afiliado",
                    Data = x
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar afiliado");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar afiliado",
                    Data = ex.Message
                };
            }
        }

        public async Task<RespuestaDTO> BuscarLugarDePago(string cuil)
        {
            try
            {
                List<LugarPagoDTO> listLugarPago = new List<LugarPagoDTO>();
                var respuesta = await GetConsumoApi(cuil);
                var afiliado = await _AfiliadosRepository.GetIdAfiliadoByCuil(cuil);
                var salario = await _creditosRepository.GetIngresoFamiliarByIdAfiliado(afiliado);
                if (salario is not null && respuesta.meta.cantidad != 0)
                {
                    var LugarPagoDGI = await _AfiliadosRepository.GetAportesAfiliado(cuil);
                    foreach (var item in respuesta.data)
                    {
                        var DetalleLugarPagoDGI = await _AfiliadosRepository.GetAportesAfiliadoPorNombre(LugarPagoDGI,item.lugarDePago, item);

                        var respuestaDTO = new LugarPagoDTO
                        { 
                            Control = DetalleLugarPagoDGI.Control,
                            LugarPago = salario.IDLugarDePago,
                            NombreLugar = DetalleLugarPagoDGI.NombreLugar,
                            Planta = DetalleLugarPagoDGI.Planta,
                            ANumero = DetalleLugarPagoDGI.ANumero,
                            Cuil = DetalleLugarPagoDGI.Cuil,
                            Afiliado = DetalleLugarPagoDGI.Afiliado,
                            Otro = DetalleLugarPagoDGI.Otro,
                            NumeroBeneficio = salario.NroControl,
                            Codigo = DetalleLugarPagoDGI.Codigo,
                            CodigoJubilado = DetalleLugarPagoDGI.CodigoJubilado,
                            HaberJubilado = salario.MaximoDescuento,
                            Aporte = salario.HaberSinAportes,
                            ConAporteDescontado = salario.TotalDescuentos,
                            CreditoTomado = DetalleLugarPagoDGI.CreditoTomado,
                            Disponible = DetalleLugarPagoDGI.Disponible,
                        };

                        listLugarPago.Add(respuestaDTO);
                    }
                   
                    return new RespuestaDTO
                    {
                        Success = true,
                        Message = "Datos Lugar de Pago",
                        Data = listLugarPago
                    };
                }

                var LugarPago = await _AfiliadosRepository.GetAportesAfiliado(cuil);


                if (LugarPago == null)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "No se encontró al lugar de pago",
                        Data = ""
                    };
                }
                else
                {
                    if (LugarPago.LugarPago is null || LugarPago.LugarPago.Trim().Equals(""))
                    {
                        var idafiliado = await _AfiliadosRepository.GetIdAfiliadoByCuil(cuil);
                        var idLugarPago = await _AfiliadosRepository.GetLugarPagoJubiladoByIdAfiliado(idafiliado);
                        LugarPago.LugarPago = idLugarPago.IdLugarPago.ToString();
                    }
                    var x = await _AfiliadosRepository.GetAportesJubilado(LugarPago);
                    listLugarPago.Add(x);
                    return new RespuestaDTO
                    {
                        Success = true,
                        Message = "Datos Lugar de Pago",
                        Data = listLugarPago
                    };

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar lugar de pago");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar lugar de pago",
                    Data = ex.Message
                };
            }
        }

        public async Task<RespuestaIOSEP> ProcesoPago(List<CreditosDetalleParameter> payments)
        {
            try
            {
                foreach (var item in payments)
                {
                    string NroCredito = "";
                    switch (item.IdTipoDetalle)
                    {
                        case 2: //Pago Factura Cuota
                            NroCredito = "PA";
                            break;
                        case 4: //Credito Cuota 
                            NroCredito = "NC";
                            break;
                        default:
                            throw new Exception();
                    }
                    var aux = new CreditosDetalleDTO
                    {
                        ImporteCuota = item.ImporteCuota,
                        Saldo = item.Saldo * (-1),
                        IdCredito = item.IdCredito,
                        NroCredito = NroCredito + (item.NroCredito ?? "0"),
                        Subcodigo = item.Subcodigo,
                        CodMovimiento = item.CodMovimiento ?? "",
                        Anulado = false,
                        IdDetalle = item.IdDetalle
                    };
                    _creditosRepository.CrearCreditoDetalle(aux);

                    int idCreditoDetalle = aux.IdDetalleCredito;
                    var pago = new CreditosPagosCredito
                    {
                        IdCreditoDetalle = item.IdDetalleCredito,
                        IdDetalleFactura = idCreditoDetalle,
                        FechaPago = DateTime.Now,
                        Anulado = false
                    };
                    //_dbiosep.Set<CreditosPagosCredito>().Add(pago);
                    CancelarCredito(item.IdCredito);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al generar el pago");

                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error al generar el pago"
                };
            }

            return new RespuestaIOSEP
            {
                Error = false,
                DescripcionError = string.Empty
            };
        }

        private decimal CalcularCostoAdministrativo(decimal monto, string formaDePago)
        {
            if (formaDePago == "Tarjeta")
                return monto * 0.10m; // 10% de costo administrativo para pago con tarjeta
            return 0;
        }

        private async void CancelarCredito(int IdCredito)
        {
            try
            {
                decimal deuda = 0;
                decimal pagado = 0;
                var cuotas = await _creditosRepository.GetDetalleCreditoById(IdCredito);
                //await (from c in _dbiosep.CreditosDetalle where c.IdCredito == IdCredito && !c.Anulado && c.IdDetalle == 0 select c).ToListAsync();
                foreach (var c in cuotas)
                {
                    deuda += c.ImporteCuota;
                    var pagos = await _creditosRepository.GetDetalleCreditoByIdDetalle(c.IdDetalleCredito);
                    //await (from p in _dbiosep.CreditosDetalle where p.IdDetalle == c.IdDetalleCredito && !c.Anulado select p).ToListAsync();
                    foreach (var p in pagos)
                        pagado += p.Saldo;
                }
                if ((deuda + pagado) == 0)
                {
                    var credito = _creditosRepository.GetCreditoByIdCredito(IdCredito);
                    //await (from cr in _dbiosep.CreditosCredito where cr.IdCredito == IdCredito && !cr.Anulado select cr).FirstOrDefaultAsync(); 
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al cancelar el credito");
                throw new Exception();
            }
        }

        public async Task<RespuestaDTO> BuscarDetalleCuotas(int IdCredito)
        {
            try
            {
                var cuotas = await _creditosRepository.GetDetalleCreditoById(IdCredito);
                //await (from c in _dbiosep.CreditosDetalle
                //                where c.IdCredito == IdCredito && !c.Anulado && c.IdDetalle == 0
                //                select c).ToListAsync();

                if (cuotas == null)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "No se encontraron cuotas pertenecientes al credito",
                        Data = ""
                    };
                }
                else
                {
                    List<object> listaDetCuotas = new List<object>();

                    foreach (var c in cuotas)
                    {
                        var pagado = await ImporteCuotaPago(c.IdDetalleCredito);
                        var detCuota = new
                        {
                            IdCredito = c.IdCredito,
                            IdDetalleCredito = c.IdDetalleCredito,
                            SubCodigo = c.Subcodigo,
                            NroCredito = c.NroCredito,
                            CodMovimiento = c.CodMovimiento,
                            ImporteCuota = c.ImporteCuota,
                            Pagado = ((-1) * pagado),
                            Saldo = c.ImporteCuota,
                            Periodo = c.Periodo
                        };
                        listaDetCuotas.Add(detCuota);
                    }

                    return new RespuestaDTO
                    {
                        Success = true,
                        Message = "Datos Cuotas del Credito",
                        Data = listaDetCuotas
                    };

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar cuotas del credito");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar cuotas del credito",
                    Data = ex.Message
                };
            }
        }

        private async Task<decimal> ImporteCuotaPago(int idDetalleCredito)
        {
            return await _creditosRepository.CalcularSaldoCuota(idDetalleCredito);
            // return (from p in _dbiosep.CreditosDetalle where p.IdDetalle == idDetalleCredito && !p.Anulado select p.Saldo).Sum();
            // Realiza la suma en el lado del cliente
        }

        public async Task<RespuestaDTO> BuscarCreditos(int IdAfiliado)
        {
            try
            {
                // Verifica si existen créditos para el afiliado antes de traer todos los datos
                bool existenCreditos = await _creditosRepository.ExisteCreditoByIdAfiliado(IdAfiliado);
                if (!existenCreditos)
                {
                    return new RespuestaDTO
                    {
                        Success = true,
                        Message = "No se encontraron créditos pertenecientes al afiliado",
                        Data = ""
                    };
                }

                var creditos = await _creditosRepository.GetCreditosYDetalleCreditos(IdAfiliado);

                return new RespuestaDTO
                {
                    Success = true,
                    Message = "Datos de los créditos del afiliado",
                    Data = creditos
                };
            }
            catch (SqlException sqlEx)
            {
                _logger.LogError(sqlEx, "Error de base de datos al buscar créditos del afiliado");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error de base de datos al buscar créditos del afiliado",
                    Data = sqlEx.Message
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar créditos del afiliado");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar créditos del afiliado",
                    Data = ex.Message
                };
            }
        }


        public async Task<RespuestaDTO> BuscarCredito(string CodigoCredito)
        {
            try
            {
                var creditos = await _creditosRepository.GetCreditoByConceptoCodigo(CodigoCredito);

                if (creditos == null || creditos.Count == 0)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "No se encontró el crédito indicado",
                        Data = ""
                    };
                }
                else
                {
                    return new RespuestaDTO
                    {
                        Success = true,
                        Message = "Datos del Credito",
                        Data = creditos
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar el credito");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar el credito",
                    Data = ex.Message
                };
            }
        }

        public async Task<List<CreditosReporteCoseguroOrden>> GetReportesCoseguroOrdenesAsync(CreditosCoseguroOrdenes request)
        {
            var result = new List<CreditosReporteCoseguroOrden>();

            int columns = request.IdPrestadores.Count;
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));

            for (int i = 0; i < columns; i++)
            {
                dataTable.Rows.Add(request.IdPrestadores[i]);
            }
            try
            {
                string fechaDesde = request.FechaDesde.ToString();
                fechaDesde = fechaDesde.Substring(0, 10);
                string fechaHasta = request.FechaHasta.ToString();
                fechaHasta = fechaHasta.Substring(0, 10);

                var structure = new SqlParameter
                {
                    ParameterName = "@idPrestadores",
                    SqlDbType = SqlDbType.Structured,
                    TypeName = "dbo.IDList",
                    Value = dataTable
                };

                //_dbiosep.Database.SetCommandTimeout(0);

                //result = await _dbiosep.Set<CreditosReporteCoseguroOrden>()
                //    .FromSqlRaw("EXEC Sp_ReportesCoseguroOrdenesOnLineVariosPrestadores @fechaDesde, @fechaHasta, @tipoOrden, @idPrestadores, @detalle, @idAfiliado",
                //        new SqlParameter("@fechaDesde", fechaDesde),
                //        new SqlParameter("@fechaHasta", fechaHasta),
                //        new SqlParameter("@tipoOrden", request.TipoOrden),
                //        structure,
                //        new SqlParameter("@detalle", request.Detalle),
                //        new SqlParameter("@idAfiliado", request.IdAfiliado))
                //    .ToListAsync();
            }
            catch (Exception e)
            {
                // Log the exception
                // Your exception handling logic
                //return StatusCode(500, "Internal server error");
            }
            return result;
        }

        private DataTable ArrayToDataTable(int[] ids)
        {
            var table = new DataTable();
            table.Columns.Add("ID", typeof(int));

            foreach (var id in ids)
            {
                table.Rows.Add(id);
            }

            return table;
        }

        public async Task<RespuestaIOSEP> GrabarCreditosCoseguroOrdenesAsync(List<CreditosReporteCoseguroOrden> request)
        {
            var dt = new DataTable("CreditosReporteCoseguroOrden");

            dt.Columns.AddRange(new DataColumn[]
            {
            new DataColumn("IdAfiliadoTitular", typeof(int)) { AllowDBNull = false },
            new DataColumn("Numero", typeof(string)) { MaxLength = 50, AllowDBNull = false },
            new DataColumn("Nombre", typeof(string)) { MaxLength = 100, AllowDBNull = false },
            new DataColumn("Cuil", typeof(string)) { MaxLength = 20, AllowDBNull = false },
            new DataColumn("NumeroAfiliado", typeof(string)) { MaxLength = 50, AllowDBNull = false },
            new DataColumn("TipoFamiliar", typeof(string)) { MaxLength = 50, AllowDBNull = false },
            new DataColumn("Titular", typeof(string)) { MaxLength = 100, AllowDBNull = false },
            new DataColumn("CuilTitular", typeof(string)) { MaxLength = 20, AllowDBNull = false },
            new DataColumn("Plan", typeof(string)) { MaxLength = 50, AllowDBNull = false },
            new DataColumn("TipoOrden", typeof(string)) { MaxLength = 50, AllowDBNull = false },
            new DataColumn("Importe", typeof(decimal)) { AllowDBNull = false },
            new DataColumn("Coseguro", typeof(decimal)) { AllowDBNull = false },
            new DataColumn("FechaCrea", typeof(DateTime)) { AllowDBNull = false },
            new DataColumn("Anulado", typeof(bool)) { AllowDBNull = false },
            new DataColumn("CodigoPago", typeof(string)) { MaxLength = 50, AllowDBNull = true },
            new DataColumn("LugarPago", typeof(string)) { MaxLength = 100, AllowDBNull = true },
            new DataColumn("NumeroBeneficio", typeof(string)) { MaxLength = 50, AllowDBNull = true }
            });

            foreach (CreditosReporteCoseguroOrden coseguroOrden in request)
            {
                DataRow row = dt.NewRow();
                row["IdAfiliadoTitular"] = coseguroOrden.IdAfiliadoTitular;
                row["Numero"] = (coseguroOrden.Numero ?? "").Trim();
                row["Nombre"] = (coseguroOrden.Nombre ?? "").Trim();
                row["Cuil"] = (coseguroOrden.Cuil ?? "").Trim();
                row["NumeroAfiliado"] = (coseguroOrden.NumeroAfiliado ?? "").Trim();
                row["TipoFamiliar"] = (coseguroOrden.TipoFamiliar ?? "").Trim();
                row["Titular"] = (coseguroOrden.Titular ?? "").Trim();
                row["CuilTitular"] = (coseguroOrden.CuilTitular ?? "").Trim();
                row["Plan"] = (coseguroOrden.Plan ?? "").Trim();
                row["TipoOrden"] = (coseguroOrden.TipoOrden ?? "").Trim();
                row["Importe"] = coseguroOrden.Importe;
                row["Coseguro"] = coseguroOrden.Coseguro;
                row["FechaCrea"] = coseguroOrden.FechaCrea;
                row["Anulado"] = coseguroOrden.Anulado;
                row["CodigoPago"] = (coseguroOrden.CodigoPago ?? "").Trim();
                row["LugarPago"] = (coseguroOrden.LugarPago ?? "").Trim();
                row["NumeroBeneficio"] = (coseguroOrden.NumeroBeneficio ?? "").Trim();

                dt.Rows.Add(row);
            }
            try
            {
                var mapping = GenerateColumnMappings(dt);
                PerformBulkCopy("CreditosReporteCoseguroOrden", dt, mapping);
            }
            catch (Exception ex)
            {

                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error al generar el pago"
                };
            }
            try
            {

                using (var cx = new SqlConnection(_configuration.GetConnectionString("IOSEP")))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    try
                    {
                        cx.Open();
                        cmd.CommandText = "SP_CreditosGrabarCoseguroOrden";
                        cmd.Parameters.Clear();
                        SqlDataReader reader = await cmd.ExecuteReaderAsync();
                        while (reader.Read())
                        {
                            var numbon = reader.GetDecimal(0);

                            var resul = numbon;
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {

                        return new RespuestaIOSEP
                        {
                            Error = true,
                            DescripcionError = "Ocurrió un error al generar el pago"
                        };
                    }
                }

            }
            catch (Exception ex)
            {

                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error al generar el pago"
                };
            }

            return new RespuestaIOSEP
            {
                Error = false,
                DescripcionError = string.Empty
            };
        }

        public void PerformBulkCopy(string tableName, DataTable dataTable, Dictionary<string, string> columnMappings)
        {
            try
            {
                using (var cx = new SqlConnection(_configuration.GetConnectionString("IOSEP")))
                {
                    cx.Open();

                    // Eliminar los datos existentes de la tabla antes de la inserción masiva
                    using (var deleteCommand = new SqlCommand($"DELETE FROM {tableName}", cx))
                    {
                        deleteCommand.ExecuteNonQuery();
                    }

                    using (var sqlBulkCopy = new SqlBulkCopy(cx))
                    {
                        // Establecer el nombre de la tabla de destino.
                        sqlBulkCopy.DestinationTableName = tableName;

                        // Mapeo de columnas
                        foreach (var mapping in columnMappings)
                        {
                            sqlBulkCopy.ColumnMappings.Add(mapping.Key, mapping.Value);
                        }

                        sqlBulkCopy.BulkCopyTimeout = 0; // Sin límite de tiempo
                        sqlBulkCopy.WriteToServer(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error during bulk copy operation: " + ex.Message, ex);
            }
        }

        public Dictionary<string, string> GenerateColumnMappings(DataTable dataTable)
        {
            var columnMappings = new Dictionary<string, string>();

            // Iterar sobre las columnas del DataTable y crear un mapeo automático
            foreach (DataColumn column in dataTable.Columns)
            {
                // Asumimos que los nombres de las columnas en el DataTable coinciden con los de la tabla en la base de datos
                columnMappings[column.ColumnName] = column.ColumnName;
            }

            return columnMappings;
        }

        public async Task<RespuestaDTO> BuscarSalario(string cuil)
        {
            try
            {
                var idAfiliado = await _AfiliadosRepository.GetIdAfiliadoByCuil(cuil);
                //await (from a in _dbiosep.Afiliados
                //                    where a.Cuil == cuil && !a.Anulado && a.IdMotivoBaja == 0
                //                    select a.IdAfiliado).FirstOrDefaultAsync();

                if (idAfiliado == 0)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "No se encontró el afiliado indicado",
                        Data = ""
                    };
                }
                else
                {
                    return await BuscarSalario(idAfiliado);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar el afiliado");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar el afiliado",
                    Data = ex.Message
                };
            }

        }

        public async Task<RespuestaDTO> BuscarSalario(int idAfiliado)
        {
            try
            {
                var salario = await _creditosRepository.GetIngresoFamiliarById(idAfiliado);
                //await (from s in _dbiosep.CreditosSalarioAfiliado
                //                 where s.IdAfiliado == idAfiliado && !s.Anulado
                //                 select new
                //                 {
                //                     s.IdSalario,
                //                     Monto = (decimal)s.Monto,
                //                     Desde = s.Desde.ToShortDateString(),
                //                     Hasta = s.Hasta.ToShortDateString()
                //                 }).ToListAsync();

                if (salario == null)
                {
                    return new RespuestaDTO
                    {
                        Success = false,
                        Message = "No se encontró el salario del afiliado indicado",
                        Data = ""
                    };
                }
                else
                {
                    return new RespuestaDTO
                    {
                        Success = true,
                        Message = "Datos del Salario del Afiliado",
                        Data = salario
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al buscar el salario");
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Error al buscar el salario",
                    Data = ex.Message
                };
            }
        }

        public async Task<RespuestaIOSEP> NuevoSalario(int IdAfiliado, decimal Monto, DateTime Desde)
        {
            try
            {
                var salarioAfiliado = new CreditosSalarioAfiliadoDTO
                {
                    IdAfiliado = IdAfiliado,
                    Desde = Desde,
                    Hasta = new DateTime(1900, 01, 01),
                    Monto = Monto,
                    FechaCrea = DateTime.Now
                };

                await _creditosRepository.AgregarNuevoIngresoFamiliar(salarioAfiliado);

                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al agregar un nuevo salario al afiliado");
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error al agregar un nuevo salario al afiliado"
                };
            }
        }

        public async Task<RespuestaIOSEP> EditarSalario(int IdSalario, decimal Monto, DateTime Hasta)
        {
            try
            {

                var salarioAfiliado = await _creditosRepository.GetIngresoFamiliarByIdSalario(IdSalario);
                //await _dbiosep.CreditosSalarioAfiliado.FirstOrDefaultAsync(s => s.IdSalario == IdSalario);

                if (salarioAfiliado == null)
                {
                    return new RespuestaIOSEP
                    {
                        Error = true,
                        DescripcionError = "Ocurrió un error al editar el salario del afiliado"
                    };
                }
                _creditosRepository.ActualizarSalarioAfiliado(salarioAfiliado, Monto, Hasta);

                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al editar el salario del afiliado");
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error al editar el salario del afiliado"
                };
            }
        }

        public async Task<RespuestaIOSEP> AnularSalario(int IdSalario)
        {
            try
            {

                var salarioAfiliado = await _creditosRepository.GetIngresoFamiliarByIdSalario(IdSalario);
                //await _dbiosep.CreditosSalarioAfiliado.FirstOrDefaultAsync(s => s.IdSalario == IdSalario);

                if (salarioAfiliado == null)
                {
                    return new RespuestaIOSEP
                    {
                        Error = true,
                        DescripcionError = "Ocurrió un error al anular el salario del afiliado"
                    };
                }
                _creditosRepository.AnularSalarioAfiliado(salarioAfiliado);
                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al anular el salario del afiliado");
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error al anular el salario del afiliado"
                };
            }
        }

        public async Task<RespuestaIOSEP> GrabarFichacta(List<string> archivo)
        {
            try
            {
                // Lista para almacenar los registros procesados
                var registros = new List<CreditosFichactaDTO>();

                foreach (var linea in archivo)
                {
                    try
                    {
                        // Crear un nuevo objeto que represente una línea de texto
                        var registro = new CreditosFichactaDTO
                        {
                            Periodo = linea.Substring(0, 6).Trim(),
                            IdAfiliado = linea.Substring(6, 7).Trim(),
                            Nombre = linea.Substring(13, 30).Trim(),
                            TipoDNI = linea.Substring(43, 1).Trim(),
                            DNI = linea.Substring(44, 8).Trim(),
                            NumBeneficiario = linea.Substring(52, 11).Trim(),
                            LugarPago = linea.Substring(63, 5).Trim(),
                            Estado = linea.Substring(68, 2).Trim(),
                            CodigoCredito = linea.Substring(70, 3).Trim(),
                            SubCodigo = linea.Substring(73, 1).Trim(),
                            NroCredito = linea.Substring(73, 7).Trim(),
                            Cuotas = linea.Substring(80, 3).Trim(),
                            CuotasPendientes = linea.Substring(83, 3).Trim(),
                            Fecha = linea.Substring(86, 8).Trim(),
                            ImporteCuota = decimal.Parse(linea.Substring(94, 7)) / 100,
                            PagoAcumulado = decimal.Parse(linea.Substring(103, 7)) / 100,
                            MontoCredito = linea.Substring(112, 7).Trim()
                        };

                        // Agregar el registro a la lista
                        registros.Add(registro);
                    }
                    catch (Exception ex)
                    {
                        // Manejar líneas problemáticas y continuar con el resto
                        Console.WriteLine($"Error procesando línea: {linea}. Detalle: {ex.Message}");
                    }
                }

                // Guardar todos los registros en la base de datos
                _creditosRepository.GrabarFichacta(registros);

                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error"
                };
            }
        }

        public async Task<RespuestaIOSEP> GrabarAnexo(List<string> archivo)
        {
            try
            {
                // Lista para almacenar los registros procesados
                var registros = new List<CreditosAnexoDTO>();

                foreach (var linea in archivo)
                {
                    try
                    {
                        // Validar la longitud de la línea antes de procesar
                        if (linea.Length < 94)
                        {
                            Console.WriteLine($"Línea inválida: {linea}");
                            continue;
                        }

                        // Crear un nuevo objeto que represente una línea de texto
                        var registro = new CreditosAnexoDTO
                        {
                            Control = linea.Substring(0, 7).Trim(),
                            LugarPago = linea.Substring(7, 5).Trim(),
                            Planta = linea.Substring(13, 1).Trim(),
                            Cuil = linea.Substring(14, 11).Trim(),
                            Dni = linea.Substring(33, 8).Trim(),
                            Nombre = linea.Substring(41, 25).Trim(),
                            Sexo = linea.Substring(67, 1).Trim(),
                            Periodo = linea.Substring(69, 6).Trim(),
                            TotalHaber = decimal.Parse(linea.Substring(75, 9)) / 100,
                            CodigoCred = linea.Substring(82, 3).Trim(),
                            Importe = decimal.Parse(linea.Substring(85, 9)) / 100,
                            Anulado = false,
                            EstadoImporte = false
                        };

                        // Agregar el registro a la lista
                        registros.Add(registro);
                    }
                    catch (Exception ex)
                    {
                        // Manejar errores en una línea específica y continuar
                        Console.WriteLine($"Error procesando línea: {linea}. Detalle: {ex.Message}");
                    }
                }
                _creditosRepository.GrabarAnexo(registros);

                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error"
                };
            }
        }
        public async Task<RespuestaIOSEP> GrabarNoefect(List<string> archivo)
        {
            try
            {

                var creditos = new List<CreditosNoEfectuadosDTO>();
                var credito = new CreditosNoEfectuadosDTO();
                int tempInt;
                foreach (var line in archivo)
                {
                    string nombre = "";
                    string ultimoValor = "";
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 1; i < parts.Length - 1; i++)
                    {
                        if (int.TryParse(parts[i], out tempInt))
                        {

                            ultimoValor = parts[i];
                        }
                        else
                        {
                            nombre = nombre + parts[i] + " ";
                        }
                    }
                    if (parts[0].Length > 5)
                    {
                        credito = new CreditosNoEfectuadosDTO
                        {
                            NroControl = parts[0].Substring(0, 8),
                            LugarPago = parts[0].Substring(8, 5),
                            Planta = parts[0].Substring(13, 1),
                            Cuil = parts[0].Substring(14, 11),
                            A_Numero = int.Parse(parts[0].Substring(25, 7)),
                            Dni = parts[0].Substring(32, 8),
                            Nombre = nombre,
                            Periodo = parts[parts.Length - 1].Substring(0, 6),
                            Codigo = parts[parts.Length - 1].Substring(6, 3),
                            Importe = decimal.Parse(parts[parts.Length - 1].Substring(9, 9)) / 100,
                            NroCuota = parts[parts.Length - 1].Substring(18, 3),
                            TotalCuota = parts[parts.Length - 1].Substring(21, 3),
                            IdMotivo = int.Parse(parts[parts.Length - 1].Substring(24, 1)),
                        };
                    }
                    else
                    {
                        // Crear un nuevo objeto que represente una línea de texto
                        credito = new CreditosNoEfectuadosDTO
                        {
                            LugarPago = parts[0],
                            A_Numero = int.Parse(parts[1]),
                            Nombre = nombre,
                            Periodo = parts[parts.Length - 1].Substring(0, 6),
                            Codigo = parts[parts.Length - 1].Substring(6, 3),
                            Importe = decimal.Parse(parts[parts.Length - 1].Substring(9, 9)) / 100,
                            NroCuota = parts[parts.Length - 1].Substring(18, 3),
                            TotalCuota = parts[parts.Length - 1].Substring(21, 3),
                            IdMotivo = int.Parse(parts[parts.Length - 1].Substring(24, 1)),
                        };
                    }
                    // Guardar cada línea en la base de datos (con Entity Framework)
                    //_dbiosep.CreditosNoEfectuados.Add(credito);

                    creditos.Add(credito);
                }
                _creditosRepository.GrabarNoEfectuados(creditos);

                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error"
                };
            }
        }

        public async Task<List<string>> GenerarCabeceraLote(string fechaCrea)
        {
            DateTime fecha = DateTime.Parse(fechaCrea);

            // Obtiene el año, mes y día
            int anio = fecha.Year;
            int mes = fecha.Month;
            int dia = fecha.Day;
            string mesPeriodo = mes.ToString();
            if (mesPeriodo.Length == 1)
            {
                mesPeriodo = "0" + mes.ToString();
            }

            string periodo = dia.ToString() + mes.ToString();
            try
            {
                var cabecera = await _LotesRepository.GetCabeceraLoteAsync();
                var conceptosCred = await _creditosRepository.GetConceptoCredito();

                var resultList = new List<CabeceraLoteDto>();
                var detalleDto = new DetalleLoteDto();

                int nroPaquete = 1;
                foreach (var item in conceptosCred)
                {
                    decimal importe = 0;
                    var creditos = await _creditosRepository.GetCreditosPorPeriodo(fecha, item.IdConcCred);

                    if (creditos != null)
                    {
                        var cabeceraDto = new CabeceraLoteDto
                        {
                            Identif = "ID",
                            Nropaq = nroPaquete.ToString().PadLeft(3, '0'),
                            Credito = item.IdConcCred.ToString().PadLeft(3, '0'),
                            Mes = mesPeriodo,
                            Anio = anio.ToString(),
                            Cantdoc = creditos.Count.ToString().PadLeft(3, '0') ?? "000",
                            Totimpcu = "0",
                            Cantotcu = creditos.Count.ToString().PadLeft(3, '0') ?? "000",
                            Imptotcr = "0",
                            detalleLote = new List<DetalleLoteDto>()
                        };

                        var resultDetalle = new List<CabeceraLoteDto>();

                        for (int i = 0; i < creditos.Count; i += 2)
                        {
                            // Accedemos al primer detalle (afiliado 1)
                            var detalle1 = creditos[i];

                            // Verificamos si existe un segundo detalle (afiliado 2)
                            if (i + 1 >= creditos.Count)
                            {
                                // Si no existe un segundo afiliado, salteamos esta iteración
                                continue;
                            }

                            var A_Num = await _AfiliadosRepository.GetAfiliadoById(creditos[i].IdAfiliado);
                            var A_Num2 = await _AfiliadosRepository.GetAfiliadoById(creditos[i + 1].IdAfiliado);
                            var aux = (creditos[i].ImporteTotal * 100).ToString("F0").PadLeft(8, '0');
                            var aux2 = creditos[i].ImporteTotal.ToString().PadLeft(8, '0');
                            detalleDto = new DetalleLoteDto
                            {
                                Identif = "IC",
                                Nropaq = nroPaquete.ToString().PadLeft(3, '0'),
                                Credito = item.IdConcCred.ToString().PadLeft(3, '0'),
                                Mes = mesPeriodo,
                                Anio = anio.ToString().Substring(2, 2),
                                Nroafil = A_Num.A_Numero.Trim().ToString().PadLeft(7, '0'),
                                Nrocred = creditos[i].IdCredito.ToString().PadLeft(7, '0'),
                                Codmov = "3",
                                Dias = dia.ToString(),
                                Cantcuot = creditos[i].Cuotas.ToString().PadLeft(3, '0'),
                                Impcuota = ((creditos[i].ImporteTotal / (creditos[i].Cuotas == 0 ? 1 : creditos[i].Cuotas))).ToString("F0").PadLeft(8, '0'),
                                Nroafil2 = A_Num2.A_Numero.Trim().ToString().PadLeft(7, '0'),
                                Nrocred2 = creditos[i + 1].IdCredito.ToString().PadLeft(7, '0'),
                                Codmov2 = "3",
                                Dias2 = dia.ToString(),
                                Cantcuot2 = creditos[i + 1].Cuotas.ToString().PadLeft(3, '0'),
                                Impcuota2 = ((creditos[i + 1].ImporteTotal / (creditos[i + 1].Cuotas == 0 ? 1 : creditos[i + 1].Cuotas)) * 100).ToString("F0").PadLeft(8, '0')
                            };

                            cabeceraDto.detalleLote.Add(detalleDto);
                            importe = importe + creditos[i + 1].ImporteTotal + creditos[i].ImporteTotal;

                        }
                        cabeceraDto.Imptotcr = (importe * 100).ToString("F0").PadLeft(10, '0');
                        cabeceraDto.Totimpcu = (importe * 100).ToString("F0").PadLeft(10, '0');

                        resultList.Add(cabeceraDto);

                    }
                    nroPaquete = nroPaquete + 1;

                }
                if (cabecera == null)
                {
                    return new List<string>();
                }

                int indicePaquete = 1;
                foreach (var item in cabecera)
                {
                    if (int.TryParse(item.Nropaq, out int number))
                    {
                        number = indicePaquete;
                        var resultDetalle = await DetalleLote(number, 200).ConfigureAwait(false);
                        indicePaquete++;
                        var arregloTotal = item.Totimpcu.Split('.');
                        var arregloImporte = item.Imptotcr.Split('.');
                        // Llenamos el DTO
                        var cabeceraDto = new CabeceraLoteDto
                        {
                            Identif = item.Identif,
                            Nropaq = item.Nropaq,
                            Credito = item.Credito,
                            Mes = item.Mes,
                            Anio = item.Anio.Substring(2, 2),
                            Cantdoc = item.Cantdoc,
                            Totimpcu = (arregloTotal[0] + arregloTotal[1]).PadLeft(10, '0'),
                            Cantotcu = item.Cantotcu.PadLeft(5, '0'),
                            Imptotcr = (arregloImporte[0] + arregloImporte[1]).PadLeft(10, '0'),
                            detalleLote = new List<DetalleLoteDto>()
                        };

                        for (int i = 0; i < resultDetalle.Count; i += 2)
                        {
                            // Accedemos al primer detalle (afiliado 1)
                            var detalle1 = resultDetalle[i];

                            // Verificamos si existe un segundo detalle (afiliado 2)
                            if (i + 1 >= resultDetalle.Count)
                            {
                                // Si no existe un segundo afiliado, salteamos esta iteración
                                continue;
                            }

                            var detalle2 = resultDetalle[i + 1];
                            var arregloImpcuota = detalle1.Impcuota.Split('.');
                            var arregloImpcuota2 = detalle2.Impcuota.Split('.');

                            detalleDto = new DetalleLoteDto
                            {
                                Identif = detalle1.Identif,
                                Nropaq = detalle1.Nropaq,
                                Credito = detalle1.Credito,
                                Mes = detalle1.Mes,
                                Anio = detalle1.Anio.Substring(2, 2),
                                Nroafil = detalle1.Nroafil,
                                Nrocred = detalle1.Nrocred.PadLeft(7, '0'),
                                Codmov = detalle1.Codmov,
                                Dias = detalle1.Dias,
                                Cantcuot = detalle1.Cantcuot,
                                Impcuota = (arregloImpcuota[0] + arregloImpcuota[1]).PadLeft(8, '0'),
                                Nroafil2 = detalle2.Nroafil ?? string.Empty,
                                Nrocred2 = detalle2.Nrocred.PadLeft(7, '0') ?? string.Empty,
                                Codmov2 = detalle2.Codmov ?? string.Empty,
                                Dias2 = detalle2.Dias ?? string.Empty,
                                Cantcuot2 = detalle2.Cantcuot ?? string.Empty,
                                Impcuota2 = (arregloImpcuota2[0] + arregloImpcuota2[1]).PadLeft(8, '0') ?? string.Empty
                            };
                            cabeceraDto.detalleLote.Add(detalleDto);
                        }
                        resultList.Add(cabeceraDto);
                    }
                }
                List<string> txtInformation = new List<string>();
                foreach (var item in resultList)
                {
                    txtInformation.Add(
                        GenerateHeaderTxtInformationLine(item));

                    var parallelOptions = new ParallelOptions
                    {
                        MaxDegreeOfParallelism = 6 // Cambia este valor al número de hilos que desees
                    };

                    // Usamos ConcurrentBag para almacenar resultados temporalmente
                    var bag = new ConcurrentBag<string>();

                    Parallel.ForEach(item.detalleLote, parallelOptions, itemDetalle =>
                    {
                        bag.Add(
                            GenerateDetailTxtInformationLine(itemDetalle)); // Agregamos a la ConcurrentBag
                    });

                    // Después del procesamiento paralelo, transferimos los elementos de la bag a la lista
                    txtInformation.AddRange(bag);

                }
                return txtInformation;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al generar el archivo");
                return new List<string>();
            }
        }

        private static string GenerateHeaderTxtInformationLine(CabeceraLoteDto header)
        {
            string concat = $"{header.Identif}{header.Nropaq}{header.Credito}{header.Mes}" +
                            $"{header.Anio}{header.Cantdoc}{header.Totimpcu}{header.Cantotcu}" +
                            $"{header.Imptotcr}";
            return concat;
        }

        private static string GenerateDetailTxtInformationLine(DetalleLoteDto detail)
        {
            string concat = $"{detail.Identif}{detail.Nropaq}{detail.Credito}{detail.Mes}{detail.Anio}{detail.Nroafil}" +
                            $"{detail.Nrocred}{detail.Codmov}{detail.Dias}{detail.Cantcuot} {detail.Impcuota}{detail.Nroafil2}" +
                            $"{detail.Nrocred2}{detail.Codmov2}{detail.Dias2}{detail.Cantcuot2} {detail.Impcuota2}";

            return concat;
        }

        public async Task<List<CabeceraLoteArchivoNuevoDTO>> CabeceraLoteArchivoNuevo()
        {
            try
            {
                var aportes = await _creditosRepository.GetAllCreditos();
                //        await _dbiosep.CreditosCredito
                //      .AsNoTracking()
                //        .Select(a => new
                //        {
                //            a.IdAfiliado,
                //            a.ImporteTotal,
                //            a.Cuotas,
                //            a.FechaCrea
                //        })
                // .ToListAsync()
                //.ConfigureAwait(false);

                var resultList = new List<CabeceraLoteArchivoNuevoDTO>();
                foreach (var aporte in aportes)
                {
                    resultList.Add(new CabeceraLoteArchivoNuevoDTO
                    {
                        Planta = "P",  // Asigna el valor de planta
                        Control = aporte.IdAfiliado.ToString(), // Asigna el valor de control
                        Codigo = "630",
                        Importe = aporte.ImporteTotal,
                        Cuotas = aporte.Cuotas,
                        Novedad = "",
                        Mes = 01,
                        Anio = 24
                    });
                }

                return resultList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al anular el salario del afiliado");
                return null;
            }
        }

        public Task<List<ResultadoOrdenCoseguro>> DetalleLote(int pageNumber, int pageSize)
        {
            return _creditosRepository.GetDetalleLote(pageNumber, pageSize);
        }
        public async Task<RespuestaDTO> BuscarDatosFichaCuenta(string periodo, int pageNumber, int pageSize)
        {
            var respuesta = await _creditosRepository.BuscarDatosFichaCuenta(periodo, pageNumber, pageSize);

            return new RespuestaDTO
            {
                Success = true,
                Message = "Ficha cuenta por periodo",
                Data = respuesta
            };
        }

        public async Task<RespuestaDTO> BuscarDatosNoEfectuados(string periodo, int pageNumber, int pageSize)
        {
            var credFichacta = await _creditosRepository.BuscarDatosNoEfectuados(periodo, pageNumber, pageSize);
            return new RespuestaDTO
            {
                Success = true,
                Message = "Ficha cuenta por periodo",
                Data = credFichacta
            };
        }
        public async Task<RespuestaDTO> BuscarDatosAnexo(string periodo, int pageNumber, int pageSize)
        {
            var credFichacta = _creditosRepository.BuscarDatosAnexo(periodo, pageNumber, pageSize);
            return new RespuestaDTO
            {
                Success = true,
                Message = "Ficha cuenta por periodo",
                Data = credFichacta
            };
        }

        public async Task<RespuestaIOSEP> pagoFichacta(List<FichactaDto> payments)
        {
            try
            {
                foreach (var item in payments)
                {
                    int numCuota = (int.Parse(item.Cuotas) - int.Parse(item.CuotasPendientes));
                    var afiliado = await _AfiliadosRepository.GetIdAfiliadoByAnumero(int.Parse(item.IdAfiliado));
                    if (afiliado is not null)
                    {
                        var credCredito = await _creditosRepository.GetCreditoByNroCreditoMigracion(item.NroCredito, afiliado.IdAfiliado);

                        if (credCredito is null)
                        {
                            credCredito = await _creditosRepository.GetCreditoByIdCredito(int.Parse(item.NroCredito));
                        }
                        if (credCredito is null)
                            throw new Exception("detalle de credito no encontrado");
                        var pagoFichacta = await _creditosRepository.GetDetalleCreditoByIdYNumCuota(credCredito.IdCredito, numCuota.ToString());
                        var impactarCredito = await _creditosRepository.GetDatoFichaCta(item);

                        if (pagoFichacta != null && impactarCredito != null)
                        {
                            _creditosRepository.ImpactarPagoFichacta(pagoFichacta, impactarCredito, item.ImporteCuota);
                        }
                    }
                }

                return new RespuestaIOSEP
                {
                    Error = false,
                    DescripcionError = string.Empty
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al generar el pago");

                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = ex.Message
                };
            }

            return new RespuestaIOSEP
            {
                Error = false,
                DescripcionError = string.Empty
            };
        }

        public async Task<RespuestaIOSEP> GrabarMigracion(List<string> archivo, bool Cabecera = false)
        {
            try
            {
                var resultList = new List<CreditosHcablTcrDTO>();
                if (Cabecera)
                {
                    foreach (var linea in archivo)
                    {
                        // Crear un nuevo objeto que represente una línea de texto
                        CreditosHcablTcrDTO registro = new CreditosHcablTcrDTO
                        {
                            Identif = linea.Substring(0, 2),
                            Nropaq = linea.Substring(2, 3),
                            Credito = linea.Substring(5, 3),
                            Mes = linea.Substring(8, 2),
                            Anio = linea.Substring(10, 4),
                            Cantdoc = linea.Substring(14, 3),
                            Totimpcu = linea.Substring(18, 10),
                            Cantocu = linea.Substring(29, 5),
                            Impotctr = linea.Substring(34, 10),
                            Identific = linea.Substring(45, 6),
                            Iden_fecha = linea.Substring(51, 8),
                            Iden_hora = linea.Substring(59, 8),
                            Error1 = "",
                            Error2 = "",
                            Error3 = "",
                            Error4 = "",
                            Error9 = "",
                            Fecproc = linea.Substring(70, 7)
                        };
                        // Guardar cada línea en la base de datos (con Entity Framework)
                        resultList.Add(registro);
                    }

                    Console.WriteLine("Pausa");

                    // Guardar los cambios en la base de datos
                    _creditosRepository.GrabarMigracion(resultList);

                    return new RespuestaIOSEP
                    {
                        Error = false,
                        DescripcionError = string.Empty
                    };

                }
                else
                {
                    foreach (var linea in archivo)
                    {
                        // Crear un nuevo objeto que represente una línea de texto
                        CreditosHlotEcrd registro = new CreditosHlotEcrd
                        {
                            Identif = linea.Substring(0, 2),
                            Nropaq = linea.Substring(2, 3),
                            Credito = linea.Substring(5, 3),
                            Mes = linea.Substring(8, 2),
                            Anio = linea.Substring(10, 4),
                            Nroafil = linea.Substring(14, 7),
                            Subcod = "",
                            Nrocred = linea.Substring(21, 7),
                            Codmov = linea.Substring(28, 1),
                            Dias = linea.Substring(29, 2),
                            Cantcuot = linea.Substring(31, 3),
                            Signo = "",
                            Impcuota = linea.Substring(35, 10),
                            Identific = linea.Substring(45, 6),
                            Iden_fecha = linea.Substring(51, 8),
                            Iden_hora = linea.Substring(60, 7),
                            Error1 = "",
                            Fecproc = linea.Substring(67, 8)
                        };

                        // Guardar cada línea en la base de datos (con Entity Framework)
                        //_dbiosep.CreditosHlotEcrd.Add(registro);
                    }

                    Console.WriteLine("Pausa");

                    // Guardar los cambios en la base de datos
                    //await _dbiosep.SaveChangesAsync();

                    return new RespuestaIOSEP
                    {
                        Error = false,
                        DescripcionError = string.Empty
                    };
                }
            }
            catch (Exception ex)
            {
                return new RespuestaIOSEP
                {
                    Error = true,
                    DescripcionError = "Ocurrió un error"
                };
            }
        }
        public async Task<RespuestaDTO> GenerarCuotaPorCredito(decimal ImporteCredito, decimal ingresoFamiliar)
        {
            try
            {
                int cantCuotas = CalcularCantidadCuotas(ImporteCredito, ingresoFamiliar);
                List<CuotasDisponibles> listaCuota = new List<CuotasDisponibles>();
                for (int i = 3; i < cantCuotas; i = i + 3)
                {
                    CuotasDisponibles cuotasdisp = new CuotasDisponibles
                    {
                        cantidadCuota = i,
                        importePorCuota = ImporteCredito / i,
                    };
                    listaCuota.Add(cuotasdisp);
                }

                return new RespuestaDTO
                {
                    Success = true,
                    Message = "Listado de cuotas",
                    Data = listaCuota
                };
            }
            catch (Exception ex)
            {
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Ocurrió un error"
                };
            }
        }
        public async Task<RespuestaDTO> GenerarCuotasPorImporte(decimal ImporteCredito, decimal ingresoFamiliar, int cantCuotas)
        {
            try
            {

                // decimal cuotaMaxima = sueldo * 0.40m;
                var alicuota = (decimal)Math.Ceiling(((double)(ImporteCredito) * 1.10));
                var cuotaCredito = (int)Math.Ceiling(alicuota / cantCuotas);
                CuotasDisponibles cuotasdisp = new CuotasDisponibles
                {
                    cantidadCuota = cantCuotas,
                    importePorCuota = cuotaCredito,
                    ImporteTotalSinInteres = ImporteCredito,
                    ImporteTotalConInteres = alicuota,
                };

                return new RespuestaDTO
                {
                    Success = true,
                    Message = "informe de cuotas",
                    Data = cuotasdisp
                };
            }
            catch (Exception ex)
            {
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Ocurrió un error"
                };
            }
        }
        public async Task<RespuestaDTO> GetLoteOtorgamiento(string conceptoCredito, string periodo)
        {
            try
            {

                var lote = await _LotesRepository.GetLotesXPeriodoXConcepto(conceptoCredito, periodo);
                return new RespuestaDTO
                {
                    Success = true,
                    Message = "lote por periodo",
                    Data = lote
                };
            }
            catch (Exception ex)
            {
                return new RespuestaDTO
                {
                    Success = false,
                    Message = "Ocurrió un error"
                };
            }
        }

        public async Task<Root?> GetConsumoApi(string cuil)
        {
            string baseUrl = "http://iosep.dgipse.gob.ar";
            string apiKey = "DGISEIOSEP_SantiagoDelEstero_n2seA_j6lbA_r1seM_m8seJ_a3lbJ_l8seF_r6lbI";

            try
            {
                // Generar el token
                var obtenerTokenResponse = await ObtenerToken(baseUrl, apiKey);
                string token = obtenerTokenResponse.Token;
                if (!string.IsNullOrEmpty(token))
                {
                    Console.WriteLine($"Token generado: {token}");

                    // Consultar el CUIL con el token generado
                    var respuesta = await ConsultarCuil(baseUrl, token, cuil);
                    if (!string.IsNullOrEmpty(respuesta.data.ToString()))
                    {
                        // Serializar la respuesta a JSON y devolverla
                        var resultJson = JsonConvert.SerializeObject(respuesta);
                        return respuesta;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ObtenerTokenResponse> ObtenerToken(string baseUrl, string apiKey)
        {
            string url = $"{baseUrl}/log";
            var client = new RestClient(url);
            var request = new RestRequest
            {
                Method = Method.Post // Especificar el método HTTP aquí
            };
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"apiKey={apiKey}", ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonObject = JsonConvert.DeserializeObject<ObtenerTokenResponse>(response.Content);

                return jsonObject;
            }
            return null;
        }
        private async Task<Root?> ConsultarCuil(string baseUrl, string token, string cuil)
        {

            string url = $"{baseUrl}/cuil/{cuil}";
            var client = new RestClient(url);
            var request = new RestRequest
            {
                Method = Method.Get // Especificar el método HTTP aquí
            };
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", token);
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonObject = JsonConvert.DeserializeObject<Root>(response.Content);
                var res = await grabarInfoDGI(jsonObject);
                return jsonObject;
            }
            return null;
        }

        public async Task<string> grabarInfoDGI(Root infoDGI)
        {
            foreach (var item in infoDGI.data)
            {
                var afiliado = _AfiliadosRepository.GetIdAfiliadoByCuil(item.cuil).Result;
                var actualizado = _creditosRepository.CompararIngresoFamiliar(afiliado, item).Result;
                if (actualizado != null)
                {
                    var salarioAfiliado = _creditosRepository.GetIngresoFamiliarByIdSalario(actualizado.IdSalario).Result;
                    if (salarioAfiliado is null)
                    {
                        var salarioAfiliadoDGI = new CreditosSalarioAfiliadoDTO
                        {
                            IdAfiliado = afiliado,
                            Desde = DateTime.Now,
                            Hasta = new DateTime(1900, 01, 01),
                            Monto = item.maximoDescuento,

                            NroControl = item.nroControl,
                            IDLugarDePago = item.lugarDePago,
                            Antiguedad = item.antiguedad,
                            HaberConAportes = Decimal.Parse(item.haberesConAportes) / 100,
                            HaberSinAportes = Decimal.Parse(item.haberesSinAportes) / 100,
                            TotalDescuentos = Decimal.Parse(item.totalDescuentos) / 100,
                            Liquido = Decimal.Parse(item.liquido) / 100,
                            MaximoDescuento = item.maximoDescuento,
                            FechaCrea = DateTime.Now,
                            UsuarioCrea = "UsuarioSistema",
                            Anulado = false,
                            FechaAnula = new DateTime(1900, 01, 01),
                            UsuarioAnula = string.Empty
                        };
                        await _creditosRepository.AgregarNuevoIngresoFamiliarDGI(salarioAfiliadoDGI);
                    }
                    else
                    {
                        _creditosRepository.ActualizarSalarioAfiliadoDGI(salarioAfiliado, item);
                    }
                }
                else
                {
                    var salarioAfiliado = _creditosRepository.GetIngresoFamiliarByIdAfiliado(afiliado).Result;
                    if (salarioAfiliado is null)
                    {
                        var salarioAfiliadoDGI = new CreditosSalarioAfiliadoDTO
                        {
                            IdAfiliado = afiliado,
                            Desde = DateTime.Now,
                            Hasta = new DateTime(1900, 01, 01),
                            Monto = item.maximoDescuento,

                            NroControl = item.nroControl,
                            IDLugarDePago = item.lugarDePago,
                            Antiguedad = item.antiguedad,
                            HaberConAportes = Decimal.Parse(item.haberesConAportes) / 100,
                            HaberSinAportes = Decimal.Parse(item.haberesSinAportes) / 100,
                            TotalDescuentos = Decimal.Parse(item.totalDescuentos) / 100,
                            Liquido = Decimal.Parse(item.liquido) / 100,
                            MaximoDescuento = item.maximoDescuento,
                            FechaCrea = DateTime.Now,
                            UsuarioCrea = "UsuarioSistema",
                            Anulado = false,
                            FechaAnula = new DateTime(1900, 01, 01),
                            UsuarioAnula = string.Empty
                        };
                        await _creditosRepository.AgregarNuevoIngresoFamiliarDGI(salarioAfiliadoDGI);
                    }
                }
            }
            return "";
        }
        private int CalcularCantidadCuotas(decimal monto, decimal sueldo)
        {
            // La cuota no debe superar el 25% del sueldo
            decimal cuotaMaxima = sueldo * 0.40m;
            return (int)Math.Ceiling(monto / cuotaMaxima);
        }

        public async Task<RestResponse> GetImprimirxCredito(int id)
        {
            var movi = await _creditosRepository.GetCreditosAsync(id);

            string json = System.Text.Json.JsonSerializer.Serialize(movi);

            var request = new RestRequest("api/imprimirCreditos", Method.Post)
                .AddHeader("Content-Type", "application/json")
                .AddParameter("application/json", json, ParameterType.RequestBody);

            return await client.ExecuteAsync(request);
        }

        public async Task<RespuestaDTO> CancelarCreditoFallecido(List<CreditosNoEfectuadosDTO> creditosNoEfect)
        {
            var resCreditoNoEfect = await _creditosRepository.CancelarCreditosAfiliado(creditosNoEfect);
            return new RespuestaDTO
            {
                Success = true,
                Message = "CreditosCancelados",
                Data = resCreditoNoEfect
            };
        }
        public async Task<List<CreditosNoEfectuadosDTO>> GetFallecidosNoEfectuados()
        {
            List<CreditosNoEfectuadosDTO> creditosNoEfect = new List<CreditosNoEfectuadosDTO>();
            var resCreditoNoEfect = _creditosRepository.BuscarDatosNoEfectuadosXFallecidos();
            foreach (var item in resCreditoNoEfect.Result)
            {
                var Fallecido = new CreditosNoEfectuadosDTO
                {
                    NroControl = item.NroControl,
                    LugarPago = item.LugarPago,
                    Planta = item.Planta,
                    Cuil = item.Cuil,
                    A_Numero = item.A_Numero,
                    Dni = item.Dni,
                    Nombre = item.Nombre,
                    Periodo = item.Periodo,
                    Codigo = item.Codigo,
                    Importe = item.Importe,
                    NroCuota = item.NroCuota,
                    TotalCuota = item.TotalCuota,
                    IdMotivo = item.IdMotivo
                };
                creditosNoEfect.Add(Fallecido);
            }
            return creditosNoEfect;
        }
        public async Task<RespuestaDTO> CalcularCreditosUnificados(UnificacionCreditosDto request, int cantCuotas)
        {
            decimal importeCuotasPendientes = 0;
            foreach (var item in request.Creditos)
            {
                if (!item.Cancelado && !item.Anulado)
                {
                    var importe = await _creditosRepository.CalcularImporteCuotasPendientes(item);
                    importeCuotasPendientes += importe;
                }
            }
            var alicuota = (decimal)Math.Ceiling(((double)(importeCuotasPendientes) * 1.10));
            var cuotaCredito = (int)Math.Ceiling(alicuota / cantCuotas);
            CuotasDisponibles cuotasdisp = new CuotasDisponibles
            {
                cantidadCuota = cantCuotas,
                importePorCuota = cuotaCredito,
                ImporteTotalSinInteres = importeCuotasPendientes,
                ImporteTotalConInteres = alicuota,
            };

            return new RespuestaDTO
            {
                Success = true,
                Message = "Calculo de Creditos Unificados",
                Data = cuotasdisp
            };
        }
        public async Task<RespuestaDTO> GetCreditoUnificar(int idAfiliado)
        {
            var listadoCreditos = await _creditosRepository.GetListCreditosByIdAfiliado(idAfiliado);


            return new RespuestaDTO
            {
                Success = true,
                Message = "CreditosCancelados",
                Data = listadoCreditos
            };
        }
        public async Task<RespuestaDTO> UnificarCreditosService(UnificacionCreditosDto ListaCredito, decimal importeCredito, int cantCuota, decimal importePorCuota)
        {
            var creditoUnificado = await _creditosRepository.GetAllCreditos();


            var item = ListaCredito.Creditos[0];
            var creditoDTO = new CreditosCreditoDTO
            {
                Cuotas = cantCuota,
                ImporteTotal = importeCredito,
                Denomina = item.Denomina,
                CodigoCredito = item.CodigoCredito,
                IdAfiliado = item.IdAfiliado,
                FormaPago = 0,
                FechaCrea = DateTime.Now,
                Anulado = false,
                Cancelado = false
            };

            var creditoCreado = await _creditosRepository.CrearCredito(creditoDTO);

            var periodo = "";
            for (int i = 1; i <= cantCuota; i++)
            {
                periodo = CalcularPeriodo(creditoCreado.FechaCrea, int.Parse(i.ToString() ?? "0"));
                var creditoDetalleDTO = new CreditosDetalleDTO
                {
                    IdDetalle = ListaCredito.Creditos[0].IdCredito,
                    NroCredito = i.ToString(),
                    CodMovimiento = "3",
                    ImporteCuota = importePorCuota,
                    Periodo = periodo,
                    Subcodigo = "Credito unificado",
                    IdCredito = creditoCreado.IdCredito
                };
                _creditosRepository.CrearCreditoDetalle(creditoDetalleDTO);
            }
            var cancelarCredito = await _creditosRepository.CancelarCreditoPorUnificar(ListaCredito);
            return new RespuestaDTO
            {
                Success = true,
                Message = "Credito Unificado",
                Data = ""
            };
        }

        public async Task<RespuestaDTO> VincularGaranteService(int idAfiliadoGarante, int idAfiliadoDeudor)
        {
            await _creditosRepository.AgregarNuevoGarante(idAfiliadoGarante, idAfiliadoDeudor, "");
            return new RespuestaDTO
            {
                Success = true,
                Message = "Credito Unificado",
                Data = ""
            };
        }

        public async Task<RespuestaDTO> VincularCreditoDeudorGaranteService(int idAfiliadoGarante, int idAfiliadoDeudor, int idCredito)
        {
            var existe = await _creditosRepository.ExisteGarante(idAfiliadoGarante, idAfiliadoDeudor);
            if (!existe)
            {
                await _creditosRepository.AgregarNuevoGarante(idAfiliadoGarante, idAfiliadoDeudor, "");
            }
            var detalleCredito = await _creditosRepository.GetDetalleCreditoById(idCredito);
            var solicitudCredito = new SolicitudCreditoDto
            {
                IdAfiliado = idAfiliadoGarante,
                ConceptoCodigo = 630,
                Denomina = "SERV. ASISTENCIAL",
                creditoDetalle = detalleCredito
                .Where(item => item.Saldo == 0)
                .Select(item => new CreditoDetalleDto
                {
                    Subcodigo = "Credito deudor",
                    NroCredito = item.NroCredito,
                    CodMovimiento = "3",
                    ImporteCuota = item.ImporteCuota
                }).ToArray()
            };
            // Llamar al servicio CrearCredito
            var respuestaCrearCredito = await CrearCredito(solicitudCredito);

            var detalle = _creditosRepository.CancelarCreditoPorVincularDeudor(idCredito, "Cancelado por vinculo garante");

            return new RespuestaDTO
            {
                Success = true,
                Message = "Credito Unificado con Garante",
                Data = ""
            };
        }
        public async Task<RespuestaDTO> GetAfiliadoService(int idAfiliado)
        {
            var datos = await _creditosRepository.GetAfiliadoByID(idAfiliado);
            return new RespuestaDTO
            {
                Success = true,
                Message = "Datos de afiliado",
                Data = datos
            };
        }
        public async Task<RespuestaDTO> TransferirCreditoACobranzasService(int idCredito, int idAfiliado)
        {
            var detalleCredito = await _creditosRepository.GetDetalleCreditoById(idCredito);
            var solicitudCredito = new SolicitudCreditoDto
            {
                IdAfiliado = idAfiliado,
                ConceptoCodigo = 650,
                Denomina = "EXTRAJUDICIAL",
                creditoDetalle = detalleCredito
                    .Where(item => item.Saldo == 0)
                    .Select(item => new CreditoDetalleDto
                    {
                        Subcodigo = "CEXT",
                        NroCredito = item.NroCredito,
                        CodMovimiento = "3",
                        ImporteCuota = item.ImporteCuota
                    }).ToArray()
            };
            // Llamar al servicio CrearCredito
            var respuestaCrearCredito = await CrearCredito(solicitudCredito);

            var detalle = _creditosRepository.CancelarCreditoPorVincularDeudor(idCredito, "Cancelado a cobranza Extra Judicial");
            return new RespuestaDTO
            {
                Success = true,
                Message = "cobranza Extra Judicial",
                Data = ""
            };
        }
        public async Task<RespuestaDTO> ActualizarMargenSalarialPorCreditoService(int idCredito, int idAfiliado)
        {
            var credito = await _creditosRepository.GetCreditoByIdCredito(idCredito);
            var detalle = await _creditosRepository.GetDetalleCreditoByIdYNumCuota(idCredito, "1");
            var salario = await _creditosRepository.GetIngresoFamiliarByIdAfiliado(idAfiliado);
            if (salario != null)
            {
                if (salario.MaximoDescuento > detalle.ImporteCuota)
                {
                    salario.MaximoDescuento = salario.MaximoDescuento - detalle.ImporteCuota;
                    salario.Monto = salario.Monto - detalle.ImporteCuota;
                } 
                _creditosRepository.ActualizarMargenSalarialJubilado(salario);
            }
            return new RespuestaDTO
            {
                Success = true,
                Message = "margen salarial actualizado",
                Data = ""
            };
        }
    }
}


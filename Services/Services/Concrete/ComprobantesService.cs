using ApiIosep.Models.CtaCte;
using ApiIosep.Models.CtaCte.MovDet;
using ApiIosep.Models.StoreProcedures;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;
using System.Data;
using System.Xml;
using ApiIosep.Models.DTOs;
using ApiIosep.Models.IOSEP;
using Microsoft.EntityFrameworkCore;
using ApiIosep.Models;
using Models.Models.DTOs;
using Newtonsoft.Json;

namespace ApiIosep.Services.Concrete
{
    public class ComprobantesService : IComprobantesService
    {
        private IStoredProceduresIOSEPRepository _storedProceduresIOSEPRepository;
        private IcomprobanteRepository _comprobanteRepository;
        private IUnitOfWork _unitOfWork;
        private IVencimientosPeriodosFacturacionRepository _vencimientosPeriodosFacturacionRepository;
        private IAfiliadosRespository _afiliadosRespository;
        private IComprobanteDetalleRepository _comprobanteDetalleRepository;
        private IReportesIosepSaludRepository _reportesIosepSaludRepository;
        private ITools _tools;
        public ComprobantesService(IStoredProceduresIOSEPRepository storedProceduresIOSEPRepository, IcomprobanteRepository comprobanteRepository, IUnitOfWork unitOfWork, IVencimientosPeriodosFacturacionRepository vencimientosPeriodosFacturacionRepository, IAfiliadosRespository afiliadosRespository, IComprobanteDetalleRepository comprobanteDetalleRepository, IReportesIosepSaludRepository reportesIosepSaludRepository, ITools tools)
        {
            _storedProceduresIOSEPRepository = storedProceduresIOSEPRepository;
            _comprobanteRepository = comprobanteRepository;
            _unitOfWork = unitOfWork;
            _vencimientosPeriodosFacturacionRepository = vencimientosPeriodosFacturacionRepository;
            _afiliadosRespository = afiliadosRespository;
            _comprobanteDetalleRepository = comprobanteDetalleRepository;
            _reportesIosepSaludRepository = reportesIosepSaludRepository;
            _tools = tools;
        }

        public async Task<List<ComprobanteVM>> GetComprobantexAfiliado(int id, bool esEmpresa = false, string? desde = "", string? hasta = "")
        {
            string param = esEmpresa ? "IdEmpresa" : "IdAfiliado";
            string fechaActual = DateTime.Now.ToString("yyyyMM");
            string fechaHaceUnAnio = DateTime.Now.AddYears(-1).ToString("yyyyMM");

            var PeriodoDesde =  desde == "" ? fechaHaceUnAnio : desde;
            var PeriodoHasta = hasta == "" ? fechaActual : hasta;
            var result = new List<ComprobanteVM>();
            try
            {
                result = await _storedProceduresIOSEPRepository.ctacte_resumen(id, esEmpresa, PeriodoDesde, PeriodoHasta);
                if (result.Count <= 1)
                {
                    result = await _storedProceduresIOSEPRepository.ctacte_resumenAfiliadosEmpresa(param, id);
                    return result;
                }
                
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public async Task<List<ComprobanteVM>> GetComprobanteViejoxAfiliado(int id) 
        {
            var result = new List<ComprobanteVM>();
            try
            {
                result = await _storedProceduresIOSEPRepository.ctacte_sistemaviejo(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public async Task<List<DetalleMovimiento>> GetDetallesMovimientos(int id)
        {
            var result = new List<DetalleMovimiento>();
            try
            {
                result = await _storedProceduresIOSEPRepository.ctacte_resumenDetalleComp(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public async Task<List<Mov>> GetMovimientos()
        {
            List<Mov> result = new List<Mov>();

            try
            {
                var comprobante = await _storedProceduresIOSEPRepository.getMovimientos();
                if (comprobante != null)
                {
                    //Genero relación padre e hijo.
                    int ultID = -1;
                    foreach (var debe in comprobante)
                    {
                        if (ultID != debe.IdTipoMovimiento)
                        {
                            ultID = debe.IdTipoMovimiento;
                            Mov singleMov = new();
                            singleMov.IdMovimiento = debe.IdTipoMovimiento;
                            singleMov.Nombre = debe.Movimiento.Trim();
                            singleMov.Detalle = new List<Det>();
                            result.Add(singleMov);
                        }
                        int index = result.FindIndex(c => c.IdMovimiento == ultID);
                        if (index != -1)
                        {
                            Det singleDet = new();
                            singleDet.IdDetalle = debe.IdDetalle;
                            singleDet.Nombre = debe.Detalle.Trim();
                            singleDet.DebeHaber = debe.DebeHaber;
                            singleDet.Relacion = debe.Relacion;
                            singleDet.RelacionMov = debe.RelacionMov;
                            singleDet.Cuotas = debe.Cuotas;
                            singleDet.RelacionCaja = debe.RelacionCaja;
                            singleDet.ConsultaValorCuota = debe.ConsultaValorCuota;
                            singleDet.OrdenesOnline = debe.OrdenesOnline;
                            result[index].Detalle.Add(singleDet);
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public async Task<List<Mov>> GetMovxOpc(string param)
        {
            List<Mov> result = new List<Mov>();
            try
            {
                var comprobante = await _storedProceduresIOSEPRepository.getMovimientos(param);

                if (comprobante != null)
                {
                    //Genero relación padre e hijo.
                    int ultID = -1;
                    foreach (var debe in comprobante)
                    {
                        if (ultID != debe.IdTipoMovimiento)
                        {
                            ultID = debe.IdTipoMovimiento;
                            Mov singleMov = new();
                            singleMov.IdMovimiento = debe.IdTipoMovimiento;
                            singleMov.Nombre = debe.Movimiento.Trim();
                            singleMov.Detalle = new List<Det>();
                            result.Add(singleMov);
                        }
                        int index = result.FindIndex(c => c.IdMovimiento == ultID);
                        if (index != -1)
                        {
                            Det singleDet = new();
                            singleDet.IdDetalle = debe.IdDetalle;
                            singleDet.Nombre = debe.Detalle.Trim();
                            singleDet.DebeHaber = debe.DebeHaber;
                            singleDet.Relacion = debe.Relacion;
                            singleDet.RelacionMov = debe.RelacionMov;
                            singleDet.Cuotas = debe.Cuotas;
                            singleDet.RelacionCaja = debe.RelacionCaja;
                            singleDet.ConsultaValorCuota = debe.ConsultaValorCuota;
                            singleDet.OrdenesOnline = debe.OrdenesOnline;
                            result[index].Detalle.Add(singleDet);
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }


        public async Task<List<CuotaVM>> GetCuotaxAfiliado(int id, string periodo)
        {
            var comprobante = new List<CuotaVM>();
            try
            {
                comprobante = await _storedProceduresIOSEPRepository.CuotaAfiliado(id, periodo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return comprobante;
        }

        public async Task<List<CuotaVM>> GetCuotaxEmpresa(int id, string periodo)
        {
            var comprobante = new List<CuotaVM>();
            try
            {
                comprobante = await _storedProceduresIOSEPRepository.ImporteCuotaEmpresa(id, periodo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return comprobante;
        }

        public async Task<string> GetImprimirxComprobante(int id)
        {
            string json = "";
          
             
                var comp = await _comprobanteRepository.GetById(id);
                if (comp != null)
                {
                    //FACTURA CUOTA O NOTA DE DEBITO
                    if (comp.IdTipoMovimiento == 1 || comp.IdTipoMovimiento == 3)
                    {

                        var movi = await _storedProceduresIOSEPRepository.ctacte_imprimir(id);

                        json = System.Text.Json.JsonSerializer.Serialize(movi);
                    }
                    //RECIBO CUOTA O NOTA DE CREDITO
                    else if (comp.IdTipoMovimiento == 2 || comp.IdTipoMovimiento == 4)
                    { 
                        var movi = await _storedProceduresIOSEPRepository.pa_CtaCte_Imprimir_Recibos_Empresas(id);

                        json = System.Text.Json.JsonSerializer.Serialize(movi);

                    }
                }

            return json;
        }

        public async Task<List<NotaCredito>> GetDataInfoReciboAfiliado(string codBarra)
        {
            var movi = new List<NotaCredito>();
            try
            {
                movi = await _storedProceduresIOSEPRepository.pa_CtaCte_CobranzaGetInfo(codBarra);
            }
            catch
            {
                throw;
            }
            return movi;
        }

        public async Task<List<NotaCreditoEmpresa>> GetDataInfoReciboEmpresa(string codBarra)
        {
            var movi = new List<NotaCreditoEmpresa>();
            try
            {

                movi = await _storedProceduresIOSEPRepository.pa_CtaCte_CobranzaGetInfoEmpresas(codBarra);
                
            }
            catch (Exception e)
            {
                throw;
            }
            return movi;
        }

        public async Task<string> SetNotadeCredito(string CodigoBarra, string Json, Int16 Tipo, string? Observaciones,string cuil)
        {
            if (cuil == "20273907646" || cuil == "20377368585" || cuil == "20443143549")
            {
               await _unitOfWork.BeginTransactionAsync();
                try
                {
                    if (Tipo == 1)
                    {
                        XmlDocument doc = new XmlDocument();
                        XmlElement el = (XmlElement)doc.AppendChild(doc.CreateElement("rows"));
                        DataSet ds = JsonConvert.DeserializeObject<DataSet>(Json);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                XmlNode xrow = el.AppendChild(doc.CreateElement("row"));
                                //((XmlElement)xrow).SetAttribute("name", "value");
                                xrow.AppendChild(doc.CreateElement("IdDetalle")).InnerText = dr["IdDetalle"].ToString();
                                string per = dr["Periodo"].ToString().Replace("-", "");

                                xrow.AppendChild(doc.CreateElement("Periodo")).InnerText = per;

                                xrow.AppendChild(doc.CreateElement("IdComprobante")).InnerText = dr["IdComprobante"].ToString();
                                xrow.AppendChild(doc.CreateElement("Importe")).InnerText = dr["Importe"].ToString();
                                xrow.AppendChild(doc.CreateElement("Pagado")).InnerText = dr["Pagado"].ToString();
                            }
                        }

                        var cuotasNueva = await _storedProceduresIOSEPRepository.pa_CtaCte_NotaDeCredito1(CodigoBarra, doc,cuil,Observaciones);

                        await _unitOfWork.CommitAsync();
                        return "ok";
                    }
                    else
                    {
                        var cursor =  double.Parse(Json.ToString());

                        var cuotasNueva = await _storedProceduresIOSEPRepository.pa_CtaCte_NotaDeCreditoEmpresas(CodigoBarra, cursor, cuil, Observaciones);

                        await _unitOfWork.CommitAsync();
                        return "ok";
                    }


                }
                catch (Exception e)
                {
                    await _unitOfWork.RollbackAsync();
                    return "error";
                }
            }
            else
            {
                return "error";
            }
        }

        public async Task<List<ComprobanteVM>> PostComprobante(ComprobanteP comprobante)
        {
            List<ComprobanteVM> comprobantes = new List<ComprobanteVM>();
            await _unitOfWork.BeginTransactionAsync();
            try
            {
                //var movi = await _storedProceduresIOSEPRepository.getMovimientos(comprobante.IdDetalle);
                //MovimientoDetalle mov = movi[0];

                DateTime fechaVen1 = comprobante.Vencimiento_1_Original ?? DateTime.MinValue;
                DateTime fechaVen2 = comprobante.Vencimiento_2_Original ?? DateTime.MinValue;

                string fechaVen1Formatted = fechaVen1.ToString("yyyy-MM-dd");
                string fechaVen2Formatted = fechaVen2.ToString("yyyy-MM-dd");

                await _storedProceduresIOSEPRepository.pa_CtaCte_Facturacion(comprobante, fechaVen1Formatted, fechaVen2Formatted);

                await _unitOfWork.CommitAsync();


            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                Console.WriteLine(ex.Message);
            }

            comprobantes = await GetComprobantexAfiliado(comprobante.IdAfiliado);
            return comprobantes;

        }

        public async Task<List<ComprobanteVM>> PostComprobanteEmpresa(ComprobanteP comprobante)
        {
            List<ComprobanteVM> comprobantes = new List<ComprobanteVM>();
            await _unitOfWork.BeginTransactionAsync();
            try
            {
                //var movi = await _storedProceduresIOSEPRepository.getMovimientos(comprobante.IdDetalle);
                //MovimientoDetalle mov = movi[0];

                await _storedProceduresIOSEPRepository.FacturacionEmpresasNuevo(comprobante);

                await _unitOfWork.CommitAsync();


            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                Console.WriteLine(ex.Message);
            }

            comprobantes = await GetComprobantexAfiliado((int)comprobante.IdEmpresa,true);
            return comprobantes;

        }

        public async Task<VencimientosDTO> FechasVencimiento(string periodo)
        {
            return await _vencimientosPeriodosFacturacionRepository.FechasVencimiento(periodo);
        }

        public async Task<int> PostGlobal(string periodo, string tipo,string sucursal)
        {
             await _unitOfWork.BeginTransactionAsync();
            
            int cantReg = 0;
            try
            {
                //recupero todos los afiliados de iosepsalud titular.
                //TODO: controlar que no estén en empresas.
                var afiliados = await _afiliadosRespository.GetAfiliadosIOSEPSalud();

                //Busco el movimiento.
                var movi = await _storedProceduresIOSEPRepository.getMovimientos(1);
                MovimientoDetalle mov = movi[0];

                //Recupero Vencimiento de Cuota
                //TODO: Recuperar sucursal del usuario.
                //string sucursal = Config.Application["sucursal"];
                string tipoComprobante = "CU";

                //Recuperar vencimiento
                var vence = await _vencimientosPeriodosFacturacionRepository.FechaVencimiento(periodo);

                DateTime vence2 = vence.Vencimiento_2.HasValue ? vence.Vencimiento_2.Value : vence.Vencimiento_1;

                foreach (var a in afiliados)
                {
                    //Recupero cuota y cantidad de familiares.
                    var cuotas = await _storedProceduresIOSEPRepository.CuotaAfiliado(a.IdAfiliado, periodo);
                    CuotaVM cu = cuotas[0];

                    comprobante Compro = new();
                    Compro.IdComprobante = 0;
                    Compro.IdDetalle = mov.IdDetalle;
                    Compro.IdTipoMovimiento = mov.IdTipoMovimiento;
                    Compro.IdAfiliado = a.IdAfiliado;
                    Compro.Detalle = "Fact. Global: " + periodo;
                    Compro.Anulado = false;
                    Compro.IdCajaTipoOrigen = 2;
                    Compro.Cuotas = 1;
                    Compro.Importe = cu.ValorCuota;
                    Compro.Periodo = periodo;
                    Compro.CodigoBarra = Compro.Numero = "";

                    #region DETALLE
                    comprobanteDetalle detalle = new();
                    detalle.IdComprobanteDetalle = 0;
                    detalle.IdComprobante = Compro.IdComprobante;
                    detalle.Vencimiento1 = vence.Vencimiento_1;
                    detalle.ImporteVence1 = Compro.Importe.HasValue ? Compro.Importe.Value : cu.ValorCuota;
                    detalle.Vencimiento2 = vence2;
                    detalle.ImporteVence2 = Compro.Importe;
                    detalle.IdDetalle = mov.IdDetalle;
                    detalle.Detalle = "Fliar. " + cu.CantidadFamiliares.ToString();
                    detalle.Periodo = Compro.Periodo;
                    detalle.Fecha = DateTime.Now;
                    detalle.Anulado = false;
                    Compro.comprobanteDetalles.Add(detalle);
                    #endregion

                    await _comprobanteRepository.Insert(Compro);
                    //_context.Comprobante.Add(comprobante);
                    await _comprobanteRepository.Save();
                    //Actualizo el numero y codigo de barra.
                    string numero = tipoComprobante + sucursal + Compro.IdComprobante.ToString().PadLeft(8, '0');
                    string codBarra = _tools.CodigoBarra(numero, Compro.Importe.Value, vence.Vencimiento_1, vence2);
                    Compro.Numero = numero;
                    Compro.CodigoBarra = codBarra;
                    await _comprobanteRepository.Update(Compro);
                    await _comprobanteRepository.Save();
                    cantReg++;
                }

               await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                Console.WriteLine(ex.Message);
            }

            return cantReg;
        }

        public async Task<Respuesta> PutComprobantes(int id, comprobante comprobante)
        {
            var resp = new Respuesta();
            try
            {
                await _comprobanteRepository.Update(comprobante);
                await _comprobanteRepository.Save();
                resp.Code = 200;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _comprobanteRepository.ExistComp(id))
                {
                    resp.Code = 404;
                }
                else
                {
                    throw;
                }
            }

            return resp;
        }

        public async Task<List<ComprobanteVM>> DeleteComprobante(int id)
        {
            List<ComprobanteVM> resp = new List<ComprobanteVM>();
            try
            {
                var comprobante = await _comprobanteRepository.GetById(id);
                if (comprobante == null)
                {
                    return resp;
                }

                comprobante.Anulado = true;


                var comprobanteDetalle = await _comprobanteDetalleRepository.GetComprobanteDetalleById(id);
                if (comprobanteDetalle != null)
                {

                    foreach (var detalle in comprobanteDetalle)
                    {
                        detalle.Anulado = true;
                        await _comprobanteDetalleRepository.Update(detalle);
                    }
                    await _comprobanteDetalleRepository.Save();
                }

                //while (comprobanteDetalle != null && comprobanteDetalle.Anulado == false)
                //{
                //    comprobanteDetalle.Anulado = true;
                //    _context.Entry(comprobanteDetalle).State = EntityState.Modified;
                //    try
                //    {
                //        await _context.SaveChangesAsync();
                //    }
                //    catch (DbUpdateConcurrencyException)
                //    {
                //        if (!ComprobanteExists(id))
                //        {
                //            return NotFound();
                //        }
                //        else
                //        {
                //            throw;
                //        }
                //    }
                //    comprobanteDetalle = await _context.ComprobanteDetalle.FirstOrDefaultAsync(cd => cd.IdComprobante == comprobante.IdComprobante && cd.Anulado == false);
                //}
                await _comprobanteRepository.Update(comprobante);

                await _comprobanteRepository.Save();
                resp = await GetComprobantexAfiliado(comprobante.IdAfiliado);
            }
            catch (DbUpdateConcurrencyException)
            {
                return resp;
            }
            return resp;
        }

        public async Task<Response<List<ComprobanteVM>>> AnularComprobanteReporte(anularComprobanteRequest request,string? user)
        {

            Response<List<ComprobanteVM>> resp = new Response<List<ComprobanteVM>>();
            try
            {
                var fechaDesde = (int.Parse(request.Periodo.Substring(0, 4)) - 1).ToString() + request.Periodo.Substring(4, 2);
                var fechaHasta = request.Periodo;


                var comprobante = await _comprobanteRepository.GetById(request.IdComprobante);
                if (comprobante == null)
                {
                    resp.Error = true;
                    resp.Message = "404";
                    return resp;
                }

                await _unitOfWork.BeginTransactionAsync();

                var reporte = await _reportesIosepSaludRepository.GetReportesIS(request.IdAfiliado, request.Periodo);
                if (reporte != null)
                {
                    reporte.Anulado = true;
                    reporte.UsuarioAnula = user ?? "usuario";
                    reporte.FechaAnula = DateTime.Now;
                    await _reportesIosepSaludRepository.Update(reporte);
                }

                comprobante.Anulado = true;
                await _comprobanteRepository.Update(comprobante);

                var comprobanteDetalles = await _comprobanteDetalleRepository.GetComprobanteDetalleById(comprobante.IdComprobante);

                foreach (var detalle in comprobanteDetalles)
                {
                    detalle.Anulado = true;
                    await _comprobanteDetalleRepository.Update(detalle);
                }
                //await _context.SaveChangesAsync();
                //await dbIOSEP.SaveChangesAsync();

                await _unitOfWork.CommitAsync();

                resp.Data = await GetComprobantexAfiliado(comprobante.IdAfiliado, true, fechaDesde, fechaHasta);

            }
            catch (Exception ex) 
            {
                await _unitOfWork.RollbackAsync();
                resp.Message = ex.Message;
                resp.Error = true;
            }
            return resp;    
        }

        public async Task<string> GetImprimirPeriodoAfiliado(int id, string periodo)
        {

            var movi = await _storedProceduresIOSEPRepository.GenerarImpresionEmpresaPanel(id, periodo);

            string json = System.Text.Json.JsonSerializer.Serialize(movi);

        
            return json;

        }

        #region class comprobante

        #endregion
    }
}

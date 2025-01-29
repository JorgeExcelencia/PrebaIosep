using ApiIosep.Models.CtaCte.Empresa;
using ApiIosep.Models.DTOs;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.StoreProcedures;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;
using Models.Models.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace ApiIosep.Services.Concrete
{
    public class EmpresasServices : IEmpresasServices
    {
        private IEmpresaRepository _empresaRepository;
        private IStoredProceduresIOSEPRepository _storedProceduresIOSEPRepository;
        public EmpresasServices(IEmpresaRepository empresaRepository, IStoredProceduresIOSEPRepository storedProceduresIOSEPRepository)
        {
            _empresaRepository = empresaRepository;
            _storedProceduresIOSEPRepository = storedProceduresIOSEPRepository;
        }


        public async Task<List<empresa>> GetEmpresas()
        {

            return await _empresaRepository.GetEmpresas();
        }

        public async Task<List<empresa>> GetEmpresas(string filter)
        {

            return await _empresaRepository.GetEmpresasByNombre(filter);
        }

        public async Task<List<EmpresaVW>> GetEmpCtaCte()
        {

            return await _empresaRepository.EmpresaCTACTE();
        }

        public async Task<bool> DeleteEmpresas(int id)
        {
            try
            {
                var emp = await _empresaRepository.GetById(id);
                if (emp == null)
                    return false;

                emp.Anulado = true;

                await _empresaRepository.Save();

                return true;
            }
            catch
            {

                return false;

            }
        }

        public async Task<empresa> PutEmpresas(empresa emp)
        {

            if (!string.IsNullOrEmpty(emp.Cuit))
                emp.Cuit = emp.Cuit.Replace("-", "");

            try
            {

                await _empresaRepository.Update(emp);
                await _empresaRepository.Save();

                return emp;
            }
            catch 
            {
                emp.IdEmpresa = 0;

            }
            return emp;
        }

        public async Task<empresa> PostEmpresas(empresa emp)
        {
            try
            {
                if (!string.IsNullOrEmpty(emp.Cuit))
                    emp.Cuit = emp.Cuit.Replace("-", "");

                await _empresaRepository.Insert(emp);
                await _empresaRepository.Save();

                return emp;

            }       
            catch (Exception ex)
            {
                emp.IdEmpresa = -1;
                return emp;
            }

        }

        public async Task<Response<List<ClaseIosepSalud>>> InformePorEmpresasPeriodo(InformeAfiliadosRequest request)
        {
            Response<List<ClaseIosepSalud>> resp = new Response<List<ClaseIosepSalud>>(); 
            try
            {
                resp.Error = false;
                resp.Data = await _storedProceduresIOSEPRepository.SP_IosepSALUDAfiliadosPeriodoNuevo(request);
                return resp;
            }
            catch (Exception e)
            {
                resp.Error = true;
                resp.Message = e.Message;
                
            }
            return resp;
        }

        public async Task<Response<List<empresa>>> GetEmpresasById(int id)
        {
            var resp = new Response<List<empresa>>();
            try
            {
                var empresas = await _empresaRepository.GetEmpresas(id);

                if (empresas == null)
                {
                    resp.Error = true;
                    return resp;
                }

                resp.Data = empresas;
                
            }
            catch (Exception ex)
            {
                resp.Error = true;
                resp.Message = ex.Message;
            }
            return resp;

        }

        public async Task<Response<byte[]>> ImprimirPanel( ImprimirPanelDTO payload, string UsuarioImprime)
        {
            Response<byte[]> resp = new Response<byte[]>(); 
            var result = await _storedProceduresIOSEPRepository.SP_GenerarImpresionEmpresaPanel(payload, UsuarioImprime);

            if (result.Count < 0) { 
                resp.Error = true;
                resp.Message = "No se encontraron datos para generar el informe.";
                return resp;
            }

            var imprimirPayload = new ImprimirPanelRequest
            {
                Data = result,
                Periodo = payload.Periodo,
                UsuarioImprime = UsuarioImprime
            };

            var json = JsonConvert.SerializeObject(imprimirPayload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(60);
                    client.BaseAddress = new Uri("https://app.iosep.gob.ar/CRWeb/");

                    try
                    {
                        var response = await client.PostAsync("api/EmpresasIosepSalud/imprimirPanel", content);

                        if (response.IsSuccessStatusCode)
                        {
                            var pdfBytes = await response.Content.ReadAsByteArrayAsync();

                            var contentDisposition = response.Content.Headers.ContentDisposition;
                            var fileName = contentDisposition?.FileName ?? "archivo.pdf";
                         
                            resp.Data = pdfBytes;
                            resp.Error = false;
                            return resp;
                        }
                        else
                        {
                            resp.Error = true;
                            resp.Message = "Error al generar el informe.";
                                return resp;
                        }
                    }
                    catch (Exception ex)
                    {
                        resp.Error = true;
                        resp.Message = $"Error al realizar la solicitud: {ex.Message}";
                        return resp;
                    }
                }
            

        }

        public async Task<Response<string>> GenerarFacuraIosepSaludEmpresas(ImprimirPanelDTO payload, string operador)
        {
            var resp = new Response<string>();
            try
            {


                var result = await _storedProceduresIOSEPRepository.pa_CtaCteProcesofacturacionEmpresasPanel(payload, operador, "0001");
                if (result > 0)
                {
                    resp.Error = false;
                }
                else
                {
                    resp.Error = true;
                    resp.Message ="No se generó la factura.";
                }
            }
            catch (Exception ex)
            {
                resp.Error = true;
                resp.Message = $"Error al generar la factura: {ex.Message}";
            }

            return resp;    
        }

        public async Task<Response<string>> ConfirmarCambios(ImprimirPanelDTO payload, string UsuarioImprime)
        {
            var resp = new Response<string>();
            var result = await _storedProceduresIOSEPRepository.SP_GenerarImpresionEmpresaPanel(payload, UsuarioImprime);
               
            if (result.Count > 0)
            {
                resp.Error = false;
                resp.Message = "Guardado con exito.";
            }
            else
            {
                resp.Error = true;
                resp.Message = "No se encontraron datos.";
            }
            return resp;

        }

        public async Task<Response<List<AfiliadoCuil>>> BuscarCuil(buscarCuilRequest datos)
        {
            var resp = new Response<List<AfiliadoCuil>>();
            var result = await _storedProceduresIOSEPRepository.SP_BuscarAfiliado(datos);
            if (result.Count > 0)
            {
                resp.Error = false;
                resp.Data = result;
            }
            else
            {
                resp.Error = true;
                resp.Message = "No se encontraron datos.";
            }
            return resp;
        }

    }
}

using ApiIosep.Models.DTOs;
using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;
using RestSharp;
using Services.Services.Interfaces;

namespace ApiIosep.Services.Concrete
{
    public class ImprimirsServices : IImprimirsServices
    {
        private IImprimirRepository _imprimirrepository;
        private IEmpresaRepository _empresarepository;
        private IStoredProceduresIOSEPRepository _storedproceduresRepository;
        private IAfiliadosRespository _afiliadosRespository;
        private IHubServices _hubservices;

        public ImprimirsServices(IImprimirRepository imprimirRepository,IEmpresaRepository empresaRepository,IStoredProceduresIOSEPRepository storedProceduresIOSEPRepository,IAfiliadosRespository afiliadosRespository, IHubServices hubServices)
        {
            _imprimirrepository = imprimirRepository;
            _empresarepository = empresaRepository;
            _storedproceduresRepository = storedProceduresIOSEPRepository;
            _afiliadosRespository = afiliadosRespository;
            _hubservices = hubServices;
        }


        public async Task<List<Imprimir>> GetImprimir()
        {
            var resp = await _imprimirrepository.GetAll();
            return resp.ToList(); 
        }

        public async Task<Imprimir> GetImprimir(long id)
        {
            return await _imprimirrepository.GetById(id);
        }

        public async Task<bool> PutImprimir(Imprimir imprimir)
        {
            try
            {
                await _imprimirrepository.Update(imprimir);
                await _imprimirrepository.Save();

                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<Response<Imprimir>> PostImprimir(Imprimir imprimir)
        {
            var resp = new Response<Imprimir>();

            try
            {
                await _imprimirrepository.Insert(imprimir);
                await _imprimirrepository.Save();

                resp.Data = imprimir;
                resp.Error = false;

            }
            catch (Exception ex)
            {
                resp.Error = true;
                resp.Message = ex.Message;
                throw;
            }
            return resp;
        }

        public async Task<bool> DeleteImprimir(long id)
        {
            try
            {
            await _imprimirrepository.Delete(id);
            await _imprimirrepository.Save();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<RestResponse> DetalleCtaCte(int IdAfiliado, string FechaDesde, string FechaHasta, bool Empresa)
        {
            byte tipo = Empresa ? (byte)1 : (byte)0;
            string afi; //Cuil-Cuit
            string nom; //Nombre equisde
            DateTime d = FechaDesde == "" ? DateTime.Parse("1900-01-01") : DateTime.Parse(FechaDesde);
            DateTime h = FechaHasta == "" ? DateTime.Now : DateTime.Parse(FechaHasta);

            RestResponse resultado;

            if (Empresa)
            {
                var resEmp = await _empresarepository.GetById(IdAfiliado);
                afi = resEmp.Cuit;
                nom = resEmp.Nombre;

                var datos = await _storedproceduresRepository.pa_CtaCteEmpresas_Vista(IdAfiliado, d, h);
                resultado = await _hubservices.ImprimirDetalleCtaCte(d.ToString(), h.ToString(), afi, nom, tipo, datos, null);

            }
            else
            {
                var resAfi = await _afiliadosRespository.GetAfiliadoById(IdAfiliado);
                afi = resAfi.Cuil;
                nom = resAfi.Nombre;
                

                var datos = await _storedproceduresRepository.pa_CtaCteAfiliados_Vista(IdAfiliado, d, h);
                resultado = await _hubservices.ImprimirDetalleCtaCte(d.ToString(), h.ToString(), afi, nom, tipo, null, datos);

            }

            return resultado;

        }
    }
}

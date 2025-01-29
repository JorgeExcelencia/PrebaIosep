using ApiIosep.Models.CtaCte.Empresa;
using ApiIosep.Models.DTOs;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.StoreProcedures;
using Models.Models.DTOs;

namespace ApiIosep.Services.Interfaces
{
    public interface IEmpresasServices
    {
        Task<List<empresa>> GetEmpresas();
        Task<List<empresa>> GetEmpresas(string filter);
        Task<List<EmpresaVW>> GetEmpCtaCte();
        Task<bool> DeleteEmpresas(int id);
        Task<empresa> PutEmpresas(empresa empresas);
        Task<empresa> PostEmpresas(empresa emp);
        Task<Response<List<ClaseIosepSalud>>> InformePorEmpresasPeriodo(InformeAfiliadosRequest request);
        Task<Response<List<empresa>>> GetEmpresasById(int id);
        Task<Response<byte[]>> ImprimirPanel(ImprimirPanelDTO payload, string UsuarioImprime);
        Task<Response<string>> GenerarFacuraIosepSaludEmpresas(ImprimirPanelDTO payload, string operador);
        Task<Response<string>> ConfirmarCambios(ImprimirPanelDTO payload, string UsuarioImprime);
        Task<Response<List<AfiliadoCuil>>> BuscarCuil(buscarCuilRequest datos);
    }
}

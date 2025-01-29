using ApiIosep.Models.CtaCte.Empresa;
using ApiIosep.Models.IOSEP;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IEmpresaRepository : IBaseRepository<empresa>
    {
        Task<List<empresa>> GetEmpresas();
        Task<List<empresa>> GetEmpresasByNombre(string filter);
        Task<List<EmpresaVW>> EmpresaCTACTE();
        Task<List<empresa>> GetEmpresas(int id);
    }
}

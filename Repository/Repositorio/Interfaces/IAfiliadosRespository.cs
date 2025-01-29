using ApiIosep.Models.IOSEP;
using ApiIosep.Models.IOSEPweb;
using ApiIosep.Models.Persona;
using Models.Models.Creditos;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IAfiliadosRespository : IBaseRepository<Afiliado>
    {
        Task<List<AfiliadoVM>> GetAfiliadoVM();
        Task<List<AfiliadoVM>> GetAfiliadoVM(string filter);
        Task<List<int>> GetAfiliadoVMListId(string filter);
        Task<List<AfiliadoVM>> GetAfiliadoVMByIdAfiliado(int id);
        Task<List<AfiliadoVM>> GetAfiliadoVMByNombre(string filter, bool iosep);
        Task<List<int>> GetAfiliadoVMByNombreByNombre(string filter);
        Task<Afiliado> GetAfiliadoById(int id);
        Task<bool> ExistAfiliado(int id);
        Task<string> GetCuilTitularById(int id);
        Task<List<Afiliado>> GetGrupoFamiliarByIdAfiliado(int idAfiliado);
        Task<List<Afiliado>> GetAfiliadosIOSEPSalud();
        string GetNombreTitular(string cuil);
        Task<List<int>> GetAfiliadoExistCompList(string filter);
        Task<int> GetIdAfiliadoByCuil(string cuil);
        Task<Aporte> GetAportesAfiliado(string cuil);
        Task<Afiliado?> GetAfiliadoCreditos(string cuil);
        Task<Afiliado?> GetIdAfiliadoByAnumero(int ANumero);
        Task<LugarPagoDTO> GetAportesAfiliadoPorNombre(Aporte LugarPago, string CodLugarPago, Datum aporte);
        Task<LugarPagoDTO> GetAportesJubilado(Aporte LugarPago);
        Task<AfiliadosLugarPago?> GetLugarPagoJubiladoByIdAfiliado(int idAfiliado);

    }
}

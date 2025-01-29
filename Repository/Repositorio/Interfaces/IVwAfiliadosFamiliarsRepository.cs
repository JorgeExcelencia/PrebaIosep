using ApiIosep.Models.DTOs.Afiliados;
using ApiIosep.Models.IOSEP;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IVwAfiliadosFamiliarsRepository : IBaseRepository<VwAfiliadosFamiliar>
    {
        Task<List<GrupoFamiliarDTO>> GetGrupoFamiliarDTO(string cuil);
    }
}

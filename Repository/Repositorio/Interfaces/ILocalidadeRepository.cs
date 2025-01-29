using ApiIosep.Models.IOSEP;
using ApiIosep.Models.Persona.Geo;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface ILocalidadeRepository : IBaseRepository<Localidade>
    {
        Task<List<LocalidadVW>> GetLocalidadesByIdProvincia(int IdProvincia);
        Task<int> GetIdProvinciaByIdLocalidad(int IdLocalidad);
    }
}

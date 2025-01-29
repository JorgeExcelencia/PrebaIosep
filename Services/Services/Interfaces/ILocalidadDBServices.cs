using ApiIosep.Models.IOSEP;
using ApiIosep.Models.Persona.Geo;

namespace ApiIosep.Services.Interfaces
{
    public interface ILocalidadDBServices
    {
        Task<bool> DeleteLocalidadDB(int id);
        Task<List<LocalidadVW>> GetLocalidad(int idLocalidad);
        Task<List<LocalidadVW>> GetLocalidades(int idProv);
        Task<Localidade> PostLocalidadDB(Localidade localidadDB);
        Task<bool> PutLocalidadDB(Localidade localidadDB);
    }
}
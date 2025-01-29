using ApiIosep.Models;
using ApiIosep.Models.DTOs.Afiliados;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.Persona;

namespace ApiIosep.Services.Interfaces
{
    public interface IAfiliadosServices
    {
        Task<List<AfiliadoVM>> GetAfiliados(string filter);
        Task<Afiliado> GetAfiliados(int ID);
        Task<Respuesta> PutAfiliados(int id, Afiliado afiliados);
        Task<List<GrupoFamiliarDTO>> GetGrupoFamiliar(int idAfiliado);
    }
}

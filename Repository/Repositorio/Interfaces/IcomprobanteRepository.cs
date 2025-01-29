using ApiIosep.Models.DTOs.Autogestion;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.Persona;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IcomprobanteRepository : IBaseRepository<comprobante>
    {
        Task<List<int>> ExistsCompByListAfi(List<int> idsafi);
        Task<bool> ExistComp(int id);
        Task<string?> UltimoPeriodoFacturado(int idAfiliado);
        Task<List<BoletaDTO>> GetBoleta(int idAfiliado, string ultimoPeriodo, string email);

    }
}

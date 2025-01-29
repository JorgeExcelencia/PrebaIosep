using ApiIosep.Models.IOSEP;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IComprobanteDetalleRepository : IBaseRepository<comprobanteDetalle>
    {
        Task<List<comprobanteDetalle>> GetComprobanteDetalleById(int id);
    }
}

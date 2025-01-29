using ApiIosep.Models.IOSEP;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IDomiciliosRepository : IBaseRepository<Domicilio>
    {
        Task<string?> GetEmailByIdAfiliado(int idAfiliado);
    }
}

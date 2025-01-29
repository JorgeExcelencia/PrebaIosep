using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Repositorio.Concrete
{
    public class DomiciliosRepository : BaseRepository<Domicilio>, IDomiciliosRepository
    {
        public DomiciliosRepository(IOSEPContext context) : base(context)
        {
            
        }

        public async Task<string?> GetEmailByIdAfiliado (int idAfiliado)
            => await table.Where(d => d.IdAfiliado == idAfiliado && !d.Anulado).Select(d => d.Email).FirstOrDefaultAsync();
    }
}

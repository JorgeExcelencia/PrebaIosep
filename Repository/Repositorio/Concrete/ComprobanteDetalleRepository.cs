using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Repositorio.Concrete
{
    public class ComprobanteDetalleRepository : BaseRepository<comprobanteDetalle>, IComprobanteDetalleRepository
    {
        public ComprobanteDetalleRepository(IOSEPContext context): base(context)
        {
            
        }

        public async Task<List<comprobanteDetalle>> GetComprobanteDetalleById(int id)
            => await table.Where(cd => cd.IdComprobante == id && !cd.Anulado).ToListAsync();
    }
}

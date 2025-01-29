using ApiIosep.Models.IOSEP;
using Models.Models.Creditos;
using Repository.Repositorio.Interfaces;

namespace Repository.Repositorio.Concrete
{
    public class CabeceraLoteRepository : ICabeceraLoteRepository
    {
        public IOSEPContext _context;
        public CabeceraLoteRepository(IOSEPContext context)
        {
            _context = context;
        }
        public List<CabeceraLote> GetAll()
        {
            return _context.CabeceraLote.ToList();
        }       
    }
}

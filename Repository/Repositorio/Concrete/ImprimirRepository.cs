using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;

namespace ApiIosep.Repositorio.Concrete
{
    public class ImprimirRepository : BaseRepository<Imprimir>, IImprimirRepository
    {
        public ImprimirRepository(IOSEPContext context) : base(context) 
        {
  
        }
    }
}

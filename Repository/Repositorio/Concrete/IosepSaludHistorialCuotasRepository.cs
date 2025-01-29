using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;

namespace ApiIosep.Repositorio.Concrete
{
    public class IosepSaludHistorialCuotasRepository : BaseRepository<IosepSaludHistorialCuota>, IIosepSaludHistorialCuotasRepository
    {
        public IosepSaludHistorialCuotasRepository(IOSEPContext context) : base(context)
        {
            
        }
    }
}

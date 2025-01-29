using ApiIosep.Repositorio.Interfaces;
using Models.Models.Creditos;

namespace Repository.Repositorio.Interfaces
{
    public interface ICabeceraLoteRepository 
    { 
        public List<CabeceraLote> GetAll();
    }
}

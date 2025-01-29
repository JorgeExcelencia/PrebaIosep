using ApiIosep.Models.IOSEPweb;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IAspNetUsers1Repository : IBaseRepository<AspNetUser1>
    {
        Task<AspNetUser1> UserByCuil(string cuil);
    }
}

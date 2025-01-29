using ApiIosep.Models.DTOs;
using ApiIosep.Models.Persona;

namespace ApiIosep.Services.Interfaces
{
    public interface ILoginService
    {
        Task<Response<LoginSuccess>> GetUser(string cuil, string password);
    }
}

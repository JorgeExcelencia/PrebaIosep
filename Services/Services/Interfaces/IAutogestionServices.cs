using ApiIosep.Models.DTOs.Autogestion;

namespace ApiIosep.Services.Interfaces
{
    public interface IAutogestionServices
    {
        Task<List<BoletaDTO>> BuscarBoletas(string cuil);
    }
}

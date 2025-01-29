using ApiIosep.Models.DTOs;
using ApiIosep.Models.IOSEP;
using RestSharp;

namespace ApiIosep.Services.Interfaces
{
    public interface IImprimirsServices
    {
        Task<List<Imprimir>> GetImprimir();
        Task<Imprimir> GetImprimir(long id);
        Task<bool> PutImprimir(Imprimir imprimir);
        Task<Response<Imprimir>> PostImprimir(Imprimir imprimir);
        Task<bool> DeleteImprimir(long id);
        Task<RestResponse> DetalleCtaCte(int IdAfiliado, string FechaDesde, string FechaHasta, bool Empresa);
    }
}

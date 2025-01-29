using ApiIosep.Models.DTOs;

namespace ApiIosep.Services.Interfaces
{
    public interface IIosepSaludServices
    {
        Task<Response<string>> SetVencimientoFacturacion(string Periodo, string fecven1, string fecven2, string? obs1, string? obs2, string? obs3, string? lug1, string? lug2);
        Task<bool> VerificarVencimientosFacturacion(string Periodo);
        string PrintGlobalRecibos(int Id, string P, string? O1, string? O2, string? O3, string? L1, string? L2, string F1, string F2, string Tipo, byte afecta, string user);
    }
}

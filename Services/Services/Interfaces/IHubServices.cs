using ApiIosep.Models.CtaCte.Afiliado;
using ApiIosep.Models.CtaCte.Empresa;
using RestSharp;

namespace Services.Services.Interfaces
{
    public interface IHubServices
    {
        Task<RestResponse> ImprimirDetalleCtaCte(string Desde, string Hasta, string Afiliado, string Nombre, byte Tipo, List<EmpresaDetalleVW>? jsonE, List<AfiliadoDetalleVW>? jsonA);

        Task<RestResponse> ImprimirPDF(string json);
    }
}

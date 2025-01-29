using ApiIosep.Models.CtaCte.Afiliado;
using ApiIosep.Models.CtaCte.Empresa;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using Services.Services.Interfaces;

namespace ApiIosep.Controllers
{
    public class HubController : Controller
    {
        private IHubServices _hubServices;
        public HubController(IHubServices hubServices)
        {
            _hubServices = hubServices;
        }
        public async Task<RestResponse> ImprimirPDF(string json)
        {
            return await _hubServices.ImprimirPDF(json);
        }
        public async Task<RestResponse> ImprimirDetalleCtaCte(string Desde, string Hasta, string Afiliado, string Nombre, byte Tipo, List<EmpresaDetalleVW>? jsonE, List<AfiliadoDetalleVW>? jsonA)
        {
            
            return await _hubServices.ImprimirDetalleCtaCte( Desde, Hasta, Afiliado, Nombre, Tipo,  jsonE, jsonA);
            
        }
    }
}

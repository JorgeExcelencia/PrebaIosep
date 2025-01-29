using ApiIosep.Models.CtaCte.Afiliado;
using ApiIosep.Models.CtaCte.Empresa;
using RestSharp;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services.Services.Concrete
{
    public class HubServices : IHubServices
    {
        public HubServices() { }


        private RestClient client = new RestClient("https://app.iosep.gob.ar/CRWeb/");
        //private RestClient client = new RestClient("https://app.iosep.gob.ar/CRWebTest/");
        //private RestClient client = new RestClient("http://localhost:62667/");

        public async Task<RestResponse> ImprimirPDF(string json)
        {
            var request = new RestRequest("api/imprimir", Method.Post);

            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", json, ParameterType.RequestBody);

            //Console.WriteLine(response.Content);

            return await client.ExecuteAsync(request);
        }

        public async Task<RestResponse> ImprimirDetalleCtaCte(string Desde, string Hasta, string Afiliado, string Nombre, byte Tipo, List<EmpresaDetalleVW>? jsonE, List<AfiliadoDetalleVW>? jsonA)
        {
            string url = "api/imprimir/ImprimirDetalle?Desde=" + Desde + "&Hasta=" + Hasta + "&Afiliado=" + Afiliado + "&Nombre=" + Nombre + "&Tipo=" + Tipo;
            var request = new RestRequest(url, Method.Post);

            request.AddHeader("Content-Type", "application/json");
            if (jsonE != null)
            {
                var E = JsonSerializer.Serialize(jsonE);
                request.AddParameter("application/json", E, ParameterType.RequestBody);
            }
            else if (jsonA != null)
            {
                var A = JsonSerializer.Serialize(jsonA);
                request.AddParameter("application/json", A, ParameterType.RequestBody);
            }

            var a = await client.ExecuteAsync(request);
            return a;

        }
    }
}

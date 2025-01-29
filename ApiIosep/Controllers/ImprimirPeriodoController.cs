using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ApiIosep.Controllers
{
    public class ImprimirPeriodoController : Controller
    {
        private RestClient client = new RestClient("https://app.iosep.gob.ar/CRWeb/");
        //private RestClient client = new RestClient("http://localhost:62667/");

        public async Task<RestResponse> ImprimirPDFPeriodo(string json, string periodo)
        {
            var request = new RestRequest("Api/Imprimir/ImprimirAfiliadoxEmpresa?periodo="+periodo, Method.Post);

            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", json, ParameterType.RequestBody);

            //return await client.ExecuteAsync(request);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
            string s = "";
            return response;
        }
    }
}

using ApiIosep.Models.DTOs.Autogestion;
using ApiIosep.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiIosep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutogestionController : ControllerBase
    {
        private IAutogestionServices _autogestionServices;

        public AutogestionController(IAutogestionServices autogestionServices)
        {
            _autogestionServices = autogestionServices;
        }

        [HttpGet]
        [Route("Boleta")]
        public async Task<List<BoletaDTO>> BuscarBoletas(string cuil)
        {
            return await _autogestionServices.BuscarBoletas(cuil);
        }
    }
}

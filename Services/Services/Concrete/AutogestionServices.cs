using ApiIosep.Models.DTOs.Autogestion;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Services.Concrete
{
    public class AutogestionServices : IAutogestionServices
    {
        private IAfiliadosRespository _afiliadosRespository;
        private IDomiciliosRepository _domiciliosRepository;
        private IcomprobanteRepository _comprobanteRepository;

        public AutogestionServices(IAfiliadosRespository afiliadosRespository, IDomiciliosRepository domiciliosRepository, IcomprobanteRepository comprobanteRepository)
        {
            _afiliadosRespository = afiliadosRespository;
            _domiciliosRepository = domiciliosRepository;
            _comprobanteRepository = comprobanteRepository;
        }


        public async Task<List<BoletaDTO>> BuscarBoletas(string cuil)
        {

            int idAfiliado = await  _afiliadosRespository.GetIdAfiliadoByCuil(cuil);
            string email = await _domiciliosRepository.GetEmailByIdAfiliado(idAfiliado);

            var ultimoPeriodoFacturado = await _comprobanteRepository.UltimoPeriodoFacturado(idAfiliado);


            var resultado = await _comprobanteRepository.GetBoleta(idAfiliado, ultimoPeriodoFacturado, email);

            return resultado;

        }

    }
}

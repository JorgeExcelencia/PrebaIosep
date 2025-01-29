using ApiIosep.Models;
using ApiIosep.Models.DTOs.Afiliados;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.Persona;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;

namespace ApiIosep.Services.Concrete
{
    public class AfiliadosServices : IAfiliadosServices
    {
        private IAfiliadosRespository _afiliadosRespository;
        private IcomprobanteRepository _comprobanteRepository;
        private IVwAfiliadosFamiliarsRepository _vwAfiliadosFamiliarsRepository;
        public AfiliadosServices(IAfiliadosRespository afiliadosRespository, IcomprobanteRepository comprobanteRepository, IVwAfiliadosFamiliarsRepository vwAfiliadosFamiliarsRepository)
        {
            _afiliadosRespository = afiliadosRespository;
            _comprobanteRepository = comprobanteRepository;
            _vwAfiliadosFamiliarsRepository = vwAfiliadosFamiliarsRepository;
        }

        public async Task<List<AfiliadoVM>> GetAfiliados(string filter)
        {
            List<AfiliadoVM> afiliados = new List<AfiliadoVM>();
            filter = filter.ToLower().Trim();
            if (filter == "")
            {

                return await _afiliadosRespository.GetAfiliadoVM();
            }
            else
            {

                double a;
                var resultado = double.TryParse(filter, out a);
                List<AfiliadoVM>? AfiliadoIosepObligadoDeudor;


                if (resultado)
                {
                    afiliados = await _afiliadosRespository.GetAfiliadoVM(filter);

                    //Control para aquellos afiliados que cambian de iosep salud a obligado y aun deben cuotas. Como las cuotas coseguro por ejemplo.
                    if (afiliados.Count == 0)
                    {
                        List<int> afiIosep = await _afiliadosRespository.GetAfiliadoVMListId(filter);


                        var AfiIosepObligadoDeudor = await _comprobanteRepository.ExistsCompByListAfi(afiIosep);
                        //AfiliadoIosepObligadoDeudor = 
                        //await _context.Afiliados
                        //   .Where(afiliado => (afiliado.Cuil.Contains(filter)
                        //    || afiliado.A_Numero.Contains(filter))
                        //    )
                        //    .Join(
                        //    _context.comprobantes,
                        //    afiliado => afiliado.IdAfiliado,
                        //    comprobanteaf => comprobanteaf.IdAfiliado,
                        //    (afiliado, comprobanteaf) => new { Afiliado = afiliado, Comprobante = comprobanteaf }
                        //    )
                        //    .Where(joinedData => joinedData.Comprobante.IdDetalle == 19 ||
                        //     joinedData.Comprobante.IdDetalle == 5 ||
                        //     joinedData.Comprobante.IdDetalle == 11 ||
                        //     joinedData.Comprobante.IdDetalle == 21).Select(joinedData => new AfiliadoVM
                        //     {
                        //         IdAfiliado = joinedData.Afiliado.IdAfiliado
                        //     }).ToListAsync();

                        if (AfiIosepObligadoDeudor.Count > 0)
                        {

                            afiliados = await _afiliadosRespository.GetAfiliadoVMByIdAfiliado(AfiIosepObligadoDeudor[0]);
                        }
                    }
                }
                else
                {
                    afiliados = await _afiliadosRespository.GetAfiliadoVMByNombre(filter, true);

                    //List<int> afiIosep = await _afiliadosRespository.GetAfiliadoVMByNombreByNombre(filter);
                    //List<int> af = new List<int> { 43135,164899,164900,164901,64462,64624 };
                    var AfiIosepObligadoDeudor = await _afiliadosRespository.GetAfiliadoExistCompList(filter);

                    if (AfiIosepObligadoDeudor.Count > 0)
                    {
                        afiliados = await _afiliadosRespository.GetAfiliadoVMByNombre(filter, false);
                    }

                }
                
            }


            return afiliados;
        }

        public async Task<Afiliado> GetAfiliados(int ID) 
        {
            return await _afiliadosRespository.GetAfiliadoById(ID);
        }

        public async Task<Respuesta> PutAfiliados(int id, Afiliado afiliados)
        {
            Respuesta resp = new Respuesta();
            try
            {
                await _afiliadosRespository.Update(afiliados);
                await _afiliadosRespository.Save();

                resp.Code = 200;
            }
            catch {

                if (!await _afiliadosRespository.ExistAfiliado(id))
                {
                    resp.Code = 404;
                }

            }
            return resp;
        }

        public async Task<List<GrupoFamiliarDTO>> GetGrupoFamiliar(int idAfiliado)
        {

            var cuilTitular =  _afiliadosRespository.GetCuilTitularById(idAfiliado);

            var a = await _vwAfiliadosFamiliarsRepository.GetGrupoFamiliarDTO(await cuilTitular);

            return a;
        }
    }
}
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.Persona.Geo;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;

namespace ApiIosep.Services.Concrete
{
    public class LocalidadDBServices : ILocalidadDBServices
    {
        private ILocalidadeRepository _localidadeRepository;
        public LocalidadDBServices(ILocalidadeRepository localidadeRepository)
        {
            _localidadeRepository = localidadeRepository;
        }

        public async Task<List<LocalidadVW>> GetLocalidades(int idProv)
        {
            return await _localidadeRepository.GetLocalidadesByIdProvincia(idProv);
        }

        public async Task<List<LocalidadVW>> GetLocalidad(int idLocalidad)
        {
            int idProvincia = await _localidadeRepository.GetIdProvinciaByIdLocalidad(idLocalidad);

            return await _localidadeRepository.GetLocalidadesByIdProvincia(idProvincia);
        }

        public async Task<bool> PutLocalidadDB(Localidade localidadDB)
        {
            try
            {
                await _localidadeRepository.Update(localidadDB);
                await _localidadeRepository.Save();
                return true;
            }
            catch
            {
                return true;
            }
        }

        public async Task<Localidade> PostLocalidadDB(Localidade localidadDB)
        {
            try
            {
                await _localidadeRepository.Insert(localidadDB);
                await _localidadeRepository.Save();

            }
            catch
            {
                localidadDB.IdLocalidad = -1;
            }
            return localidadDB;
        }

        public async Task<bool> DeleteLocalidadDB(int id)
        {
            try
            {
                await _localidadeRepository.Delete(id);
                await _localidadeRepository.Save();

                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}

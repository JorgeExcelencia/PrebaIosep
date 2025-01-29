using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;

namespace ApiIosep.Services.Concrete
{
    public class CuotasServices : ICuotasServices
    {
        private IIosepSaludHistorialCuotasRepository _iosepSaludHistorialCuotasRepository;
        public CuotasServices(IIosepSaludHistorialCuotasRepository iosepSaludHistorialCuotasRepository)
        {
            _iosepSaludHistorialCuotasRepository = iosepSaludHistorialCuotasRepository;
        }


        public async Task<List<IosepSaludHistorialCuota>> GetCuotas()
        {

            var cuotas = await _iosepSaludHistorialCuotasRepository.GetAll();

            return cuotas.ToList();
        }

        public async Task<IosepSaludHistorialCuota> GetCuota(int id)
        {
            return await _iosepSaludHistorialCuotasRepository.GetById(id);
        }

        public async Task<bool> PutCuotas(IosepSaludHistorialCuota cuotas)
        {
            bool status = false;
            try
            {
                await _iosepSaludHistorialCuotasRepository.Update(cuotas);
                await _iosepSaludHistorialCuotasRepository.Save();
                status = true;
            }
            catch
            {
                return status;
            }
            return status;
        }

        public async Task<IosepSaludHistorialCuota> PostCuotas(IosepSaludHistorialCuota cuotas)
        {
            var resp = new IosepSaludHistorialCuota();
            try
            {
                await _iosepSaludHistorialCuotasRepository.Insert(cuotas);
                await _iosepSaludHistorialCuotasRepository.Save();

                return cuotas;
            }
            catch
            {

                return resp;
            }
        }

        public async Task<bool> DeleteCuotas(int id)
        {
            var cuotas = await _iosepSaludHistorialCuotasRepository.GetById(id);
            if (cuotas == null)
            {
                return false;
            }
            try
            {
                await _iosepSaludHistorialCuotasRepository.Delete(id);
                await _iosepSaludHistorialCuotasRepository.Save();
                return true;
            }
            catch
            {
                return false;

            }

        }
    }
}

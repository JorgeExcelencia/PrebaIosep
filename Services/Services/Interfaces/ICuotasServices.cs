using ApiIosep.Models.IOSEP;

namespace ApiIosep.Services.Interfaces
{
    public interface ICuotasServices
    {
        Task<List<IosepSaludHistorialCuota>> GetCuotas();
        Task<IosepSaludHistorialCuota> GetCuota(int id);
        Task<bool> PutCuotas(IosepSaludHistorialCuota cuotas);
        Task<IosepSaludHistorialCuota> PostCuotas(IosepSaludHistorialCuota cuotas);
        Task<bool> DeleteCuotas(int id);
    }
}

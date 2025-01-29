using ApiIosep.Models.IOSEP;

namespace ApiIosep.Services.Interfaces
{
    public interface IVencimientosService
    {
        Task<List<VencimientosPeriodosFacturacion>> GetVencimientos(string periodos, bool futuros);
        Task<VencimientosPeriodosFacturacion> GetVencimientos(int id);
        Task<VencimientosPeriodosFacturacion> GetVencxPeriodo(string periodo);
        Task<bool> PutVencimientos(VencimientosPeriodosFacturacion vencimientos);
        Task<VencimientosPeriodosFacturacion> PostVencimientos(VencimientosPeriodosFacturacion vencimientos);
        Task<bool> DeleteVencimientos(int id);
    }
}

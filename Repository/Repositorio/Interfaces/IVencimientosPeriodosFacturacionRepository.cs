using ApiIosep.Models.DTOs;
using ApiIosep.Models.IOSEP;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IVencimientosPeriodosFacturacionRepository : IBaseRepository<VencimientosPeriodosFacturacion>
    {
        Task<VencimientosDTO> FechasVencimiento(string periodo);
        Task<VencimientoDTO> FechaVencimiento(string periodo);
        Task<List<VencimientosPeriodosFacturacion>> GetVencimientosPFByPeriodo(string periodo);
        Task<List<VencimientosPeriodosFacturacion>> GetVencimientoFuturo(string periodo);
        Task<List<VencimientosPeriodosFacturacion>> GetVencimiento(string periodo);
        Task<VencimientoPeriodoDTO> GetVencimientoPeriodo(string periodo);
        Task<VencimientosPeriodosFacturacion> GetVencimientoPerio(string periodo);
    }
}

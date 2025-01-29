using ApiIosep.Models.DTOs;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.IOSEPweb;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace ApiIosep.Repositorio.Concrete
{
    public class VencimientosPeriodosFacturacionRepository : BaseRepository<VencimientosPeriodosFacturacion>, IVencimientosPeriodosFacturacionRepository
    {
        public VencimientosPeriodosFacturacionRepository(IOSEPContext context) : base(context)
        {

        }

        public async Task<VencimientosDTO> FechasVencimiento(string periodo)
            => await table
            .AsNoTracking()
            .Where(f => f.Periodo == periodo)
            .Select(f => new VencimientosDTO { Vencimiento_1_Original = f.Vencimiento_1_Original, Vencimiento_2_Original = f.Vencimiento_2_Original })
            .FirstOrDefaultAsync();

        public async Task<VencimientoDTO> FechaVencimiento(string periodo)
            => await table
            .AsNoTracking()
            .Where(w => string.Compare(w.Periodo, periodo) == 0 && !w.Anulado)
            .Select(w => new VencimientoDTO {
                Vencimiento_1 = w.Vencimiento_1,
                Vencimiento_2 = w.Vencimiento_2
            })
            .FirstOrDefaultAsync();


        public async Task<List<VencimientosPeriodosFacturacion>> GetVencimientosPFByPeriodo(string periodo)
            => await table
            .Where(v => v.Periodo == periodo && !v.Anulado)
            .ToListAsync();

        public async Task<List<VencimientosPeriodosFacturacion>> GetVencimientoFuturo(string periodo)
            => await table.Where(w => string.Compare(w.Periodo, periodo) > 0)
            .ToListAsync();
        public async Task<List<VencimientosPeriodosFacturacion>> GetVencimiento(string periodo)
            => await table.Where(w => string.Compare(w.Periodo, periodo) <= 0)
            .ToListAsync();

        public async Task<VencimientoPeriodoDTO> GetVencimientoPeriodo(string periodo)
            => await table.AsNoTracking()
            .Where(a => !a.Anulado && a.Periodo == periodo)
            .OrderByDescending(a => a.idPeriodo)
            .Select(a => new VencimientoPeriodoDTO { Lugar_de_pago1 = a.Lugar_de_pago1, Lugar_de_pago2 = a.Lugar_de_pago2, Renglon_1 = a.Renglon_1, Renglon_2 = a.Renglon_2, Renglon_3 = a.Renglon_3, Vencimiento_1 = a.Vencimiento_1, Vencimiento_2 = a.Vencimiento_2 })
            .FirstOrDefaultAsync();

        public async Task<VencimientosPeriodosFacturacion> GetVencimientoPerio(string periodo)
            => await table.AsNoTracking().Where(w => string.Compare(w.Periodo, periodo) == 0).FirstOrDefaultAsync();



    }
}

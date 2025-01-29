using ApiIosep.Models.DTOs.Autogestion;
using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Repositorio.Concrete
{
    public class comprobanteRepository : BaseRepository<comprobante>, IcomprobanteRepository
    {
        public comprobanteRepository(IOSEPContext context) : base(context)
        {

        }

        public async Task<List<int>> ExistsCompByListAfi(List<int> idsafi)
        => await table.AsNoTracking()
            .Where(c => idsafi.Contains(c.IdAfiliado))
            .Select(c => c.IdAfiliado)
            .ToListAsync();

        public async Task<bool> ExistComp(int id)
            => await table.AnyAsync(a => a.IdComprobante == id);

        public async Task<string?> UltimoPeriodoFacturado(int idAfiliado)
            => await table.AsNoTracking()
                .Where(c => c.IdAfiliado == idAfiliado && 
                            !c.Anulado && 
                            c.IdDetalle == 2)
                .MaxAsync(c => c.Periodo);

        public async Task<List<BoletaDTO>> GetBoleta( int idAfiliado,string ultimoPeriodo,string email)
            =>await table.AsNoTracking()
            .Where( c => c.IdAfiliado == idAfiliado && 
                         !c.Anulado && 
                         c.IdDetalle == 1 && 
                         Convert.ToInt32(c.Periodo) > Convert.ToInt32(ultimoPeriodo) &&
                    !(c.comprobanteDetalles
                        .Where(cd => cd.numeroPago != null)
                        .Select(cd => cd.numeroPago)
                        .Contains(c.Numero)
                        )
                    )
                .Select( a => new BoletaDTO
                {
                    idComprobante = a.IdComprobante,
                    periodo = a.Periodo != null ? a.Periodo.Substring(4, 2) + "-" + a.Periodo.Substring(0, 4) : "",
                    numero = a.Numero,
                    detalle = a.Detalle ?? "",
                    importe = a.Importe ?? 0,
                    IdAfiliado = idAfiliado,
                    Email = email ?? "sin@sin.sin",
                    CodigoBarra = a.CodigoBarra ?? "0"
                })
                .ToListAsync();
    }
}

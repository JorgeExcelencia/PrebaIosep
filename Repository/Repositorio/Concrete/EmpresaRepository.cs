using ApiIosep.Models.CtaCte.Empresa;
using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Repositorio.Concrete
{
    public class EmpresaRepository : BaseRepository<empresa>, IEmpresaRepository
    {
        public EmpresaRepository(IOSEPContext context) : base (context)
        {
            
        }

        public async Task<List<empresa>> GetEmpresas()
            => await table.Where(e => !e.Anulado)
            .OrderBy(o => o.Nombre)
            .ToListAsync();

        public async Task<List<empresa>> GetEmpresasByNombre(string filter)
            => await table.Where(w => w.Nombre.ToLower().Contains(filter) && !w.Anulado)
            .OrderBy(o => o.Nombre)
            .ToListAsync();

        public async Task<List<EmpresaVW>> EmpresaCTACTE()
            => await table.Include(e => e.empresa_afiliados)
            .Select( e => new EmpresaVW
            {
                IdEmpresa = e.IdEmpresa,
                Nombre = e.Nombre,
                Titulares = e.empresa_afiliados.Where(w => w.EsTitular && !w.Anulado).Count(),
                Beneficiarios = e.empresa_afiliados.Where(w => !w.EsTitular && !w.Anulado).Count(),
                Domicilio = e.Domicilio,
                Contacto = e.Contacto,
                Telefono = e.Telefono,
                Resolucion = e.Resolucion,
                CuotaFija = e.CuotaFija,
                Inicio = e.Inicio,
                Fin = e.Fin,
                Renovar = e.Renovar,
                Cuit = e.Cuit,
                IdLocalidad = e.IdLocalidad,
                Contratados = e.Contratados,
                ProntoPagoDescuento = e.ProntoPagoDescuento,
                ProntoPagoImporte = e.ProntoPagoImporte,
                ValorFijo = e.ValorFijo,
                ContratoIndividual = e.ContratoIndividual,
                Tipo = e.Tipo,
                PeriodoFacturado = e.PeriodoFacturado,
                Anulado = e.Anulado,
            })
            .OrderBy(o => o.Nombre)
            .ToListAsync();

        public async Task<List<empresa>> GetEmpresas(int id)
           => await table.AsNoTracking().Where(e => e.IdEmpresa == id)
           .ToListAsync();
    }
}

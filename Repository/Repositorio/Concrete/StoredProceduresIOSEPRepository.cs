using ApiIosep.Models.CtaCte;
using ApiIosep.Models.CtaCte.Afiliado;
using ApiIosep.Models.CtaCte.Empresa;
using ApiIosep.Models.CtaCte.MovDet;
using ApiIosep.Models.IOSEP;
using ApiIosep.Models.StoreProcedures;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models.Models.DTOs;
using System.Data;
using System.Data.SqlTypes;
using System.Xml;


namespace ApiIosep.Repositorio.Concrete
{
    public class StoredProceduresIOSEPRepository : IStoredProceduresIOSEPRepository
    {
        protected IOSEPContext _context;
        public StoredProceduresIOSEPRepository(IOSEPContext _context)
        {
            this._context = _context;
        }

        public async Task<List<ComprobanteVM>> ctacte_resumen(int id, bool esEmpresa = false, string? desde = "", string? hasta = "")
        { 
            _context.Database.SetCommandTimeout(0);

            return await _context.ComprobanteVM
                .FromSqlRaw("EXEC [iosepsalud].[ctacte_resumen] @IdAfiliado, @IdEmpresa, @PeriodoDesde, @PeriodoHasta",
                    new SqlParameter("@IdAfiliado", esEmpresa ? 0 : (object)id),
                    new SqlParameter("@IdEmpresa", esEmpresa ? (object)id : 0),
                    new SqlParameter("@PeriodoDesde", desde),
                    new SqlParameter("@PeriodoHasta", hasta))
                .ToListAsync();
        } 

        public async Task<List<ComprobanteVM>> ctacte_resumenAfiliadosEmpresa(string param, int id)
            => await _context.ComprobanteVM
            .FromSqlRaw($"exec [iosepsalud].[ctacte_resumenAfiliadosEmpresa] @{param}",
                new SqlParameter($"@{param}", id))
            .ToListAsync();

        public async Task<List<ComprobanteVM>> ctacte_sistemaviejo(int id)
           => await _context.ComprobanteVM
           .FromSqlRaw($"exec [iosepsalud].[ctacte_resumenAfiliadosEmpresa] @IdAfiliado",
               new SqlParameter("@IdAfiliado", id))
           .ToListAsync();

        public async Task<List<DetalleMovimiento>> ctacte_resumenDetalleComp(int id)
            => await _context.DetalleMovimiento
            .FromSqlRaw("EXEC [iosepsalud].[ctacte_resumen] @IdAfiliado, @IdEmpresa, @PeriodoDesde, @PeriodoHasta",
                new SqlParameter("@IdAfiliado", id))
            .ToListAsync();

        public async Task<List<MovimientoDetalle>> getMovimientos()
            => await _context.MovimientoDetalle.FromSqlRaw("exec [iosepsalud].[getMovimientos] @DebeHaber",
                new SqlParameter("@DebeHaber", "D"))
            .ToListAsync();

        public async Task<List<MovimientoDetalle>> getMovimientos(string param)
            => await _context.MovimientoDetalle.FromSqlRaw("exec [iosepsalud].[getMovimientos] @Mostrar, @Todo, @Filtro",
                new SqlParameter("@Mostrar", "1"),
                new SqlParameter("@Todo", "0"),
                new SqlParameter("@Filtro", param))
            .ToListAsync();
        public async Task<List<MovimientoDetalle>> getMovimientos(int? id)
            => await _context.MovimientoDetalle.FromSqlRaw("exec [iosepsalud].[getMovimientos] @IdDetalle",
                new SqlParameter("@IdDetalle", id))
            .ToListAsync();

        public async Task<List<CuotaVM>> CuotaAfiliado(int id, string periodo)
            => await _context.CuotaVM.FromSqlRaw("exec [iosepsalud].[CuotaAfiliado] @IdAfiliado, @Periodo",
                    new SqlParameter("@IdAfiliado", id),
                    new SqlParameter("@Periodo", periodo)
                ).ToListAsync();

        public async Task<List<CuotaVM>> ImporteCuotaEmpresa(int id, string periodo)
            => await _context.CuotaVM.FromSqlRaw("exec [dbo].[Pa_ImporteCuotaEmpresa] @IdEmpresa, @Periodo",
                    new SqlParameter("@IdEmpresa", id),
                    new SqlParameter("@Periodo", periodo)
                ).ToListAsync();

        public async Task<List<imprimir_ctacteVW>> ctacte_imprimir(int id)
            => await _context.ImprimirCtaCte.FromSqlRaw("exec [iosepsalud].[ctacte_imprimir] @IDComprobante",
                new SqlParameter("@IDComprobante", id))
            .ToListAsync();

        public async Task<List<imprimir_PagoCtaCte>> pa_CtaCte_Imprimir_Recibos_Empresas(int id)
            => await _context.ImprimirPagoCtaCte.FromSqlRaw("exec [iosepsalud].[pa_CtaCte_Imprimir_Recibos_Empresas] @idcomp",
                new SqlParameter("@idcomp", id))
            .ToListAsync();

        public async Task<List<NotaCredito>> pa_CtaCte_CobranzaGetInfo(string codBarra)
            => await _context.NotaCreditos.FromSqlRaw("exec [iosepsalud].[pa_CtaCte_CobranzaGetInfo] @CodBarra",
                new SqlParameter("@CodBarra", codBarra))
            .ToListAsync();

        public async Task<List<NotaCreditoEmpresa>> pa_CtaCte_CobranzaGetInfoEmpresas(string codBarra)
            => await _context.NotaCreditoEmpresas.FromSqlRaw("exec [iosepsalud].[pa_CtaCte_CobranzaGetInfoEmpresas] @CodBarra",
                new SqlParameter("@CodBarra", codBarra))
            .ToListAsync();

        public async Task<List<Comprobante>> pa_CtaCte_NotaDeCredito1(string CodigoBarra, XmlDocument doc, string cuil, string? observaciones)
            => await _context.Comprobante.FromSqlRaw(@"exec [iosepsalud].[pa_CtaCte_NotaDeCredito1]  @CodBarra,@Cursor,@Sucursal, @CuilOperador,@IdLugar, @Observaciones",
                new SqlParameter("@CodBarra", CodigoBarra),
                new SqlParameter("@Cursor", new SqlXml(new XmlTextReader(new StringReader(doc.OuterXml)))),
                new SqlParameter("@Sucursal", "0001"),
                new SqlParameter("@CuilOperador", cuil),
                new SqlParameter("@IdLugar", 0001),
                new SqlParameter("@Observaciones", observaciones))
            .ToListAsync();

        public async Task<List<Comprobante>> pa_CtaCte_NotaDeCreditoEmpresas(string CodigoBarra, double importe, string cuil, string? observaciones)
            => await _context.Comprobante.FromSqlRaw(@"exec [iosepsalud].[pa_CtaCte_NotaDeCreditoEmpresas]  @CodBarra,@Importe,@Sucursal,@CuilOperador,@IdLugar, @Observaciones",
                new SqlParameter("@CodBarra", CodigoBarra),
                new SqlParameter("@Cursor", importe),
                new SqlParameter("@Sucursal", "0001"),
                new SqlParameter("@CuilOperador", cuil),
                new SqlParameter("@IdLugar", "0001"),
                new SqlParameter("@Observaciones", observaciones))
            .ToListAsync();

        public async Task pa_CtaCte_Facturacion(ComprobanteP comprobante, string fecha1, string fecha2)
        {
            _context.Database.SetCommandTimeout(600);

            await _context.Database.ExecuteSqlInterpolatedAsync($@"exec [iosepsalud].[pa_CtaCte_Facturacion] 
                @IDAfiliado = {comprobante.IdAfiliado},
                @Sucursal = '0001',
                @IdTipoMovimiento = 1,
                @IdDetalleMovimiento = {comprobante.IdDetalle},
                @Periodo = {comprobante.Periodo},
                @Cuotas = {comprobante.Cuotas},
                @Importe = {comprobante.Importe},
                @Global = {DateTime.Now.ToString("yyyyMMdd")},
                @DetalleFactura = {comprobante.Detalle},
                @FechaVen1 = {fecha1},
                @FechaVen2 = {fecha2}
                 ");
        }

        public async Task FacturacionEmpresasNuevo(ComprobanteP comprobante)
        => await _context.Database.ExecuteSqlInterpolatedAsync($@"
                exec FacturacionEmpresasNuevo
                @Periodo = {comprobante.Periodo},
                @SucursalUser = '0001',
                @IdEmpresa = {comprobante.IdEmpresa},
                @DetalleFactura = {comprobante.Detalle}
                 ");
        

        public async Task<List<imprimir_PeriodoPago>> GenerarImpresionEmpresaPanel(int id,string periodo)
            => await _context.ImprimirPeriodo.FromSqlRaw("exec [iosepsalud].[SP_GenerarImpresionEmpresaPanel] @IdAfiliado, @IDPeriodo",
                new SqlParameter("@IDAfiliado", id),
                new SqlParameter("@IDPeriodo", periodo))
                .ToListAsync();

        public async Task<List<ClaseIosepSalud>> SP_IosepSALUDAfiliadosPeriodoNuevo(InformeAfiliadosRequest request)
            => await _context.ClaseIosepSalud.FromSqlRaw("EXEC dbo.SP_IosepSALUDAfiliadosPeriodoNuevo @Periodo, @EmpresaId", 
                    new SqlParameter("@Periodo", request.periodo),
                    new SqlParameter("@EmpresaId", request.empresaId))
               .ToListAsync();

        public async Task<List<IosepSALUDAfiliadosEmp>> SP_GenerarImpresionEmpresaPanel(ImprimirPanelDTO payload, string UsuarioImprime)
            => await _context.Set<IosepSALUDAfiliadosEmp>()
                .FromSqlRaw("EXEC dbo.SP_GenerarImpresionEmpresaPanel @Filas, @EmpresaID, @Periodo, @Usuario",
                new SqlParameter("@Filas", payload.Filas),
                new SqlParameter("@EmpresaID", payload.EmpresaID),
                new SqlParameter("@Periodo", payload.Periodo),
                new SqlParameter("@Usuario", UsuarioImprime))
            .ToListAsync();

        public async Task<int> pa_CtaCteProcesofacturacionEmpresasPanel(ImprimirPanelDTO payload, string operador, string sucursal)
            => await _context.Database.ExecuteSqlRawAsync("EXEC iosepsalud.pa_CtaCteProcesofacturacionEmpresasPanel @Periodo, @SucursalUser, @IdEmpresa, @DetalleFactura, @Operador, @Filas",
                    new SqlParameter("@Periodo", payload.Periodo),
                new SqlParameter("@SucursalUser", sucursal),
                new SqlParameter("@IdEmpresa", payload.EmpresaID),
                new SqlParameter("@DetalleFactura", ""),
                new SqlParameter("@Operador", operador),
                new SqlParameter("@Filas", payload.Filas));

        public async Task<List<AfiliadoCuil>> SP_BuscarAfiliado(buscarCuilRequest datos)
            => await _context.Set<AfiliadoCuil>()
                    .FromSqlRaw("EXEC dbo.SP_BuscarAfiliado @Cuil, @Periodo",
                        new SqlParameter("@Cuil", datos.Cuil),
                        new SqlParameter("@Periodo", datos.Periodo))
                    .ToListAsync();

        public async Task<List<EmpresaDetalleVW>> pa_CtaCteEmpresas_Vista(int IdAfiliado, DateTime d, DateTime h)
            => await _context.Set<EmpresaDetalleVW>().FromSqlRaw($"exec [iosepsalud].[pa_CtaCteEmpresas_Vista] @IdEmpresa, @FechaDesde, @FechaHasta",
                    new SqlParameter("@IdEmpresa", SqlDbType.Int) { Direction = ParameterDirection.Input, Value = IdAfiliado },
                    new SqlParameter("@FechaDesde", SqlDbType.NChar) { Direction = ParameterDirection.Input, Value = d.ToString("yyyy-MM-dd") },
                    new SqlParameter("@FechaHasta", SqlDbType.NChar) { Direction = ParameterDirection.Input, Value = h.ToString("yyyy-MM-dd") }
                    )
                .ToListAsync();
        public async Task<List<AfiliadoDetalleVW>> pa_CtaCteAfiliados_Vista(int IdAfiliado, DateTime d, DateTime h)
            => await _context.Set<AfiliadoDetalleVW>().FromSqlRaw($"exec [iosepsalud].[pa_CtaCteAfiliados_Vista] @IdEmpresa, @FechaDesde, @FechaHasta",
                    new SqlParameter("@IdEmpresa", SqlDbType.Int) { Direction = ParameterDirection.Input, Value = IdAfiliado },
                    new SqlParameter("@FechaDesde", SqlDbType.NChar) { Direction = ParameterDirection.Input, Value = d.ToString("yyyy-MM-dd") },
                    new SqlParameter("@FechaHasta", SqlDbType.NChar) { Direction = ParameterDirection.Input, Value = h.ToString("yyyy-MM-dd") }
                    )
                .ToListAsync();
        public async Task VerificarYActualizarVencimientos(string periodo)
            => await _context.Database.ExecuteSqlInterpolatedAsync($@"Exec VerificarYActualizarVencimientos @Periodo = {periodo}");

    }
}

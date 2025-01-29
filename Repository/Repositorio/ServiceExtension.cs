using ApiIosep.Repositorio.Concrete;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repositorio.Concrete;
using Repository.Repositorio.Interfaces;

namespace ApiIosep.Repositorio
{
    static public class ServiceExtension
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IAfiliadosRespository, AfiliadosRespository>();
            services.AddScoped<IcomprobanteRepository, comprobanteRepository>();
            services.AddScoped<IVwAfiliadosFamiliarsRepository, VwAfiliadosFamiliarsRepository>();
            services.AddScoped<IStoredProceduresIOSEPRepository,StoredProceduresIOSEPRepository>();
            services.AddScoped<IVencimientosPeriodosFacturacionRepository, VencimientosPeriodosFacturacionRepository>();
            services.AddScoped<IComprobanteDetalleRepository, ComprobanteDetalleRepository>();
            services.AddScoped<IReportesIosepSaludRepository, ReportesIosepSaludRepository>();
            services.AddScoped<IDomiciliosRepository, DomiciliosRepository>();
            services.AddScoped<IIosepSaludHistorialCuotasRepository, IosepSaludHistorialCuotasRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IImprimirRepository, ImprimirRepository>();
            services.AddScoped<ILocalidadeRepository, LocalidadeRepository>();
            services.AddScoped<IAspNetUsers1Repository, AspNetUsers1Repository>();
            services.AddScoped<IAspNetRole1Repository, AspNetRole1Repository>();
            services.AddScoped<ICabeceraLoteRepository, CabeceraLoteRepository>();
            services.AddScoped<ILotesRepository, LotesRepository>();
            services.AddScoped<ICreditosRepository, CreditosRepository>();
        }
    }
}

using ApiIosep.Services.Concrete;
using ApiIosep.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Services.Services.Concrete;
using Services.Services.Interfaces;

namespace ApiIosep.Services
{
    static public class ServiceExtension
    {
        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<IAfiliadosServices, AfiliadosServices>();
            services.AddScoped<IComprobantesService, ComprobantesService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAutogestionServices, AutogestionServices>();
            services.AddScoped<IEmpresasServices, EmpresasServices>();
            services.AddScoped<ILocalidadDBServices, LocalidadDBServices>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IVencimientosService, VencimientosService>();
            services.AddScoped<ITools, Tools>();
            services.AddScoped<IHubServices, HubServices>();
            services.AddScoped<IIosepSaludServices, IosepSaludServices>();
            services.AddScoped<ICreditosService, CreditosService>();

        }
    }
}

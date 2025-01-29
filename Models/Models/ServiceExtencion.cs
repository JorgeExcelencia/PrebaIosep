using ApiIosep.Models.IOSEP;
using ApiIosep.Models.IOSEPweb;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiIosep.Models
{
    static public class ServiceExtencion
    {
        public static void ConfigureModel(this IServiceCollection services, IConfiguration Configuration)
        {

            services.AddDbContext<IOSEPContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("WebApiDB")));

            services.AddDbContext<IOSEPwebContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("iosepWeb")));
        }
    }
}

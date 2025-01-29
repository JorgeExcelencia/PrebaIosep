using ApiIosep.Models.IOSEPweb;
using ApiIosep.Repositorio.Interfaces;

namespace ApiIosep.Repositorio.Concrete
{
    public class AspNetRole1Repository : BaseRepositoryWeb<AspNetRole1>, IAspNetRole1Repository
    {
        public AspNetRole1Repository(IOSEPwebContext context) : base (context)
        {
            
        }

        
    }
}

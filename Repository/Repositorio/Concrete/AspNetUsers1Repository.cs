using ApiIosep.Models.IOSEPweb;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Repositorio.Concrete
{
    public class AspNetUsers1Repository : BaseRepositoryWeb<AspNetUser1>, IAspNetUsers1Repository
    {
        public AspNetUsers1Repository(IOSEPwebContext context) : base(context)
        {
        }

        public async Task<AspNetUser1> UserByCuil(string cuil)
        {
            return await table.Include(a => a.Roles).SingleOrDefaultAsync(x => x.UserName == cuil);
        }

       
    }
}

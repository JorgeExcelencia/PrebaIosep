using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Repositorio.Concrete
{
    public class ReportesIosepSaludRepository : BaseRepository<ReportesIosepSalud>, IReportesIosepSaludRepository
    {
        public ReportesIosepSaludRepository(IOSEPContext context) : base(context)
        {
            
        }

        public async Task<ReportesIosepSalud?> GetReportesIS(int idEmpresa, string periodo)
            => await table.Where(r => r.EmpresaID == idEmpresa && r.Periodo == periodo && !r.Anulado).FirstOrDefaultAsync();
                
    }
}

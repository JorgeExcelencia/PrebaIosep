using ApiIosep.Models.IOSEP;

namespace ApiIosep.Repositorio.Interfaces
{
    public interface IReportesIosepSaludRepository : IBaseRepository<ReportesIosepSalud>
    {
        Task<ReportesIosepSalud?> GetReportesIS(int idEmpresa, string period);
    }
}

using Models.Models.Creditos;

namespace Repository.Repositorio.Interfaces
{
    public interface ILotesRepository  
    {
        Task<List<CreditosLotes>> GetLotesXPeriodoAsync(string periodo);
        Task<List<CreditosLotes>> GetLotesXPeriodoByCodigo(string periodo, string codigo);
        List<CreditosLoteDetalles> GetLoteDetallesByID(int id);
        CreditosLotes? GetCreditosLotesByID(int id);
        CreditosLotes? GetCreditosLoteByConcepto(string periodo, string concepto);

        void CrearLote(CreditosLotesDTO lote);
        void CrearDetalleLote(CreditosLoteDetallesDTO DetalleloteDTO);
        CreditosLoteDetalles? GetUltimoLoteDetalleByID(int id);
        Task<List<CabeceraLote>> GetCabeceraLoteAsync();
        Task<CreditosLoteDetalles?> GetLotesXPeriodoXConcepto(string conceptoCodigo, string periodo);

    }
}

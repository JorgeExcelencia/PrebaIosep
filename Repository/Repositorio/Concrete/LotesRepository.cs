using ApiIosep.Models.IOSEP;
using Microsoft.EntityFrameworkCore;
using Models.Models.Creditos;
using Repository.Repositorio.Interfaces;

namespace Repository.Repositorio.Concrete
{
    public class LotesRepository : ILotesRepository
    {
        public IOSEPContext _context;
        public LotesRepository(IOSEPContext context)
        {
            _context = context;
        }
        public async Task<List<CreditosLotes>> GetLotesXPeriodoAsync(string periodo)
        {
            return await _context.CreditosLotes
                .Where(x => x.PeriodoProcesamiento == periodo && !x.Anulado)
                .ToListAsync();
        } 
        public async Task<List<CreditosLotes>> GetLotesXPeriodoByCodigo(string periodo, string codigo)
        {
            return await _context.CreditosLotes
                .Where(x => x.PeriodoProcesamiento == periodo && !x.Anulado && x.Descripcion == codigo)
                .ToListAsync();
        }
        public List<CreditosLoteDetalles> GetLoteDetallesByID(int id)
        {
            return _context.CreditosLoteDetalles.Where(x => x.IdLote == id).ToList();
        }
        public CreditosLotes? GetCreditosLotesByID(int id)
        {
            return _context.CreditosLotes.Where(x => x.IdLote == id).FirstOrDefault();
        }
        public CreditosLotes? GetCreditosLoteByConcepto(string periodo, string concepto)
        {
            return _context.CreditosLotes.Where(x => x.PeriodoProcesamiento == periodo && x.Descripcion == concepto).FirstOrDefault();
        }
        public void CrearLote(CreditosLotesDTO loteDTO)
        {
            CreditosLotes lote = new CreditosLotes{
                Descripcion = loteDTO.Descripcion,
                PeriodoProcesamiento = loteDTO.PeriodoProcesamiento,
                OperadorCrea = loteDTO.OperadorCrea,
                Anulado = false
            };
            _context.CreditosLotes.Add(lote);
            _context.SaveChanges();
        }
        public void CrearDetalleLote(CreditosLoteDetallesDTO DetalleloteDTO)
        {
            CreditosLoteDetalles creditosLoteDetalles = new CreditosLoteDetalles
            {
                ImporteTotal = 0,
                CantDocumentos = 0,
                IdLote = DetalleloteDTO.IdLote,
                Anulado = false
            };
            _context.CreditosLoteDetalles.Add(creditosLoteDetalles);
            _context.SaveChanges();
        }

        public CreditosLoteDetalles? GetUltimoLoteDetalleByID(int id)
        {
            return _context.CreditosLoteDetalles.Where(x => x.IdLote == id && !x.Anulado && x.CantDocumentos > 200).FirstOrDefault();
        }
        public async Task<List<CabeceraLote>> GetCabeceraLoteAsync()
        {
            return await _context.CabeceraLote.ToListAsync();
        } 
        public async Task <CreditosLoteDetalles?> GetLotesXPeriodoXConcepto(string conceptoCodigo,string periodo)
        {
            var lote = _context.CreditosLotes.Where(x => x.PeriodoProcesamiento == periodo && !x.Anulado && x.Descripcion == conceptoCodigo)
                .OrderByDescending(x => x.IdLote)
                .FirstOrDefault();
            if(lote is null)
            {
                return null;
            }
            var detalleLote =  _context.CreditosLoteDetalles.Where(x => x.IdLote == lote.IdLote && !x.Anulado)
                 .OrderByDescending(x => x.IdLoteDetalle)
                 .FirstOrDefault(); 

            return detalleLote;
        }
    }
}

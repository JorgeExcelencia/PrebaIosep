using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public class CreditosLoteDetalles
    {
        [Key]
        public int IdLoteDetalle { get; set; } = 0;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ImporteTotal { get; set; } = 0;

        public int? CantDocumentos { get; set; } = 0;

        public int IdLote { get; set; } = 0;

        public bool Anulado { get; set; } = false;
    }
}

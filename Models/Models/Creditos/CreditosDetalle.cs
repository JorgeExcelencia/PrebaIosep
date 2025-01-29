using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public partial class CreditosDetalle
    {
        [Key]
        public int IdDetalleCredito { get; set; }

        [StringLength(10)]
        public string Subcodigo { get; set; } = string.Empty;

        [StringLength(20)]
        public string NroCredito { get; set; } = string.Empty;

        [StringLength(10)]
        public string CodMovimiento { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ImporteCuota { get; set; } = 0;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Saldo { get; set; } = 0;

        public bool Anulado { get; set; } = false;

        public int IdCredito { get; set; } = 0;
        public int IdDetalle { get; set; } = 0;
        public string Periodo { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public class CreditosConcCred
    {
        [Key]
        public int IdConcCred { get; set; }

        [StringLength(100)]
        public string Desc_conc { get; set; } = string.Empty;
        public DateTime? Fecha_baja { get; set; }
        [StringLength(100)]
        public string? Motivo_baja { get; set; }
        [StringLength(11)]
        public string? Operador { get; set; }
    }
}

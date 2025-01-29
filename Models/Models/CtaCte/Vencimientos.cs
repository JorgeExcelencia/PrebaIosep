using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte
{
    [Table("VencimientosPeriodosFacturacion")]
    public class Vencimientos
    {
        [Key]
        public int IdPeriodo { get; set; }
        public string Periodo { get; set; } = string.Empty;
        public DateTime Vencimiento_1 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal? Interes_1 { get; set; } = 0;
        public DateTime? Vencimiento_2 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal? Interes_2 { get; set; } = 0;
        public string? Renglon_1 { get; set; }
        public string? Renglon_2 { get; set; }
        public string? Renglon_3 { get; set; }
        public string? Lugar_de_pago1 { get; set; }
        public string? Lugar_de_pago2 { get; set; }
        public bool Anulado { get; set; } = false;
        public DateTime? Vencimiento_ProntoPago { get; set; }
        public DateTime? Vencimiento_1_Original { get; set; }
        public DateTime? Vencimiento_2_Original { get; set; }
    }
}

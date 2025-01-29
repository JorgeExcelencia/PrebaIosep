using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte
{
    [Table("IosepSaludHistorialCuotas")]
    public class Cuotas
    {
        [Key]
        public int IdIosepSaludHistorialCuotas { get; set; }
        public string Resolucion { get; set; } = string.Empty;
        public string? ReferenciaResolucion { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime VigenciaHasta { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Titular1 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Esposa1 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Hijo1 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Titular2 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Esposa2 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Hijo2 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Titular3 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Esposa3 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Hijo3 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Titular4 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Esposa4 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Hijo4 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Titular5 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Esposa5 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Hijo5 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Titular6 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Titular7 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Adicional7 { get; set; }
        public DateTime Cargada { get; set; }
        public string OperadorCarga { get; set; } = string.Empty;
        public DateTime? FechaAnula { get; set; }
        public DateTime? FechaHastaAnterior { get; set; }
        public bool Anulada { get; set; } = false;

    }
}

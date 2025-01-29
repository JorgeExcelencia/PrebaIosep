using ApiIosep.Models.Persona;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte
{
    [Table("ComprobanteDetalle", Schema = "iosepsalud")]
    public class ComprobanteDetalle
    {
        [Key]
        public int IdComprobanteDetalle { get; set; }
        public int IdComprobante { get; set; }
        public DateTime Vencimiento1 { get; set; }
        public decimal ImporteVence1 { get; set; }
        public DateTime Vencimiento2 { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ImporteVence2 { get; set; }
        public int IdDetalle { get; set; }
        public string? Detalle { get; set; }
        public string? CuponCoseguro { get; set; }
        public string? Periodo { get; set; }
        public DateTime? Fecha { get; set; }
        public bool Anulado { get; set; } = false;
        public int? IdDetalleFactura { get; set; }
        //public DateTime? Vencimiento_1_Original { get; set; }
        //public DateTime? Vencimiento_2_Original { get; set; }
        public virtual Comprobante Comprobante { get; set; } = new();
    }
}

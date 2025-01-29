using ApiIosep.Models.Persona;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiIosep.Models.CtaCte
{
    [Table("Comprobante", Schema = "iosepsalud")]
    public class Comprobante
    {
        public Comprobante()
        {
            ComprobanteDetalle = new HashSet<ComprobanteDetalle>();
            ComprobanteLog = new HashSet<ComprobanteLog>();
        }

        [Key]
        public int IdComprobante { get; set; }
        public int IdAfiliado { get; set; }
        public int IdCajaTipoOrigen { get; set; }
        [StringLength(14)]
        public string Numero { get; set; }
        public Byte Cuotas { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Importe { get; set; }
        public string? CodigoBarra { get; set; }
        public int? IdTipoMovimiento { get; set; }
        public int? IdDetalle { get; set; }
        [StringLength(50)]
        public string? Detalle { get; set; }
        public int? IdEmpresa { get; set; }
        [StringLength(6)]
        public string? Periodo { get; set; }
        public bool Anulado { get; set; } = false;

        [JsonIgnore]
        public virtual ICollection<ComprobanteDetalle> ComprobanteDetalle { get; set; }
        [JsonIgnore]
        public virtual ICollection<ComprobanteLog> ComprobanteLog { get; set; }
    }
}

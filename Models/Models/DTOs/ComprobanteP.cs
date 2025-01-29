using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ApiIosep.Models.CtaCte;

namespace Models.Models.DTOs
{
    public class ComprobanteP
    {
        public ComprobanteP()
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
        public DateTime? Vencimiento_1_Original { get; set; }
        public DateTime? Vencimiento_2_Original { get; set; }

        [JsonIgnore]
        public virtual ICollection<ComprobanteDetalle> ComprobanteDetalle { get; set; }
        [JsonIgnore]
        public virtual ICollection<ComprobanteLog> ComprobanteLog { get; set; }
    }
}

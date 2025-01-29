using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte
{
    [Keyless]
    public class ComprobanteVM
    {
        public int IdComprobante { get; set; }
        public int IdAfiliado { get; set; }
        public string Numero { get; set; } = String.Empty;
        public Byte Cuotas { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Debe { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Haber { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Saldo { get; set; }
        public string? CodigoBarra { get; set; }
        public int? IdDetalle { get; set; }
        public string? DetalleFactura { get; set; }
        public string? Detalle { get; set; }
        public int? IdEmpresa { get; set; }
        public string? Periodo { get; set; }
        public string? NumeroPago { get; set; } = String.Empty;
    }
}

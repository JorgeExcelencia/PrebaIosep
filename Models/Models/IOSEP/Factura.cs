using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Factura
    {
        public int IdFactura { get; set; }
        public int? IdEncabezadoFactura { get; set; }
        public int TipoComprobanteId { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public decimal Importe { get; set; }
        public string CUIT { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public int? IdAfiliado { get; set; }
        public string? CAI { get; set; }
        public string? CAE { get; set; }
        public int? TipoServicio { get; set; }
        public string? Codigo { get; set; }
        public string? Observacion { get; set; }
        public bool Valido { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual Encabezado_Factura? IdEncabezadoFacturaNavigation { get; set; }
        public virtual Tipo_Comprobante TipoComprobante { get; set; } = null!;
    }
}

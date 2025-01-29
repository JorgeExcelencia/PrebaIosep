using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenCompra_Comprobante
    {
        public int OrdenCompraComprobanteId { get; set; }
        public int OrdenCompraEncabezadoId { get; set; }
        public int OrdenPagoId { get; set; }
        public int TipoComprobanteId { get; set; }
        public string Numero_Comprobante { get; set; } = null!;
        public DateTime Fecha_Comprobante { get; set; }
        public int ProveedorId { get; set; }
        public string CUIT { get; set; } = null!;
        public string? CAI { get; set; }
        public decimal? Importe_Bruto { get; set; }
        public decimal? Importe_Retencion { get; set; }
        public decimal? Importe_Iva { get; set; }
        public decimal? Importe_Neto { get; set; }
        public bool Anulado { get; set; }

        public virtual OrdenCompra_Encabezado OrdenCompraEncabezado { get; set; } = null!;
        public virtual Tipo_Comprobante TipoComprobante { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class comprobanteDetalle
    {
        public int IdComprobanteDetalle { get; set; }
        public int IdComprobante { get; set; }
        public DateTime Vencimiento1 { get; set; }
        public decimal ImporteVence1 { get; set; }
        public DateTime Vencimiento2 { get; set; }
        public decimal? ImporteVence2 { get; set; }
        public int IdDetalle { get; set; }
        public string? Detalle { get; set; }
        public string? CuponCoseguro { get; set; }
        public string? Periodo { get; set; }
        public DateTime? Fecha { get; set; }
        public bool Anulado { get; set; }
        public int? IdDetalleFactura { get; set; }

        public string? numeroPago { get; set; }
        public int? idAfiliado { get; set; }

        public virtual comprobante IdComprobanteNavigation { get; set; } = null!;
    }
}

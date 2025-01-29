using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenPago_DetalleCheque
    {
        public int OrdenPagoDetalleChequesID { get; set; }
        public int OrdenPagoID { get; set; }
        public int TipoMovimientosBancoID { get; set; }
        public string Numero_Comprobante { get; set; } = null!;
        public decimal Importe { get; set; }
        public string? Observaciones { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public DateTime? Fecha_Impresion { get; set; }
        public DateTime? Fecha_Vencimiento { get; set; }
        public DateTime? Fecha_Entrega { get; set; }
        public DateTime? Fecha_Ingreso { get; set; }
        public string? OpCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual Orden_Pago OrdenPago { get; set; } = null!;
        public virtual Tipo_MovimientoBanco TipoMovimientosBanco { get; set; } = null!;
    }
}

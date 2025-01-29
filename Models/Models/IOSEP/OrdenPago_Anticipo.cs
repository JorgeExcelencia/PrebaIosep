using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenPago_Anticipo
    {
        public int OrdenPagoAnticiposID { get; set; }
        public int OrdenPagoID { get; set; }
        public DateTime Fecha_Anticipo { get; set; }
        public string Detalle { get; set; } = null!;
        public decimal Importe { get; set; }
        public string? OpCrea { get; set; }
        public bool? Pagado { get; set; }
        public bool Anulado { get; set; }

        public virtual Orden_Pago OrdenPago { get; set; } = null!;
    }
}

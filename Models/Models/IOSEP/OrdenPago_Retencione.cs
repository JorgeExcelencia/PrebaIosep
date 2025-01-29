using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenPago_Retencione
    {
        public int OrdenPagoRetencionesID { get; set; }
        public int OrdenPagoID { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoRetencionID { get; set; }
        public decimal Importe_Retenido { get; set; }
        public string? OpCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual Orden_Pago OrdenPago { get; set; } = null!;
        public virtual Tipo_Retencion TipoRetencion { get; set; } = null!;
    }
}

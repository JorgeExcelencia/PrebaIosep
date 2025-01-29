using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoOrdenPago
    {
        public TipoOrdenPago()
        {
            Orden_Pagos = new HashSet<Orden_Pago>();
        }

        public int TipoOrdenPagoID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Orden_Pago> Orden_Pagos { get; set; }
    }
}

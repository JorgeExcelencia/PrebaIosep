using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_MovimientoBanco
    {
        public Tipo_MovimientoBanco()
        {
            OrdenPago_DetalleCheques = new HashSet<OrdenPago_DetalleCheque>();
        }

        public int TipoMovimientosBancoID { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<OrdenPago_DetalleCheque> OrdenPago_DetalleCheques { get; set; }
    }
}

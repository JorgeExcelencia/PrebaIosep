using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoMovimientoCuentum
    {
        public TipoMovimientoCuentum()
        {
            Movimiento_Cuenta = new HashSet<Movimiento_Cuentum>();
        }

        public int TipoMovimientoCuentaID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Movimiento_Cuentum> Movimiento_Cuenta { get; set; }
    }
}

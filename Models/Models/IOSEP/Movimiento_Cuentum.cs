using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Movimiento_Cuentum
    {
        public int MovimientoCuentaID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public int TipoMovimientoCuentaID { get; set; }
        public int CuentaBancoID { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool? Anulado { get; set; }

        public virtual Cuentas_Banco CuentaBanco { get; set; } = null!;
        public virtual TipoMovimientoCuentum TipoMovimientoCuenta { get; set; } = null!;
    }
}

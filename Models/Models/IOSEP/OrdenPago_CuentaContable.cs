using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenPago_CuentaContable
    {
        public int OrdenPago_CuentaContableID { get; set; }
        public int OrdenPagoID { get; set; }
        public int CuentaContableID { get; set; }
        public int CuentaBancoID { get; set; }
        public short Asiento { get; set; }
        public short AsientoManual { get; set; }
        public DateTime FechaCrea { get; set; }
        public decimal Importe_Parcial { get; set; }
        public bool Anulado { get; set; }

        public virtual Cuentas_Banco CuentaBanco { get; set; } = null!;
        public virtual Orden_Pago OrdenPago { get; set; } = null!;
    }
}

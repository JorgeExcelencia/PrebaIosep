using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Estados_Cuenta
    {
        public int EstadoCuentaID { get; set; }
        public int CuentaBancoID { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoActual { get; set; }
        public string OpeCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}

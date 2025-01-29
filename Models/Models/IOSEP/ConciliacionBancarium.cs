using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConciliacionBancarium
    {
        public int IdConciliacionBancaria { get; set; }
        public int IdCuentaBancaria { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public DateTime FechaValor { get; set; }
        public decimal Monto { get; set; }
        public string Referencia { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual Cuentas_Banco IdCuentaBancariaNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Historico_EstadosCuenta
    {
        public int HistoricoEstadosCuentasID { get; set; }
        public int CuentaBancoID { get; set; }
        public decimal SaldoInicial { get; set; }
        public DateTime FechaSaldoInicial { get; set; }
        public decimal SaldoAnterior { get; set; }
        public DateTime FechaSaldoAnterior { get; set; }
        public decimal SaldoActual { get; set; }
        public DateTime FechaSaldoActual { get; set; }
        public string OperCrea { get; set; } = null!;
    }
}

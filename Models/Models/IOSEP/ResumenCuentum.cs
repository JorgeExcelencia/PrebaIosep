using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ResumenCuentum
    {
        public int ResumenCuentaId { get; set; }
        public int CuentaBancoID { get; set; }
        public string CBU { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Comprobante { get; set; } = null!;
        public int TipoMovimientosBancoId { get; set; }
        public decimal Debito { get; set; }
        public decimal Credito { get; set; }
        public decimal Saldos { get; set; }
        public string OperadorCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}

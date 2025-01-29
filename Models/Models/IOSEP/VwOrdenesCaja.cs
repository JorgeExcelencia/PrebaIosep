using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwOrdenesCaja
    {
        public int IdCaja { get; set; }
        public string Lugar { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string TipoCaja { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public short Cantidad { get; set; }
        public decimal Importe { get; set; }
        public string FormaPago { get; set; } = null!;
        public decimal Pagado { get; set; }
        public string Concepto { get; set; } = null!;
        public string Cajero { get; set; } = null!;
        public bool Anulado { get; set; }
        public int IdOrden { get; set; }
        public int IdCierreCaja { get; set; }
        public int IdConcepto { get; set; }
    }
}

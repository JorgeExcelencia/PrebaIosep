using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwCaja
    {
        public int IdCaja { get; set; }
        public string Lugar { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string TipoCaja { get; set; } = null!;
        public short Cantidad { get; set; }
        public decimal Importe { get; set; }
        public string FormaPago { get; set; } = null!;
        public decimal Pagado { get; set; }
        public string Concepto { get; set; } = null!;
        public string Cajero { get; set; } = null!;
        public bool Anulado { get; set; }
        public int IdCierreCaja { get; set; }
        public int IdConcepto { get; set; }
        public short IdTipoCaja { get; set; }
        public short IdTipoLugar { get; set; }
        public short IdTipoFormaPago { get; set; }
        public int? IdAutoriza { get; set; }
        public string? comprobante_original { get; set; }
        public string? TipoOrden { get; set; }
        public int? IdAfiliado { get; set; }
    }
}

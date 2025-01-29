using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LiquidacionGremiosDetalle
    {
        public int LiquidacionGremiosDetalleID { get; set; }
        public int LiquidacionGremiosEncabezadoID { get; set; }
        public int InternadoID { get; set; }
        public string Estado { get; set; } = null!;
        public decimal? ImporteOS { get; set; }
        public decimal? ImporteGremio { get; set; }
        public decimal? ImporteCuota { get; set; }
        public string? CantidadCuotas { get; set; }
        public string? MotivoDebito { get; set; }
        public bool Anulado { get; set; }

        public virtual LiquidacionGremiosEncabezado LiquidacionGremiosEncabezado { get; set; } = null!;
    }
}

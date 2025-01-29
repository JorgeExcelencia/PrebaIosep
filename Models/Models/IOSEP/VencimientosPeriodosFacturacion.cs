using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VencimientosPeriodosFacturacion
    {
        public int idPeriodo { get; set; }
        public string Periodo { get; set; } = null!;
        public DateTime Vencimiento_1 { get; set; }
        public decimal? Interes_1 { get; set; }
        public DateTime? Vencimiento_2 { get; set; }
        public decimal? Interes_2 { get; set; }
        public string? Renglon_1 { get; set; }
        public string? Renglon_2 { get; set; }
        public string? Renglon_3 { get; set; }
        public string? Lugar_de_pago1 { get; set; }
        public string? Lugar_de_pago2 { get; set; }
        public bool Anulado { get; set; }
        public DateTime? Vencimiento_ProntoPago { get; set; }
        public DateTime Vencimiento_1_Original { get; set; }
        public DateTime Vencimiento_2_Original { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LugarPagoDDJJ
    {
        public int IdLugarPagoDDJJ { get; set; }
        public int IdLugarPago { get; set; }
        public int IdDdjj { get; set; }
        public string? NumBeneficioAnses { get; set; }
        public DateTime Fecha_Desde { get; set; }
        public DateTime? Fecha_Hasta { get; set; }
        public int IdSituacionLaboral { get; set; }
        public decimal? Sueldo { get; set; }
        public decimal? Aporte { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaCrea { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual AfiliadosDDJJ IdDdjjNavigation { get; set; } = null!;
        public virtual Tipo_LugarPago IdLugarPagoNavigation { get; set; } = null!;
        public virtual Tipo_SituacionLaboral IdSituacionLaboralNavigation { get; set; } = null!;
    }
}

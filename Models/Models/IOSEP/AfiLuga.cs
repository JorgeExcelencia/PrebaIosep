using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiLuga
    {
        public int IdAfiLuga { get; set; }
        public string A_Numero { get; set; } = null!;
        public string LugarPa { get; set; } = null!;
        public decimal? Familiares { get; set; }
        public decimal? Af_Adic { get; set; }
        public DateTime? F_Releve { get; set; }
        public decimal? Haberes { get; set; }
        public decimal? Aportes { get; set; }
        public decimal? Adicional { get; set; }
        public decimal? Haber { get; set; }
        public decimal? Aporte { get; set; }
        public bool? Comp { get; set; }
        public bool? Anses { get; set; }
        public bool? Varios { get; set; }
        public decimal? Veces { get; set; }
        public string? Control { get; set; }
        public bool? Voluntar { get; set; }
        public string? Viejo { get; set; }
        public decimal? Adicional2 { get; set; }
        public decimal? NCtrol { get; set; }
        public string? Familiar { get; set; }
    }
}

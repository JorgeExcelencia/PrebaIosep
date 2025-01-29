using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadosLugarPago
    {
        public int IdAfiliadosLugarPago { get; set; }
        public int IdLugarPago { get; set; }
        public int IdAfiliado { get; set; }
        public string? NumBeneficioAnses { get; set; }
        public DateTime? Fecha_Desde { get; set; }
        public DateTime? Fecha_Hasta { get; set; }
        public decimal? Sueldo { get; set; }
        public decimal? Aporte { get; set; }
        public decimal? Adicional { get; set; }
        public int? IdSituacionLaboral { get; set; }
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }
    }
}

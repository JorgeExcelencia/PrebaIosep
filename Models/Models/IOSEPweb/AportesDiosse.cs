using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AportesDiosse
    {
        public int IdAporteDiosse { get; set; }
        public string Desconocido { get; set; } = null!;
        public string NumeroControl { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string ApellidoNombre { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string LugarPago { get; set; } = null!;
        public string Planta { get; set; } = null!;
        public decimal HaberIosep { get; set; }
        public decimal HaberCredito { get; set; }
        public decimal AporteGrupo { get; set; }
        public decimal AporteAdicional { get; set; }
        public decimal DescuentoCredito { get; set; }
        public decimal AportePatronal { get; set; }
        public string MesLiquidacion { get; set; } = null!;
        public string AnioLiquidacion { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}

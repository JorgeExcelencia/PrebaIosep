using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VwAportesAfiliado
    {
        public string? Periodo { get; set; }
        public string? Cuil { get; set; }
        public string? Afiliado { get; set; }
        public string? NumeroControl { get; set; }
        public string? NumeroBeneficio { get; set; }
        public string? CodigoLiquidacion { get; set; }
        public string? LugarPago { get; set; }
        public decimal? HaberIosep { get; set; }
        public decimal HaberCredito { get; set; }
        public decimal? AporteGrupo { get; set; }
        public decimal AporteAdicional { get; set; }
        public string CodArchivo { get; set; } = null!;
    }
}

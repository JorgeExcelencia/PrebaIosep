using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class tyoEnero
    {
        public double? Codigo { get; set; }
        public string? NombrePractica { get; set; }
        public DateTime? Vigencia { get; set; }
        public double? Honorario { get; set; }
        public double? Gastos { get; set; }
        public double? NuevoHon { get; set; }
        public double? NuevoGastos { get; set; }
    }
}

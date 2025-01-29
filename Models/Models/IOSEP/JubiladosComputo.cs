using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class JubiladosComputo
    {
        public string? Beneficio { get; set; }
        public string? Afiliado { get; set; }
        public string? Filler { get; set; }
        public int? Tipo { get; set; }
        public string? DNI { get; set; }
        public int? Cod_Anses { get; set; }
        public double? Haber { get; set; }
        public double? Descuento { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
        public string? Cuil { get; set; }
        public DateTime? Fec_Nac { get; set; }
        public string? Sexo { get; set; }
        public string? Iosep { get; set; }
    }
}

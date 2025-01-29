using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class IngresosMunicipio
    {
        public int IdIngresosMunicipios { get; set; }
        public string? CUIL { get; set; }
        public decimal? SUJETO { get; set; }
        public string? NOMBRE { get; set; }
        public string? MUNICOMI { get; set; }
        public string? PERIODO { get; set; }
        public decimal? APORTES { get; set; }
        public decimal? CONTRIB { get; set; }
        public decimal? COSEGURO { get; set; }
        public decimal? PRESENTA { get; set; }
    }
}

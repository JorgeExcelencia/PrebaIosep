using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AportesMunicipio
    {
        public int IdAportesMunicipios { get; set; }
        public string? Cuil { get; set; }
        public decimal? Sujeto { get; set; }
        public string? Nombre { get; set; }
        public string? MuniComi { get; set; }
        public string? Periodo { get; set; }
        public decimal? Aportes { get; set; }
        public decimal? Contrib { get; set; }
        public decimal? Coseguro { get; set; }
        public decimal? Presenta { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
    }
}

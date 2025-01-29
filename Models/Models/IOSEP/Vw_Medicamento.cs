using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Medicamento
    {
        public string Troquel { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string Tamano { get; set; } = null!;
        public string Monodroga { get; set; } = null!;
        public decimal? Importe { get; set; }
        public int IdManual { get; set; }
        public string CodBarras { get; set; } = null!;
        public int NroRegistro { get; set; }
        public string Laboratorio { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AccionFarmacologica
    {
        public int IdManual { get; set; }
        public string Nombre { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string MonoDro { get; set; } = null!;
        public string AccioFar { get; set; } = null!;
        public string Laboratorio { get; set; } = null!;
    }
}

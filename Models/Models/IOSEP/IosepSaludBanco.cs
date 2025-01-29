using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class IosepSaludBanco
    {
        public int IdIosepSaludBanco { get; set; }
        public string NombreArchivo { get; set; } = null!;
        public DateTime FechaCargado { get; set; }
        public string Linea_Control { get; set; } = null!;
        public string Operador { get; set; } = null!;
        public int? Total_Registros { get; set; }
        public decimal? Total_cobrado { get; set; }
        public int? TotalRegistrosIncorrectos { get; set; }
        public decimal? TotalMontoIncorrecto { get; set; }
        public int? TotalRegistrosArchivo { get; set; }
    }
}

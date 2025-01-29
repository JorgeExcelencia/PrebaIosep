using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RedLink_ArchivoRefresh
    {
        public int EnvioID { get; set; }
        public string NombreArchivo { get; set; } = null!;
        public string RI_IdentRegistro { get; set; } = null!;
        public string RI_Codigo { get; set; } = null!;
        public string RI_FechaProc { get; set; } = null!;
        public int RI_Lote { get; set; }
        public string? RF_IdentRegistro { get; set; }
        public int? RF_CantRegistros { get; set; }
        public decimal? RF_TotalPrimerVenc { get; set; }
        public decimal? RF_TotalSegundoVenc { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string? Periodo { get; set; }
        public int? Volumen { get; set; }
    }
}

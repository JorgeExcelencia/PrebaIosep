using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RedLink_ArchivoControl
    {
        public int ControlID { get; set; }
        public int? EnvioID { get; set; }
        public string? NombreArchivo { get; set; }
        public string? RI_IdentificacionInicio { get; set; }
        public string? RI_Fecha { get; set; }
        public string? RI_Codigo { get; set; }
        public string? RI_NombreArchivoRefresh { get; set; }
        public string? RI_LongitudArchivo { get; set; }
        public string? RF_IdentificacionFinal { get; set; }
        public int? RF_CantTotalRegistros { get; set; }
        public decimal? RF_TotalPrimerVencimiento { get; set; }
        public decimal? RF_TotalSegundoVencimiento { get; set; }
        public string? RF_FechaUltimoVencimiento { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string? Anulado { get; set; }
    }
}

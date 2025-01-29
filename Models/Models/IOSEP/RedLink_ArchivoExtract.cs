using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RedLink_ArchivoExtract
    {
        public int ExtractID { get; set; }
        public string RI_TipoRegistro { get; set; } = null!;
        public string RI_Codigo { get; set; } = null!;
        public string RI_FechaProceso { get; set; } = null!;
        public string? RF_TipoRegistro { get; set; }
        public int? RF_CantRegistros { get; set; }
        public decimal? RF_SumaImportes { get; set; }
        public DateTime? FechaCrea { get; set; }
        public bool? Anulado { get; set; }
        public string? NombreArchivo { get; set; }
        public string? UsuarioCrea { get; set; }
    }
}

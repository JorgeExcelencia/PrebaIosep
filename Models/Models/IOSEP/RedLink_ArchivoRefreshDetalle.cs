using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RedLink_ArchivoRefreshDetalle
    {
        public int DetalleEnvioID { get; set; }
        public int EnvioID { get; set; }
        public string IdentificadorDeuda { get; set; } = null!;
        public string IdentificadorConcepto { get; set; } = null!;
        public string IdentificacionUsuario { get; set; } = null!;
        public string FechaPrimerVencimiento { get; set; } = null!;
        public decimal ImportePrimerVencimiento { get; set; }
        public string? FechaSegundoVencimiento { get; set; }
        public decimal? ImporteSegundoVencimiento { get; set; }
        public string Comprobante { get; set; } = null!;
        public string? Discrecional { get; set; }
        public bool? Anulado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class HistorialMontoCarnet
    {
        public int HistorialMontoCarnetID { get; set; }
        public int MotivoImpresionID { get; set; }
        public string? Resolucion { get; set; }
        public string? RefResolucion { get; set; }
        public string? NroExpediente { get; set; }
        public string? RefExpediente { get; set; }
        public decimal Importe { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
    }
}

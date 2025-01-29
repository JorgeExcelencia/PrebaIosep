using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DiagnosticoImagen
    {
        public int DiagnosticoImagenID { get; set; }
        public int ResultadoId { get; set; }
        public string? Observaciones { get; set; }
        public int AutorizacionesId { get; set; }
        public int DetalleId { get; set; }
        public string Afiliado { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public bool Digitalizado { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
    }
}

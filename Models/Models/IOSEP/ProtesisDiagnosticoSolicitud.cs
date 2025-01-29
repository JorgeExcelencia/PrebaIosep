using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProtesisDiagnosticoSolicitud
    {
        public int ProtesisDiagnosticoSolicitudID { get; set; }
        public int ProtesisEncabezadoSolicitudID { get; set; }
        public int IdDiagnostico { get; set; }
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? MotivoAnulaID { get; set; }
        public string? ObservacionesAnula { get; set; }
    }
}

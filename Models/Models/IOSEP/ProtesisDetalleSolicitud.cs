using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProtesisDetalleSolicitud
    {
        public int ProtesisDetalleSolicitudID { get; set; }
        public int ProtesisEncabezadoSolicitudID { get; set; }
        public int IdProtesis { get; set; }
        public int? ProtesisNomencladorID { get; set; }
        public int CantidadSolicitada { get; set; }
        public int CantidadAutorizada { get; set; }
        public decimal PrecioProtesis { get; set; }
        public string EstadoAutorizacion { get; set; } = null!;
        public string? MotivoRechazo { get; set; }
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

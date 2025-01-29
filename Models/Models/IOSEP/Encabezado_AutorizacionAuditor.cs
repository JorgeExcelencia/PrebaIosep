using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Encabezado_AutorizacionAuditor
    {
        public int EncabezadoAutorizacionAudID { get; set; }
        public string Auditor { get; set; } = null!;
        public DateTime FechaAuditoria { get; set; }
        public string TipoPractica { get; set; } = null!;
        public int? AutorizacionesId { get; set; }
        public int? DetalleID { get; set; }
        public string? Observaciones { get; set; }
        public bool PreBono { get; set; }
        public bool Protesis { get; set; }
    }
}

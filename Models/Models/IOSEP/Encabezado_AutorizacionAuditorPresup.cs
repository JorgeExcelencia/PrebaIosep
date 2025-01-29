using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Encabezado_AutorizacionAuditorPresup
    {
        public int EncabezadoAutorizacionAudPresupID { get; set; }
        public string Auditor { get; set; } = null!;
        public DateTime FechaAuditoria { get; set; }
        public string TipoPractica { get; set; } = null!;
        public int? AutorizacionesID { get; set; }
        public int? DetalleID { get; set; }
        public string? Observaciones { get; set; }
    }
}

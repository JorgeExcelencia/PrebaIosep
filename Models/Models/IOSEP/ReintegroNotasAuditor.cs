using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ReintegroNotasAuditor
    {
        public int ReintegroNotasAuditorID { get; set; }
        public int ReintegrosEncabezadoID { get; set; }
        public string Notas { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Auditor { get; set; }
        public int? SectorID { get; set; }
        public bool DeAuditoria { get; set; }
    }
}

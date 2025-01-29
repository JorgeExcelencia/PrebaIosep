using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class HistorialAuditorium
    {
        public int HistorialAuditoriaID { get; set; }
        public int ReintegroID { get; set; }
        public string UsuarioAperturaAuditoria { get; set; } = null!;
        public DateTime FechaAperturaAuditoria { get; set; }
        public int MotivoAperturaID { get; set; }
        public string Observaciones { get; set; } = null!;
    }
}

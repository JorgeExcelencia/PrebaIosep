using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NotasAuditoriaInternado
    {
        public int NotaAuditoriaID { get; set; }
        public int? AutorizacionesID { get; set; }
        public int InternadoID { get; set; }
        public string NotaAuditoria { get; set; } = null!;
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
    }
}

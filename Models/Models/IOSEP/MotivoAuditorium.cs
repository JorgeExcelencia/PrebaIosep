using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoAuditorium
    {
        public int MotivoAuditoriaID { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool AbrirAuditoria { get; set; }
        public bool CerrarAuditoria { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}

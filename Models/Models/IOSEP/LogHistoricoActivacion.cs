using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LogHistoricoActivacion
    {
        public int IDLogActivacion { get; set; }
        public string NroBono { get; set; } = null!;
        public string TipoBono { get; set; } = null!;
        public int IdTipoBono { get; set; }
        public int IdCierreCaja { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioAnulo { get; set; } = null!;
        public string MotivoAnulacion { get; set; } = null!;
        public DateTime FechaActivacion { get; set; }
        public string UsuarioActiva { get; set; } = null!;
        public string MotivoActivacion { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}

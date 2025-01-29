using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LogBajasProcesoNocturno
    {
        public int IdLog { get; set; }
        public string Cuil { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioCrea { get; set; }
    }
}

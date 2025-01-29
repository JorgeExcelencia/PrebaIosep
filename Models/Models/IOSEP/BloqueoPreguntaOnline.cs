using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class BloqueoPreguntaOnline
    {
        public int PreguntaID { get; set; }
        public string Pregunta { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
    }
}

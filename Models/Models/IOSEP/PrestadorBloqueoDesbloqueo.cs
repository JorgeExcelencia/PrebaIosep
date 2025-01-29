using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorBloqueoDesbloqueo
    {
        public int BloqueoDesbloqueoID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int MotivoBloqueoID { get; set; }
        public string? Observaciones { get; set; }
        public bool Bloqueo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaBloqueoDesbloqueo { get; set; }
        public string UsuarioBloqueoDesb { get; set; } = null!;
    }
}

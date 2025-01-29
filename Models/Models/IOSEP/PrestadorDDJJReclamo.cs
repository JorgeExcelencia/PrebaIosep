using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJReclamo
    {
        public int PrestadorDDJJReclamoID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int MotivoReclamoID { get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaReclamo { get; set; }
        public string NumExpediente { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string Usuario { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual PrestadorMotivoReclamo MotivoReclamo { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}

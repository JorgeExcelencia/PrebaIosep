using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJSuspendido
    {
        public int PrestadorDDJJSuspendidoID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int MotivoSuspensionID { get; set; }
        public string? Observaciones { get; set; }
        public string NumExpediente { get; set; } = null!;
        public string NumResolucion { get; set; } = null!;
        public DateTime FechaSuspendidoDesde { get; set; }
        public DateTime FechaSuspendidoHasta { get; set; }
        public DateTime FechaCrea { get; set; }
        public string Usuario { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual PrestadorMotivoSuspension MotivoSuspension { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorMotivoSuspension
    {
        public PrestadorMotivoSuspension()
        {
            PrestadorDDJJSuspendidos = new HashSet<PrestadorDDJJSuspendido>();
        }

        public int PrestadorMotivoSuspensionID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJSuspendido> PrestadorDDJJSuspendidos { get; set; }
    }
}

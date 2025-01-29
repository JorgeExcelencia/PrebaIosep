using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorMotivoReclamo
    {
        public PrestadorMotivoReclamo()
        {
            PrestadorDDJJReclamos = new HashSet<PrestadorDDJJReclamo>();
        }

        public int PrestadorMotivoReclamoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJReclamo> PrestadorDDJJReclamos { get; set; }
    }
}

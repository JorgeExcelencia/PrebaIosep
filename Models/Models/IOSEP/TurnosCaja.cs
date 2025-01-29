using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TurnosCaja
    {
        public TurnosCaja()
        {
            RendicionCajas = new HashSet<RendicionCaja>();
        }

        public int IdTurnoCaja { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<RendicionCaja> RendicionCajas { get; set; }
    }
}

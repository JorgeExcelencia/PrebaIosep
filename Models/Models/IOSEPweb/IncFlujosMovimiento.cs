using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncFlujosMovimiento
    {
        public IncFlujosMovimiento()
        {
            IncFlujosEsquemas = new HashSet<IncFlujosEsquema>();
        }

        public int FlujoMovimientoId { get; set; }
        public int FlujodeTrabajoId { get; set; }
        public int EstadoId { get; set; }
        public short Orden { get; set; }
        public bool Anulado { get; set; }

        public virtual IncEstado Estado { get; set; } = null!;
        public virtual IncFlujodeTrabajo FlujodeTrabajo { get; set; } = null!;
        public virtual ICollection<IncFlujosEsquema> IncFlujosEsquemas { get; set; }
    }
}

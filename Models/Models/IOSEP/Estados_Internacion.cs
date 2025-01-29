using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Estados_Internacion
    {
        public Estados_Internacion()
        {
            MovimientosInternados = new HashSet<MovimientosInternado>();
        }

        public short IdEstado { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<MovimientosInternado> MovimientosInternados { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosSector
    {
        public InternadosSector()
        {
            MovimientosInternados = new HashSet<MovimientosInternado>();
        }

        public int SectorID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<MovimientosInternado> MovimientosInternados { get; set; }
    }
}

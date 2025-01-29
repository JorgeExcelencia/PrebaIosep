using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoAltum
    {
        public TipoAltum()
        {
            MovimientosInternados = new HashSet<MovimientosInternado>();
        }

        public short TipoAltaID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool? Deriva { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<MovimientosInternado> MovimientosInternados { get; set; }
    }
}

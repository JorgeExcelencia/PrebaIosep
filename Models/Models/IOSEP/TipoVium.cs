using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoVium
    {
        public TipoVium()
        {
            PorcentajeVia = new HashSet<PorcentajeVium>();
        }

        public int TipoViaID { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<PorcentajeVium> PorcentajeVia { get; set; }
    }
}

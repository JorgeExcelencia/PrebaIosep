using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NumeroCirugium
    {
        public NumeroCirugium()
        {
            PorcentajeVia = new HashSet<PorcentajeVium>();
        }

        public int NumeroCirugiaID { get; set; }
        public string DescripcionCorta { get; set; } = null!;
        public string DescripcionLarga { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<PorcentajeVium> PorcentajeVia { get; set; }
    }
}

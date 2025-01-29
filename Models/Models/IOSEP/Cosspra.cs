using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cosspra
    {
        public Cosspra()
        {
            AfiliadosDDJJs = new HashSet<AfiliadosDDJJ>();
        }

        public int IdCosspra { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<AfiliadosDDJJ> AfiliadosDDJJs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoCondicionIVA
    {
        public TipoCondicionIVA()
        {
            PrestadorDDJJs = new HashSet<PrestadorDDJJ>();
        }

        public int TipoCondicionIvaID { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal? IVA { get; set; }
        public bool? CalculaImpuesto { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJ> PrestadorDDJJs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoPrestadorDDJJ
    {
        public TipoPrestadorDDJJ()
        {
            PrestadorDDJJs = new HashSet<PrestadorDDJJ>();
        }

        public int TipoPrestadorDDJJID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJ> PrestadorDDJJs { get; set; }
    }
}

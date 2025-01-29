using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoPractica
    {
        public TipoPractica()
        {
            NPracticas_Bases = new HashSet<NPracticas_Base>();
        }

        public int TipoPracticaID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<NPracticas_Base> NPracticas_Bases { get; set; }
    }
}

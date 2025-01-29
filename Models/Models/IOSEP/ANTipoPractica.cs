using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANTipoPractica
    {
        public ANTipoPractica()
        {
            ANPracticasBases = new HashSet<ANPracticasBase>();
        }

        public int ANTipoPracticaID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<ANPracticasBase> ANPracticasBases { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANTipoCalculo
    {
        public ANTipoCalculo()
        {
            ANPracticasBases = new HashSet<ANPracticasBase>();
        }

        public int ANTipoCalculoID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<ANPracticasBase> ANPracticasBases { get; set; }
    }
}

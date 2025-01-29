using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TituloProfesional
    {
        public TituloProfesional()
        {
            PrestadorDDJJs = new HashSet<PrestadorDDJJ>();
        }

        public int TituloProfesionalID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJ> PrestadorDDJJs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ServicoCentro
    {
        public ServicoCentro()
        {
            PrestadorDDJJServicioCentros = new HashSet<PrestadorDDJJServicioCentro>();
        }

        public int ServicoCentroID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<PrestadorDDJJServicioCentro> PrestadorDDJJServicioCentros { get; set; }
    }
}

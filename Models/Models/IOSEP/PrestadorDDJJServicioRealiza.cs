using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJServicioRealiza
    {
        public int PrestadorDDJJServicioRealizaID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int ServicoRealizaID { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
        public virtual ServicoRealiza ServicoRealiza { get; set; } = null!;
    }
}

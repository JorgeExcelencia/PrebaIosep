using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJServicioCentro
    {
        public int PrestadorDDJJServicioCentroID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int ServicioCentroID { get; set; }
        public int PrestadorDDJJIDaCargo { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }

        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJIDaCargoNavigation { get; set; } = null!;
        public virtual ServicoCentro ServicioCentro { get; set; } = null!;
    }
}

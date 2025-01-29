using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SeguroMalaPraxiPago
    {
        public int SeguroMalaPraxiPagosID { get; set; }
        public int SeguroMalaPraxiID { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Pagado { get; set; }

        public virtual SeguroMalaPraxi SeguroMalaPraxi { get; set; } = null!;
    }
}

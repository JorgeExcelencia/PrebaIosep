using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncFlujosEsquema
    {
        public int FlujoEsquemaId { get; set; }
        public int FlujoMovimientoId { get; set; }
        public int Parent { get; set; }
        public bool Anulado { get; set; }

        public virtual IncFlujosMovimiento FlujoMovimiento { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VencimientoAfiliacione
    {
        public int VencimientoAfiliacionesID { get; set; }
        public int TipoVencimientoID { get; set; }
        public string Vencimiento { get; set; } = null!;
        public bool EsFecha { get; set; }
        public bool Anulado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Motivo_Reimpresion
    {
        public int MotivoReimpresionID { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal? Costo { get; set; }
        public bool Anulado { get; set; }
    }
}

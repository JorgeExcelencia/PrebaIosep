using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoBaja
    {
        public short IdMotivoBaja { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class zLog
    {
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; } = null!;
        public string? Tabla { get; set; }
    }
}

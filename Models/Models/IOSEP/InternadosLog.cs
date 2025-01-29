using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosLog
    {
        public int IdInternadoLog { get; set; }
        public int IdInternado { get; set; }
        public DateTime FechaControl { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
    }
}

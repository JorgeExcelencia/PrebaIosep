using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwEvolucion
    {
        public int IdEvolucion { get; set; }
        public int IdInternado { get; set; }
        public DateTime Fecha { get; set; }
        public string Evolucion { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Visible { get; set; }
        public bool Anulado { get; set; }
        public string UserName { get; set; } = null!;
        public bool SoloAuditores { get; set; }
    }
}

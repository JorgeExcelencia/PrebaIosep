using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosEvolucion
    {
        public int IdEvolucion { get; set; }
        public int IdInternado { get; set; }
        public DateTime Fecha { get; set; }
        public string Evolucion { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool? Visible { get; set; }
        public bool SoloAuditores { get; set; }
        public string Crea { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? IP { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual Internado IdInternadoNavigation { get; set; } = null!;
    }
}

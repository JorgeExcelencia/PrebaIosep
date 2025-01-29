using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosAfeccion
    {
        public int IdInternadoAfeccion { get; set; }
        public int IdInternado { get; set; }
        public int IdAfeccion { get; set; }
        public int IdPrestador { get; set; }
        public DateTime FechaHora { get; set; }
        public DateTime FechaHoraCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaHoraAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Activo { get; set; }
        public bool Anulado { get; set; }

        public virtual Afeccion IdAfeccionNavigation { get; set; } = null!;
    }
}

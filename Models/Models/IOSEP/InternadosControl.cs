using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadosControl
    {
        public int IdInternadoControl { get; set; }
        public int IdInternado { get; set; }
        public string? Tarjeta { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaCrea { get; set; }
        public string UserCrea { get; set; } = null!;
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
        public int? EncabezadoPreBonoId { get; set; }
        public int? SectorID { get; set; }
        public int NumeroDia { get; set; }
        public bool MedioDia { get; set; }

        public virtual Internado IdInternadoNavigation { get; set; } = null!;
    }
}

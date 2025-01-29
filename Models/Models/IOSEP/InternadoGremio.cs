using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class InternadoGremio
    {
        public int IdInternadoGremio { get; set; }
        public int IdGremio { get; set; }
        public int IdInternado { get; set; }
        public DateTime FechaInternado { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBajaGremio { get; set; }
        public int? Transaccion { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public bool Facturado { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Detalle_AutorizacionesModificado
    {
        public int ModificaId { get; set; }
        public int DetalleId { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
    }
}

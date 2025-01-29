using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RendicionCaja
    {
        public int RendicionID { get; set; }
        public int IdCierre { get; set; }
        public int IdDelegacion { get; set; }
        public int IdTurnoCaja { get; set; }
        public int IdFormaPago { get; set; }
        public string? Observaciones { get; set; }
        public decimal Importe { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual CajaCierre IdCierreNavigation { get; set; } = null!;
        public virtual TurnosCaja IdTurnoCajaNavigation { get; set; } = null!;
    }
}

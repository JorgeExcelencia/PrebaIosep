using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class HistoricoMovimientosPartida
    {
        public int HistoricoMovimientosId { get; set; }
        public int? ContableGastosOrigenId { get; set; }
        public int ContableGastosDestinoId { get; set; }
        public int Tipo_MovimientoContableId { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual Tipo_MovimientoContable Tipo_MovimientoContable { get; set; } = null!;
    }
}

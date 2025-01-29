using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_MovimientoContable
    {
        public Tipo_MovimientoContable()
        {
            HistoricoMovimientosPartida = new HashSet<HistoricoMovimientosPartida>();
        }

        public int Tipo_MovimientoContableId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<HistoricoMovimientosPartida> HistoricoMovimientosPartida { get; set; }
    }
}

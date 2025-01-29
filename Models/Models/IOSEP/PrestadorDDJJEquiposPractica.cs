using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJEquiposPractica
    {
        public int PrestadorDDJJEquiposPracticasID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int EquiposPracticasID { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string? NExpediente { get; set; }
        public string? NComprobante { get; set; }

        public virtual EquiposPractica EquiposPracticas { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}

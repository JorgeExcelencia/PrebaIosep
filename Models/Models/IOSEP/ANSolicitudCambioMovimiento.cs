using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANSolicitudCambioMovimiento
    {
        public int ANSolicitudCambioMovimientoID { get; set; }
        public int ANSolicitudCambioID { get; set; }
        public string NumeroSolicitud { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime? FechaEstado { get; set; }
        public bool Anulado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANSolicitudCambioDetalleAN
    {
        public ANSolicitudCambioDetalleAN()
        {
            ANSolicitudCambioDetalleRestricANs = new HashSet<ANSolicitudCambioDetalleRestricAN>();
        }

        public int ANSolicitudCambioDetalleANID { get; set; }
        public int ANSolicitudCambioID { get; set; }
        public int ANConvenioPracticaID { get; set; }
        public string? EstadoAutorizar { get; set; }
        public bool Anulado { get; set; }

        public virtual ANConvenioPractica ANConvenioPractica { get; set; } = null!;
        public virtual ANSolicitudCambio ANSolicitudCambio { get; set; } = null!;
        public virtual ICollection<ANSolicitudCambioDetalleRestricAN> ANSolicitudCambioDetalleRestricANs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANSolicitudCambio
    {
        public ANSolicitudCambio()
        {
            ANSolicitudCambioDetalleANs = new HashSet<ANSolicitudCambioDetalleAN>();
            ANSolicitudCambioDetalleAVs = new HashSet<ANSolicitudCambioDetalleAV>();
            ANSolicitudCambioDetalleNPs = new HashSet<ANSolicitudCambioDetalleNP>();
        }

        public int ANSolicitudCambioID { get; set; }
        public int ANTipoSolicitudID { get; set; }
        public string NumeroSolicitud { get; set; } = null!;
        public int PrestadorID { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime? FechaEstado { get; set; }
        public string? ObservacionesAutorizar { get; set; }
        public string? ObservacionesReenviar { get; set; }
        public bool Reenviado { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual ANTipoSolicitud ANTipoSolicitud { get; set; } = null!;
        public virtual ICollection<ANSolicitudCambioDetalleAN> ANSolicitudCambioDetalleANs { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleAV> ANSolicitudCambioDetalleAVs { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleNP> ANSolicitudCambioDetalleNPs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANSolicitudCambioDetalleNP
    {
        public ANSolicitudCambioDetalleNP()
        {
            ANSolicitudCambioDetalleRestricNPs = new HashSet<ANSolicitudCambioDetalleRestricNP>();
            ANSolicitudCambioDetalleValNPs = new HashSet<ANSolicitudCambioDetalleValNP>();
        }

        public int ANSolicitudCambioDetalleNPID { get; set; }
        public int ANSolicitudCambioID { get; set; }
        public int ANPracticaBaseID { get; set; }
        public string? EstadoAutorizar { get; set; }
        public bool Anulado { get; set; }

        public virtual ANPracticasBase ANPracticaBase { get; set; } = null!;
        public virtual ANSolicitudCambio ANSolicitudCambio { get; set; } = null!;
        public virtual ICollection<ANSolicitudCambioDetalleRestricNP> ANSolicitudCambioDetalleRestricNPs { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleValNP> ANSolicitudCambioDetalleValNPs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANTipoRestriccion
    {
        public ANTipoRestriccion()
        {
            ANConvenioRestriccions = new HashSet<ANConvenioRestriccion>();
            ANSolicitudCambioDetalleRestricANs = new HashSet<ANSolicitudCambioDetalleRestricAN>();
            ANSolicitudCambioDetalleRestricNPs = new HashSet<ANSolicitudCambioDetalleRestricNP>();
            ANTipoRestriccionValors = new HashSet<ANTipoRestriccionValor>();
        }

        public int ANTipoRestriccionID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<ANConvenioRestriccion> ANConvenioRestriccions { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleRestricAN> ANSolicitudCambioDetalleRestricANs { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleRestricNP> ANSolicitudCambioDetalleRestricNPs { get; set; }
        public virtual ICollection<ANTipoRestriccionValor> ANTipoRestriccionValors { get; set; }
    }
}

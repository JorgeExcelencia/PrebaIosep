using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANSolicitudCambioDetalleRestricAN
    {
        public int ANSolicitudCambioDetalleRestricANID { get; set; }
        public int ANSolicitudCambioDetalleANID { get; set; }
        public int? ANConvenioRestriccionID { get; set; }
        public int ANTipoRestriccionID { get; set; }
        public int ANTipoRestriccionValorID { get; set; }
        public string Estado { get; set; } = null!;
        public string? EstadoAutorizar { get; set; }
        public bool Anulado { get; set; }

        public virtual ANConvenioRestriccion? ANConvenioRestriccion { get; set; }
        public virtual ANSolicitudCambioDetalleAN ANSolicitudCambioDetalleAN { get; set; } = null!;
        public virtual ANTipoRestriccion ANTipoRestriccion { get; set; } = null!;
        public virtual ANTipoRestriccionValor ANTipoRestriccionValor { get; set; } = null!;
    }
}

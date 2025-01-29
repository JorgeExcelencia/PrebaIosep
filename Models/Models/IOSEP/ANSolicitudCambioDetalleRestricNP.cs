using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANSolicitudCambioDetalleRestricNP
    {
        public int ANSolicitudCambioDetalleRestricNPID { get; set; }
        public int ANSolicitudCambioDetalleNPID { get; set; }
        public int ANTipoRestriccionID { get; set; }
        public int ANTipoRestriccionValorID { get; set; }
        public string? EstadoAutorizar { get; set; }
        public bool Anulado { get; set; }

        public virtual ANSolicitudCambioDetalleNP ANSolicitudCambioDetalleNP { get; set; } = null!;
        public virtual ANTipoRestriccion ANTipoRestriccion { get; set; } = null!;
        public virtual ANTipoRestriccionValor ANTipoRestriccionValor { get; set; } = null!;
    }
}

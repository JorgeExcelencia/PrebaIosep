using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANTipoRestriccionValor
    {
        public ANTipoRestriccionValor()
        {
            ANConvenioRestriccions = new HashSet<ANConvenioRestriccion>();
            ANSolicitudCambioDetalleRestricANs = new HashSet<ANSolicitudCambioDetalleRestricAN>();
            ANSolicitudCambioDetalleRestricNPs = new HashSet<ANSolicitudCambioDetalleRestricNP>();
        }

        public int ANTipoRestriccionValorID { get; set; }
        public int ANTipoRestriccionID { get; set; }
        public string? Valor { get; set; }
        public string? ValorAbreviatura { get; set; }
        public bool Anulado { get; set; }

        public virtual ANTipoRestriccion ANTipoRestriccion { get; set; } = null!;
        public virtual ICollection<ANConvenioRestriccion> ANConvenioRestriccions { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleRestricAN> ANSolicitudCambioDetalleRestricANs { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleRestricNP> ANSolicitudCambioDetalleRestricNPs { get; set; }
    }
}

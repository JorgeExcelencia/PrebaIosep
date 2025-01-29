using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANConvenioRestriccion
    {
        public ANConvenioRestriccion()
        {
            ANSolicitudCambioDetalleRestricANs = new HashSet<ANSolicitudCambioDetalleRestricAN>();
        }

        public int ANConvenioRestriccionID { get; set; }
        public int ANConvenioID { get; set; }
        public int ANConvenioPracticaID { get; set; }
        public int ANTipoRestriccionID { get; set; }
        public int ANTipoRestriccionValorID { get; set; }
        public bool Anulado { get; set; }

        public virtual ANConvenio ANConvenio { get; set; } = null!;
        public virtual ANConvenioPractica ANConvenioPractica { get; set; } = null!;
        public virtual ANTipoRestriccion ANTipoRestriccion { get; set; } = null!;
        public virtual ANTipoRestriccionValor ANTipoRestriccionValor { get; set; } = null!;
        public virtual ICollection<ANSolicitudCambioDetalleRestricAN> ANSolicitudCambioDetalleRestricANs { get; set; }
    }
}

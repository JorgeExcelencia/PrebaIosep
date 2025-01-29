using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANConvenioPractica
    {
        public ANConvenioPractica()
        {
            ANConvenioRestriccions = new HashSet<ANConvenioRestriccion>();
            ANConvenioValors = new HashSet<ANConvenioValor>();
            ANSolicitudCambioDetalleANs = new HashSet<ANSolicitudCambioDetalleAN>();
            ANSolicitudCambioDetalleAVs = new HashSet<ANSolicitudCambioDetalleAV>();
        }

        public int ANConvenioPracticaID { get; set; }
        public int ANConvenioID { get; set; }
        public int? ANPracticaBaseID { get; set; }
        public int? ANPracticaModuloID { get; set; }
        public string? Tipo { get; set; }
        public bool Anulado { get; set; }

        public virtual ANConvenio ANConvenio { get; set; } = null!;
        public virtual ANPracticasBase? ANPracticaBase { get; set; }
        public virtual ANPracticasModulo? ANPracticaModulo { get; set; }
        public virtual ICollection<ANConvenioRestriccion> ANConvenioRestriccions { get; set; }
        public virtual ICollection<ANConvenioValor> ANConvenioValors { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleAN> ANSolicitudCambioDetalleANs { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleAV> ANSolicitudCambioDetalleAVs { get; set; }
    }
}

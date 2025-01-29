using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANPracticasBase
    {
        public ANPracticasBase()
        {
            ANConvenioPracticas = new HashSet<ANConvenioPractica>();
            ANPracticasModulos = new HashSet<ANPracticasModulo>();
            ANSolicitudCambioDetalleNPs = new HashSet<ANSolicitudCambioDetalleNP>();
        }

        public int ANPracticasBaseID { get; set; }
        public int ANTipoPracticaID { get; set; }
        public int? ANTipoUnidadID { get; set; }
        public int? ANTipoCalculoID { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ANTipoCalculo? ANTipoCalculo { get; set; }
        public virtual ANTipoPractica ANTipoPractica { get; set; } = null!;
        public virtual ANTipoUnidad? ANTipoUnidad { get; set; }
        public virtual ICollection<ANConvenioPractica> ANConvenioPracticas { get; set; }
        public virtual ICollection<ANPracticasModulo> ANPracticasModulos { get; set; }
        public virtual ICollection<ANSolicitudCambioDetalleNP> ANSolicitudCambioDetalleNPs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANConvenioValor
    {
        public ANConvenioValor()
        {
            ANSolicitudCambioDetalleAVs = new HashSet<ANSolicitudCambioDetalleAV>();
        }

        public int ANConvenioValorID { get; set; }
        public int ANConvenioID { get; set; }
        public int ANConvenioPracticaID { get; set; }
        public decimal TotalHonorarios { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal ReconoceHonorarios { get; set; }
        public decimal ReconoceGastos { get; set; }
        public decimal CoseguroHonorarios { get; set; }
        public decimal CoseguroGastos { get; set; }
        public bool Anulado { get; set; }

        public virtual ANConvenio ANConvenio { get; set; } = null!;
        public virtual ANConvenioPractica ANConvenioPractica { get; set; } = null!;
        public virtual ICollection<ANSolicitudCambioDetalleAV> ANSolicitudCambioDetalleAVs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ANSolicitudCambioDetalleAV
    {
        public int ANSolicitudCambioDetalleAVID { get; set; }
        public int ANSolicitudCambioID { get; set; }
        public int ANConvenioPracticaID { get; set; }
        public int ANConvenioValorID { get; set; }
        public string? EstadoAutorizar { get; set; }
        public bool Anulado { get; set; }
        public decimal PorcentajeAjusteHonorarios { get; set; }
        public decimal PorcentajeAjusteGastos { get; set; }

        public virtual ANConvenioPractica ANConvenioPractica { get; set; } = null!;
        public virtual ANConvenioValor ANConvenioValor { get; set; } = null!;
        public virtual ANSolicitudCambio ANSolicitudCambio { get; set; } = null!;
    }
}

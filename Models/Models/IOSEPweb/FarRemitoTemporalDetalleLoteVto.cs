using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarRemitoTemporalDetalleLoteVto
    {
        public int IdDetalleTemporalLoteVto { get; set; }
        public int IdDetalleTemporal { get; set; }
        public int NroRegistro { get; set; }
        public string? Lote { get; set; }
        public string? Vence { get; set; }
        public decimal? CantidadRecibida { get; set; }
        public bool Anulado { get; set; }

        public virtual FarRemitoTemporalDetalle IdDetalleTemporalNavigation { get; set; } = null!;
    }
}

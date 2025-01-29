using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncEtiquetasDetalle
    {
        public int EtiquetaDetalleId { get; set; }
        public int MovIncidenciaHeadId { get; set; }
        public int EtiquetaId { get; set; }
        public bool Anulado { get; set; }

        public virtual IncEtiqueta Etiqueta { get; set; } = null!;
        public virtual IncMovIncidenciasHead MovIncidenciaHead { get; set; } = null!;
    }
}

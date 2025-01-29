using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncEtiqueta
    {
        public IncEtiqueta()
        {
            IncEtiquetasDetalles = new HashSet<IncEtiquetasDetalle>();
        }

        public int EtiquetaId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<IncEtiquetasDetalle> IncEtiquetasDetalles { get; set; }
    }
}

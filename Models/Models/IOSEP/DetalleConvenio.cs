using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class DetalleConvenio
    {
        public int IdDetalleConvenio { get; set; }
        public int IdEncabezadoConvenio { get; set; }
        public int IdPrestador { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual EncabezadoConvenio IdEncabezadoConvenioNavigation { get; set; } = null!;
    }
}

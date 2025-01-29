using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EncabezadoConvenio
    {
        public EncabezadoConvenio()
        {
            DetalleConvenios = new HashSet<DetalleConvenio>();
        }

        public int IdEncabezadoConvenio { get; set; }
        public int IdPrestador { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<DetalleConvenio> DetalleConvenios { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaConvenioUnidad
    {
        public int NomPracticaConvenioUnidadID { get; set; }
        public int NomPracticaConvenioID { get; set; }
        public int IdTipoUnidad { get; set; }
        public decimal Valor { get; set; }
        public DateTime Desde { get; set; }
        public string? Resolucion { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoUnidad IdTipoUnidadNavigation { get; set; } = null!;
        public virtual NomPracticaConvenio NomPracticaConvenio { get; set; } = null!;
    }
}

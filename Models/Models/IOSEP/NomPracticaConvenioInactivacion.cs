using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaConvenioInactivacion
    {
        public int NomPracticaConvenioInactivacionID { get; set; }
        public int NomPracticaConvenioID { get; set; }
        public int IdPractica { get; set; }
        public string? NroResolucion { get; set; }
        public string? RefResolucion { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual NomPracticaConvenio NomPracticaConvenio { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaConvenioRestriccion
    {
        public int NomPracticaConvenioRestriccionID { get; set; }
        public int NomPracticaConvenioID { get; set; }
        public int IdPractica { get; set; }
        public int IdPlan { get; set; }
        public bool Ambulatorio { get; set; }
        public bool Internado { get; set; }
        public int Frecuencia { get; set; }
        public int Cantidad { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual NomPracticaConvenio NomPracticaConvenio { get; set; } = null!;
    }
}

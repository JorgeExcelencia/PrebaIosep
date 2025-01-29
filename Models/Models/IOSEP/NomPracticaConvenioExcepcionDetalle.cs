using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaConvenioExcepcionDetalle
    {
        public int NomPracticaConvenioExcepcionDetalleID { get; set; }
        public int NomPracticaConvenioExcepcionID { get; set; }
        public int IdPractica { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }

        public virtual NomPracticaConvenioExcepcion NomPracticaConvenioExcepcion { get; set; } = null!;
    }
}

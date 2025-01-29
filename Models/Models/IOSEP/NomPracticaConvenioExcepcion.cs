using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaConvenioExcepcion
    {
        public NomPracticaConvenioExcepcion()
        {
            NomPracticaConvenioExcepcionDetalles = new HashSet<NomPracticaConvenioExcepcionDetalle>();
        }

        public int NomPracticaConvenioExcepcionID { get; set; }
        public string NombreExcepcion { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<NomPracticaConvenioExcepcionDetalle> NomPracticaConvenioExcepcionDetalles { get; set; }
    }
}

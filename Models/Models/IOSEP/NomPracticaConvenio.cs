using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaConvenio
    {
        public NomPracticaConvenio()
        {
            NomPracticaConvenioDetalles = new HashSet<NomPracticaConvenioDetalle>();
            NomPracticaConvenioInactivacions = new HashSet<NomPracticaConvenioInactivacion>();
            NomPracticaConvenioRestriccions = new HashSet<NomPracticaConvenioRestriccion>();
            NomPracticaConvenioUnidads = new HashSet<NomPracticaConvenioUnidad>();
        }

        public int NomPracticaConvenioID { get; set; }
        public int InstitucionID { get; set; }
        public int IdProvincia { get; set; }
        public string Tipo { get; set; } = null!;
        public DateTime FechaCreado { get; set; }
        public bool Vigente { get; set; }
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual Prestadore Institucion { get; set; } = null!;
        public virtual ICollection<NomPracticaConvenioDetalle> NomPracticaConvenioDetalles { get; set; }
        public virtual ICollection<NomPracticaConvenioInactivacion> NomPracticaConvenioInactivacions { get; set; }
        public virtual ICollection<NomPracticaConvenioRestriccion> NomPracticaConvenioRestriccions { get; set; }
        public virtual ICollection<NomPracticaConvenioUnidad> NomPracticaConvenioUnidads { get; set; }
    }
}

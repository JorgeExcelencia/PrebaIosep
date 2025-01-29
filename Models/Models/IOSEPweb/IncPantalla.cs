using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncPantalla
    {
        public IncPantalla()
        {
            IncPantallasEsquemas = new HashSet<IncPantallasEsquema>();
            IncPantallasxIncidencia = new HashSet<IncPantallasxIncidencia>();
        }

        public int PantallaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Default { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncPantallasEsquema> IncPantallasEsquemas { get; set; }
        public virtual ICollection<IncPantallasxIncidencia> IncPantallasxIncidencia { get; set; }
    }
}

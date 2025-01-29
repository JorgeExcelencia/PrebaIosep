using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncResolucione
    {
        public IncResolucione()
        {
            IncMovIncidencia = new HashSet<IncMovIncidencia>();
        }

        public int ResolucionesId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncMovIncidencia> IncMovIncidencia { get; set; }
    }
}

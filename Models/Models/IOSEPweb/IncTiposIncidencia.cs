using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncTiposIncidencia
    {
        public IncTiposIncidencia()
        {
            IncMovIncidenciasHeads = new HashSet<IncMovIncidenciasHead>();
            IncPantallasxIncidencia = new HashSet<IncPantallasxIncidencia>();
        }

        public int TipoIncidenciaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool SubTarea { get; set; }
        public byte[]? Avatar { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncMovIncidenciasHead> IncMovIncidenciasHeads { get; set; }
        public virtual ICollection<IncPantallasxIncidencia> IncPantallasxIncidencia { get; set; }
    }
}

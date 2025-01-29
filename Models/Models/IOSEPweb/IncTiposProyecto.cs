using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncTiposProyecto
    {
        public IncTiposProyecto()
        {
            IncProyectos = new HashSet<IncProyecto>();
        }

        public int TipoProyectoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte[]? Avatar { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncProyecto> IncProyectos { get; set; }
    }
}

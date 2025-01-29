using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncCategoriasProyecto
    {
        public IncCategoriasProyecto()
        {
            IncProyectos = new HashSet<IncProyecto>();
        }

        public int CategoriaProyectoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool? KanBan { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncProyecto> IncProyectos { get; set; }
    }
}

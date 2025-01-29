using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncFlujodeTrabajo
    {
        public IncFlujodeTrabajo()
        {
            IncFlujosMovimientos = new HashSet<IncFlujosMovimiento>();
            IncProyectos = new HashSet<IncProyecto>();
        }

        public int FlujodeTrabajoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncFlujosMovimiento> IncFlujosMovimientos { get; set; }
        public virtual ICollection<IncProyecto> IncProyectos { get; set; }
    }
}

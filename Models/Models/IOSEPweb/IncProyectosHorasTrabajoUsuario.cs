using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncProyectosHorasTrabajoUsuario
    {
        public int ProyectoHorasTrabajoUsuarioId { get; set; }
        public int ProyectoId { get; set; }
        public int ProyectoUsuarioId { get; set; }
        public decimal CantidadHoras { get; set; }
        public bool Anulado { get; set; }

        public virtual IncProyecto Proyecto { get; set; } = null!;
        public virtual IncProyectosUsuario ProyectoUsuario { get; set; } = null!;
    }
}

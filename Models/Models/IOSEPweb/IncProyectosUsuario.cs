using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncProyectosUsuario
    {
        public IncProyectosUsuario()
        {
            IncMovIncidenciaAdjuntos = new HashSet<IncMovIncidenciaAdjunto>();
            IncMovIncidenciasHeadInformadors = new HashSet<IncMovIncidenciasHead>();
            IncMovIncidenciasHeadResponsables = new HashSet<IncMovIncidenciasHead>();
            IncProyectosHorasTrabajoUsuarios = new HashSet<IncProyectosHorasTrabajoUsuario>();
            IncSprintCreaUsuarios = new HashSet<IncSprint>();
            IncSprintDetalleCreaUsuarios = new HashSet<IncSprintDetalle>();
            IncSprintDetalleModiUsuarios = new HashSet<IncSprintDetalle>();
            IncSprintModiUsuarios = new HashSet<IncSprint>();
        }

        public int ProyectoUsuarioId { get; set; }
        public int ProyectoId { get; set; }
        public int RolId { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual IncProyecto Proyecto { get; set; } = null!;
        public virtual IncRole Rol { get; set; } = null!;
        public virtual ICollection<IncMovIncidenciaAdjunto> IncMovIncidenciaAdjuntos { get; set; }
        public virtual ICollection<IncMovIncidenciasHead> IncMovIncidenciasHeadInformadors { get; set; }
        public virtual ICollection<IncMovIncidenciasHead> IncMovIncidenciasHeadResponsables { get; set; }
        public virtual ICollection<IncProyectosHorasTrabajoUsuario> IncProyectosHorasTrabajoUsuarios { get; set; }
        public virtual ICollection<IncSprint> IncSprintCreaUsuarios { get; set; }
        public virtual ICollection<IncSprintDetalle> IncSprintDetalleCreaUsuarios { get; set; }
        public virtual ICollection<IncSprintDetalle> IncSprintDetalleModiUsuarios { get; set; }
        public virtual ICollection<IncSprint> IncSprintModiUsuarios { get; set; }
    }
}

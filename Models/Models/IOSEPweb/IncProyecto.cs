using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncProyecto
    {
        public IncProyecto()
        {
            IncEstadosXproyectos = new HashSet<IncEstadosXproyecto>();
            IncIncidenciasxProyectos = new HashSet<IncIncidenciasxProyecto>();
            IncMovIncidenciasHeads = new HashSet<IncMovIncidenciasHead>();
            IncProyectosDiasLaborables = new HashSet<IncProyectosDiasLaborable>();
            IncProyectosDiasNoLaborables = new HashSet<IncProyectosDiasNoLaborable>();
            IncProyectosHorasTrabajoUsuarios = new HashSet<IncProyectosHorasTrabajoUsuario>();
            IncProyectosUsuarios = new HashSet<IncProyectosUsuario>();
            IncSprints = new HashSet<IncSprint>();
        }

        public int ProyectoId { get; set; }
        public int TipoProyectoId { get; set; }
        public int? CategoriaProyectoId { get; set; }
        public int FlujodeTrabajoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string? Url { get; set; }
        public byte[]? Avatar { get; set; }
        public string? Descripcion { get; set; }
        public string Lider { get; set; } = null!;
        public string CreaUsuario { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual IncCategoriasProyecto? CategoriaProyecto { get; set; }
        public virtual IncFlujodeTrabajo FlujodeTrabajo { get; set; } = null!;
        public virtual IncTiposProyecto TipoProyecto { get; set; } = null!;
        public virtual ICollection<IncEstadosXproyecto> IncEstadosXproyectos { get; set; }
        public virtual ICollection<IncIncidenciasxProyecto> IncIncidenciasxProyectos { get; set; }
        public virtual ICollection<IncMovIncidenciasHead> IncMovIncidenciasHeads { get; set; }
        public virtual ICollection<IncProyectosDiasLaborable> IncProyectosDiasLaborables { get; set; }
        public virtual ICollection<IncProyectosDiasNoLaborable> IncProyectosDiasNoLaborables { get; set; }
        public virtual ICollection<IncProyectosHorasTrabajoUsuario> IncProyectosHorasTrabajoUsuarios { get; set; }
        public virtual ICollection<IncProyectosUsuario> IncProyectosUsuarios { get; set; }
        public virtual ICollection<IncSprint> IncSprints { get; set; }
    }
}

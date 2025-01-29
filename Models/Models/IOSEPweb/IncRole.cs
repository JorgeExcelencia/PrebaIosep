using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncRole
    {
        public IncRole()
        {
            IncProyectosUsuarios = new HashSet<IncProyectosUsuario>();
            IncRolesPermisos = new HashSet<IncRolesPermiso>();
        }

        public int RolId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncProyectosUsuario> IncProyectosUsuarios { get; set; }
        public virtual ICollection<IncRolesPermiso> IncRolesPermisos { get; set; }
    }
}

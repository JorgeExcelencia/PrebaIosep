using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncPermiso
    {
        public IncPermiso()
        {
            IncRolesPermisos = new HashSet<IncRolesPermiso>();
        }

        public int PermisoId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<IncRolesPermiso> IncRolesPermisos { get; set; }
    }
}

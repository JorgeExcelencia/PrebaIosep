using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncRolesPermiso
    {
        public int RolPermisoId { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public bool Anulado { get; set; }

        public virtual IncPermiso Permiso { get; set; } = null!;
        public virtual IncRole Rol { get; set; } = null!;
    }
}

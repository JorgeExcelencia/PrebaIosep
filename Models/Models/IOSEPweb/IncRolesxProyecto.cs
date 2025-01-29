using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncRolesxProyecto
    {
        public int ProyectoId { get; set; }
        public string RoleId { get; set; } = null!;

        public virtual IncProyecto Proyecto { get; set; } = null!;
    }
}

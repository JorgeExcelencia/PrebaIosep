using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class RolesInMenu
    {
        public int IdRolesInMenu { get; set; }
        public int IdMenu { get; set; }
        public string RoleId { get; set; } = null!;
    }
}

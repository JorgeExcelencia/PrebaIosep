using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class MainMenuIosep
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; } = null!;
        public string Action { get; set; } = null!;
        public int Parent { get; set; }
        public string Roles { get; set; } = null!;
        public int Orden { get; set; }
    }
}

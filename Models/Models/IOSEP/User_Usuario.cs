using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class User_Usuario
    {
        public long IdUser { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? IdOficina { get; set; }
        public bool? Anulado { get; set; }
    }
}

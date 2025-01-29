using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class User_Perfile
    {
        public short IdPerfil { get; set; }
        public string Nombre { get; set; } = null!;
        public bool? Anulado { get; set; }
    }
}

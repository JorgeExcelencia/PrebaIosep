using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_User_UsuariosyPerfile
    {
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;
        public short? IdPerfil { get; set; }
        public string? NombrePerfil { get; set; }
        public long IdUser { get; set; }
    }
}

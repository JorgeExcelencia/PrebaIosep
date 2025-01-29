using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class tbl_App_Perfile
    {
        public short IdApp { get; set; }
        public string Aplicacion { get; set; } = null!;
        public bool Digitalizar { get; set; }
        public bool ImprimirCarnet { get; set; }
        public string IdPerfiles { get; set; } = null!;
        public string? IdPerfilSupervisor { get; set; }
        public short? IdTabla { get; set; }
    }
}

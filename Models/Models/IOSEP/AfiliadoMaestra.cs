using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadoMaestra
    {
        public int AfiliadoMaestraID { get; set; }
        public int AfiliadoID { get; set; }
        public int MaestraID { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}

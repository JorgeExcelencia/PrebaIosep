using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tiempo
    {
        public int TiempoID { get; set; }
        public string Descripcion { get; set; } = null!;
        public int CantDias { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}

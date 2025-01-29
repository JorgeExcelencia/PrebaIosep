using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CalculoPrecio
    {
        public int CalculoPrecioID { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? ObsAnula { get; set; }
    }
}

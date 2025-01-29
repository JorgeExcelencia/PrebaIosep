using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Instructivo
    {
        public int InstructivoID { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Duracion { get; set; } = null!;
        public string Ubicacion { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public int? Orden { get; set; }
        public string? ImagenPreliminar { get; set; }
    }
}

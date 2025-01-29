using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ContencionFliarTipoDefuncion
    {
        public int ContencionFliarTipoDefuncionID { get; set; }
        public int TipoDefuncionID { get; set; }
        public int EncabezadoContencionID { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}

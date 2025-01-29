using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ContencionFliarEncabezado
    {
        public int EncabezadoContencionID { get; set; }
        public int AfiliadoTitularID { get; set; }
        public int AfiliadoBenID { get; set; }
        public string NroExpediente { get; set; } = null!;
        public DateTime FechaExpediente { get; set; }
        public string RefExpediente { get; set; } = null!;
        public DateTime FechaDefuncion { get; set; }
        public DateTime FechaTramite { get; set; }
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}

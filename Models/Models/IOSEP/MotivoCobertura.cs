using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoCobertura
    {
        public int MotivoCoberturaID { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public int MotivoAnulaID { get; set; }
    }
}

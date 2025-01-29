using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProtesisRubro
    {
        public int ProtesisRubroID { get; set; }
        public int? ProtesisEspecialidadID { get; set; }
        public string CodigoRubro { get; set; } = null!;
        public string DescripcionRubro { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? MotivoAnulaID { get; set; }
        public string? ObservacionAnula { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
    }
}

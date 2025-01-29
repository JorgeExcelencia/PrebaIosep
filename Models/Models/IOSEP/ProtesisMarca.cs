using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProtesisMarca
    {
        public int MarcaProtesisID { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public int? MotivoAnulaId { get; set; }
        public string? ObservacionAnula { get; set; }
    }
}

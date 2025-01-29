using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProvistoPor
    {
        public int ProvistoPorID { get; set; }
        public string? Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public int? PeriodoFacturacionID { get; set; }
        public int? CalcularPrecioID { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioCarga { get; set; }
        public DateTime? FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? MotivoAnulaId { get; set; }
        public string? Observaciones { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
        public string? ObsAnula { get; set; }
        public string? ObsMod { get; set; }
    }
}

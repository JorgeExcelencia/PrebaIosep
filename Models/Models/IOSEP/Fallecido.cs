using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Fallecido
    {
        public int IdFallecido { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime FechaDefuncion { get; set; }
        public string? NumeroActa { get; set; }
        public string? Observacion { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
        public bool Internado { get; set; }
        public int? IdInternado { get; set; }
        public bool Confirmado { get; set; }
        public string? UserConfirma { get; set; }
        public DateTime? FechaConfirma { get; set; }
        public bool Anulado { get; set; }
    }
}

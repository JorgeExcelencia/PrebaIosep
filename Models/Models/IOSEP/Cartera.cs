using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cartera
    {
        public int IdCartera { get; set; }
        public int IdCentro { get; set; }
        public int IdInstitucion { get; set; }
        public DateTime FechaDesde { get; set; }
        public decimal Importe { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
        public int? MotivoAnulaId { get; set; }
        public string? Observaciones { get; set; }
        public string? UsuarioMod { get; set; }
        public DateTime? FechaMod { get; set; }
    }
}

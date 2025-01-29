using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Ddjj_Header
    {
        public Ddjj_Header()
        {
            AfiliadosDDJJs = new HashSet<AfiliadosDDJJ>();
        }

        public int IdDdjjHeader { get; set; }
        public DateTime Fecha { get; set; }
        public string Operador { get; set; } = null!;
        public bool Cerrado { get; set; }
        public bool Confirmado { get; set; }
        public bool IosepSalud { get; set; }
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string? OpeCierra { get; set; }
        public DateTime? FechaCierra { get; set; }
        public string? OpeConfirma { get; set; }
        public DateTime? FechaConfirma { get; set; }
        public bool Baja { get; set; }
        public bool? Cobranzas { get; set; }
        public string? Expediente { get; set; }
        public string? RefExpediente { get; set; }

        public virtual ICollection<AfiliadosDDJJ> AfiliadosDDJJs { get; set; }
    }
}

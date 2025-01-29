using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class OlimpiadasPersona
    {
        public OlimpiadasPersona()
        {
            OlimpiadasMovimientos = new HashSet<OlimpiadasMovimiento>();
        }

        public int PersonaId { get; set; }
        public string Dni { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public DateTime? FeCrea { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FeModi { get; set; }
        public string? OpModi { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<OlimpiadasMovimiento> OlimpiadasMovimientos { get; set; }
    }
}

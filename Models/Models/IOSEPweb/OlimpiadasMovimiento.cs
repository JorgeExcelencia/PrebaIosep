using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class OlimpiadasMovimiento
    {
        public OlimpiadasMovimiento()
        {
            OlimpiadasDetalleMovimientos = new HashSet<OlimpiadasDetalleMovimiento>();
        }

        public int MovimientoId { get; set; }
        public int EncabezadoId { get; set; }
        public int PersonaId { get; set; }
        public DateTime? FeCrea { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FeModi { get; set; }
        public string? OpModi { get; set; }
        public bool Anulado { get; set; }

        public virtual OlimpiadasEncabezado Encabezado { get; set; } = null!;
        public virtual OlimpiadasPersona Persona { get; set; } = null!;
        public virtual ICollection<OlimpiadasDetalleMovimiento> OlimpiadasDetalleMovimientos { get; set; }
    }
}

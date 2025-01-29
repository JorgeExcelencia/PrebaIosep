using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AnamnesisDetalle
    {
        public AnamnesisDetalle()
        {
            EventoDetalles = new HashSet<EventoDetalle>();
        }

        public int AnamnesisDetalleId { get; set; }
        public int TipoAnamnesisId { get; set; }
        public int Orden { get; set; }
        public string Pregunta { get; set; } = null!;
        public bool Obligatorio { get; set; }
        public int TipoRespuestaId { get; set; }
        public string? ValorMaximo { get; set; }
        public string? ValorMinimo { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoAnamnesi TipoAnamnesis { get; set; } = null!;
        public virtual TipoRespuestum TipoRespuesta { get; set; } = null!;
        public virtual ICollection<EventoDetalle> EventoDetalles { get; set; }
    }
}

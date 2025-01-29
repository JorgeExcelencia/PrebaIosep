using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class EventoEncabezado
    {
        public EventoEncabezado()
        {
            EventoDetalles = new HashSet<EventoDetalle>();
        }

        public int EventoEncabezadoId { get; set; }
        public DateTime Fecha { get; set; }
        public int Id { get; set; }
        public int TipoAnamnesisId { get; set; }
        public bool Activo { get; set; }
        public string Crea { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual TipoAnamnesi TipoAnamnesis { get; set; } = null!;
        public virtual ICollection<EventoDetalle> EventoDetalles { get; set; }
    }
}

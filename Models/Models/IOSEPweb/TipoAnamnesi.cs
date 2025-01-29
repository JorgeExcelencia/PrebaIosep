using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoAnamnesi
    {
        public TipoAnamnesi()
        {
            Anamnesis = new HashSet<Anamnesi>();
            AnamnesisDetalles = new HashSet<AnamnesisDetalle>();
            EventoEncabezados = new HashSet<EventoEncabezado>();
        }

        public int TipoAnamnesisId { get; set; }
        public string Nombre { get; set; } = null!;
        public int? AsociadaId { get; set; }
        public int? ServicioId { get; set; }
        public int? PrestadorId { get; set; }
        public string? Tabla { get; set; }
        public string? Action { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Anamnesi> Anamnesis { get; set; }
        public virtual ICollection<AnamnesisDetalle> AnamnesisDetalles { get; set; }
        public virtual ICollection<EventoEncabezado> EventoEncabezados { get; set; }
    }
}

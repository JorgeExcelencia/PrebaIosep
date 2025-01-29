using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncEvento
    {
        public IncEvento()
        {
            IncRecordatorios = new HashSet<IncRecordatorio>();
        }

        public int EventoId { get; set; }
        public int MovIncidenciaHeadId { get; set; }
        public DateTime Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string Tipo { get; set; } = null!;
        public int? EstadoId { get; set; }
        public bool Anulado { get; set; }

        public virtual IncEstado? Estado { get; set; }
        public virtual ICollection<IncRecordatorio> IncRecordatorios { get; set; }
    }
}

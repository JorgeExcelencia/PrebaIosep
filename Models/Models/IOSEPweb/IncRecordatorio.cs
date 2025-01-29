using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncRecordatorio
    {
        public int RecordatorioId { get; set; }
        public int EventoId { get; set; }
        public string TipoTiempo { get; set; } = null!;
        public int? Tiempo { get; set; }
        public DateTime? FechaHora { get; set; }
        public DateTime? Avisado { get; set; }
        public DateTime? Visto { get; set; }
        public bool Anulado { get; set; }

        public virtual IncEvento Evento { get; set; } = null!;
    }
}

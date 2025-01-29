using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncMovComentario
    {
        public int MovComentarioId { get; set; }
        public int MovIncidenciaHeadId { get; set; }
        public string Comentario { get; set; } = null!;
        public Guid Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int? RespuestaId { get; set; }
        public bool Anulado { get; set; }

        public virtual IncMovIncidenciasHead MovIncidenciaHead { get; set; } = null!;
    }
}

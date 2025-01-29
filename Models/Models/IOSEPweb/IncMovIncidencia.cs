using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncMovIncidencia
    {
        public int MovIncidenciaId { get; set; }
        public int MovIncidenciaHeadId { get; set; }
        public int EstadoId { get; set; }
        public int ResolucionId { get; set; }
        public string Resumen { get; set; } = null!;
        public string? Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public bool Anulado { get; set; }

        public virtual IncEstado Estado { get; set; } = null!;
        public virtual IncMovIncidenciasHead MovIncidenciaHead { get; set; } = null!;
        public virtual IncResolucione Resolucion { get; set; } = null!;
    }
}

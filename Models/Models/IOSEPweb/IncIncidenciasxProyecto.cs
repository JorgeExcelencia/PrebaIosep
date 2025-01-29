using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncIncidenciasxProyecto
    {
        public int IncidenciaId { get; set; }
        public bool Default { get; set; }
        public string? TipoIncidenciaId { get; set; }
        public int ProyectoId { get; set; }
        public bool Anulado { get; set; }

        public virtual IncProyecto Proyecto { get; set; } = null!;
    }
}

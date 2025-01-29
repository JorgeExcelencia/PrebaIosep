using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncSprintDetalle
    {
        public int SprintDetalleId { get; set; }
        public int SprintId { get; set; }
        public int MovIncidenciaHeadId { get; set; }
        public string Estado { get; set; } = null!;
        public int CreaUsuarioId { get; set; }
        public DateTime CreaFecha { get; set; }
        public int? ModiUsuarioId { get; set; }
        public DateTime? ModiFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual IncProyectosUsuario CreaUsuario { get; set; } = null!;
        public virtual IncProyectosUsuario? ModiUsuario { get; set; }
        public virtual IncMovIncidenciasHead MovIncidenciaHead { get; set; } = null!;
        public virtual IncSprint Sprint { get; set; } = null!;
    }
}

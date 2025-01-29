using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncProyectosDiasNoLaborable
    {
        public int ProyectoDiaNoLaborableId { get; set; }
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }

        public virtual IncProyecto Proyecto { get; set; } = null!;
    }
}

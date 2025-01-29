using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncProyectosDiasLaborable
    {
        public int ProyectoDiaLaborableId { get; set; }
        public int ProyectoId { get; set; }
        public bool? Lunes { get; set; }
        public bool? Martes { get; set; }
        public bool? Miercoles { get; set; }
        public bool? Jueves { get; set; }
        public bool? Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public bool Anulado { get; set; }

        public virtual IncProyecto Proyecto { get; set; } = null!;
    }
}

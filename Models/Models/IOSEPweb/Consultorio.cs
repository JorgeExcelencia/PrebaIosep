using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Consultorio
    {
        public Consultorio()
        {
            PlanillaTurnos = new HashSet<PlanillaTurno>();
        }

        public int ConsultorioId { get; set; }
        public string Nombre { get; set; } = null!;
        public int? EspecialidadId { get; set; }
        public int TvMonitorId { get; set; }
        public bool Anulado { get; set; }

        public virtual TvMonitor TvMonitor { get; set; } = null!;
        public virtual ICollection<PlanillaTurno> PlanillaTurnos { get; set; }
    }
}

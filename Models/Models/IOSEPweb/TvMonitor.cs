using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TvMonitor
    {
        public TvMonitor()
        {
            Consultorios = new HashSet<Consultorio>();
        }

        public int TvMonitorId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Consultorio> Consultorios { get; set; }
    }
}

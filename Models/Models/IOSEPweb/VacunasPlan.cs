using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VacunasPlan
    {
        public VacunasPlan()
        {
            VacunasMovimientos = new HashSet<VacunasMovimiento>();
        }

        public int PlanId { get; set; }
        public string Nombre { get; set; } = null!;
        public int RelacionId { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<VacunasMovimiento> VacunasMovimientos { get; set; }
    }
}

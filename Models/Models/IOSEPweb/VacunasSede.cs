using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VacunasSede
    {
        public VacunasSede()
        {
            VacunasEncabezados = new HashSet<VacunasEncabezado>();
        }

        public int SedeId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<VacunasEncabezado> VacunasEncabezados { get; set; }
    }
}

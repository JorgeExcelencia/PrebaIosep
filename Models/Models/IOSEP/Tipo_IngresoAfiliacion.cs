using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_IngresoAfiliacion
    {
        public Tipo_IngresoAfiliacion()
        {
            AfiliadosDDJJs = new HashSet<AfiliadosDDJJ>();
        }

        public int IdTipoIngresoAfiliacion { get; set; }
        public string Nombre { get; set; } = null!;
        public int DiasCarencia { get; set; }
        public bool Anulado { get; set; }
        public bool? IosepSalud { get; set; }

        public virtual ICollection<AfiliadosDDJJ> AfiliadosDDJJs { get; set; }
    }
}

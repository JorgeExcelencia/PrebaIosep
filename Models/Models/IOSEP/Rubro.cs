using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Rubro
    {
        public Rubro()
        {
            RubrosDetalles = new HashSet<RubrosDetalle>();
        }

        public int IdRubro { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<RubrosDetalle> RubrosDetalles { get; set; }
    }
}

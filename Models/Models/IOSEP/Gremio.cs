using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Gremio
    {
        public Gremio()
        {
            LiquidacionGremiosEncabezados = new HashSet<LiquidacionGremiosEncabezado>();
        }

        public int IdGremio { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<LiquidacionGremiosEncabezado> LiquidacionGremiosEncabezados { get; set; }
    }
}

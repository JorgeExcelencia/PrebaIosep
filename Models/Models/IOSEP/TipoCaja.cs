using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoCaja
    {
        public TipoCaja()
        {
            CajaOperadores = new HashSet<CajaOperadore>();
        }

        public short IdTipoCaja { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<CajaOperadore> CajaOperadores { get; set; }
    }
}

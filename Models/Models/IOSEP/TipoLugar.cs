using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoLugar
    {
        public TipoLugar()
        {
            CajaOperadores = new HashSet<CajaOperadore>();
        }

        public short IdTipoLugar { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<CajaOperadore> CajaOperadores { get; set; }
    }
}

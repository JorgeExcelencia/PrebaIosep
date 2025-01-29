using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoCondicion
    {
        public TipoCondicion()
        {
            CondicionAfiliados = new HashSet<CondicionAfiliado>();
        }

        public short IdTipoCondicion { get; set; }
        public string Nombre { get; set; } = null!;
        public bool? Anulado { get; set; }

        public virtual ICollection<CondicionAfiliado> CondicionAfiliados { get; set; }
    }
}

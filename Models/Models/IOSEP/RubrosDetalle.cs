using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RubrosDetalle
    {
        public int IdRubroDetalle { get; set; }
        public int IdRubro { get; set; }
        public int IdCuentaContable { get; set; }
        public bool Anulado { get; set; }

        public virtual Rubro IdRubroNavigation { get; set; } = null!;
    }
}

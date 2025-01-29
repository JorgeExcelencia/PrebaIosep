using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoFormaPago
    {
        public TipoFormaPago()
        {
            CajaOperadores = new HashSet<CajaOperadore>();
        }

        public short IdTipoFormaPago { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Cuenta_Contable { get; set; }
        public string? Credito { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<CajaOperadore> CajaOperadores { get; set; }
    }
}

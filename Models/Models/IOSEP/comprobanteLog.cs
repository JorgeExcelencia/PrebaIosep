using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class comprobanteLog
    {
        public int IdLog { get; set; }
        public int IdCompronante { get; set; }
        public string Operador { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Operacion { get; set; }

        public virtual comprobante IdCompronanteNavigation { get; set; } = null!;
    }
}

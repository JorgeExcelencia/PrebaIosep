using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class VwFormaPago
    {
        public short IdTipoFormaPago { get; set; }
        public string Nombre { get; set; } = null!;
        public string? CuentaContable { get; set; }
        public string? Credito { get; set; }
        public bool Anulado { get; set; }
    }
}

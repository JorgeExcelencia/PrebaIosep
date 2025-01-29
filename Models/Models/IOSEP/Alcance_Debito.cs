using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Alcance_Debito
    {
        public int IdAlcance_Debito { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public bool? Anulado { get; set; }
    }
}

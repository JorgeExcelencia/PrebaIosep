using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Transaccion_Ordene
    {
        public string Numero_Bono { get; set; } = null!;
        public string Numero_Transaccion { get; set; } = null!;
        public string? Tipo_bono { get; set; }
    }
}

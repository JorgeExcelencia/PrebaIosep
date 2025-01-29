using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Debito
    {
        public int IdTipo_Debito { get; set; }
        public string? codigo { get; set; }
        public string? nombre { get; set; }
        public int? IdSectorDebito { get; set; }
        public bool anulado { get; set; }
        public int? IdAlcance_Debito { get; set; }
        public string? campo { get; set; }
    }
}

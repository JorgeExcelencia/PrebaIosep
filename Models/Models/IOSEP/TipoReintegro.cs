using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoReintegro
    {
        public int TipoReintegroID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }
    }
}

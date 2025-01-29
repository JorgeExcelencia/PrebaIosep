using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ObrasSociale
    {
        public int IdObraSocial { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

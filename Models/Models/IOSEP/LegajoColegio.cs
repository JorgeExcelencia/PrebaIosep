using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class LegajoColegio
    {
        public int IdLegajoColegio { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

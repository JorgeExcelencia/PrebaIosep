using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Jubilado
    {
        public long IdJubilado { get; set; }
        public int IdAfiliado { get; set; }
        public string NroJubilatorio { get; set; } = null!;
        public bool? Anulado { get; set; }
    }
}

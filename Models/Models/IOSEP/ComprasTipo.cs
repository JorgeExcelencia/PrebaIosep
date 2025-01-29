using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ComprasTipo
    {
        public int IdComprasTipo { get; set; }
        public string Tipo { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

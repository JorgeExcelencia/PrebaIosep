using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CierreFactura
    {
        public int IdCierre { get; set; }
        public DateTime FechaCierre { get; set; }
        public string Periodo { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

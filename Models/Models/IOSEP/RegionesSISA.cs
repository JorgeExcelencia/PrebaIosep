using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RegionesSISA
    {
        public int IdRegion { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Superficie { get; set; }
        public bool Anulado { get; set; }
    }
}

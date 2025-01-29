using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EscuelasSPEP
    {
        public int Id { get; set; }
        public string? CODDEP { get; set; }
        public string? NIVEL { get; set; }
        public int? DEPENDEN { get; set; }
        public int? CUE { get; set; }
        public string? DESCRIPCIO { get; set; }
        public int? SUBVEN { get; set; }
        public string? LOCAL { get; set; }
        public int? ZONA { get; set; }
    }
}

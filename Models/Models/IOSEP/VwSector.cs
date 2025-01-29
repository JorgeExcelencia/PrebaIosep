using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwSector
    {
        public string Nombre { get; set; } = null!;
        public int IdInternado { get; set; }
        public byte IdSector { get; set; }
    }
}

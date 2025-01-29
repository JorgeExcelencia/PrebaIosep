using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class SectorReintegro
    {
        public int SectorReintegroID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime? FechaCrea { get; set; }
    }
}

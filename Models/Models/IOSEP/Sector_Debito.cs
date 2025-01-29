using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Sector_Debito
    {
        public int IdSector_Debito { get; set; }
        public string? codigo { get; set; }
        public string? nombre { get; set; }
        public bool anulado { get; set; }
    }
}

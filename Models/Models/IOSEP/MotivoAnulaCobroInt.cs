using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoAnulaCobroInt
    {
        public int MotivoAnulaCobroIntID { get; set; }
        public string Usuario { get; set; } = null!;
        public string NroBono { get; set; } = null!;
        public string MotivoAnula { get; set; } = null!;
        public DateTime FechaAnula { get; set; }
        public bool Anulado { get; set; }
    }
}

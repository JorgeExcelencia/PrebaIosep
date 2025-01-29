using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AlfaBeta_ExtraBarra
    {
        public int NroRegistro { get; set; }
        public string? CodigoBarra { get; set; }
        public string? Troquel { get; set; }

        public virtual AlfaBeta_ManualDat NroRegistroNavigation { get; set; } = null!;
    }
}

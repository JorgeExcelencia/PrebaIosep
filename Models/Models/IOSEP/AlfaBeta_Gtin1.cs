using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AlfaBeta_Gtin1
    {
        public int NroRegistro { get; set; }
        public string Gtin { get; set; } = null!;

        public virtual AlfaBeta_ManualDat NroRegistroNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AlfaBeta_Barextra
    {
        public int NroRegistro { get; set; }
        public string CodigoBarra { get; set; } = null!;

        public virtual AlfaBeta_ManualDat NroRegistroNavigation { get; set; } = null!;
    }
}

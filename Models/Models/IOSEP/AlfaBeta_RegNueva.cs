using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AlfaBeta_RegNueva
    {
        public int NroRegistro { get; set; }
        public int MonoDro { get; set; }
        public string Potencia { get; set; } = null!;
        public int uPotenci { get; set; }

        public virtual AlfaBeta_Nuevadro MonoDroNavigation { get; set; } = null!;
        public virtual AlfaBeta_ManualDat NroRegistroNavigation { get; set; } = null!;
        public virtual AlfaBeta_uPotenci uPotenciNavigation { get; set; } = null!;
    }
}

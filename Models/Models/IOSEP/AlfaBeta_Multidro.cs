using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AlfaBeta_Multidro
    {
        public int NroRegistro { get; set; }
        /// <summary>
        /// Archivo nuevadro.txt
        /// </summary>
        public int NuevaDro { get; set; }

        public virtual AlfaBeta_ManualDat NroRegistroNavigation { get; set; } = null!;
        public virtual AlfaBeta_Nuevadro NuevaDroNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AlfaBeta_ManPato
    {
        public int IdPatologia { get; set; }
        public int Monodro { get; set; }

        public virtual Patologia IdPatologiaNavigation { get; set; } = null!;
        public virtual AlfaBeta_MonoDro MonodroNavigation { get; set; } = null!;
    }
}

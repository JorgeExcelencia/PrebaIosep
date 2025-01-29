using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_VentaAlfaBetum
    {
        public Tipo_VentaAlfaBetum()
        {
            AlfaBeta_ManualDats = new HashSet<AlfaBeta_ManualDat>();
        }

        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<AlfaBeta_ManualDat> AlfaBeta_ManualDats { get; set; }
    }
}

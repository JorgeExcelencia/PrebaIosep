using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pat_Movimiento
    {
        public int IdMovimiento { get; set; }
        public int IdSectorOrigen { get; set; }
        public int IdSectorDestino { get; set; }
        public DateTime FechaMov { get; set; }
        public int IdBienMov { get; set; }
        public int IdMov_Ref { get; set; }
        public string TipoMov { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public string OpModi { get; set; } = null!;
        public int NumMovimiento { get; set; }

        public virtual Sectores_Iosep IdSectorDestinoNavigation { get; set; } = null!;
        public virtual Sectores_Iosep IdSectorOrigenNavigation { get; set; } = null!;
    }
}

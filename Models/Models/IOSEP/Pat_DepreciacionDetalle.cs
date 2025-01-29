using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pat_DepreciacionDetalle
    {
        public int IdDetalle { get; set; }
        public int IdResumen { get; set; }
        public int IdBien { get; set; }
        public decimal ValorBien { get; set; }
        public byte VidaUtil { get; set; }
        public decimal Depreciacion { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string opCrea { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public string OpModi { get; set; } = null!;

        public virtual Pat_Biene IdBienNavigation { get; set; } = null!;
        public virtual Pat_Depreciacion_Resuman IdResumenNavigation { get; set; } = null!;
    }
}

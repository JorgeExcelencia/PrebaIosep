using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pat_Mejora
    {
        public int IdMotivo { get; set; }
        public int IdBien { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; } = null!;
        public bool Anulado { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string OpModi { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public decimal Valor { get; set; }
        public byte VidaUtil { get; set; }
        public int IdRepDetalle { get; set; }

        public virtual Pat_Biene IdBienNavigation { get; set; } = null!;
    }
}

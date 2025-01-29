using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarRemitoTemporalPresentacione
    {
        public FarRemitoTemporalPresentacione()
        {
            FarRemitoTemporalPresentacionesDetalles = new HashSet<FarRemitoTemporalPresentacionesDetalle>();
        }

        public int IdPresentacionRemito { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime? Crea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? Modi { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<FarRemitoTemporalPresentacionesDetalle> FarRemitoTemporalPresentacionesDetalles { get; set; }
    }
}

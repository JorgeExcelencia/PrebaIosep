using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pat_Depreciacion_Resuman
    {
        public Pat_Depreciacion_Resuman()
        {
            Pat_DepreciacionDetalles = new HashSet<Pat_DepreciacionDetalle>();
        }

        public int IdResumen { get; set; }
        public int Año { get; set; }
        public DateTime fechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public string OpModi { get; set; } = null!;

        public virtual ICollection<Pat_DepreciacionDetalle> Pat_DepreciacionDetalles { get; set; }
    }
}

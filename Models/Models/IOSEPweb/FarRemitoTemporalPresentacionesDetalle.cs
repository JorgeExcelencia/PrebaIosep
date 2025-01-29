using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarRemitoTemporalPresentacionesDetalle
    {
        public int IdPresentacionRemitoDetalle { get; set; }
        public int IdPresentacionRemito { get; set; }
        public int IdEncabezadoTemporal { get; set; }
        public bool Anulado { get; set; }

        public virtual FarRemitoTemporalEncabezado IdEncabezadoTemporalNavigation { get; set; } = null!;
        public virtual FarRemitoTemporalPresentacione IdPresentacionRemitoNavigation { get; set; } = null!;
    }
}

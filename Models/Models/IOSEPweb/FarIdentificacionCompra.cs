using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarIdentificacionCompra
    {
        public int IdIdentificacionCompras { get; set; }
        public int IdDetalleCompras { get; set; }
        public int? IdDetalleVentas { get; set; }
        public string NroSerie { get; set; } = null!;
        public string NroLote { get; set; } = null!;
        public DateTime Vence { get; set; }
        public bool Anulado { get; set; }

        public virtual FarDetalleCompra IdDetalleComprasNavigation { get; set; } = null!;
        public virtual FarDetalleVenta? IdDetalleVentasNavigation { get; set; }
    }
}

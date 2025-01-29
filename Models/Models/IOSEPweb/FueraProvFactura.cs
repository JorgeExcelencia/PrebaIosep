using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FueraProvFactura
    {
        public int IdFactura { get; set; }
        public int IdEncabezado { get; set; }
        public int IdEfector { get; set; }
        public string Factura { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public DateTime? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual FueraProvEncabezadoPresentacion IdEncabezadoNavigation { get; set; } = null!;
    }
}

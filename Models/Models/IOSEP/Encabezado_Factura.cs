using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Encabezado_Factura
    {
        public Encabezado_Factura()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdEncabezadoFactura { get; set; }
        public string Expediente { get; set; } = null!;
        public string Ref_Expediente { get; set; } = null!;
        public int SectorID { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public string? MotivoAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}

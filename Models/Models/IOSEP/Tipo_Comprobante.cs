using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_Comprobante
    {
        public Tipo_Comprobante()
        {
            Facturas = new HashSet<Factura>();
            OrdenCompra_Comprobantes = new HashSet<OrdenCompra_Comprobante>();
        }

        public int TipoComprobanteId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Detalle { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<OrdenCompra_Comprobante> OrdenCompra_Comprobantes { get; set; }
    }
}

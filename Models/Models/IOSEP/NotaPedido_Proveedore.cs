using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NotaPedido_Proveedore
    {
        public int NotaPedidoProveedoresId { get; set; }
        public int NotaPedidoEncabezadoId { get; set; }
        public int ProveedorId { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }

        public virtual NotaPedido_Encabezado NotaPedidoEncabezado { get; set; } = null!;
        public virtual Proveedore Proveedor { get; set; } = null!;
    }
}

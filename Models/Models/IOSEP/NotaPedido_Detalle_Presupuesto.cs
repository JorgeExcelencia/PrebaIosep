using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NotaPedido_Detalle_Presupuesto
    {
        public int NotadePedidoGanadoresId { get; set; }
        public int NotaPedidoDetalleId { get; set; }
        public int NotaPedidoPresupuestoId { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }

        public virtual NotaPedido_Detalle NotaPedidoDetalle { get; set; } = null!;
        public virtual NotaPedido_Presupuesto NotaPedidoPresupuesto { get; set; } = null!;
    }
}

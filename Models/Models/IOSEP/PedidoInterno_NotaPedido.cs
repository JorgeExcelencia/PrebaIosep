using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PedidoInterno_NotaPedido
    {
        public int PedidoInternoNotaPedidoId { get; set; }
        public int PedidoInternoDetalleoId { get; set; }
        public int NotaPedidoDetalleId { get; set; }
        public bool Anulado { get; set; }

        public virtual NotaPedido_Detalle NotaPedidoDetalle { get; set; } = null!;
        public virtual PedidoInterno_Detalle PedidoInternoDetalleo { get; set; } = null!;
    }
}

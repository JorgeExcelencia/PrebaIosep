using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PedidoInterno_Detalle
    {
        public PedidoInterno_Detalle()
        {
            PedidoInterno_NotaPedidos = new HashSet<PedidoInterno_NotaPedido>();
        }

        public int PedidoInternoDetalleId { get; set; }
        public int PedidoInternoEncabezadoId { get; set; }
        public int NroRegistro { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? Precio_Unitario { get; set; }
        public string? Observaciones { get; set; }
        public string? Tipo_Entrega { get; set; }
        public int IdMotivo { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }

        public virtual PedidoInterno_Motivo IdMotivoNavigation { get; set; } = null!;
        public virtual PedidoInterno_Encabezado PedidoInternoEncabezado { get; set; } = null!;
        public virtual ICollection<PedidoInterno_NotaPedido> PedidoInterno_NotaPedidos { get; set; }
    }
}

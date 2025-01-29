using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NotaPedido_Detalle
    {
        public NotaPedido_Detalle()
        {
            NotaPedido_Detalle_Presupuestos = new HashSet<NotaPedido_Detalle_Presupuesto>();
            PedidoInterno_NotaPedidos = new HashSet<PedidoInterno_NotaPedido>();
        }

        public int NotaPedidoDetalleId { get; set; }
        public int NotaPedidoEncabezadoId { get; set; }
        public short Renglon { get; set; }
        public int NroRegistro { get; set; }
        public string Detalle { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public int Id_ProveedorGanador { get; set; }
        public int Id_PresupuestoGanador { get; set; }
        public int MotivoGanadorId { get; set; }
        public string Observaciones { get; set; } = null!;
        public decimal Precio_Unitario { get; set; }
        public decimal Alicuota_IVA { get; set; }
        public decimal Precio_Neto { get; set; }
        public int OrdenCompraEncabezadoId { get; set; }
        public int? OrdenPagoEncabezadoId { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaModi { get; set; }
        public string? OpModi { get; set; }

        public virtual Motivo_Ganador MotivoGanador { get; set; } = null!;
        public virtual NotaPedido_Encabezado NotaPedidoEncabezado { get; set; } = null!;
        public virtual ICollection<NotaPedido_Detalle_Presupuesto> NotaPedido_Detalle_Presupuestos { get; set; }
        public virtual ICollection<PedidoInterno_NotaPedido> PedidoInterno_NotaPedidos { get; set; }
    }
}

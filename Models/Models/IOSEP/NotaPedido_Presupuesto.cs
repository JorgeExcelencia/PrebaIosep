using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NotaPedido_Presupuesto
    {
        public NotaPedido_Presupuesto()
        {
            NotaPedido_Detalle_Presupuestos = new HashSet<NotaPedido_Detalle_Presupuesto>();
        }

        public int NotaPedidoPresupuestoId { get; set; }
        public int NotaPedidoEncabezadoId { get; set; }
        public int ProveedorId { get; set; }
        public decimal Precio_Unitario { get; set; }
        public int PresupuestoMotivoId { get; set; }
        public decimal Alicuota_Iva { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public string? OpModi { get; set; }
        public bool? Original { get; set; }

        public virtual NotaPedido_Encabezado NotaPedidoEncabezado { get; set; } = null!;
        public virtual Presupuesto_Motivo PresupuestoMotivo { get; set; } = null!;
        public virtual Proveedore Proveedor { get; set; } = null!;
        public virtual ICollection<NotaPedido_Detalle_Presupuesto> NotaPedido_Detalle_Presupuestos { get; set; }
    }
}

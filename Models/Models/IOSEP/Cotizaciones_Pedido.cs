using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cotizaciones_Pedido
    {
        public Cotizaciones_Pedido()
        {
            Cotizaciones_PedidoDetalles = new HashSet<Cotizaciones_PedidoDetalle>();
        }

        public int IdCotizaciones_Pedido { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public DateTime Fecha_Requerimiento { get; set; }
        /// <summary>
        /// A - Afiliado , P - Plan , C - Calculado
        /// </summary>
        public string TipoPedido { get; set; } = null!;
        public int IdAfiliado { get; set; }
        public string IdPlan { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime Fecha_Cierre { get; set; }
        public DateTime CalculoDesde { get; set; }
        public DateTime CalculoHasta { get; set; }
        public string Operador { get; set; } = null!;

        public virtual ICollection<Cotizaciones_PedidoDetalle> Cotizaciones_PedidoDetalles { get; set; }
    }
}

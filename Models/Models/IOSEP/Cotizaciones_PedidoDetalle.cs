using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cotizaciones_PedidoDetalle
    {
        public int IdCotizaciones_PedidoDetalle { get; set; }
        public int IdCotizaciones_Pedido { get; set; }
        /// <summary>
        /// Valor IdManual del Medicamento
        /// </summary>
        public string Codigo { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Asignado { get; set; }
        public decimal Presupuestado { get; set; }
        public string Observaciones { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual Cotizaciones_Pedido IdCotizaciones_PedidoNavigation { get; set; } = null!;
    }
}

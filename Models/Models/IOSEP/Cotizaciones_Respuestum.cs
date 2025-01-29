using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cotizaciones_Respuestum
    {
        public int IdCotizaciones_Respuesta { get; set; }
        public int IdCotizaciones_Envio { get; set; }
        public int IdCotizaciones_Pedido { get; set; }
        public int IdCotizaciones_PedidoDetalle { get; set; }
        public DateTime Fecha_respuesta { get; set; }
        public string Codigo { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }

        public virtual Cotizaciones_Envio IdCotizaciones_EnvioNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cotizaciones_Licitacione
    {
        public int IdCotizaciones_Propuesto { get; set; }
        public int IdCotizaciones_Pedido { get; set; }
        public int IdCotizaciones_PedidoDetalle { get; set; }
        public int IdProveedorPropuesto { get; set; }
        public DateTime Fecha_Licitacion { get; set; }
        public string Operador { get; set; } = null!;
        public bool Anulado { get; set; }
        public string OperadorAnulado { get; set; } = null!;
        public DateTime FechaAnulado { get; set; }
    }
}

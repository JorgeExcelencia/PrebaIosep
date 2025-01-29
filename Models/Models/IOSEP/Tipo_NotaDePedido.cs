using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Tipo_NotaDePedido
    {
        public Tipo_NotaDePedido()
        {
            NotaPedido_Encabezados = new HashSet<NotaPedido_Encabezado>();
        }

        public int TipoNotadePedidoId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal MontoDesde { get; set; }
        public decimal MontoHasta { get; set; }
        public string Normativa { get; set; } = null!;
        public bool Genera_OrdenCompra { get; set; }
        public bool Anulado { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string? OpModi { get; set; }
        public DateTime? FechaModi { get; set; }

        public virtual ICollection<NotaPedido_Encabezado> NotaPedido_Encabezados { get; set; }
    }
}

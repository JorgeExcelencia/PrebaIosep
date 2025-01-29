using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Estado_NotaDePedido
    {
        public Estado_NotaDePedido()
        {
            NotaPedido_Encabezados = new HashSet<NotaPedido_Encabezado>();
        }

        public int EstadoNotaDePedidoId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<NotaPedido_Encabezado> NotaPedido_Encabezados { get; set; }
    }
}

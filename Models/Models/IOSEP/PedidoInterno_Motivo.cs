using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PedidoInterno_Motivo
    {
        public PedidoInterno_Motivo()
        {
            PedidoInterno_Detalles = new HashSet<PedidoInterno_Detalle>();
        }

        public int PedidoInterno_MotivoId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<PedidoInterno_Detalle> PedidoInterno_Detalles { get; set; }
    }
}

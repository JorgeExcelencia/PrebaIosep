using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Motivo_Ganador
    {
        public Motivo_Ganador()
        {
            NotaPedido_Detalles = new HashSet<NotaPedido_Detalle>();
        }

        public int MotivoGanadorID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<NotaPedido_Detalle> NotaPedido_Detalles { get; set; }
    }
}

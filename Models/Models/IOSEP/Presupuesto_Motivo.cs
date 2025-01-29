using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Presupuesto_Motivo
    {
        public Presupuesto_Motivo()
        {
            NotaPedido_Presupuestos = new HashSet<NotaPedido_Presupuesto>();
        }

        public int PresupuestoMotivoId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<NotaPedido_Presupuesto> NotaPedido_Presupuestos { get; set; }
    }
}

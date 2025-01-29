using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FarPresupuesto
    {
        public FarPresupuesto()
        {
            FarPresupuestoDetalles = new HashSet<FarPresupuestoDetalle>();
        }

        public int PresupuestoId { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime Fecha { get; set; }
        public string? Crea { get; set; }
        public DateTime? CreaFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<FarPresupuestoDetalle> FarPresupuestoDetalles { get; set; }
    }
}

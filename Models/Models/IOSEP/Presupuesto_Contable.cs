using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Presupuesto_Contable
    {
        public Presupuesto_Contable()
        {
            Ampliacion_Presupuestos = new HashSet<Ampliacion_Presupuesto>();
            Contable_Gastos = new HashSet<Contable_Gasto>();
            Contable_Recursos = new HashSet<Contable_Recurso>();
        }

        public int PresupuestoContableId { get; set; }
        public string Anio { get; set; } = null!;
        public string Expediente { get; set; } = null!;
        public DateTime Fecha_Aprobacion { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<Ampliacion_Presupuesto> Ampliacion_Presupuestos { get; set; }
        public virtual ICollection<Contable_Gasto> Contable_Gastos { get; set; }
        public virtual ICollection<Contable_Recurso> Contable_Recursos { get; set; }
    }
}

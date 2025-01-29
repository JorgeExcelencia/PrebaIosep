using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Contable_Recurso
    {
        public int ContableRecursosId { get; set; }
        public int PresupuestoContableId { get; set; }
        public int CuentaContableId { get; set; }
        public decimal Importe_Estimado { get; set; }
        public decimal? Importe_Ampliacion { get; set; }
        public decimal? Importe_Efectivo { get; set; }
        public decimal? Importe_Diferencias { get; set; }
        public DateTime? Fecha_Aprobacion { get; set; }
        public DateTime? Fecha_Ampliacion { get; set; }
        public bool Anulado { get; set; }

        public virtual Cuentas_Contable CuentaContable { get; set; } = null!;
        public virtual Presupuesto_Contable PresupuestoContable { get; set; } = null!;
    }
}
